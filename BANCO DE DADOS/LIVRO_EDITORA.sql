CREATE TABLE IF NOT EXISTS editora(
id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
nome VARCHAR(11) NOT NULL UNIQUE,
documento VARCHAR (14) NOT NULL UNIQUE
);

select distinct(editora) from livro;

INSERT INTO editora ( nome, documento)
VALUES
('intrínseca', '21306675000133'),
('abril', '87067440000144'),
('globo', '03708536000154'),
('panini', '22455174000181'),
('rocco ltda.', '41500632000100'),
('darkside', '80731635000106'),
('marvel', '49420531000122'),
('harpercollins', '36780957000145'),
('companhia das letras', '20413077000109'),
('senac', '82535051000182'),
('biblioteca azul', '97045992000105');

select
*
from 
autor;

select 
*
from
genero;

select
*
from
editora;
