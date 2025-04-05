/*
tabela 1
*/
CREATE TABLE IF NOT EXISTS produto (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    categoria VARCHAR(100) NOT NULL,
    preco DECIMAL(10,2) NOT NULL,
    estoque INT NOT NULL,
    id_fornecedor INT NOT NULL,
    FOREIGN KEY (id_fornecedor) REFERENCES fornecedor(id)
);

/*
tabela 2
*/
CREATE TABLE IF NOT EXISTS fornecedor(
id INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR (100) NOT NULL,
cidade VARCHAR(100) NOT NULL
);

drop table fornecedor;

/*
tabela 3
*/
CREATE TABLE IF NOT EXISTS pedido(
id INT PRIMARY KEY AUTO_INCREMENT,
produto_id int not null,
data_pedido date not null,
quantidade int not null,
cliente_id int not null,
foreign key (produto_id) references produto(id),
foreign key (cliente_id) references cliente(id)
);

/*
tabela 4   
*/ 
create table if not exists cliente(
id int primary key auto_increment,
nome varchar (100) not null,
cidade varchar (225) not null,
idade int not null
);

insert into produto(
categoria,nome,preco,estoque)
values
('celular x', 'eletronicos' , 25000.00, 30 ),
('notebook x', 'eletronicos', 4800.00, 15 ),
('mesa de madeira', 'moveis', 750.00, 10),
('cadeira z', 'moveis', 300.00, 25),
('tv 50', 'eletronicos',3500.00,8)
;

insert into fornecedor(
nome,cidade)
values
('techbrasil', 'sao paulo'),
('computech', 'rio de janeiro'),
('movies&co', 'curitiba')
;

insert into pedido(
produto_id,quantidade,data_pedido,cliente_id)
values
(1,2,'2024-03-10', 1),
(3,1,'2024-03-11',2),
(2,1,'2024-03-15',3),
(5,3,'2024-03-18',1),
(4,4,'2024-03-20',4)
;

insert into cliente(
nome,cidade,idade)
values
('joao silva', 'sao paulo',35),
('maria santos', 'belo horizonte' , 28),
('carlos lima' ,'rio de janeiro', 42),
('fernanda rocha', 'curitiba', 30)
;

select*from produto;

select*from fornecedor;

select*from pedido;

select*from cliente;

/*
2 exercicio avancados
*/


/* 
1
*/

select*from produto
where trim(categoria) like 'eletronicos'
and cast(preco as decimal) > 300
order by preco desc;

/*
2
*/
select*from cliente
where cidade <> 'sao paulo'
and idade >30;

/*
3
*/

select*from pedido
where data_pedido  between '2024-03-10' and '2024-03-15' 
order by data_pedido desc;

/*
4
*/

select*from produto 
where estoque <10
order by estoque asc;

/*
5
*/
select*from fornecedor
where cidade <> 'rio de janeiro'
and nome like 't%';


/*
parte 2 agregagação e agrupamento
*/

/*
1.1
*/

select categoria, avg(preco) as preco_medio
from produto
group by categoria;

/*
1.2
*/

SELECT cliente_id, COUNT(produto_id) AS total_pedido
from pedido
GROUP BY cliente_id;

/*
1.3
*/

select categoria, sum(estoque) as total_estoque
from  produto
group by categoria;

/*
1.4
*/
SELECT id, produto_id, quantidade
FROM pedido
ORDER BY quantidade DESC
LIMIT 1;

/*
1.5
*/
select cidade , count(*) as total_cliente
from cliente
group by cidade	
order by total_cliente desc;

/*
parte 3 junçoes 
*/

/*
1.1
*/
SELECT p.*, f.nome AS nome_fornecedor
FROM produto p
INNER JOIN fornecedor f ON p.fornecedor_id = f.id
ORDER BY f.nome;

/*
1.2
*/

SELECT ped.*, c.nome AS nome_cliente, p.nome AS nome_produto
FROM pedido ped
INNER JOIN cliente c ON ped.cliente_id = c.id
INNER JOIN produto p ON ped.produto_id = p.id
ORDER BY ped.data_pedido;

/*
1.3
*/

SELECT ped.*, c.nome AS cliente, p.nome AS produto, f.nome AS fornecedor
FROM pedido ped
INNER JOIN cliente c ON ped.cliente_id = c.id
INNER JOIN produto p ON ped.produto_id = p.id
INNER JOIN fornecedor f ON p.fornecedor_id = f.id;

/*
1.4
*/

SELECT c.nome, SUM(ped.quantidade) AS total_produtos
FROM pedido ped
INNER JOIN cliente c ON ped.cliente_id = c.id
GROUP BY c.nome;

/*
parte 4 subconsultas e modificação de dados
*/

/*
1.1
*/
select *from produto 
where preco > (select avg(preco) from produto 
where categoria = produto.categoria);

/*
1.2
*/
select c.nome, p.id as pedido_id
from cliente c
left join pedido p on c.id = p.cliente_id;

/*
1.3
*/
DELETE FROM pedido 
WHERE cliente_id = (SELECT id FROM cliente WHERE cidade = 'Curitiba');
/*
1.4
*/

INSERT INTO cliente (nome, cidade, idade) VALUES
			   ('Ricardo Lopes', 'Porto Alegre', 38);

/*
1.5
*/
INSERT INTO pedido (produto_id, quantidade, data_pedido, cliente_id) VALUES 
((SELECT id FROM produto WHERE nome = 'Notebook Y'), 2 , 
'2024-03-25', (SELECT id FROM cliente WHERE nome = 'João Silva'));

INSERT INTO pedido (produto_id, quantidade, data_pedido, cliente_id) VALUES 
(4, 2, '2025-04-03', (SELECT id FROM cliente WHERE nome = 'Ricardo Lopes'));

/*
1.6
*/

SELECT pro.categoria, ped.id AS id_pedido, cli.nome
			   FROM pedido ped
               INNER JOIN cliente cli ON cli.id = ped.cliente_id
               INNER JOIN produto pro ON pro.id = ped.produto_id
               WHERE categoria = 'Móveis';

