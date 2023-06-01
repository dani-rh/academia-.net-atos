

create login atos with password='Senh@_123';
create user usuario from login atos;
exec sp_addrolemember 'DB_DATAREADER', 'usuario';
exec sp_addrolemember 'DB_DATAWRITER', 'usuario';

insert into pessoas values ('Fabricio', 'Professor')
insert into pessoas values ('Zé', 'Programador')

select * from pessoas

