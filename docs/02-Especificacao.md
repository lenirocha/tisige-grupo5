# Especificação do Projeto

## Pré-requisitos

### Especificação do Problema
A prática do Jiu-jitsu exige acompanhamento contínuo da evolução técnica e física dos praticantes. Atualmente, a Academia Sigma enfrenta dificuldades devido ao controle manual ou pouco estruturado de frequência, à ausência de um sistema estruturado para registro do desempenho individual dos alunos (dependendo apenas da percepção subjetiva do professor) e à falta de um controle integrado de pagamentos de mensalidades. Isso torna o monitoramento evolutivo limitado, suscetível a falhas e gera um aproveitamento desigual das aulas.

### Ideia de Solução
Desenvolver o sistema **Black Belt**: uma solução automatizada e integrada para gerenciamento de frequência, desempenho técnico e controle financeiro básico de alunos de Jiu-jitsu. O sistema permitirá o registro automatizado de presenças, cadastro e monitoramento de evolução técnica individual por níveis de habilidades, identificação de dificuldades específicas, controle e acompanhamento do pagamento de mensalidades (adimplentes e inadimplentes), além do gerenciamento de turmas e instrutores. Com isso, professores e gestores poderão planejar treinos personalizados e tomar decisões estratégicas baseadas em dados consolidados.

---

## Visão Geral

Nesta parte do documento, serão abordados:
* **Personas e Mapa de Stakeholders:** Descrição dos perfis de usuários e seus níveis de interesse e influência no sistema.
* **Histórias de Usuários:** Necessidades, dores e motivações práticas de cada perfil mapeado.
* **Requisitos Funcionais:** Funcionalidades detalhadas e processos de negócios que o sistema deve oferecer.
* **Requisitos Não Funcionais:** Características técnicas do sistema ligadas a desempenho, usabilidade, segurança e arquitetura.
* **Restrições do Projeto:** Limitações e diretrizes impostas ao desenvolvimento da solução acadêmica.

### Técnicas e Ferramentas Utilizadas
* **Técnicas:** Análise de stakeholders, criação de personas, elicitação de requisitos, definição de histórias de usuários e priorização de requisitos (MoSCoW).
* **Ferramentas:** Microsoft Word para documentação preliminar, Diagrams.net/Lucidchart para modelagem de diagramas e interface, e GitHub para versionamento do código-fonte e publicação da documentação.

---

## Personas

### Persona 1 – Gabriela Paes (Gestora Administrativa / Sócia)
* **Idade:** 35 anos
* **Profissão:** Sócia-Gerente Administrativa da Academia Sigma.
* **Tecnologia:** Intermediária (utiliza aplicativos de mensagens, Instagram para marketing e planilhas de controle).
* **Características:** Focada em resultados, busca otimizar os processos internos e reduzir falhas operacionais.
* **Motivação:** Necessita de uma visão integrada e clara do negócio (financeiro unificado à frequência) para criar ações estratégicas de retenção de alunos e controlar a inadimplência de forma rápida.

### Persona 2 – Arthur Lima (Instrutor de Jiu-jitsu)
* **Idade:** 29 anos
* **Profissão:** Professor de Jiu-jitsu Faixa-Preta.
* **Tecnologia:** Básica (utiliza smartphone para redes sociais e comunicação rápida).
* **Características:** Didático e atento aos detalhes, mas avesso a burocracias ou preenchimento de planilhas de papel durante o horário de treino.
* **Motivação:** Quer uma forma simples e ágil de registrar quem faltou e quem compareceu à aula, além de conseguir pontuar em poucos cliques a evolução de técnicas específicas dos alunos.

### Persona 3 – Rafael Romagnoli (Aluno de Jiu-jitsu)
* **Idade:** 24 anos
* **Profissão:** Estudante Universitário e Praticante de Artes Marciais.
* **Tecnologia:** Alta (utiliza smartphones, computadores e navegadores web diariamente).
* **Características:** Dedicado, focado em sua evolução pessoal, mas sente que o aprendizado às vezes é desigual pela falta de acompanhamento focado nas suas dificuldades.
* **Motivação:** Deseja ter transparência sobre seu progresso técnico no tatame, saber quais habilidades precisa melhorar para as próximas graduações e consultar seu histórico de treinos.

### Mapa de Stakeholders

| Stakeholder | Interesse | Influência |
| :--- | :--- | :--- |
| **Gestores (Gabriela)** | Resultados comerciais, redução da inadimplência e relatórios integrados. | Alta |
| **Instrutores (Arthur)** | Facilidade de chamada diária e histórico técnico sem papelada. | Alta |
| **Alunos (Rafael)** | Transparência no desempenho técnico e treinos personalizados. | Média |

---

## Histórias de Usuários

| EU COMO... `PERSONA` | QUERO/PRECISO ... `FUNCIONALIDADE` | PARA ... `MOTIVO/VALOR` |
| :--- | :--- | :--- |
| **Gestora** | Visualizar relatórios integrados de frequência, desempenho e situação financeira | Ter uma visão de 360° do aluno para criar estratégias de retenção. |
| **Gestora** | Acompanhar o pagamento das mensalidades e identificar inadimplentes | Manter o controle financeiro simplificado e a saúde do negócio. |
| **Gestora** | Cadastrar e gerenciar a equipe de professores | Organizar o corpo docente e vinculá-los às suas respectivas turmas. |
| **Instrutor** | Registrar a presença dos alunos de forma automatizada por turma | Eliminar o controle manual ineficiente e economizar tempo de aula. |
| **Instrutor** | Ranquear habilidades dos alunos por níveis (ex: Chave de braço, Estrangulamento) | Substituir a percepção subjetiva por um histórico evolutivo real. |
| **Instrutor** | Identificar as dificuldades específicas de cada praticante | Planejar treinamentos mais eficazes e aulas personalizadas. |
| **Aluno** | Autenticar-se no sistema usando meu CPF e senha | Acessar com segurança o meu painel individual do aluno. |
| **Aluno** | Visualizar meu histórico de desempenho e assiduidade | Compreender meus pontos fortes e me motivar para as graduações. |

---

## Requisitos

### Requisitos Funcionais (RF)

| ID | Descrição | Prioridade |
| :--- | :--- | :--- |
| **RF-001** | O sistema deve permitir o login e autenticação de usuários conforme o tipo de acesso (Administrador, Professor, Aluno). | Essencial |
| **RF-002** | O sistema deve permitir o cadastro de alunos com dados pessoais (nome, e-mail, CPF, telefone, data de nascimento, endereço e faixa). | Essencial |
| **RF-003** | O sistema deve permitir editar e excluir dados cadastrais dos alunos. | Essencial |
| **RF-004** | O sistema deve permitir o cadastro, edição e exclusão de professores/instrutores. | Essencial |
| **RF-005** | O sistema deve permitir registrar a presença diária dos alunos em suas respectivas turmas. | Essencial |
| **RF-006** | O sistema deve permitir consultar o histórico de frequência de cada aluno de forma individualizada. | Essencial |
| **RF-007** | O sistema deve gerenciar turmas, permitindo vincular alunos e instrutores a elas. | Essencial |
| **RF-008** | O sistema deve permitir registrar o pagamento de mensalidades dos alunos praticantes. | Essencial |
| **RF-009** | O sistema deve permitir consultar a situação financeira em tempo real do aluno (adimplente/inadimplente). | Essencial |
| **RF-010** | O sistema deve permitir registrar a evolução técnica dos alunos através do ranqueamento de níveis de habilidades específicas (ex: Chaves de braço, Estrangulamentos, Imobilizações, Quedas). | Importante |
| **RF-011** | O sistema deve permitir visualizar o histórico de desempenho individual e identificar dificuldades específicas de forma centralizada. | Importante |
| **RF-012** | O sistema deve gerar relatórios administrativos básicos de frequência por período. | Desejável |
| **RF-013** | O sistema deve gerar relatórios financeiros básicos sobre os mensalistas. | Desejável |
| **RF-014** | O sistema deve gerar relatórios unificados e consolidados (frequência, desempenho técnico e finanças) para apoio à tomada de decisões estratégicas da gerência. | Desejável |

### Requisitos Não Funcionais (RNF)

| ID | Descrição | Prioridade |
| :--- | :--- | :--- |
| **RNF-001** | O sistema deve ser responsivo, adaptando-se perfeitamente a interfaces Desktop (Navegadores) e Mobile (Smartphones). | Essencial |
| **RNF-002** | O sistema deve possuir uma interface simples, amigável e intuitiva, voltada para usuários leigos ou sem conhecimento técnico avançado. | Essencial |
| **RNF-003** | O sistema deve exigir autenticação segura por CPF e senha para liberação de acesso às funcionalidades. | Essencial |
| **RNF-004** | O sistema deve garantir o controle de permissões de acesso estrito (restrição conforme o tipo de perfil: Administrador/Professor/Aluno). | Essencial |
| **RNF-005** | O sistema deve garantir a proteção e privacidade dos dados cadastrados dos alunos. | Essencial |
| **RNF-006** | O sistema deve responder às requisições e ações do usuário em um tempo limite de até 2 segundos. | Importante |
| **RNF-007** | O sistema deve ser capaz de suportar múltiplos acessos simultâneos sem sofrer degradação em seu desempenho geral. | Importante |
| **RNF-008** | O sistema deve estar disponível continuamente, garantindo o funcionamento estável durante todo o horário de atendimento da academia. | Importante |
| **RNF-009** | A arquitetura do sistema deve ser estruturada de forma modular para facilitar futuras manutenções corretivas e evoluções de código. | Importante |

### Restrições do Projeto

| ID | Restrição |
| :--- | :--- |
| **001** | O projeto possui caráter estritamente acadêmico, o que inviabiliza custos previstos com infraestruturas pagas de hospedagem ou licenciamento corporativo. |
| **002** | O sistema web deve obrigatoriamente ser desenvolvido utilizando a arquitetura de software recomendada pela instituição parceira e escopo do curso. |
| **003** | O prazo limite para a entrega do sistema funcional documentado e revisado encerra-se impreterivelmente ao final do semestre letivo corrente. |
