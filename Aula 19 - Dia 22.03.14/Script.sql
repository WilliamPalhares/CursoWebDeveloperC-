go
create table Produto(
	IdProduto		integer			identity,
	Nome			nvarchar(50)	not null,
	Preco			decimal(10,2)	not null,
	Quantidade		integer			not null,
	primary key(IdProduto))
