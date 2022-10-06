CREATE TABLE alumnos (
idAlumno INT AUTO_INCREMENT,
dni VARCHAR(8) NOT NULL,
apellido VARCHAR(20) NOT NULL,
nombres VARCHAR(30) NOT NULL,
direccion VARCHAR(50) NOT NULL,
PRIMARY KEY (idAlumno),
UNIQUE uk_dni (dni),
UNIQUE uk_nomApe (apellido, nombres)
)