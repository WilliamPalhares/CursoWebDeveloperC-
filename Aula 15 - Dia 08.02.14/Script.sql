go
create table Produto(
	IdProduto		integer			identity,
	Nome			nvarchar(50)	not null,
	Preco			numeric(10,2)	not null,
	Quantidade		integer			not null,
	DataCompra		date			not null,
	primary key(IdProduto))
