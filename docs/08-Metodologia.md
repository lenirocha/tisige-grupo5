# 8. Metodologia

O desenvolvimento deste projeto foi conduzido a partir da identificação de uma demanda real da Academia Sigma, localizada em Contagem/MG. A definição do problema ocorreu por meio de reuniões com a gerência da instituição e da experiência prática de um dos integrantes da equipe como aluno da academia, possibilitando compreender as dificuldades relacionadas ao controle de frequência, ao acompanhamento da evolução técnica dos praticantes e à gestão financeira das mensalidades.

Após a identificação da demanda, foi realizado o levantamento dos requisitos funcionais e não funcionais do sistema, considerando as necessidades apresentadas pela instituição parceira. Nessa etapa foram definidos os principais processos que deveriam ser apoiados pela solução, incluindo autenticação de usuários, cadastro de alunos, professores e turmas, registro de frequência, acompanhamento das habilidades técnicas dos praticantes e controle financeiro.

Como forma de fundamentar a proposta, foi realizada uma pesquisa bibliográfica sobre Sistemas de Informação aplicados à gestão esportiva e administrativa, permitindo compreender como ferramentas computacionais podem contribuir para a organização, o monitoramento e a tomada de decisões em instituições desse segmento.

Com base nos requisitos levantados, foram elaborados protótipos das principais interfaces do sistema, possibilitando a validação inicial das funcionalidades e da experiência de uso. Os protótipos contemplaram as telas de login, gerenciamento de usuários, gerenciamento de alunos e turmas, registro de presença, acompanhamento de desempenho técnico e controle financeiro.

A implementação do sistema foi conduzida de forma incremental, utilizando uma adaptação da metodologia ágil Scrum para o contexto acadêmico. O desenvolvimento foi organizado em duas sprints, nas quais as atividades foram distribuídas entre os integrantes da equipe de acordo com suas responsabilidades. O acompanhamento das tarefas foi realizado por meio de um quadro Kanban, permitindo monitorar o andamento, os prazos e a conclusão de cada funcionalidade planejada.

Para o gerenciamento do código-fonte e controle de versões, foi adotada a estratégia Git Flow, utilizando as branches main, develop, feature e hotfix para organizar o desenvolvimento, a integração de funcionalidades e a correção de eventuais problemas, garantindo maior estabilidade e rastreabilidade das alterações realizadas no projeto.

Durante cada sprint foram realizados testes funcionais e validações das funcionalidades implementadas, assegurando a conformidade com os requisitos definidos e contribuindo para a qualidade da solução desenvolvida.

Dessa forma, a metodologia adotada combinou levantamento de requisitos junto à instituição parceira, pesquisa bibliográfica, prototipação das interfaces, desenvolvimento incremental baseado em Scrum, utilização de Git Flow para controle de versões e validação contínua das funcionalidades implementadas.

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
* **Scrum Master:** Arthur
* **Banco de Dados e Modelagem:** Arthur e Bárbara
* **Desenvolvimento Back-end:** Arthur, Carolina, Pedro e Rafael
* **Desenvolvimento Front-end:** Bárbara, Leni, Carolina e Arthur
* **Testes e Validação:** Pedro e Rafael
* **Documentação e Acompanhamento:** Todos os integrantes

#### Sprint 2
* **Scrum Master:** Arthur
* **Banco de Dados e Persistência:** Carolina
* **Desenvolvimento Back-end:** Carolina, Pedro, Bárbara e Leni
* **Desenvolvimento Front-end:** Rafael, Leni, Arthur e Pedro
* **Testes e Garantia da Qualidade:** Pedro e Rafael
* **Documentação de Testes:** Pedro e Rafael
* **Integração e Validação do Sistema:** Carolina e Pedro

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
