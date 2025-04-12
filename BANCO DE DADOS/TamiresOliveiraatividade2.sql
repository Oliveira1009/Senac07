 \						
INSERT INTO cliente(
nome, idade, cidade, saldo)
VALUES
('Carlos','45','São Paulo','2500.00'),
('Mariana','32','Rio de Janeiro','3200.50'),
('Pedro','27','Belo Horizonte','1500.75'),
('Fernanda','38','Curitiba','4200.00')
;
select *
from cliente;

    CREATE TABLE IF NOT EXISTS pedido (
    id INT PRIMARY KEY AUTO_INCREMENT,
    id_cliente INT NOT NULL,
    valor DECIMAL(10, 2) NULL,
    data_publicacao DATETIME NOT NULL,
     FOREIGN KEY (id_cliente)
        REFERENCES cliente (id)
);
INSERT INTO pedido(
id_cliente, valor, data_publicacao)
VALUES
('1','500.00','2024-03-10'),
('2','1200.00','2024-03-12'),
('3','300.50','2024-03-15'),
('1','800.00','2024-03-18')
;
select *
from pedido;