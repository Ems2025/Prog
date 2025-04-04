
/*exercicio 1, selecionando dados*/
CREATE TABLE IF NOT EXISTS exercicio (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    idade INT NULL,
    departamento varchar(255),
    salario int null 
    
);

INSERT INTO exercicio(nome, idade, departamento, salario)  
VALUES ('Joao', '30', 'RH','50000'),
('Sarah', '28', 'TI','60000'),
('Miguel', '35', 'vendas', '55000'),
('Ana', '27', 'TI', '62000');

/*Tarefa 1 */
select 
*
FROM exercicio
where departamento = 'TI';

/* Tarefa 2 */
select 
*
FROM exercicio
where salario > '55000';

/* Tarefa 3 */
SELECT 
    *
FROM
    exercicio
ORDER BY idade DESC;

/* Exercicio 2, Tarefa 1*/
SELECT 
    *
FROM
    exercicio
where idade >= 28 and idade <= 35;

/* Exercicio 2, Tarefa 2 */
SELECT 
    *
FROM
    exercicio
 where lower (nome) like 'm%';

/* Exercicio 2, tarefa 3 */
SELECT 
    *
FROM
    exercicio
WHERE
    departamento != 'RH';
    
    
    
/* Exercicio 3, tarefa 1 */
SELECT 
    COUNT(departamento)
FROM
    exercicio;
    
/*Exercicio 3, tarefa 2 */
SELECT AVG(salario) AS salario_medio
FROM exercicio
WHERE departamento = 'TI';
 
 /* Exercicio 3, tarefa 3 */
SELECT sum(salario) AS total_salarios
FROM exercicio
WHERE departamento = 'vendas';

/* Exercicio 4, tabela departamento e empregado*/
CREATE TABLE IF NOT EXISTS Departamento(
id INT PRIMARY KEY AUTO_INCREMENT,
 nome VARCHAR(100) NOT NULL);
 
/* insert tabela departamento*/
INSERT INTO Departamento (nome)
values ('RH'), ('TI'), ('Vendas');

CREATE TABLE IF NOT EXISTS Empregado (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
  id_departamento INT NOT NULL,
    FOREIGN KEY (departamento_id)
        REFERENCES Departamento (id)
);
/* insert tabela empregado*/
insert into Empregado( nome, id_departamento)
Values ('Joao', '1'), ('Sarah', '2'), ('Miguel', '3'),('Ana','2');

/*Exercicio 4, tarefa 1*/
SELECT 
    e.nome as empregado, D.nome as departamento
FROM
    Empregado
        JOIN
    departamento d ON e.id_departamento = d.id; 

SELECT 
    d.nome AS departamento, e.nome AS Empregado
FROM
    departamento d
        LEFT JOIN
    exercicio e ON d.id = e.id_departamento;







/*Exercicio 5, tarefa 1 */
SELECT * 
FROM exercicio
WHERE salario > (SELECT AVG(salario) FROM exercicio);

/*Exercicio 5, tarefa 2*/
SELECT 
    e.nome AS Empregado, d.nome AS Departamento
FROM
    exercicio e
        INNER JOIN
    departamento d ON e.id_departamento = d.id
WHERE
id_departamento = (SELECT 
            e.id_departamento
        FROM
            exercicio e
        WHERE
            nome = 'Sarah'); 

/*Exercicio 6, tarefa 1*/
INSERT INTO Empregado(
nome, idade, id_departamento, salario)
VALUES
('Tomás','48','3','58000')
;

/*Exercicio 6, tarefa 2 */
UPDATE Empregado 
SET 
    Empregado.salario = Empregado.salario + (Empregado.salario * 1.05)
WHERE
    Empregado.id_departamento = (SELECT 
            departamento.id
        FROM
         Departamento
        WHERE
            Departamento.nome = 'TI');
            
/*Exercicio 6, tarefa 3 */

DELETE FROM Empregado 
WHERE id = (SELECT id FROM Empregado WHERE idade > 40);
























