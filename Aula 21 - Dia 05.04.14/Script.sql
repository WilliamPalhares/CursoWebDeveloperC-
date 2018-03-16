go
create table Cliente(
	IdCliente		integer			identity(1,1),
	Nome			nvarchar(50)	not null,
	Email			nvarchar(50)	not null unique,
	DataCadastro	datetime		not null,
	primary key(IdCliente))
