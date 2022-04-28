--Creacion de las tablas
create database INSTITUTO_IDIOMAS
go

use INSTITUTO_IDIOMAS
go

create table usuario(
id_user int identity primary key,
nombre_user varchar(20) unique not null,
contrasennia varchar(20) not null
)
go

create table programa(
id_programa int identity primary key,
nombre varchar(20) not null,
descripcion varchar(255) not null
)
go

create table administrativo(
id_admin int identity primary key,
id_programa int foreign key references programa(id_programa) 
on delete no action 
on update no action not null,
nombre varchar(50) not null,
correo varchar(50) not null,
direccion varchar(255) not null,
telefono int not null,
cargo varchar(10) not null,
id_userA int identity  foreign key references usuario(id_user),
departamento varchar(20)
)
go

create table profesor(
id_profesor int identity primary key,
cedula varchar(15) not null,
nombre varchar(50) not null,
correo varchar(50) not null,
direccion varchar(255) not null,
telefono int not null,
sueldo int not null,
idioma varchar(10) not null
id_userP int identity foreign key references usuario(id_user) 
)
go

create table estudiante(
id_estudiante int identity primary key,
cedula varchar(15) not null,
nombre varchar(50) not null,
correo varchar(50) not null,
direccion varchar(55) not null,
telefono int not null
)
go

create table curso(
id_curso int identity primary key,
id_programa int foreign key references programa(id_programa) 
on delete no action 
on update no action not null,
curso varchar(20) not null,
precio int not null,
total_horas int not null
)
go

create table curso_abierto(
id_curso_abierto int identity primary key,
id_curso int foreign key references curso(id_curso) 
on delete no action 
on update no action not null,
id_profesor int foreign key references profesor(id_profesor)
on delete no action 
on update no action not null,
hora_inicio int not null,
hora_fin int not null,
dia varchar(10) not null
)
go

create table asistencia(
id_asistencia int identity primary key,
id_curso_abierto int foreign key references curso_abierto(id_curso_abierto) 
on delete no action 
on update no action not null,
id_estudiante int foreign key references estudiante(id_estudiante)
on delete no action 
on update no action not null,
fecha_asistencia date not null,
presente bit not null
)
go

create table agendar_clase(
id_agenda int identity primary key,
id_estudiante int foreign key references estudiante(id_estudiante)
on delete no action 
on update no action not null,
id_curso_abierto int foreign key references curso_abierto(id_curso_abierto) 
on delete no action 
on update no action not null,
id_profesor int foreign key references profesor(id_profesor)
on delete no action 
on update no action not null,
fecha_leccion date not null,
hora int not null
)
go

create table aulas(
id_aula varchar(5) primary key,
id_programa int foreign key references programa(id_programa) 
on delete no action 
on update no action not null,
capacidad int not null
)
go

create table matricula(
id_matricula int identity primary key,
id_estudiante int foreign key references estudiante(id_estudiante)
on delete no action 
on update no action not null,
id_curso_abierto int foreign key references curso_abierto(id_curso_abierto)
on delete no action 
on update no action not null,
costo int not null,
estado varchar(10) not null
)
go

create table pagos(
id_pago int identity primary key,
id_matricula int foreign key references matricula(id_matricula) 
on delete no action 
on update no action not null,
monto int not null,
monto_restante int not null,
descripcion varchar(255) not null
)
go

create table registro_pagos(
id_registro int identity primary key,
id_pago int foreign key references pagos(id_pago) 
on delete no action 
on update no action not null,
fecha_pago date not null,
medio_pago varchar(20) not null,
cantidad int not null
)
go

create table feriados(
id_feriado int identity primary key,
fecha date unique not null,
motivo varchar(20) not null
)
go

--Creacion de algunos procesos almacenados
CREATE or alter PROCEDURE ELIMINARESTUDIANTE
		@idestudiante int,  
		@msj varchar(50) out 
AS BEGIN
if (not exists(select * from estudiante where id_estudiante = @idestudiante))
	begin
		set @msj='El estudiante no existe'
		return 0
	end
else
	begin
		DELETE from estudiante where id_estudiante = @idestudiante
		set @msj='Estudiante eliminado'
		return 1
	END
end
GO

CREATE or alter PROCEDURE ELIMINARPROF
		@idprof int,  
		@msj varchar(50) out 
AS BEGIN
if (not exists(select * from profesor where id_profesor = @idprof))
	begin
		set @msj='El profesor no existe'
		return 0
	end
else
	begin
		DELETE from profesor where id_profesor = @idprof
		set @msj='Profesor eliminado'
		return 1
	END
end
GO

CREATE or alter PROCEDURE ELIMINARCURSOABIERTO
		@idcursoabierto int,  
		@msj varchar(50) out 
AS BEGIN
if (not exists(select * from curso_abierto where id_curso_abierto = @idcursoabierto))
	begin
		set @msj='El curso no existe'
		return 0
	end
else
	begin
		DELETE from curso_abierto where id_curso_abierto = @idcursoabierto
		set @msj='Curso eliminado'
		return 1
	END
end
GO

CREATE or alter PROCEDURE ELIMINARADMIN
		@idadmin int,  
		@msj varchar(50) out 
AS BEGIN
if (not exists(select * from administrativo where id_admin = @idadmin))
	begin
		set @msj='El administrativo no existe'
		return 0
	end
else
	begin
		DELETE from administrativo where id_admin = @idadmin
		set @msj='Administrativo eliminado'
		return 1
	END
end
GO

create or alter trigger CheckCursoAbierto
on curso_abierto instead of insert
as	
	declare @id_curso_abierto int, @id_curso int, @id_profesor int, @hora_inicio int, @hora_fin int, @dia varchar(10)
	select @id_curso_abierto = id_curso_abierto from inserted
	select @id_curso = id_curso from inserted
	select @id_profesor = id_profesor from inserted
	select @hora_inicio = hora_inicio from inserted
	select @hora_fin = hora_fin from inserted
	select @dia = dia from inserted


	if exists(select dia from curso_abierto where dia = @dia and id_curso = @id_curso)
		begin
			print 'No Abrir dos cursos identicos mas de UNA vez al DIA'
		end
	else
		begin
			insert into curso_abierto
			values
			(@id_curso, @id_profesor, @hora_inicio, @hora_fin, @dia) 
		end
go


-- Insert de utilidad
insert into programa
values
('Inglés', 'Lengua o idioma Inglés'),
('Francés', 'Idioma frances'),
('Alemán', 'Gran idioma junto a su pais'),
('Mandarín', 'Lenguaje asiativo')
go

insert into curso
values
(1, 'Inglés 1', 80000, 80),
(1, 'Inglés 2', 80000, 80),
(1, 'Inglés 3', 80000, 80),
(1, 'Inglés 4', 80000, 80),
(1, 'Inglés 5', 80000, 80),
(1, 'Inglés 6', 80000, 80),
(1, 'Inglés 7', 80000, 80),
(1, 'Inglés 8', 80000, 80),
(1, 'Inglés 9', 80000, 80),
(1, 'Inglés 10', 80000, 80),
(1, 'Inglés 11', 80000, 80),
(1, 'Inglés 12', 80000, 80),

(2, 'Francés 1', 60000, 100),
(2, 'Francés 2', 60000, 100),
(2, 'Francés 3', 60000, 100),
(2, 'Francés 4', 60000, 100),

(3, 'Alemán 1', 90000, 94),
(3, 'Alemán 2', 90000, 94),
(3, 'Alemán 3', 90000, 94),
(3, 'Alemán 4', 90000, 94),
(3, 'Alemán 5', 90000, 94),
(3, 'Alemán 6', 90000, 94),
(3, 'Alemán 7', 90000, 94),
(3, 'Alemán 8', 90000, 94),
(3, 'Alemán 9', 90000, 94),
(3, 'Alemán 10', 90000, 94),

(4, 'Mandarín 1', 100000, 120),
(4, 'Mandarín 2', 100000, 120),
(4, 'Mandarín 3', 100000, 120),
(4, 'Mandarín 4', 100000, 120),
(4, 'Mandarín 5', 100000, 120),
(4, 'Mandarín 6', 100000, 120),
(4, 'Mandarín 7', 100000, 120),
(4, 'Mandarín 8', 100000, 120),
(4, 'Mandarín 9', 100000, 120),
(4, 'Mandarín 10', 100000, 120),
(4, 'Mandarín 11', 100000, 120),
(4, 'Mandarín 12', 100000, 120),
(4, 'Mandarín 13', 100000, 120),
(4, 'Mandarín 14', 100000, 120)
go



--Procedimiento para ayuda de la matricula
CREATE or alter PROCEDURE CREARMATRICULA
		@idestudiante int, @idcursoabierto int, @estado varchar(10),
		@msj varchar(50) out 
AS BEGIN
if (not exists(select * from matricula where id_estudiante = @idestudiante and estado = 'PENDIENTE'))
	begin
		set @msj='Debe cancelar primero la matricula anterior'
		return 0
	end
else
	begin
		declare @id int, @costoCurso int

		select @costoCurso = (
		select c.precio from curso c inner join curso_abierto ca on ca.id_curso = c.id_curso
		where ca.id_curso_abierto = @idcursoabierto
		)

		insert into matricula
		values(@idestudiante, @idcursoabierto, @costoCurso, @estado)
		select @id = SCOPE_IDENTITY()

		insert into pagos
		values
		(@id, @costoCurso, @costoCurso, 'Matricula Nueva')

		set @msj='Matricula creada'
		return 1
	END
end
GO