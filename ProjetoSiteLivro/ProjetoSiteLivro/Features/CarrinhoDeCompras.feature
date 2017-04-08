Feature: CarrinhoDeCompras
		Para comprar livros
		Eu, como usuário
		Desejo realizar a compra de dois livros Java 

@mytag
Scenario Outline: Quantidade de itens de compra atualiza corretamente adicionando o mesmo livro no carrinho de compras
	Given entrei na tela home do site Loja Livros
	And cliquei no item Entrar no menu horizontal do topo
	And informei o <email> e <senha>
	And cliquei no botao Entrar
	And cliquei no menu Livros
	And cliquei no submenu Informatica
	And cliquei no item do submenu Java
	And cliquei no comprar do livro Use a Cabeca Java
	And atualizei a quantidade do produto Use a Cabeca Java
	And cliquei no botão Continuar Comprando
	And cliquei no menu Livros
	And cliquei no submenu Informatica
	And cliquei no item do submenu Java
	When cliquei no comprar do livro Use a Cabeca Java
	Then exibe a quantidade 2 no carrinho de compras para o livro Use a Cabeca Java

Examples: 
| email                    | senha     |
| noreply@minutrade.com.br | minutrade |

