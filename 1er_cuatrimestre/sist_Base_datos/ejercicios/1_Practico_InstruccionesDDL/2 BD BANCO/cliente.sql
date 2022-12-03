CREATE TABLE cliente (
cedula_cliente INT NOT NULL AUTO_INCREMENT,
apellido_cliente VARCHAR (10) NOT NULL,
nombre_cliente VARCHAR(20) NOT NULL,
email_1_cliente VARCHAR(30) NOT NULL,
email_2_cliente VARCHAR(30),
celular_cliente VARCHAR(12) NOT NULL,
PRIMARY KEY (cedula_cliente),
UNIQUE uk_nom_ape (apellido_cliente, nombre_cliente),
UNIQUE uk_email_1 (email_1_cliente)
)