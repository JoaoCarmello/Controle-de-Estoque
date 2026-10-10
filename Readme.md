\# 📦 Sistema de Controle de Estoque



Aplicativo desktop desenvolvido em \*\*C# com Windows Forms\*\* para gerenciamento de estoque, permitindo o lançamento de entradas e saídas de mercadorias com persistência de dados em arquivos JSON, controle de saldo dinâmico e rastreabilidade por identificadores únicos de movimentação.



\## 🚀 Funcionalidades



\* \*\*Leitura e Escrita de Dados via JSON:\*\* Importa e atualiza o cadastro inicial de produtos e o histórico de movimentações diretamente de arquivos locais.

\* \*\*Lançamento de Movimentações:\*\* Permite registrar entradas e saídas de mercadorias informando o produto, o tipo de operação e a quantidade desejada.

\* \*\*Validação de Estoque:\*\* Impede saídas de mercadorias caso o saldo em estoque seja insuficiente.

\* \*\*Histórico com ID Único:\*\* Cada movimentação gera um identificador exclusivo, registrando o tipo, a quantidade, o carimbo de data/hora e o estoque final resultante.

\* \*\*Interface Dinâmica (WinForms):\*\* Atualização em tempo real de componentes visuais (`ComboBox`, `NumericUpDown`, `Labels`) integrados à camada de controle.



\## 🛠️ Tecnologias Utilizadas



\* \*\*Linguagem:\*\* C# (.NET)

\* \*\*Interface Gráfica:\*\* Windows Forms (WinForms)

\* \*\*Manipulação de Dados:\*\* `System.Text.Json` (Serialização e Deserialização)

\* \*\*Arquitetura:\*\* Padrão em camadas (Controllers, Models, Repositories, Services e Views) utilizando princípios de Injeção de Dependência e Repositórios.



\## 📂 Estrutura do Projeto



```text

controleEstoque/

│

├── Controllers/         # Intermediação entre a interface gráfica e os serviços de negócio

├── Data/                # Arquivos JSON de dados (Estoque.json e Movimentacoes.json)

├── Models/              # Entidades e enumeradores (Produto, Movimentacao, TipoMovimentacao)

├── Repositories/        # Camada de persistência e acesso aos arquivos JSON

├── Services/            # Regras de negócio de estoque e validações de movimentação

└── Views/               # Telas do sistema (frmControleEstoque)

