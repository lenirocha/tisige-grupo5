# Modelagem dos Processos de Negócio

Pré-requisitos: [Especificação do Projeto](02-Especificacao.md)

---

## Modelagem da Situação Atual (Modelagem AS IS)

Atualmente, o controle administrativo, financeiro, de frequência e o acompanhamento técnico dos alunos de Jiu-jitsu na Academia Sigma é realizado de forma descentralizada e manual, utilizando:
* **Planilhas impressas** para registro de presença, preenchidas manualmente em cima do tatame pelo instrutor durante ou ao final de cada aula.
* **Cadernos ou fichas físicas** onde os instrutores anotam de maneira subjetiva observações isoladas sobre o desempenho técnico de cada aluno.
* **Controle de mensalidades paralelo**, feito por anotações físicas ou planilhas locais na recepção, dificultando o cruzamento ágil de dados para saber quem está adimplente ou inadimplente no momento do treino.
* **Comunicação verbal ou via WhatsApp** entre os instrutores e a gerência para compartilhar informações sobre faltas recorrentes, evolução ou problemas de pagamento dos alunos.

### Problemas Identificados no Processo Atual
* **Alto risco de perda ou extravio** de informações cruciais registradas em papel (chamadas e fichas técnicas).
* **Ausência de integração** entre a frequência do aluno, sua evolução técnica e sua situação de adimplência financeira.
* **Retrabalho constante**, pois dados registrados em papel precisam ser validados e transcritos para planilhas digitais na recepção posteriormente.
* **Dificuldade de acesso a informações estratégicas**, impedindo que a gestora identifique com rapidez evasões escolares, alunos estagnados tecnicamente ou inadimplência acumulada.

---

## Descrição Geral da Proposta (Modelagem TO BE)

A solução proposta consiste na implantação do sistema web integrado **Black Belt**, que centraliza e automatiza o registro de frequência, a avaliação técnica por níveis de habilidades e o controle básico de mensalidades. Os dados passam a ser armazenados em um banco de dados relacional (SQL Server), garantindo segurança, integridade, consistência e facilidade de acesso simultâneo para a gestora e os instrutores através de dispositivos Desktop ou Mobile.

### Principais Mudanças e Oportunidades de Melhoria
* **Eliminação definitiva do papel**, substituindo planilhas e fichas físicas por registros diretos no sistema via smartphone, tablet ou computador.
* **Centralização de dados**, unificando o cadastro do aluno, seu histórico de presença, seu progresso em chaves, estrangulamentos e quedas, e seu status financeiro.
* **Controle financeiro ágil**, permitindo que a gerência identifique instantaneamente alunos adimplentes e inadimplentes, vinculando isso diretamente ao acesso às aulas.
* **Suporte à tomada de decisão**, fornecendo dados consolidados e integrados para que a gestão implemente ações eficientes de retenção de alunos.

---

## Modelagem dos Processos

### PROCESSO 1 – Registro de Frequência e Chamada
* **AS-IS:** O instrutor preenche uma lista de presença impressa no papel durante a aula. A folha é levada à recepção, onde os dados precisam ser consolidados manualmente de tempos em tempos. Se a gerência precisar de um relatório de faltas, precisa folhear os papéis ou planilhas isoladas.
* **TO-BE:** O instrutor realiza o login no sistema via dispositivo móvel, seleciona a turma ativa e realiza a chamada digital com poucos cliques. Os dados de assiduidade são atualizados em tempo real no banco de dados e ficam imediatamente disponíveis para consulta gerencial.

### PROCESSO 2 – Acompanhamento Técnico e Evolutivo
* **AS-IS:** O instrutor avalia o aluno visualmente e de forma puramente subjetiva. Anotações ocasionais são feitas em fichas físicas que ficam guardadas, sem que o aluno ou a gerência tenham uma visão transparente do progresso técnico em habilidades fundamentais.
* **TO-BE:** O instrutor acessa o perfil técnico do aluno no sistema e atribui notas/níveis estruturados para habilidades específicas (Chaves de braço, Estrangulamentos, Imobilizações e Quedas). O histórico de desempenho fica gravado, permitindo mapear as dificuldades reais da turma para o planejamento de treinos personalizados.

### PROCESSO 3 – Controle Financeiro de Mensalidades
* **AS-IS:** O controle de recebimento é feito de forma apartada. Não há uma comunicação fluida entre quem pagou a mensalidade e quem está autorizando a entrada no tatame, gerando falhas na identificação de inadimplências e afetando o faturamento.
* **TO-BE:** O sistema conta com um módulo financeiro integrado onde os pagamentos das mensalidades são registrados. O perfil do aluno passa a exibir automaticamente a condição de "Adimplente" ou "Inadimplente", permitindo que tanto a gestora quanto os instrutores tenham o controle financeiro unificado à rotina de treinos.

---

## Indicadores de Desempenho

Os indicadores de desempenho apresentados abaixo são gerados a partir dos dados adquiridos pelo sistema proposto, visto que todas as informações necessárias já são armazenadas de forma estruturada no banco de dados relacional. 

Como melhoria contínua, recomenda-se a consolidação futura desses dados em uma tela de relatórios e *dashboards* visuais para facilitar as decisões da gerência:

| Indicador | Objetivos | Descrição | Fonte de Dados | Perspectiva |
| :--- | :--- | :--- | :--- | :--- |
| **Taxa de Inadimplência** | Monitorar a saúde financeira da academia | Percentual de alunos com mensalidades em atraso em relação ao total ativo | Módulo Financeiro (Tabela de Pagamentos / Alunos) | Financeira / Gerencial |
| **Frequência Média das Turmas** | Avaliar o engajamento geral dos praticantes | Média de presenças registradas por turma em um determinado mês | Módulo de Frequência (Tabela de Presenças / Turmas) | Operacional / Pedagógica |
| **Índice de Evolução Técnica** | Medir o progresso técnico dos alunos | Percentual de alunos que subiram de nível nas habilidades mapeadas | Módulo de Avaliação (Tabela de Habilidades Técnicas) | Qualidade / Pedagógica |
| **Taxa de Evasão (Churn Rate)** | Identificar a perda de alunos | Percentual de alunos que deixaram de frequentar as aulas ou cancelaram no período | Módulo de Frequência e Cadastro de Alunos | Comercial / Retenção |
| **Ocupação de Turmas** | Otimizar a distribuição de horários e espaço | Quantidade de alunos matriculados por horário em relação à capacidade do tatame | Módulo de Turmas (Tabela de Vínculos Aluno x Turma) | Estrutural / Logística |
