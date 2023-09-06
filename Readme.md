# Gerenciador de Bares e Restaurantes - README

Bem-vindo ao Gerenciador de Bares e Restaurantes, uma aplicação totalmente autoral e em desenvolvimento para administrar e gerenciar estabelecimentos de alimentos e bebidas. Com essa ferramenta, você poderá gerenciar o cardápio, acompanhar as comandas dos clientes e muito mais.

## Instalação e Configuração

1. Clone o repositório:

```bash
git clone https://github.com/esdraslimaf/GastroBarMVC.git
```

## Funcionalidades Atuais
### Autenticação e Controle de Acesso:
- Tela de login para usuários (Administradores ou Funcionários).
- Diferentes níveis de autenticação com layouts personalizados.
- Filtros de autorização para restringir o acesso a páginas privilegiadas.

### Gerenciamento do Cardápio:
- Cardápio público para clientes, categorizado por produtos (Não requer login).
- Adicionar novos produtos ao cardápio (Somente para administradores).
- Editar produtos existentes no cardápio (Somente para administradores).
- Remover produtos do cardápio (Somente para administradores).
- Pesquisa: Filtre dados por datas, nomes, preços ou qualquer outro critério desejado.

### Comandas e Pedidos:
- Abrir comandas personalizadas para cada cliente (Disponível tanto Administradores quanto para Funcionários).
- Adicionar pedidos à comanda de cada cliente (Disponível tanto Administradores quanto para Funcionários).
- Cálculo automático do valor total da comanda (Ao adicionar pedido na comanda).
- Visualizar a lista de pedidos feitos por cada cliente (Disponível tanto Administradores quanto para Funcionários).
- Pesquisa: Filtre dados por datas, nomes, preços ou qualquer outro critério desejado.

### Relatórios Personalizados:
- Gerar relatórios personalizados ao encerrar a comanda do cliente (Disponível tanto Administradores quanto para Funcionários).
- Visualizar as comandas fechadas/exibir relatório das mesmas(Somente para administradores)
- Pesquisa: Filtre dados por datas, nomes, preços ou qualquer outro critério desejado.

## Demonstração:
### 1. Tela inicial(Esta seção mostra a tela inicial da aplicação, que exibe o cardápio público(Não requer login, pois é para clientes). Os itens do cardápio podem ser adicionados, editados ou removidos ao acessar a conta de administrador):
![image](https://github.com/esdraslimaf/GastroBarMVC/assets/101669187/4cc99275-cb92-4ced-8d74-fdcf344f8817)

### 2. Tela de login:
![image](https://github.com/esdraslimaf/GastroBarMVC/assets/101669187/44ac0981-d047-4ec7-8e0f-2a46b4e31eb1)

### 3. Login com Conta de Administrador
![image](https://github.com/esdraslimaf/GastroBarMVC/assets/101669187/4180fb5d-bba3-4e90-a138-1b2b53a79a67)

#### 3.1 Página de Comandas Abertas
Esta seção apresenta a página onde tanto administradores quanto funcionários comuns (Funcionários) podem realizar várias ações relacionadas às comandas dos clientes.

- **Abrir Comanda:** Nesta tela, os usuários podem iniciar uma nova comanda para um cliente.
- **Adicionar Pedidos:** É possível adicionar pedidos específicos à comanda do cliente, como demonstrado abaixo.
- **Remover Pedidos:** Se necessário, os pedidos podem ser removidos individualmente da comanda.
- **Fechar Comanda (Encerrar):** Ao encerrar a comanda, a situação dela é alterada de "Aberta" para "Fechada", e um relatório da comanda é gerado.
![image](https://github.com/esdraslimaf/GastroBarMVC/assets/101669187/9b659dfa-23df-4eb8-ae74-7193065b4042)

#### 3.1.1 Abrir Comanda
Esta imagem destaca o processo de abertura de uma nova comanda para um cliente específico.
![image](https://github.com/esdraslimaf/GastroBarMVC/assets/101669187/bfcda4e3-4234-4f7f-863e-627658241ef4)

#### 3.1.2 Comanda Aberta
Aqui, é mostrado o resultado após a abertura bem-sucedida da comanda.
![image](https://github.com/esdraslimaf/GastroBarMVC/assets/101669187/1254b189-b09f-4322-adc5-25fd54cc10a8)

#### 3.1.3 Adicionar Pedido à Comanda
Esta imagem destaca o processo de adição de um pedido à comanda do cliente. No exemplo, estamos adicionando "Pastéis de camarão - 10 unidades".
![image](https://github.com/esdraslimaf/GastroBarMVC/assets/101669187/b34fac90-c40b-49ba-8547-1d3a87ca819b)

#### 3.1.4 Pedido Adicionado
Aqui, você pode ver o resultado após a adição bem-sucedida do pedido à comanda.
![image](https://github.com/esdraslimaf/GastroBarMVC/assets/101669187/b317857c-e4b1-4c80-a788-8ac86d6cec04)

#### 3.1.5 Ver Pedidos
Este botão permite que você visualize os pedidos adicionados à comanda. Também é possível remover pedidos posteriormente, se necessário.
![image](https://github.com/esdraslimaf/GastroBarMVC/assets/101669187/5d714142-b03a-42bf-b775-48f72513877f)

#### 3.1.6 Fechar Comanda
O botão "Fechar conta" é usado para alterar a "situação" da comanda de "Aberta" para "Fechada" e para gerar um relatório da comanda.
![image](https://github.com/esdraslimaf/GastroBarMVC/assets/101669187/93a42a64-5db1-422d-b1a6-77d33e84eaa5)

#### 3.1.7 Confirmação para Encerrar Comanda
Esta imagem mostra uma confirmação do usuário antes de encerrar definitivamente a comanda.
![image](https://github.com/esdraslimaf/GastroBarMVC/assets/101669187/03c502bd-08eb-40d7-a8a3-620cf5a5b394)

#### 3.1.8 Relatório da Comanda
Aqui, você pode visualizar o relatório completo da comanda que foi encerrada.
![image](https://github.com/esdraslimaf/GastroBarMVC/assets/101669187/73ad93cd-9d64-44e2-8f4f-bedc67c4d15b)

### 3.2 Página de Comandas Fechadas
Nesta seção, apresentamos a página que permite ao administrador visualizar os dados das comandas que já foram fechadas e também puxar relatórios dessas comandas. Observação: Contas comuns (Funcionários) não têm permissão para realizar essa ação.
![image](https://github.com/esdraslimaf/GastroBarMVC/assets/101669187/bedece00-b603-46af-9d3f-e26898457437)


#### 3.2.1 Botão "Ver Detalhes" no Menu "Comandas Fechadas"
Nesta seção, destaca-se o botão "Ver Detalhes" no menu "Comandas Fechadas". Este botão é usado para exibir o relatório das comandas que já foram encerradas.
![image](https://github.com/esdraslimaf/GastroBarMVC/assets/101669187/65a6afd8-b8ab-4723-9404-18ebc46e0382)

### 3.3 Gerenciar Cardápio
Esta seção apresenta a página onde o administrador pode gerenciar o cardápio, incluindo a capacidade de adicionar novos produtos, remover produtos existentes e editar informações dos produtos.
![image](https://github.com/esdraslimaf/GastroBarMVC/assets/101669187/0509c63b-e0c0-4274-8925-667ec50ec152)

#### 3.3.1 Botão Adicionar Novo Produto
Nesta seção, destaca-se o botão "Adicionar Novo Produto". Aqui, os usuários podem inserir os campos necessários e escolher a categoria para adicionar um novo produto ao cardápio.
![image](https://github.com/esdraslimaf/GastroBarMVC/assets/101669187/52bcafaf-b546-4dde-81d8-63543c2cca43)
![image](https://github.com/esdraslimaf/GastroBarMVC/assets/101669187/507b752e-30d8-4dc8-bf55-6124623b0e2d)

#### 3.3.2 Botão Editar Produto
Nesta seção, destacamos o botão "Editar Produto". Aqui, os usuários têm a capacidade de editar as informações de um produto existente no cardápio. Este recurso permite fazer alterações nas informações de produtos já cadastrados conforme necessário.
![image](https://github.com/esdraslimaf/GastroBarMVC/assets/101669187/ce7a622c-77f2-45a2-b4df-335d9cfeebe0)
![image](https://github.com/esdraslimaf/GastroBarMVC/assets/101669187/ec8434a7-282d-4187-866f-7cbb2483d099)
![image](https://github.com/esdraslimaf/GastroBarMVC/assets/101669187/e1f30cc7-c33b-44bb-8086-5ef5eaba0883)

### 3.4 Menu "Gerenciar usuários" 
Aqui o administrador tem o controle total sobre as contas de usuário. Este menu permite ao administrador adicionar novas contas de usuário, editar contas existentes ou remover contas conforme necessário. É uma ferramenta essencial para gerenciar o acesso e as permissões dos usuários do sistema.
![image](https://github.com/esdraslimaf/GastroBarMVC/assets/101669187/3a21f006-cee0-4ee2-b4e1-3981392fea5e)

#### 3.4.1 Botão "Adicionar Usuário"
Ao clicar no botão "Adicionar Usuário" no menu "Gerenciar Usuários", o administrador é direcionado para uma página onde pode inserir os dados de um novo usuário. Os campos necessários incluem:
- Nome
- Login
- E-mail
- Tipo de Conta (Administrador ou Funcionário/Conta Comum)
- Senha
  
Essa página é essencial para o processo de criação de novas contas de usuário no sistema, permitindo ao administrador configurar as informações necessárias para cada usuário(Administrador ou Funcionário) do estabelecimento.
![image](https://github.com/esdraslimaf/GastroBarMVC/assets/101669187/f2c954ff-507a-4554-aacd-344165c6dd41)
![image](https://github.com/esdraslimaf/GastroBarMVC/assets/101669187/c743c61c-c644-40ea-946e-5365cf9c00a9)

#### 3.4.2 Botão "Editar Usuário"
A seção "Editar Usuário" proporciona ao administrador a capacidade de modificar os dados existentes de um usuário de acordo com as necessidades. As opções de edição incluem:
- Nome
- Login
- E-mail
- Senha
- Tipo de Conta (alterar entre Administrador e Funcionário/Conta Comum)

Esse recurso permite ao administrador ajustar as informações de um usuário existente, bem como suas permissões no sistema, seja mudando para administrador ou funcionário e vice-versa.
![image](https://github.com/esdraslimaf/GastroBarMVC/assets/101669187/e1078609-41b3-4680-99a5-85b64a480ba7)
![image](https://github.com/esdraslimaf/GastroBarMVC/assets/101669187/3bab3153-015e-4a0d-a345-9a8a4500ce3d)
![image](https://github.com/esdraslimaf/GastroBarMVC/assets/101669187/40adf1fe-eb40-44dd-8023-d61745510791)

### 3.5 Menu "Sair"
O menu "Sair" oferece aos usuários a opção de deslogar de suas contas e voltar à tela inicial do sistema. 
Essa funcionalidade é útil para encerrar a sessão atual e retornar à página inicial do sistema, especialmente quando um usuário deseja trocar de conta ou encerrar sua sessão.
![image](https://github.com/esdraslimaf/GastroBarMVC/assets/101669187/85f1e0c8-9f43-4f5f-a2ce-ea9b18aae134)


### 4. Login com Conta Comum (Funcionário)
Nesta seção, apresenta-se a tela inicia após login com uma conta comum de funcionário.
![image](https://github.com/esdraslimaf/GastroBarMVC/assets/101669187/cc8b0ddd-499e-457b-8b49-c0cc36204238)

#### 4.1 Menu "Comandas Abertas"
O menu "Comandas Abertas" oferece acesso às comandas em andamento. Os funcionários podem visualizar e gerenciar as comandas que estão em aberto.
![image](https://github.com/esdraslimaf/GastroBarMVC/assets/101669187/1afd4e8b-a296-448d-93af-5d291ce6f73a)

#### 4.2 Menu "Cardápio"
No menu "Cardápio", os funcionários podem visualizar o cardápio, mas não têm permissão para fazer alterações como adicionar, remover ou editar itens. Essas ações estão disponíveis apenas para administradores.
Essas seções ilustram a experiência de um funcionário no sistema, com acesso limitado comparado aos administradores.
![image](https://github.com/esdraslimaf/GastroBarMVC/assets/101669187/bb8c5edd-8099-4c48-9600-a8b6b6d66ab8)

#### 4.3 Restrição de Acesso
O sistema implementa uma restrição de acesso para diferentes tipos de usuários:
- Quando um usuário comum (Funcionário) tenta acessar uma página restrita aos administradores, ele será restringido e redirecionado para uma tela de erro. Isso é possível graças à implementação de filtros de autorização no sistema.
![image](https://github.com/esdraslimaf/GastroBarMVC/assets/101669187/46734224-6868-41be-a615-375bc42a2e03)

- Já os clientes são redirecionados para a página que exibe o cardápio público, pois essa deve ser a única página à qual os clientes têm acesso.
![image](https://github.com/esdraslimaf/GastroBarMVC/assets/101669187/d65b7264-1da3-40eb-9b23-a70ab63f4a50)

