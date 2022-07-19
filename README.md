### <!-- Sistema de Gestão de Materiais Ferroviários -  --> SISMF

Grupos de Funcionalidades:
1) **Infraestrutura:**
- Tratamento de Exceção;
- Gravação de Logs em arquivos;	
- Autenticação;
- Autorização;
- Auditoria;

2) **Cadastros:**
- Grupos (tipos) de produtos;
- Marcas de produtos;
- Locais de Armazenamento;
- Unidades de Medida;
- Países, Estados, Cidades;
- Fornecedores;
- Produtos;
- Perfis de Usuários;
- Usuários

3) **Operações:**
- Entrada de Produtos;
- Saída de Produtos;
- Lançamentos de Perdas de Produtos;
- Inventário de Estoque;

4) **Relatórios:**
- Posição de estoque;
- Ressuprimento;

5) **Gráficos:**
- Perdas por mês;
- Entradas vs Saídas por mês;

<!-- ### Apresentação da Aplicação -->


### Fluxo de Execução Básico:

Usuário está ligado a todas as entidades, que acabam por se tornar tabelas do banco de dados e referência semântica para o padrão de projeto MVC:

```mermaid
flowchart LR

X(Usuário)  -->  Y(Perfil)  --> Z(Produto)

A(Produto) --> B(Grupo)
A --> C(Marca)
A --> D(Fornecedor)
A --> E(Unidade de Medida)
A --> F(Local)
A --> G(Perda)
A --> H(Inventário)
A --> I(Saída)
A --> J(Entrada)
D --> K(Cidade)
K --> L(Estado)
L --> M(País)
```

Com as entidades definidas já é possível criar a guia com as listas suspensas (Dropdowns) do sistema, usando a Técnica Top-Down:

```cs
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    @*Guia do dropdown*@
                    <li>
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown">
                            @*Propriedades que mostram o dropdown*@
                            Cadastros
                            <span class="caret"></span>
                        </a>
                        <ul class="dropdown-menu">
                            <li>@Html.ActionLink("Grupo de Produtos", "GrupoProduto", "Cadastro")</li>
                            <li>@Html.ActionLink("Marcas de Produtos", "MarcaProduto", "Cadastro")</li>
                            <li>@Html.ActionLink("Locais de Armazenamento", "LocalProduto", "Cadastro")</li>
                            <li>@Html.ActionLink("Unidades de Medida", "UnidadeMedida", "Cadastro")</li>
                            <li>@Html.ActionLink("Produtos", "Produto", "Cadastro")</li>
                            <li>@Html.ActionLink("Países", "Pais", "Cadastro")</li>
                            <li>@Html.ActionLink("Estados", "Estado", "Cadastro")</li>
                            <li>@Html.ActionLink("Cidades", "Cidade", "Cadastro")</li>
                            <li>@Html.ActionLink("Perfis de Usuários", "UsarioPerfil", "Cadastro")</li>
                            <li>@Html.ActionLink("Usuários", "Usuario", "Cadastro")</li>
                        </ul>
                    </li>

                    <li>
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown">
                            Operações
                            <span class="caret"></span>
                        </a>
                        <ul class="dropdown-menu">
                            <li>@Html.ActionLink("Entrada de Produtos", "EntradaProduto", "Operacao")</li>
                            <li>@Html.ActionLink("Saída de Produtos", "SaidaProduto", "Operacao")</li>
                            <li>@Html.ActionLink("Lançamento de Perdas de Produto", "LancPerdaProduto", "Operacao")</li>
                            <li>@Html.ActionLink("Inventário de Estoque", "InvetarioEstoque", "Operacao")</li>
                        </ul>
                    </li>

                    <li>
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown">
                            Relatórios
                            <span class="caret"></span>
                        </a>
                        <ul class="dropdown-menu">
                            <li>@Html.ActionLink("Posição do Estoque", "PosicaoEstoque", "Relatorio")</li>
                            <li>@Html.ActionLink("Ressuprimento", "Ressuprimento", "Relatorio")</li>
                        </ul>
                    </li>

                    <li>
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown">
                            Gráficos
                            <span class="caret"></span>
                        </a>
                        <ul class="dropdown-menu">
                            <li>@Html.ActionLink("Perdas por mês", "PerdaMes", "Grafico")</li>
                            <li>@Html.ActionLink("Entradas vs Saídas por mês", "EntradaSaidaMes", "Grafico")</li>
                        </ul>
                    </li>
                </ul>


```

<!-- ### Funcionalidades da App


### Modelo de Dados


### Tecnologias Utilizadas

- .NET Framework 4.5.2
- C#
- ASP.NET MVC 5
- Xamarin
- Entity Framework
- SQL Server Express
- Log4net
- Javascript(jQuery)
- AJAX
- Bootstrap
- IIS
- Crystal Reports
- Google Graphs

### Estrutura Básica da App


### Controle de Usuários


### Cadastros


### Relatórios


### Gráficos


### Aplicativo Móvel

### SmartyPants

|                |ASCII                          |HTML                         |
|----------------|-------------------------------|-----------------------------|
|Single backticks|`'Isn't this fun?'`            |'Isn't this fun?'            |
|Quotes          |`"Isn't this fun?"`            |"Isn't this fun?"            |
|Dashes          |`-- is en-dash, --- is em-dash`|-- is en-dash, --- is em-dash|
 -->


<!-- Tools:
#mermaid
#stackedit

### Conceitos Básicos
Controle de fluxo de entrada e saída de produtos em uma empresa.
- Conjunto de produtos armazenados em um local.
- Dinheiro armazenado na empresa;
- 
**Pra que serve?**
- Bater as contas no final do mês;
- Calcular Lucros;
- Identificar perdas;
- Contribuir para o governo(ICMS);
---
Tipos de Estoque:
- **Matéria-prima** (celulose, minério de ferro, petróleo, etc).
- **Produtos não acabados** (peças, motores, chips, componentes eletrônicos, etc).
- **Produtos finalizados**  (carros, notebooks, etc).
- **Consumíveis** - (combustíveis, materiais de escritório, etc). 



### Drafts:

Tudo começa na compra, todo produto é comprado por um fornecedor.
E aí há uma entrada, uma saída e a venda pelo PDV.

Em algum momento as perdas precisam ser registradas.
Inventário também tem que ser feito de tempos em tempos.

Cuidados:

1. Nunca pode faltar produto (relatórios fazem a diferença);
2. Nunca pode sobrar produtos em exagero;
3. Fazer inventários periodicamente;
4. Controlar a quantidade mínima (para não deixar faltar);


BundleConfig - minificação de recursos (javascript, css e etc);
FilterConfig - Filtros Aspnet;
RouteConfig - Rota padrão;

Controller - Default é o home e é o ponto de entrada de cada uma das rotas;

Todas as páginas por padrão herdam de Shared;

Template ASP net MVC.


Após a definição do Dropdown.
Criamos uma Controller 

-->