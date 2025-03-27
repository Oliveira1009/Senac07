select * from livro
where data_publicacao >= '1957-11-09 00:00::00'
and data_publicacao <= '1999-12-31 23:59:59';

select * from livro 
where data_publicacao between '1957-11-09 00:00::00' and '1999-12-31 23:59:59';

select * from livro
where year (data_publicacao) between '1957' and '1999';

select distinct(autor) from livro;

select sum(preco), avg(preco), max(preco), min(preco) from livro;

select count(id) from livro;

select * from livro 
order by titulo desc;

select * from livro 
order by data_publicacao, titulo desc;

select * from livro 
order by min(preco) desc;

select * from livro 
order by autor desc;

select * from livro 
order by max(preco) desc;


