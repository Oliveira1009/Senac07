CREATE TABLE IF  NOT EXISTS EMPREGADO(
id INT PRIMARY KEY AUTO_INCREMENT ,
nome VARCHAR (100) NOT NULL,
cargo VARCHAR (50) NOT NULL,
salario DECIMAL (10,2) NULL,
departamento VARCHAR (100) NOT NULL,
idade VARCHAR (20) NOT NULL
);

INSERT INTO EMPREGADO(
nome, idade, departamento, salario
)VALUES(
'joão',
'30',
'rh',
50000),

('sarah',
'28',
'TI',
60000),

('Miguel',
'35',
'vendas',
55000),

('ana',
'27',
'TI',
62000
);

SELECT*FROM empregado
WHERE departamento LIKE '%TI%';

SELECT nome,
salario FROM empregado
WHERE salario > '55000'; 

SELECT * FROM empregado
ORDER BY idade desc;

SELECT* FROM empregado
WHERE idade BETWEEN '28' AND '30'
AND idade <> 35
ORDER BY idade desc;

SELECT * FROM empregado
WHERE nome LIKE '%M%';

SELECT * FROM EMPREGADO
WHERE departamento<>'RH';

SELECT count(departamento) FROM empregado;

SELECT sum(salario) FROM empregado;

SELECT sum(salario) FROM empregado
WHERE departamento = 'vendas';

CREATE TABLE IF NOT EXISTS departamento (
	id INT AUTO_INCREMENT,
	nome VARCHAR(30) NOT NULL,
    
    PRIMARY KEY(id)
);

INSERT INTO departamento (nome) VALUES
('RH'), 
('TI'), 
('Vendas'),
('Secretaria');

CREATE TABLE IF  NOT EXISTS EMPREGADO2(
id INT PRIMARY KEY AUTO_INCREMENT ,
nome VARCHAR (100) NOT NULL,
cargo VARCHAR (50) NOT NULL,
salario DECIMAL (10,2) NULL,
id_departamento int not null,
idade VARCHAR (20) NOT NULL,
foreign key (id_departamento) references departamento(id)
);

INSERT INTO EMPREGADO2 (nome, cargo, salario, id_departamento, idade)
VALUES 
('João', 'Gerente', 50000, 1, '30'),
('ana', 'Desenvolvedora', 60000, 2, '28'),
('Miguel', 'Vendas', 55000, 3, '35');

select*from empregado2

