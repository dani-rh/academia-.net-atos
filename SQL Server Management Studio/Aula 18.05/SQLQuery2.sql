
CREATE DATABASE RelacaoLivros;

CREATE TABLE AUTOR
(
	id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	nome VARCHAR (30) NOT NULL,
	nacionalidade VARCHAR (30)
);

CREATE TABLE LIVROAUTOR
(
��� id INTEGER NOT NULL PRIMARY KEY IDENTITY,
��� fk_livro VARCHAR (30) NOT NULL,
��� fk_autor INTEGER NOT NULL,
��� FOREIGN KEY (fk_livro) REFERENCES LIVRO(isbn),
��� FOREIGN KEY(fk_autor) REFERENCES AUTOR(id)
);

DROP TABLE LIVROAUTOR
SELECT * FROM LIVROAUTOR

CREATE TABLE LIVRO
(
��� isbn VARCHAR (30) NOT NULL PRIMARY KEY,
��� titulo VARCHAR (50),
��� anopublicacao INTEGER NOT NULL,
��� fk_editora INTEGER NOT NULL,
	fk_categoria INTEGER NOT NULL
	FOREIGN KEY (fk_editora) REFERENCES EDITORA(id),
��� FOREIGN KEY(fk_categoria) REFERENCES CATEGORIA(id)
);

DROP TABLE LIVRO

CREATE TABLE EDITORA
(
��� id INTEGER NOT NULL PRIMARY KEY IDENTITY,
��	nome VARCHAR (50) NOT NULL,
);

CREATE TABLE CATEGORIA
(
��� id INTEGER NOT NULL PRIMARY KEY IDENTITY,
��	tipo_categoria VARCHAR (50) NOT NULL,
);

--Inserir dados da biblioteca

--Categoria:
SELECT * FROM CATEGORIA

INSERT INTO CATEGORIA
VALUES ('Literatura Juvenil')

INSERT INTO CATEGORIA
VALUES ('Fic��o Cient�fica')

INSERT INTO CATEGORIA
VALUES ('Humor')

--Editora:
SELECT * FROM EDITORA

INSERT INTO EDITORA
VALUES ('Rocco')

INSERT INTO EDITORA
VALUES ('Wmf Martins Fontes')

INSERT INTO EDITORA
VALUES ('Casa da Palavra')

INSERT INTO EDITORA
VALUES ('Belas Letras')

INSERT INTO EDITORA
VALUES ('Matriz')

--Autor
SELECT * FROM AUTOR

INSERT INTO AUTOR
VALUES ('J. K. Rowling', '(Inglaterra)')

UPDATE AUTOR
SET nacionalidade = 'Inglaterra'
WHERE ID = 1

INSERT INTO AUTOR
VALUES ('Clive Staples Lewis', 'Inglaterra')

INSERT INTO AUTOR
VALUES ('Affonso Solano', 'Brasil')

INSERT INTO AUTOR
VALUES ('Marcos Piangers', 'Brasil')

INSERT INTO AUTOR
VALUES ('Ciro Botelho', 'Brasil'),('Bianca M�l','Brasil')

--Livro

SELECT * FROM LIVRO

INSERT INTO LIVRO
VALUES (8532511015,'Harry Potter e A Pedra Filosofal',2000,1,1)

INSERT INTO LIVRO
VALUES (9788578270698,'As Cr�nicas de N�rnia',2009,2,1)

INSERT INTO LIVRO
VALUES (9788577343348,'O Espadachim de Carv�o',2013,3,2)

INSERT INTO LIVRO
VALUES (9788581742458,'O Papai � Pop', 2015,4,3),(9788582302026,'Pior Qu� T� N�o Fica',2015,5,3),(9788577345670,'Garota Desdobr�vel',2015,3,1),(8532512062,'Harry Potter e o prisioneiro de Azkaban', 2000,1,1)

--LivroAutor

SELECT * FROM LIVROAUTOR

INSERT INTO LIVROAUTOR
VALUES (1,1)






--1. Relacione as entidades e seus respectivos atributos para este banco de dados;
--4. Crie o comando SQL para a cria��o do banco de dados BIBLIOTECA;
--5. Crie o comando SQL para a cria��o das tabelas solicitadas;
--6. Crie o comando SQL para inser��o dos referidos dados em todas as tabelas;
--7. Crie uma consulta para relacionar todos os dados dispon�veis de todos os livros existentes na biblioteca en alfab�tica de t�tulo;
--8. Crie uma consulta para relacionar todos os dados dispon�veis de todos os livros existentes na biblioteca en alfab�tica de Autor;
--9. Crie uma consulta para relacionar todos os dados dispon�veis dos livros da categoria de literatura Juvenil e de ano;
--10. Crie uma consulta para relacionar todos os dados dispon�veis dos livros de humor ou fic��o cient�fica con�2000�e�2010.






