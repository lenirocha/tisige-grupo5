# 8. Metodologia

## Controle de versão

O projeto segue a convenção do Git Flow para a organização e ciclo de vida das ramificações (branches) no repositório do GitHub. Essa abordagem permite o desenvolvimento paralelo de funcionalidades de forma organizada, garantindo a estabilidade do código principal.

As branches do projeto são estruturadas e nomeadas conforme a seguinte convenção:

* `main`: Ramificação principal e estável do sistema. Contém o código homologado e pronto para a entrega/produção. Não recebe commits diretos.
* `develop`: Ramificação de integração de todas as novas funcionalidades. É a base estável para o desenvolvimento cotidiano.
* `feature/`: Branches temporárias criadas para o desenvolvimento de requisitos funcionais específicos ou tarefas isoladas. Devem partir de `develop` e, após a conclusão e validação, retornar para ela via *Pull Request*.
    * *Exemplos:* `feature/login-usuario`, `feature/cadastro-aluno`, `feature/controle-mensalidades`.
* `hotfix/`: Ramificações corretivas de emergência criadas diretamente a partir da `main` para sanar bugs críticos encontrados na versão homologada.

---

## Planejamento do projeto

### Divisão de papéis

A equipe utiliza a metodologia ágil Scrum, adaptada para o ambiente acadêmico, dividindo a execução das atividades e o gerenciamento do escopo do sistema pelas seguintes frentes organizacionais:

#### Sprint 1
* **Scrum Master:** Vinicius
* **Protótipos / UX-UI:** Lucas e Vinicius
* **Testes / Qualidade:** Pedro e Rafael
* **Documentação / Especificações:** Sandy e Bruna

#### Sprint 2
* **Scrum Master:** Vinicius
* **Desenvolvedores Front-end:** Lucas, Carolina e Bruna
* **Desenvolvedores Back-end:** Carolina e Vinicius
* **Testes / Qualidade:** Pedro e Rafael

---

### Quadro de tarefas

O acompanhamento e status de cada entrega foram centralizados por meio de quadros Kanban visuais, mapeados cronologicamente através das iterações planejadas:

#### Sprint 1

| Responsável | Tarefa/Requisito | Iniciado em | Prazo | Status | Terminado em |
| :--- | :--- | :---: | :---: | :---: | :---: |
| Arthur | Desenvolvimento do Login de usuários | 02/04/2026 | 30/04/2026 | ✔️ | 28/04/2026 |
| Bárbara e Leni | CRUD de Usuários (Professores/Gerentes) | 03/04/2026 | 25/04/2026 | ✔️ | 24/04/2026 |
| Carolina e Pedro | CRUD de Turmas e vínculos | 05/04/2026 | 28/04/2026 | ✔️ | 27/04/2026 |
| Pedro e Rafael | CRUD de Alunos e dados pessoais | 06/04/2026 | 20/04/2026 | ✔️ | 18/04/2026 |
| Arthur e Pedro | Interface do Menu Principal e navegação | 10/04/2026 | 30/04/2026 | ✔️ | 29/04/2026 |
| Carolina e Rafael | Perfil do Aluno e Habilidades Técnicas | 12/04/2026 | 30/04/2026 | ✔️ | 28/04/2026 |
| Leni e Carolina | Mecanismo para Registrar Presença diária | 12/04/2026 | 30/04/2026 | ✔️ | 29/04/2026 |
| Arthur e Bárbara | Modificar e otimizar estrutura do banco | 02/04/2026 | 20/04/2026 | ✔️ | 19/04/2026 |

#### Sprint 2

| Responsável | Tarefa/Requisito | Iniciado em | Prazo | Status | Terminado em |
| :--- | :--- | :---: | :---: | :---: | :---: |
| Carolina e Pedro | Integração e validação do Login Web/Mobile | 02/05/2026 | 31/05/2026 | ✔️ | 28/05/2026 |
| Rafael | Componentização da tela Home do sistema | 02/05/2026 | 20/05/2026 | ✔️ | 18/05/2026 |
| Leni | Refatoração visual da listagem de Turmas | 04/05/2026 | 22/05/2026 | ✔️ | 20/05/2026 |
| Arthur | Refatoração visual do gerenciamento de Usuários | 04/05/2026 | 22/05/2026 | ✔️ | 21/05/2026 |
| Pedro e Lucas | Interface final da listagem de Alunos | 05/05/2026 | 25/05/2026 | ✔️ | 24/05/2026 |
| Bárbara e Leni | Lógica de visualização de Aula e chamadas | 10/05/2026 | 28/05/2026 | ✔️ | 26/05/2026 |
| Carolina | Modelagem e persistência do Banco de Dados | 02/05/2026 | 15/05/2026 | ✔️ | 14/05/2026 |
| Pedro e Rafael | Elaboração da Documentação de teste de software | 20/05/2026 | 31/05/2026 | ✔️ | 30/05/2026 |
| Carolina | Implementação de Pop-ups de confirmação | 15/05/2026 | 31/05/2026 | ✔️ | 29/05/2026 |

**Legenda:**
* ✔️: Terminado
* 📝: Em execução
* ⌛: Atrasado
* ❌: Não iniciado

---

## Processo

A equipe utiliza uma abordagem iterativa e incremental baseada em Scrum e Kanban. As decisões, ritos e processos de trabalho ocorrem sob as seguintes diretrizes:

1. **Planejamento da Sprint (Sprint Planning):** No início de cada ciclo de desenvolvimento, os requisitos são priorizados de acordo com o plano acadêmico e as dores da Academia Sigma, gerando tarefas específicas que são distribuídas conforme os papéis definidos.
2. **Acompanhamento Diário:** A comunicação do progresso técnico, impedimentos e conquistas cotidianas é feita de forma assíncrona através de um grupo dedicado no WhatsApp, minimizando burocracias e acelerando soluções.
3. **Monitoramento Visual (Kanban):** Todas as tarefas do projeto transitam de forma transparente entre as colunas clássicas de fluxo de trabalho (*To Do*, *In Progress*, *Testing* e *Done*), permitindo que qualquer membro identifique gargalos operacionais no repositório.
4. **Revisão e Retrospectiva (Sprint Review / Retrospective):** Ao final de cada ciclo, o incremento do sistema funcional é inspecionado frente aos protótipos de tela desenhados, procedendo-se também à análise do processo de equipe para identificar pontos de melhoria técnica para os ciclos seguintes.

---

## Relação de ambientes de trabalho

Os artefatos do projeto e o código-fonte do sistema **Black Belt** são desenvolvidos e centralizados em diferentes plataformas operacionais, configurando os seguintes ambientes de trabalho:

| Ambiente / Artefato | Plataforma Utilizada | Link / Mecanismo de Acesso |
| :--- | :--- | :--- |
| **Repositório do Código-Fonte** | GitHub | [Repositório oficial do projeto integrado](https://github.com/lenirocha/tisige-grupo5) |
| **Documentação do Projeto** | GitHub Wiki / Markdown | Diretório integrado no próprio repositório (`.md`) |
| **Projeto de Interfaces (Protótipos)** | Figma | [Links públicos compartilhados na documentação](https://www.figma.com/design/YLEuOfqvxmMry87SxlO8mm/Black-Belt?node-id=0-1&t=wDR0bASTGWwZpkXN-1) |
| **Modelagem de Casos de Uso / Diagramas** | Diagrams.net (Draw.io) | Arquivos gráficos persistidos na pasta de documentação |
| **Gerenciamento e Quadro de Tarefas** | GitHub Projects / Kanban | Aba *Projects* vinculada ao repositório institucional |

### Ferramentas

Para garantir a integração, padronização e o desenvolvimento fluido da solução baseada na arquitetura sugerida, a equipe selecionou o seguinte ecossistema tecnológico:

* **IDE de Desenvolvimento:** *Microsoft Visual Studio / VS Code*, fornecendo suporte robusto para a escrita do ecossistema .NET Core de forma ágil.
* **Modelagem de Banco de Dados:** *SQL Server Management Studio (SSMS)*, para construção física, criação de scripts relacionais de tabelas e consultas SQL integradas.
* **Design e Wireframing:** *Figma e Diagrams.net*, selecionados pela facilidade em criar interfaces responsivas intuitivas (Mobile/Desktop) e diagramas lógicos unificados.
* **Ferramentas de Comunicação:** *WhatsApp e Microsoft Teams*, para o alinhamento ágil de rotinas diárias e realização de reuniões remotas de revisão técnica.
