Funcionalidade: Home

Contexto: Acesso a Home
	Quando Acessar a home http://localhost:50677/
	#E estiver logado

Cenario: Cadastro de uma entrada
	Dado a opção ENTRADA
	E a descrição Pagamento de Salário
	E Valor 1892,93
	E a data 06/06/2014
	E clicar em cadastrar
	Então Deve aparecer a mensagem Entrada cadastrada com sucesso.
	E clicar em Últimas Entradas
	E o último registro ter os dados de entrada

Cenario: Cadastro de uma saída Importante
	Dado a opção SAÍDA
	E a descrição Compras no Bourbon
	E Valor 162,15
	E a data 06/06/2014
	E a importancia Importante
	E deduz do imposto de renda DESMARCADO
	E clicar em cadastrar
	E e tiver saldo
	Então Deve aparecer a mensagem Saída cadastrada com sucesso.
	E clicar em Últimas Saídas
	E o último registro ter os dados de entrada

Cenario: Cadastro de uma saída Importante/Dispensável
	Dado a opção SAÍDA
	E a descrição Besteiras para a casa
	E Valor 67,87
	E a data 07/06/2014
	E a importancia Importante/Dispensável
	E deduz do imposto de renda DESMARCADO
	E clicar em cadastrar
	E e tiver saldo
	Então Deve aparecer a mensagem Saída cadastrada com sucesso.
	E clicar em Últimas Saídas
	E o último registro ter os dados de entrada

Cenario: Cadastro de uma saída Dispensável
	Dado a opção SAÍDA
	E a descrição Pizza
	E Valor 83,58
	E a data 09/06/2014
	E a importancia Dispensável
	E deduz do imposto de renda DESMARCADO
	E clicar em cadastrar
	E e tiver saldo
	Então Deve aparecer a mensagem Saída cadastrada com sucesso.
	E clicar em Últimas Saídas
	E o último registro ter os dados de entrada

Cenario: Cadastro de uma saída Importante E deduz no imposto de renda
	Dado a opção SAÍDA
	E a descrição Plano de Saúde IPE
	E Valor 93,98
	E a data 10/06/2014
	E a importancia Importante
	E deduz do imposto de renda MARCADO
	E CNPJ/CPF for 123.123.123-12
	E clicar em cadastrar
	E e tiver saldo
	Então Deve aparecer a mensagem Saída cadastrada com sucesso.
	E clicar em Últimas Saídas
	E o último registro ter os dados de entrada

Cenario: Não aparecer o campo importância quando For Entrada
	Dado a opção ENTRADA
	E a importancia Dispensável
	Então Deve retornar erro de campo não encontrado

Cenario: Não aparecer o campo deduz do imposto de renda quando For Entrada
	Dado a opção ENTRADA
	E deduz do imposto de renda MARCADO
	Então Deve retornar erro de campo não encontrado

Cenario: Não aparecer o campo CNPJ/CPF quando For Saída que não deduz do imposto de renda
	Dado a opção SAÍDA
	E deduz do imposto de renda DESMARCADO
	E CNPJ/CPF for 123.123.123-12
	Então Deve retornar erro de campo não encontrado