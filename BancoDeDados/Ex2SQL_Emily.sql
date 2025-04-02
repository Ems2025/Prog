

CREATE TABLE IF NOT EXISTS exercicio2 (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    idade INT NULL,
    cidade VARCHAR(255),
    saldo INT NULL
);

INSERT INTO exercicio2(nome, idade,cidade,saldo)
VALUES ('Carlos','45','Sao Paulo',2500.00),
('Mariana',32, 'Rio de Janeiro', 3200.50),
('Pedro', 27, 'Belo Horizonte', 1500.75),
('Fernanda', 38, 'Curitiba', 4200.00);

/*Exercicio1, tarefa 1*/
SELECT 
    *
FROM
    exercicio2
WHERE
    cidade = 'Rio de Janeiro';
    
/* Exercicio 1, tarefa 2 */
SELECT 
    *
FROM
    exercicio2
WHERE
    saldo > 2.000;

SELECT 
    *
FROM
    exercicio2
ORDER BY saldo DESC;

/*Exercicio 1, tarefa 3*/
SELECT 
    *
FROM
    exercicio2
WHERE
    idade > 30 AND idade <= 45;

/* Exercico 2,tarefa 1*/
SELECT 
    *
FROM
    exercicio2
WHERE
    idade >= 25 AND idade <= 40;

/* Exercicio 2, tarefa 2*/
SELECT 
    *
FROM
    exercicio2
WHERE
    LOWER(nome) LIKE 'F%';
     
/*Exercicio 2, tarefa 3*/
SELECT 
    *
FROM
    exercicio2
WHERE
    cidade != 'Sao Paulo';
    
/*Exercicio 3 */
CREATE TABLE IF NOT EXISTS pedido1 (
    id INT PRIMARY KEY AUTO_INCREMENT,
    cliente_id INT NOT NULL,
    valor INT NOT NULL,
    data_pedido DATETIME NOT NULL,
    FOREIGN KEY (Cliente_id)
        REFERENCES exercicio2 (id)
);
 
 
INSERT INTO pedido1(cliente_id, valor,data_pedido)
VALUES (1,500.00,'2024-03-10'),
('2',1200.00,'2024-03-12'),
('3', 300.50, '2024-03-15'),
('1', 800.00, '2024-03-18');

/* Exercicio 3, tarefa 1 */
SELECT 
    SUM(valor) AS 'Total_pedidos'
FROM
    pedido1;

/* Exercicio 3, tarefa 2*/
SELECT 
    AVG(valor) AS 'Valor_Medio'
FROM
    pedido1;

/* Exercicio 3, tarefa 3*/
SELECT 
    e.id AS 'cliente_id',
    e.nome AS 'nome_cliente',
    SUM(p.valor) AS 'total_gasto'
FROM
    pedido1 p
        JOIN
    exercicio2 e ON p.cliente_id = e.id
GROUP BY e.id , e.nome;

/*Exercicio 4, tarefa 1*/
SELECT 
    p.id AS 'cliente_id', e.nome AS 'nome_cliente'
FROM
    pedido1 p
        JOIN
    exercicio2 e ON p.cliente_id = e.id;

/*Exercicio 5*, tarefa1*/
SELECT 
    e.nome, p.valor
FROM
    pedido1 p
        INNER JOIN
    exercicio2 e ON p.cliente_id = e.id
WHERE
    p.valor > (SELECT 
            AVG(valor)
        FROM
            pedido1);


/*Exercicio 5, tarefa2*/
SELECT 
    e.nome, p.valor
FROM
    exercicio2 e
        JOIN
    pedido1 p ON e.id = p.cliente_id
WHERE
    valor > 1000;

            
/*Exercicio 6, tarefa 1*/
 INSERT INTO Exercicio2 (nome, idade, cidade, saldo)
 VALUES ('Rafael', 27 , 'Porto Alegre', 790.00);
 
/*Exercicio 6, tarefa 2*/
UPDATE exercicio2 
SET 
    saldo = saldo * 1.10;
 
 /*Exercicio 6 tarefa 3*/ 
DELETE FROM pedido1 
WHERE
    valor < 500;

SELECT 
    *
FROM
    pedido1;




		
            


            

            
            
            




