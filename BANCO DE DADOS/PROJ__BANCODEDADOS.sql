CREATE TABLE IF NOT EXISTS livro (
id INT PRIMARY KEY AUTO_INCREMENT,
titulo VARCHAR(100) NOT NULL,
data_publicacao DATETIME NOT NULL,
numero_paginas INT NULL,
preco DECIMAL(10,2)NULL,
isbn VARCHAR(17) NOT NULL UNIQUE,
genero VARCHAR(30) NOT NULL,
editora VARCHAR(50) NOT NULL,
autor VARCHAR(100) NOT NULL
);

insert into livro (
titulo, data_publicacao, preco, isbn , genero ,editora , autor
) values (
'titulo do meu livro',
'2001-03-24 18:30:03',
129.99,
'978--16-148410-0',
'romance',
'editora',
'tamires oliveira'
);

INSERT INTO livro (
titulo, data_publicacao, preco , isbn ,genero ,editora ,autor
) VALUES (
'My book',
'2024-06-07 19:30:04',
140.99,
'04-16-500045-4',
'drama',
'editora',
'larissa matos'
);

DROP TABLE LIVRO ;
