go
create table Fornecedor(
	IdFornecedor	integer			identity,
	Nome			nvarchar(50)	not null,
	primary key(IdFornecedor))

go
create table Produto(
	IdProduto		integer			identity,
	Nome			nvarchar(50)	not null,
	Preco			float			not null,
	DataCadastro	datetime		not null,
	IdFornecedor	integer			not null,
	primary key(IdProduto))

go --regra de chave estrangeira => cardinalidade 1pN
alter table Produto add constraint FkProdutoFornecedor
foreign key(IdFornecedor) references Fornecedor(IdFornecedor)

go --regra para limite do campo Preco do Produto
alter table Produto add constraint CkProdutoPreco
check(Preco > 0 and Preco <= 10000)


	
	