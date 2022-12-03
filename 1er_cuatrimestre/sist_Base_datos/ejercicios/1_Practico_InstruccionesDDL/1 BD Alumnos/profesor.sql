CREATE TABLE profesor (
id_profesor INT NOT NULL AUTO_INCREMENT,
dni_profesor INT NOT NULL,
apellido_profesor VARCHAR(15) NOT NULL,
nombres_profesor VARCHAR(30) NOT NULL,
direccion_profesor VARCHAR(50) NOT NULL,
tel_profesor VARCHAR(12) NOT NULL,
PRIMARY KEY (id_profesor),
UNIQUE uk_dni (dni_profesor),
UNIQUE uk_nom_ape (apellido_profesor,nombres_profesor)
)