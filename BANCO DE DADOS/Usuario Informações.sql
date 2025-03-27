create table filme (
 id INT AUTO_INCREMENT PRIMARY KEY, 
 titulo varchar (225)  not null,
 genero varchar (100),
 duracao int,
 atores varchar (255),  
 idioma varchar (50),
 pais_de_origem varchar (100),
 personagem varchar (100)
 );
 select
 *
 from
 filme;
 insert into filme (titulo, genero, duracao)
 values
 ('O SOL TAMBEM UM ESTRELA', 'Romance', '1h 40m'),
 ('divertidamente', 'infantil', '1h 30m'),
 ('A Forja: O Poder da Transformação', 'drama', '2h 5m');
 
