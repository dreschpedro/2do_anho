create table alumnos (
idAlumno int AUTO_INCREMENT,
dni varchar(8) NOT NULL,
apellido varchar (20) NOT NULL,
nombres varchar(30) NOT NULL,
direccion varchar (50) NOT NULL,
PRIMARY (idAlumno),
UNIQUE uk_dni(dni)
)