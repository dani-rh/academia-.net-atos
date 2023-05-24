USE [AulaAtos]
GO
/****** Object:  Trigger [dbo].[segundatrigger]    Script Date: 5/23/2023 4:53:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER trigger [dbo].[segundatrigger]
on [dbo].[java]
after insert
as
begin
	insert into log values ('Inserção', 'Add prof java',GETDATE())
	print ('Dados inseridos')
end