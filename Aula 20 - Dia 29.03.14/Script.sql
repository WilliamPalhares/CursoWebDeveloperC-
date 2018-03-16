go
create table Cliente(
	IdCliente		integer			identity,
	Nome			nvarchar(50)	not null,
	Sexo			char(1)			not null,
	DataCadastro	datetime		not null,
	primary key(IdCliente))

go
create table Endereco(
	IdEndereco		integer			identity,
	Logradouro		nvarchar(50)	not null,
	Cidade			nvarchar(50)	not null,
	Estado			nvarchar(50)	not null,
	Tipo			nvarchar(50)	not null,
	IdCliente		integer			not null,
	primary key(IdEndereco))

go
alter table Endereco add constraint FkEnderecoCliente
foreign key(IdCliente) references Cliente(IdCliente)

go
alter table Endereco add constraint CkEnderecoTipo
check(Tipo = 'Residencial' or Tipo = 'Comercial')
