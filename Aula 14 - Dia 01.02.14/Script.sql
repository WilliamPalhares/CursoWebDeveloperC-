go
create table Cliente(
	IdCliente		integer			identity,
	Nome			nvarchar(50)	not null,
	Email			nvarchar(50)	not null,
	primary key(IdCliente))

go
create table Endereco(
	IdEndereco		integer			identity,
	Logradouro		nvarchar(50)	not null,
	Cidade			nvarchar(50)	not null,
	Estado			nvarchar(50)	not null,
	IdCliente		integer			not null unique,
	primary key(IdEndereco),
	foreign key(IdCliente) references Cliente(IdCliente))