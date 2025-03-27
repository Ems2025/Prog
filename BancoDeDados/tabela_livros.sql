CREATE TABLE livro (
    id INT PRIMARY KEY AUTO_INCREMENT,
    titulo VARCHAR(100) NOT NULL,
    data_puplicacao DATETIME NOT NULL,
    numero_pagina INT NULL,
    preco DECIMAL (10,2)NULL,
    genero VARCHAR(30) NOT NULL,
    editora VARCHAR(50) NOT NULL,
    isbn VARCHAR(17) NOT NULL UNIQUE,
    autor VARCHAR(100) NOT NULL
);
 
 INSERT INTO livro (id,titulo, data_publicacao,preco, genero, editora, autor)
 VALUES (
 'titulo',
 '1998-08-31',
 87.99,
 '978-3-16-148410-1',
 'tecnologia', 
 'mundo',
 'Arnold'
 );

INSERT INTO livro ( titulo, data_publicacao, preco, isbn, genero, editora, autor )
VALUES (
'Dom Quixote'
'1605/01/16'

' 49,90'
' 978-0142437230'
'Romance Clássico'
'Companhia das Letras'
'Miguel de Cervantes'
);
INSERT INTO livro ( titulo, data_publicacao, preco, isbn, genero, editora, autor)
VALUES (
'O Senhor dos Anéis'
'1954'
' 129,90'
'Fantasia'
'HarperCollins Brasil'
'J.R.R. Tolkien'
);
INSERT INTO livro ( titulo, data_publicacao, preco, isbn, genero, editora, autor)
VALUES (
' Orgulho e Preconceito'
'1813'
'34,90'
' 978-8563560556'
' Romance '
' Penguin Companhia'
'Jane Austen'
);
