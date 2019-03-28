create table Persona (
	DNI varchar (8),
    nombre varchar(45),
    apellido varchar(45),
    fechaDeNacimiento date,
    primary key (DNI)
);
create table Policia (
	idPolicia int not null,
    pistola bool
);
alter table Policia 
	add primary key (idPolicia)

create table Vehiculo (	
	placa varchar (9),
    marca varchar (40),
    ejes int,
    primary key (placa)
);

select * from Vehiculo;

select idPolicia from Policia;

insert into Vehiculo values (
	'A8C-098', 'Audi', null);
    
insert into Vehiculo (placa) values ('I8C-928');

update Vehiculo set marca='Ram',ejes=4 
where placa = 'I8C-928';

update Vehiculo set ejes=3
where placa = 'A8C-098';

select * from Vehiculo 
where ejes=2;

delete from Vehiculo where placa = 'I8C-928';
