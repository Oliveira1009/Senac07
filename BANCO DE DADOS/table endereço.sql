create table endereco(
id int primary key auto_increment,
logradouro varchar(100) not null,
numero varchar(10) not null,
 complemento varchar(50) not null,
 bairro varchar (50) not null,
 municipio varchar(50) not null,
 estado varchar (2) not null,
 cep varchar (8) not null
 );
 
 insert into endereco
 (logradouro, numero,complemento,bairro,municipio,estado,cep)
 values
 ('endereco da tamires',15, 3, 'jdstaedwiges','SP','SP','04913050'),
 ('endereco do kaique','46',4,'jdpresidente','BH','BH','0123459');