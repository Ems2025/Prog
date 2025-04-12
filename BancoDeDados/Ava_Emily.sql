
/* ESTRUTURA DAS TABELAS*/
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

 
/*CONSULTAS E FILTROS (WHERE, ORDER BY, LIKE, BETWEEN)
TAREFA 1 */
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
 produto_id,data_pedido
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

/*AGREGAÇAO E AGRUPAMENTO (COUNT, SUM, AVG, GROUP BY)
TAREFA 1*/
SELECT 
categoria,
    AVG(preco)
FROM
    produto
   GROUP BY categoria;
  
  /*tarefa 2*/
   SELECT 
	cliente_id,
    COUNT(id) as 'Qtd de pedidos'
FROM
    pedido
GROUP BY cliente_id;
 
 /* Tarefa 3*/
SELECT 
categoria,
    SUM(estoque) as 'Total em estoque'
FROM
    produto
  GROUP BY categoria;  
      
/* Tarefa 4 */
SELECT 
    id, produto_id, quantidade
FROM
    pedido
WHERE
    quantidade = (SELECT 
            MAX(quantidade)
        FROM
            pedido);

/* Tarefa 5*/
SELECT 
 c.cidade, count(c.nome) AS Numero_Cliente
FROM
cliente c
 GROUP BY c.cidade
 ORDER BY Numero_Cliente DESC;

/* JUNÇOES (INNER JOIN)
TAREFA 1*/
SELECT 
    p.nome AS produto_nome,
    f.nome AS fornecedor_nome
FROM
    produto p
        JOIN
    fornecedor f ON p.fornecedor_id = f.id
 ORDER BY p.fornecedor.nome ASC; 
 
 /*TAREFA 2*/
  SELECT 
    c.nome AS 'cliente nome',
    p.nome AS 'produto nome',
    ped.quantidade,
    ped.data_pedido
FROM 
    pedido ped
JOIN 
    cliente c ON ped.cliente_id = c.id
JOIN 
    produto p ON ped.produto_id = p.id
ORDER BY 
    ped.data_pedido;
 
 /* TAREFA 3 */
 SELECT 
    c.nome AS cliente_nome,
    p.nome AS produto_nome,
    f.nome AS fornecedor_nome
 
FROM 
    pedido ped
JOIN 
    produto p ON ped.produto_id = p.id
JOIN 
    fornecedor f ON p.fornecedor_id = f.id
JOIN 
    cliente c ON ped.cliente_id = c.id;
    
  /* TAREFA 4 */
    SELECT 
    c.nome AS cliente_nome,
    SUM(ped.quantidade) AS total_produtos_comprados
FROM 
    pedido ped
JOIN 
    cliente c ON ped.cliente_id = c.id
GROUP BY 
    c.nome
ORDER BY 
    total_produtos_comprados DESC;
    
    
   
   /* SUBCONSULTAS E MODIFICAÇOES DE DADOS
   TAREFA 1 */
SELECT 
    p.nome AS Produto_nome, p.preco, p.categoria
FROM
    produto p
WHERE
    p.preco > (SELECT 
            AVG(preco)
        FROM
            produto pro
        WHERE
            p.categoria = pro.categoria)
ORDER BY p.categoria;   
 

 /* TAREFA 2 */
 UPDATE produto
SET preco = preco * 1.1
WHERE categoria = 'Eletronicos';
 
 
 /* TAREFA 3*/
DELETE from pedido
WHERE id_cliente = (SELECT id_cliente FROM cliente WHERE cidade = 'Curitiba');


 /* TAREFA 4*/
 
 INSERT INTO cliente
(nome,cidade, idade)
VALUES
('Ricardo lopes', 'Porto Alegre', 38);

/* TAREFA 5 */
SELECT 
    id
FROM
    produto
WHERE
    nome = 'notebook Y';
SELECT 
    *
FROM
    cliente
WHERE
    nome = 'Joao silva'
        AND cidade = 'São Paulo';
INSERT INTO pedido(produto_id, quantidade, data_pedido, cliente_id)
VALUES (2, 2, '2024-03-25', (select id from produto where nome = 'notebook Y'),(select id from cliente where nome = 'Joao silva' and  'São paulo'));



/* TAREFA 6 */
 SELECT 
    c.nome
FROM
    cliente c
WHERE
    c.id IN (SELECT 
            p.cliente_id
        FROM
            pedido p
                JOIN
            produto pro ON p.produto_id = pro.id
        WHERE
            pro.categoria = 'Moveis');



 
    
    







