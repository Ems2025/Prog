SELECT
*
FROM
tabeladedados;
CREATE TABLE IF NOT EXISTS tabeladedados
( id INT PRIMARY KEY AUTO_INCREMENT,
 nome varchar(255) not null,
 sobrenome varchar (255) not null,
 apelido varchar (255) not null,
 professor varchar (255) not null,
 escolaridade varchar (255) not null
 
 );
 
 insert into tabeladedados ( nome,  sobrenome, apelido,  professor, escolaridae)
 
 Values ('Emily', 'Santos', 'Ems', 'Rafael', 'ensino medio'),
  ('Aline', 'Santos', 'li', 'Joana', 'graduada em historia'),
  ('Lucas', 'Oliveira','Lu', 'Marcos', 'ens.medio'),
  ('Michael', 'Carvalho','Prof. Ricardo Oliveira','Ensino Médio Incompleto'),
  ('Camila','Camilinha',' Profa. Ana Beatriz,','Escolaridade: Ensino Fundamental Completo'),
  ('João ','JH','Prof. Carlos Eduardo','Pós-graduação em Engenharia'),
  ('Beatriz ',' Bia','Profa. Fernanda ','Ensino Superior Completo'),
  ('Gabriel ','Biel ','Prof. André ','Ensino Fundamental Incompleto'),
  ('Eduardo',' Dudu','Prof. João ','Ensino Médio Completo'),
  ('Letícia','Lê ','Profa. Roberta Nogueira ','Escolaridade: Ensino Superior Incompleto');
  
 
    

