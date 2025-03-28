CREATE TABLE IF NOT EXISTS genero(
id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
nome VARCHAR (11) NOT NULL
);

SELECT DISTINCT (genero) from livro;

INSERT INTO genero (nome)
VALUES
('tecnologia'),
('documentário cinematográfico'),
('terror'),
('drama'),
('entrevista'),
('aventura'),
('fantasia'),
('ação'),
('ficção científica'),
('romance distópico');