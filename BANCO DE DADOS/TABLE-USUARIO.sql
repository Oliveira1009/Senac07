create database Lion;

CREATE TABLE usuario (
    id INT(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    senha VARCHAR(16) NOT NULL,
    email VARCHAR(50) NOT NULL UNIQUE
);

SELECT 
    *
FROM
    usuario;

	INSERT INTO usuario (nome,email,senha)
VALUES
('Lari Matos','LariMatos@email.com','Lariee@'),
('Ikiki','kaique25@emaiil.com','ikiki0707'),
('Tamires Oliveira','Tamires@email.com','Senha@07');


 

	