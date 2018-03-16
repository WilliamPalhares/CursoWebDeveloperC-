go
create table Cliente(
	IdCliente		integer			identity(1,1),
	Nome			nvarchar(50)	not null,
	Email			nvarchar(50)	not null,
	DataCadastro	datetime		not null,
	primary key(IdCliente))

go
create table Endereco(
	IdEndereco		integer			identity(1,1),
	Logradouro		nvarchar(50)	not null,
	Cep				char(8)			not null,
	IdCliente		integer			not null unique, --cardinalidade 1 para 1
	primary key(IdEndereco),
	foreign key(IdCliente) references Cliente(IdCliente))


