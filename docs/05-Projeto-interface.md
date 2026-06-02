# Projeto de Interface

Pré-requisitos: [Especificação do Projeto](02-Especificacao.md)

---

## Principais Interfaces da Plataforma

### 1. Tela de Login
* **Descrição:** Tela inicial de controle de acesso ao sistema, onde os usuários (Gestores, Instrutores ou Alunos) realizam a autenticação segura utilizando credenciais exclusivas (CPF e Senha).
* **Funcionalidade Atendida:** RF-001 (Autenticação de usuários).
* **Requisitos Não Funcionais Atendidos:** RNF-003 (Autenticação segura), RNF-004 (Controle de permissões) e RNF-002 (Interface simples e amigável).
* **Histórias de Usuário Relacionadas:** “Eu como aluno quero me autenticar no sistema usando meu CPF e senha para acessar com segurança o meu painel individual.”

### 2. Tela Principal (Home / Dashboard)
* **Descrição:** Painel centralizado que exibe o menu de navegação e atalhos rápidos adaptados para as funcionalidades autorizadas, conforme o nível de acesso do perfil logado (Gestão, Instrutor ou Aluno).
* **Funcionalidade Atendida:** Centralização e navegação geral pelas ferramentas integradas do sistema.
* **Requisitos Não Funcionais Atendidos:** RNF-001 (Sistema responsivo), RNF-002 (Interface intuitiva) e RNF-007 (Suporte a múltiplos acessos).
* **Histórias de Usuário Relacionadas:** Atende a todas as histórias de usuários, pois serve como ponto de partida unificado para a realização das tarefas diárias.

### 3. Cadastro e Listagem de Alunos
* **Descrição:** Interface destinada à inclusão, alteração, consulta e exclusão de dados cadastrais essenciais dos praticantes (nome, e-mail, CPF, telefone, data de nascimento, endereço e nível de faixa).
* **Funcionalidades Atendidas:** RF-002 (Cadastro de alunos) e RF-003 (Edição e exclusão de dados dos alunos).
* **Requisitos Não Funcionais Atendidos:** RNF-002 (Interface amigável) e RNF-005 (Proteção e privacidade dos dados).
* **Histórias de Usuário Relacionadas:** “Eu como gestora quero cadastrar e gerenciar a equipe e os praticantes para manter as informações unificadas.”

### 4. Cadastro de Turmas e Vínculos
* **Descrição:** Permite a organização operacional das turmas da academia, viabilizando a definição de horários, associação de alunos matriculados e atribuição do professor/instrutor responsável.
* **Funcionalidades Atendidas:** RF-007 (Gerenciar turmas e vínculos de alunos/instrutores).
* **Requisitos Não Funcionais Atendidos:** RNF-002 (Interface intuitiva) e RNF-009 (Arquitetura modular).
* **Histórias de Usuário Relacionadas:** “Eu como gestora quero organizar o corpo docente e vinculá-los às suas respectivas turmas para estruturar as rotinas.”

### 5. Cadastro de Instrutores / Equipe
* **Descrição:** Tela de gerenciamento interno voltada ao cadastro, edição e controle de dados dos professores de artes marciais responsáveis pela condução das turmas.
* **Funcionalidades Atendidas:** RF-004 (Cadastro, edição e exclusão de professores/instrutores).
* **Requisitos Não Funcionais Atendidos:** RNF-004 (Controle estrito de permissões) e RNF-002 (Interface simples).
* **Histórias de Usuário Relacionadas:** “Eu como gestora quero cadastrar e gerenciar a equipe de professores para manter o corpo docente atualizado no sistema.”

### 6. Registro de Frequência (Chamada Digital)
* **Descrição:** Tela de uso ágil em cima do tatame, onde o instrutor visualiza a listagem de matriculados daquela turma e realiza o lançamento digital instantâneo da presença diária.
* **Funcionalidades Atendidas:** RF-005 (Registrar presença diária) e RF-006 (Consultar histórico de frequência individualizado).
* **Requisitos Não Funcionais Atendidos:** RNF-001 (Responsividade mobile para uso em smartphones) e RNF-006 (Tempo de resposta rápido).
* **Histórias de Usuário Relacionadas:** “Eu como instrutor quero registrar a presença dos alunos de forma automatizada por turma para eliminar o controle manual ineficiente.”

### 7. Perfil Técnico do Aluno (Módulo de Evolução)
* **Descrição:** Interface focada na avaliação pedagógica do atleta. Permite ao instrutor lançar e monitorar níveis de proficiência em habilidades específicas (Chaves de braço, Estrangulamentos, Imobilizações e Quedas), gerando um mapa transparente das reais dificuldades do aluno.
* **Funcionalidades Atendidas:** RF-010 (Registrar evolução técnica por habilidades específicas) e RF-011 (Visualizar histórico de desempenho e dificuldades centralizadas).
* **Requisitos Não Funcionais Atendidos:** RNF-002 (Interface amigável para usuários leigos) e RNF-001 (Responsividade para consulta rápida).
* **Histórias de Usuário Relacionadas:** “Eu como instrutor quero ranquear habilidades dos alunos por níveis para substituir a percepção subjetiva por um histórico evolutivo real.”

### 8. Gestão Financeira (Mensalidades e Adimplência)
* **Descrição:** Interface financeira integrada que permite registrar o recebimento de parcelas e consultar em tempo real a situação de regularidade do aluno (Adimplente ou Inadimplente), cruzando os dados econômicos com os de frequência.
* **Funcionalidades Atendidas:** RF-008 (Registrar pagamento de mensalidades) e RF-009 (Consultar situação financeira em tempo real do aluno).
* **Requisitos Não Funcionais Atendidos:** RNF-004 (Acesso gerencial restrito) e RNF-005 (Proteção de dados internos).
* **Histórias de Usuário Relacionadas:** “Eu como gestora quero acompanhar o pagamento das mensalidades e identificar inadimplentes para manter a saúde do negócio.”

---

## Discussão sobre o Protótipo Interativo

As interfaces do sistema **Black Belt** foram projetadas seguindo os pilares fundamentais da engenharia de usabilidade e os requisitos estabelecidos para o projeto acadêmico:

* **Atendimento aos Requisitos Funcionais:** Cada tela mapeada corresponde exatamente aos fluxos de negócios essenciais da Academia Sigma. A automação une o registro operacional do professor na chamada ao controle estratégico de faturamento e desempenho técnico na gerência.
* **Atendimento aos Requisitos Não Funcionais:** Priorizou-se a **responsividade (RNF-001)** e a **simplicidade (RNF-002)**. Como os instrutores realizam os lançamentos em smartphones ou tablets ao lado do tatame, o layout limpo minimiza cliques e evita poluição visual, garantindo respostas rápidas sob o tempo de tolerância esperado.
* **Atendimento às Histórias de Usuário:** Os fluxos e restrições de visibilidade de dados respeitam as dores reais mapeadas nas personas (como a agilidade de controle para a gestora Gabriela e a necessidade de desburocratização técnica para o instrutor Arthur).

---

## Interface do Sistema

As telas prototipadas para o sistema estão representadas abaixo:

![1](https://github.com/user-attachments/assets/d3861be6-95b6-46fb-bd8c-5112a0cb9de5)
![3](https://github.com/user-attachments/assets/4bf68e3e-8cee-4172-b6b8-25f64038636c)
![4](https://github.com/user-attachments/assets/67722492-0e46-481e-9258-023f01b0a717)
![5](https://github.com/user-attachments/assets/748190d1-0c87-4baa-ab11-a4a5a6a229f4)
![6](https://github.com/user-attachments/assets/786bb004-0270-4064-96e8-d5dc859e67df)
![7](https://github.com/user-attachments/assets/6e42d041-8304-4a1b-a8d2-520b0160d366)
![8](https://github.com/user-attachments/assets/76dc6e7f-1d7c-42c1-ad6f-3b91647cc554)
![9](https://github.com/user-attachments/assets/eeb9a4f4-6e9f-44f7-948f-6e712a2f031d)
![10](https://github.com/user-attachments/assets/49a2beb2-21b1-4a64-92ef-65de57df614e)
