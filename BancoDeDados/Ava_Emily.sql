CREATE TABLE IF NOT EXISTS produto (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    categoria VARCHAR(255) NOT NULL,
    preco INT NOT NULL,
    estoque INT NOT NULL,
    fornecedor_id INT NOT NULL,
    FOREIGN KEY (fornecedor_id)
        REFERENCES fornecedor (id)
);
INSERT INTO produto(nome,categoria,preco, estoque,fornecedor_id )
    VALUES('CelularX', 'Eletronicos',2500.00, 30, 1),
    ('NotebookY', 'Eletronicos', 4800.00, 15, 2),
    ('Mesa de MAdeira', 'Moveis', 750.00, 10, 3),
    ('CadeiraZ', 'Moveis', 300.00, 25, 3),
    ('TV 50', 'Eletronicos', 3500.00, 8, 1);


    

CREATE TABLE IF NOT EXISTS fornecedor (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    Cidade VARCHAR(255) NOT NULL
);

 INSERT INTO fornecedor (nome, cidade)
 VALUES ('TechBrasil', 'São Paulo'),
 ('Computech', 'Rio de Janeiro'),
 ('Moveis&CO', 'Curitiba');
 

 CREATE TABLE IF NOT EXISTS pedido (
    id INT PRIMARY KEY AUTO_INCREMENT,
    produto_id INT NOT NULL,
    quantidade INT NOT NULL,
    data_pedido DATETIME NOT NULL,
    cliente_id INT NOT NULL,
    FOREIGN KEY (cliente_id)
        REFERENCES cliente(id)
);
 INSERT INTO  pedido(produto_id, quantidade, data_pedido, cliente_id)
VALUES( 1, 2, '2024-03-10', 1),
(3, 1, '2024-03-11', 2),
(2, 1, '2024-03-15', 3),
(5, 3, '2024-03-18', 1),
(4, 4, '2024-03-20', 4);



CREATE TABLE IF NOT EXISTS  cliente(
id INT PRIMARY KEY AUTO_INCREMENT,
nome varchar (100) not null, 
cidade varchar (200) not null,
idade int not null);

INSERT INTO cliente (nome, cidade, idade)
VALUES('João Silva', 'São Paulo', 35),
('Maria Santos', 'Belo Horizonte', 28),
('Carlos Lima', 'Rio de Janeiro', 42),
('Fernanda Rocha', 'Curitiba', 30);

DROP TABLE cliente;



/*Tarefa 1*/
SELECT 
*
FROM
produto
WHERE preco > 3000
ORDER BY preco DESC;

/*Tarefa 2 */
SELECT 
*
FROM
cliente
WHERE
    cidade <> 'Sâo Paulo'
ORDER BY idade > 30;

/*Tarefa 3*/
SELECT 
 data_pedido
FROM 
pedido 
where data_pedido >='2024-03-10' AND data_pedido < '2024-03-15'
 ORDER BY data_pedido ASC;

/*Tarefa 4 */
SELECT 
 nome, estoque
FROM 
produto
where estoque < 10
 ORDER BY estoque ASC;

/*Tarefa 5*/
SELECT 
 nome, cidade
FROM 
fornecedor
where  cidade != 'Rio de JAneiro' and  nome LIKE 'T%';

/*Exercicio 2, tarefa 1*/

SELECT 
    AVG(preco)
FROM
    produto;
    
    /* Exercicio 3, tarefa 2*/
   SELECT 
	cliente_id,
    COUNT(id)
FROM
    pedido
GROUP BY quantidade;

/* Exercicio 3, tarefa 3*/
SELECT 
    SUM(estoque)
FROM
    produto;
    
/*Exercicio 4, tarefa 4 */
SELECT 
p.id, p.produto_id, p.quantidade, count(p.quantidade) AS Maior_Qauntidade
FROM
pedido p
GROUP BY p.produto_id, p.quantidade
ORDER BY Maior_Qauntidade desc;

/*Exercicio 4, tarefa 5*/
SELECT 
 c.cidade, count(c.nome) AS Numero_Cliente
FROM
cliente c
 GROUP BY c.cidade
 ORDER BY Numero_Cliente DESC;

   


    
    
    
    