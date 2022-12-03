CREATE TABLE empresa (
id_empresa INT NOT NULL AUTO_INCREMENT,
razon_social VARCHAR (30),
rubro VARCHAR (20),
telefono VARCHAR (15),
domicilio VARCHAR (20),
PRIMARY KEY (id_empresa),
UNIQUE uk_razon_social (razon_social)
)