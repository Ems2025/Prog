USE progsenac;

CREATE TABLE IF NOT EXISTS usuario (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(50) NOT NULL UNIQUE,
    senha VARCHAR(16) NOT NULL
);

SELECT 
    *
FROM
    usuario;
    insert into usuario ( 
    nome,
    email,
    senha
    )
    
    
    values (
    'Emily',
    'Emily@hotmail.com',
    'senha@Lola');
    INSERT INTO usuario (nome, email, senha)
    VALUES
    ('Neymar jr', 'njr@email.com', 'Brun@'),
    ('Maria Madalena', 'mmmadalena@email.com', '123456'),
    ('Pablo Vittar', 'p.vitar@gmail.com', 'senha@forte');
