CREATE TABLE empleo (
id_empleo INT NOT NULL AUTO_INCREMENT,
duracion_contrato VARCHAR (10),
fecha_contrato VARCHAR (15),
tipo_contrto VARCHAR (15),
id_persona INT NOT NULL,
id_empresa INT NOT NULL,
PRIMARY KEY (id_empleo),
FOREIGN KEY fk_id_empresa_empleo (id_empresa) REFERENCES empresa (id_empresa),
FOREIGN KEY fk_id_persona_empleo (id_persona) REFERENCES persona (id_persona)
)