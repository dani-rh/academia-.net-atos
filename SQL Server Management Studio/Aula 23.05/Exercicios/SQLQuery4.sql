USE [AulaAtos]
GO
/****** Object:  Trigger [dbo].[terceiratrigger]    Script Date: 5/23/2023 4:55:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER trigger [dbo].[terceiratrigger]
on [dbo].[java]
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