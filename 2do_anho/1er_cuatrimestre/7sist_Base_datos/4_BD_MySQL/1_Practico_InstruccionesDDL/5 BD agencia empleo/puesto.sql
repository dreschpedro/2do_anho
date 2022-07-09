CREATE TABLE puesto (
id_puesto INT NOT NULL AUTO_INCREMENT,
puesto VARCHAR (20),
requisitos VARCHAR (100),
id_empresa INT NOT NULL,
PRIMARY KEY (id_puesto),
FOREIGN KEY fk_id_empresa_puesto (id_empresa) REFERENCES empresa (id_empresa)
)