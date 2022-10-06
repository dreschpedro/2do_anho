CREATE TABLE persona (
id_persona INT NOT NULL AUTO_INCREMENT,
dni VARCHAR (9) NOT NULL,
nom_apel VARCHAR (30) NOT NULL,
lic_conducir VARCHAR (10) DEFAULT NULL,
nivel_educ VARCHAR (10) DEFAULT NULL,
domicilio VARCHAR (30) DEFAULT NULL,
telefono VARCHAR (15) DEFAULT NULL,
fecha_nacim VARCHAR (15) DEFAULT NULL,
email VARCHAR (30) DEFAULT NULL,
manejo_office VARCHAR (10) DEFAULT NULL,
PRIMARY KEY (id_persona),
UNIQUE uk_dni (dni),
UNIQUE uk_nom_apel (nom_apel)
)