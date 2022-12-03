CREATE TABLE categoria (
id_categoria INT NOT NULL AUTO_INCREMENT,
nombre_cat VARCHAR (15) NOT NULL,
PRIMARY KEY (id_categoria),
UNIQUE uk_nombre_cat (nombre_cat)
)