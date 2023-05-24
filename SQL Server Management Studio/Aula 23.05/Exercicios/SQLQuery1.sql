create table java
(
    professor varchar(20) null
)
create table net
(
    professor varchar(20) null
)

insert into net 
values ('Fabrício'),('Ricardo'),('Alexandre')

insert into java 
values ('Fabrício'),('Lucas'),('Deivison')


--inner join 
select * from java
inner join net
on java.professor = net.professor

 

--left join
select * from java
left join net
on java.professor = net.professor

 

--left join exclusivo
select * from java
left join net
on java.professor = net.professor
where net.professor is null

 

--right join
select * from java
right join net
on java.professor = net.professor

 

--right join exclusivo
select * from java
right join net
on java.professor = net.professor
where java.professor is null

 

-- outer join
select * from java
full outer join net
on java.professor = net.professor

 

-- outer join excluivo
select * from java
full outer join net
on java.professor = net.professor
where java.professor is null
    or net.professor is null


--Parte 2 - aula 23/05
create table log 
(
    id integer not null primary key identity,
    acao varchar(10) not null,
    descricao varchar(100),
    quando datetime not null
)

select * from java
select * from log
select * from net

drop trigger primeiratrigger
create trigger primeiratrigger
on java
AFTER DELETE -- ESSA TRIGGER QUE ESTÁ NA TABELA JAVA É EXECUTADA ANTES OU DEPOIS DE UM DELETE/CREATE
as --REGRA
BEGIN -- AQUI COMEÇA A AÇÃO, APÓS A EXECUÇÃO DO DELETE ELE FAZ O QUE TIVER AQUI 
	INSERT INTO LOG VALUES('Exclusão','Um professor de java foi excluído',GETDATE())
END

delete from java where professor = 'Lucas'

------------
drop trigger segundatrigger
create trigger segundatrigger
on java
after insert
as 
begin
    insert into log values ('Inserção', 
        'Add prof java', GETDATE());
    print('Dados Inseridos');
end

insert into java values ('Lucas')
-------------

delete from java where professor = 'Fabrício'

create trigger terceiratrigger
on java
after insert
as
begin
	declare @contagem int --@ é uma variável
	select @contagem = (select count(professor) from java)

	PRINT('Quantidade de professores: ' + CONVERT(varchar(10), @contagem));

	IF @contagem < 3
		begin
			insert into log values ('Inserção', 'Add prof java', GETDATE());
			print('Inserido com sucesso')
		end
	ELSE
		begin
		ROLLBACK;--voltar ação para trás
		insert into log values ('Inserção', 'Tentativa de inserção mal sucedida', GETDATE());
			RAISERROR('INVALIDO', 14,1);
			RETURN;
		end
end

-------------
drop trigger quartatrigger

create trigger quartatrigger
on java
after update
as
begin
	declare @anterior varchar(20)
	declare @novo varchar(20)

	select @anterior = (select deleted.professor from deleted)
	select @novo = (select inserted.professor from inserted)
	--tabela temporária para guardar registros deletados

	if (ROWCOUNT_BIG() = 0) --ganho de processamento para caso não afete nenhuma linha
		return;

	if @anterior = @novo
		begin
			raiserror('Sem alterações',14,1);
			rollback transaction;
			insert into log values ('Update', 'Tentativa de update mal sucedida', GETDATE());
		end
	else
		begin
			insert into log values ('Update', 'Alteração do prof, de '+@anterior + ' para o '+@novo, GETDATE());
		end
end

select * from java
select * from log

update java set professor = 'Fabrício' where professor = 'Lucas'

 



