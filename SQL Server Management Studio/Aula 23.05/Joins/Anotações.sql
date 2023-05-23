
--SQL JOINS

create table java
(
��� professor varchar(20) null
)

create table net
(
��� professor varchar(20) null
)

insert into net�
values ('Fabr�cio'),('Ricardo'),('Alexandre')

insert into java�
values ('Fabr�cio'),('Lucas'),('Deivison')

select * from net
union
select * from java

--inner join
select * from java
inner join net --traz a informa��o que tem de encontra nos lados A e B
on java.professor = net.professor

--left join
select * from java
left join net --traz a informa��o que tem s� do lado A e exclui os que tem s� no lado B
on java.professor = net.professor

--left join exclusivo --mostra aquilo que aparece exclusicamente do lado A
select * from java
left join net 
on java.professor = net.professor
where net.professor is null

--right join
select * from java
right join net--traz a informa��o que tem s� do lado B e aquilo que � comum entre B e A
on java.professor = net.professor

--right join exclusivo
select * from java
right join net--traz a informa��o que tem exclusivamente do lado B, desconsiderando o que tiver em comum com A
on java.professor = net.professor
where java.professor is null

--outer join
select * from java
full outer join net --traz todas as informa��es do lado A e do lado B
on java.professor = net.professor

--outer join exclusivo
select * from java
full outer join net --traz todas as informa��es do lado A e do lado B, excluindo os valores que os dois lados tem em comum
on java.professor = net.professor
where java.professor is null
	or net.professor is null






