using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlackBelt.Context;
using BlackBelt.Models;

namespace BlackBelt.Controllers
{
    public class MensalidadesController : Controller
    {
        private readonly AppDbContext _context;

        public MensalidadesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string searchString, string statusFilter)
        {
            // Busca todos os alunos
            var alunos = _context.Alunos.Include(a => a.Mensalidades).AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                alunos = alunos.Where(a => a.Nome.Contains(searchString));
            }

            var alunosList = await alunos.ToListAsync();

            // Mapeando para uma ViewModel de exibição (Controle de Mensalidades)
            var viewModelList = alunosList.Select(a => {
                var ultimaMensalidade = a.Mensalidades?.OrderByDescending(m => m.DataVencimento).FirstOrDefault();
                
                string status = "Sem Registro";
                DateOnly? ultimoPagamento = null;
                DateOnly? proximoPagamento = null;
                decimal saldo = 0;

                if (ultimaMensalidade != null)
                {
                    status = ultimaMensalidade.Status;
                    ultimoPagamento = ultimaMensalidade.DataPagamento;
                    proximoPagamento = ultimaMensalidade.DataVencimento;
                    
                    // Simples lógica de saldo, atrasados acumulam
                    if(status == "Atrasado" || status == "Pendente")
                    {
                        saldo = -ultimaMensalidade.Valor; 
                    }
                }

                return new ControleMensalidadeViewModel
                {
                    AlunoId = a.Id,
                    Nome = a.Nome,
                    Status = status,
                    UltimoPagamento = ultimoPagamento,
                    ProximoPagamento = proximoPagamento,
                    Saldo = saldo
                };
            }).ToList();

            if (!string.IsNullOrEmpty(statusFilter))
            {
                viewModelList = viewModelList.Where(v => v.Status == statusFilter).ToList();
            }

            ViewBag.SearchString = searchString;
            ViewBag.StatusFilter = statusFilter;

            return View(viewModelList);
        }

        public async Task<IActionResult> Detalhes(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aluno = await _context.Alunos
                .Include(a => a.Mensalidades)
                .FirstOrDefaultAsync(m => m.Id == id);
                
            if (aluno == null)
            {
                return NotFound();
            }

            return View(aluno);
        }
    }

    public class ControleMensalidadeViewModel
    {
        public int AlunoId { get; set; }
        public string Nome { get; set; }
        public string Status { get; set; }
        public DateOnly? UltimoPagamento { get; set; }
        public DateOnly? ProximoPagamento { get; set; }
        public decimal Saldo { get; set; }
    }
}
