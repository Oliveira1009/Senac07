create table cliente (
id int primary key auto_increment,
nome varchar (100) not null,
 data_nascimento varchar (100) not null,
 telefone varchar(11) not null,
 email varchar (50) not null,
 tipo int not null,
 etnia int not null,
 genero int not null,
 id_endereco int not null,
 foreign key (id_endereco) references endereco(id)
 );
 
 insert into cliente
 (nome,data_nascimento,telefone,email,tipo,etnia,genero,id_endereco)
 values
 ('tamires oliveira', '2001-03-24','11958977549','tamiresoliveiraaa17@gmail.com',0,1,1,(select id from endereco where logradouro = 'endereco da tamires')),
 ('kaique matos', '1999-08-31','11983888450', ' kaiquesilva@gmail.com',0,1,0,(select id from endereco where logradouro = 'endereco do kaique'));
 
 select * from endereco;