create database 

 create table asignaturas (
 id_asignatura int IDENTITY (1,1),
 nombre varchar (50),
 CONSTRAINT PK_id_pago PRIMARY KEY (id_asignatura))

 create table carreras (
 id_carrera int IDENTITY (1,1),
 nombre varchar (50),
 titulo varchar(50),
 CONSTRAINT PK_articulos PRIMARY KEY (id_carrera))

 create table detalleCarreras (
 nro_detalle int IDENTITY (1,1),
 anioCursado smalldatetime,
 cuatrimestre varchar (50),
 id_carrera int,
 id_asignatura int 
 CONSTRAINT PK_detalleCarreras PRIMARY KEY (nro_detalle),
 CONSTRAINT FK_carreras_carrera FOREIGN KEY (id_carrera)
 REFERENCES carreras (id_carrera),
 CONSTRAINT FK_carreras_asignatura FOREIGN KEY (id_asignatura)
 REFERENCES asignaturas (id_asignatura)
 )

 INSERT INTO asignaturas (nombre) values ('Programación');
  INSERT INTO asignaturas (nombre) values ('Laboratorio');
   INSERT INTO asignaturas (nombre) values ('Ingles');
    INSERT INTO asignaturas (nombre) values ('Matemática');

	CREATE PROCEDURE SP_CONSULTAR_Asignaturas
AS
BEGIN
	
	SELECT * from asignaturas;
END
