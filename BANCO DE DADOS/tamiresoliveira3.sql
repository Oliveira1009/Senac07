CREATE TABLE IF NOT EXISTS produto (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    categoria VARCHAR(100) NOT NULL,
    preco DECIMAL(10,2) NOT NULL,
    estoque INT NOT NULL,
    id_fornecedor INT NOT NULL,
    FOREIGN KEY (id_fornecedor) REFERENCES fornecedor(id)
);

CREATE TABLE IF NOT EXISTS fornecedor(
id INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR (100) NOT NULL,
cidade VARCHAR(100) NOT NULL
);

drop table fornecedor;

CREATE TABLE IF NOT EXISTS pedido(
id INT PRIMARY KEY AUTO_INCREMENT,
produto_id int not null,
data_pedido date not null,
quantidade int not null,
cliente_id int not null,
foreign key (produto_id) references produto(id),
foreign key (cliente_id) references cliente(id)
);

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
parte 2
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

select cliente_id, count(quantidade) 
from pedido
group by cliente ;

/*
1.3
*/

select categoria, sum(estoque) as total_estoque
from  produto
group by categoria;

/*
1.5
*/

select id_pedido,id_produto, quantidade
from itens_pedido
group by pedido desc
limit  1;

/*
1.6
*/

select cidade, count(distinct c.id) as total_cliente
from cliente c


