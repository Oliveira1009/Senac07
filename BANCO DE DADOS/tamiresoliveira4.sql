/*
exercicio 1: selecionando dados
*/

create table cliente(
id int primary key auto_increment,
nome varchar(50)not null,
idade int not null,
cidade varchar(50) not null,
saldo decimal(10,2) not null
);

 drop table cliente;
 
drop tables cliente;

insert into cliente (id,nome,idade,cidade,saldo)
values
(1,'carlos',45, 'sao paulo', 250000),
(2,'mariana', 32, 'rio de janeiro', 320050),
(3, 'pedro', 27, 'belo horizonte', 1500075),
(4, 'fernanda', 38, 'curitiba', 420000);

/*
tarefa 1
*/

/*
1.1
*/
select *  from cliente
where cidade = 'rio de janeiro';

/*
1.2
*/
select*from cliente
where saldo >200 order by saldo desc;

/*
1.3
*/
select nome,idade
from cliente
where idade >30;

/*
exercicio 2:clausula where
*/


/*
tarefa 2
*/

/*
1.1
*/
select*from cliente 
where idade between 25 and 40;

/*
1.2
*/
select*from cliente
where nome like 'f%';
/*
1.3
*/
select*from cliente
where cidade not in ('sao paulo','curitiba');

/*
exercicio 3; count,sum,avg, group by
*/

/*
tabela pedido
*/

create	table pedido(
id int primary key auto_increment,
cliente_id int not null,
valor decimal (10,2),
data_pedido date not null,
foreign key (cliente_id) references cliente(id)
);

drop table pedido;
insert into pedido (id, cliente_id,valor,data_pedido)
values
(1,1,50000, '2024-03-10'),
(2,2,120000, '2024-03-12'),
(3,3, 300050, '2024-03-15'),
(4,1,80000, '2024-03-18');

/*
tarefa 0.3
*/

/*
1.1
*/
select count(*) as total_pedido
from pedido;

/*
1.2
*/
select  avg(valor) as valor_medio
from pedido;

/*
1.3
*/

select cliente_id, sum(valor) as total_gasto
from pedido 
group by cliente_id;

/*
exercicio 4: junçoes(joins)
*/

/*
tabela cliente e pedido
*/

create table cliente(
id int primary key,
nome varchar (100),
cidade varchar(100)
);

insert into cliente(id,nome,cidade)
values
(1, 'carlos','sao paulo'),
(2,'mariana','rio de janeiro'),
(3,'pedro','belo horizonte'),
(4,'fernanda','curitiba');

create table pedido(
id int primary key,
cliente_id int not null,
valor decimal (10,2),
data_pedido date not null,
foreign key (cliente_id) references cliente(id)
);


insert into pedido (id, cliente_id,valor,data_pedido)
values
(1,1,50000, '2024-03-10'),
(2,2,120000, '2024-03-12'),
(3,3, 300050, '2024-03-15'),
(4,1,80000, '2024-03-18');

/*
1.1
*/

select 
cliente.id,
cliente.nome,
cliente.cidade,
pedido.valor,
pedido.data_pedido
from
cliente
inner join
pedido on cliente.id = pedido.cliente_id;

/*
1.2
*/
select 
cliente.id,
cliente.nome,
cliente.cidade,
pedido.valor,
pedido.data_pedido
from
cliente
left join
pedido on cliente.id = pedido.cliente_id;
/*
exercicio 5: subconsultas(subqueries)
*/

/*
1.1
*/

/*
1.2
*/

/*
exercicio 6: modificando dados
*/

/*
1.1
*/

/*
1.2
*/

/*
1.3
*/
