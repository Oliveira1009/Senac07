CREATE TABLE IF  NOT EXISTS EMPREGADO(
id INT PRIMARY KEY AUTO_INCREMENT ,
nome VARCHAR (100) NOT NULL,
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
WHERE salario > 55000; 

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

CREATE TABLE IF NOT exists departamento(
id int auto_increment,
nome varchar(30) not null,
primary key (id)
);

insert into departamento(nome)
values
('rh'),
('ti'),
('vendas');

CREATE TABLE IF NOT EXISTS empregado2 (
	id INT PRIMARY KEY AUTO_INCREMENT,
	nome VARCHAR (100) NOT NULL,
	salario DECIMAL (10,2) NULL,
	idade int NOT NULL,
    id_departamento int not null,
    foreign key (id_departamento)
	references departamento (id)
);

select * from empregado2;

INSERT INTO empregado2(
nome, idade, id_departamento, salario
)VALUES(
'joão',
'30',
1,
50000),

('sarah',
'28',
2,
60000),

('Miguel',
'35',
3,
55000),

('ana',
'27',
2,
62000
);


SELECT *FROM empregado2
INNER JOIN departamento ON empregado2.id_departamento = departamento.id;

select * from empregado2
left join departamento on empregado2.id_departamento = departamento.id;


/*
exercicio 5
*/
SELECT*FROM empregado2 WHERE salario > (SELECT AVG(salario) FROM empregado2
);


/*
exercicio 6
*/

insert into empregado2 (nome,idade,id_departamento,salario) values('tomas', 45 ,3, 58.000);

select * from empregado2;

UPDATE empregado2
SET salario = salario + (salario * 0.05)
WHERE id_departamento = '3';

delete from empregado2 
where idade > 40;





