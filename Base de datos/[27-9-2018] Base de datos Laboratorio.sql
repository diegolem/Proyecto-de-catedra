create database Gestordelaboratorio
go

use Gestordelaboratorio
go

create table Clinica
(IDClinica char(6)not null primary key,
TipoClinica varchar(25),
)



CREATE TABLE PACIENTE
(Id_Paciente char(6) not null primary key,
Nombre varchar (50),
Apellido varchar (50),
Direccion varchar(100),
Telefono int,
Email varchar (50),
Fecha_Nacimiento date, 
Sexo varchar(15)
)

Create table Cuadro_Medico
(Alergia varchar (1000),
Tipo_Sangre varchar (1000),
Peso float,
Altura float,
Fk_IdPaciente char(6) not null foreign key (FK_IdPaciente) references Paciente(Id_Paciente)
)

-- aqui no hemos ejecutado

create table Doctor
(
Id_Doctor char (6) not null primary key,
Nombre varchar(50),
Apellido varchar(50),
Direccion varchar(100),
Telefono int,
Dui int,
Rol varchar (30),
Genero varchar (15),
Fk_IDClinica char(6) not null foreign key (Fk_IDClinica) references Clinica(IDClinica)
)






create table Laboratorio
( 
Id_Laboratorio char (6)not null primary key,
Fk_IDClinica char(6) not null foreign key (Fk_IDClinica) references Clinica(IDClinica), 
Descripcion varchar (1000),
Precio float ,
Fk_IdPaciente char(6) not null foreign key (Fk_IdPaciente) references Paciente(ID_Paciente),
Fk_IdDoctor char(6) not null foreign key (Fk_IdDoctor) references Doctor(Id_Doctor)
)

Create table Citas
(Id_Cita char(6) not null primary key,
fecha date,
Descripcion varchar(1000),
Fk_IdPaciente char(6) not null foreign key (Fk_IdPaciente) references Paciente(Id_Paciente),
Fk_IdDoctor char(6) not null foreign key (Fk_IdDoctor) references Doctor(Id_Doctor)
)

create table Consulta
( Id_Consulta char(6)not null primary key,
Fk_Citas char(6) not null foreign key (Fk_Citas) references Citas(Id_Cita),
Tratamiento varchar(1000)
)

create table Dental
(
Id_Dental char(6) not null primary key,
Tratamiento varchar(1000),
Detalle varchar(1000),
Piezas varchar (1000),
Fk_IdClinica char(6) not null foreign key (Fk_IdClinica) references Clinica(IDClinica)
)

Create table Tipo_Estudio
(
IdTipo_Estudio char(6) not null primary key,
Fk_Laboratorio char(6) not null foreign key (Fk_Laboratorio) references Laboratorio(ID_Laboratorio),
Nombre varchar (50))



