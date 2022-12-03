CREATE TABLE idioma (
id_idioma INT NOT NULL AUTO_INCREMENT,
idioma VARCHAR (15),
nivel VARCHAR (15),
id_persona INT NOT NULL,
PRIMARY KEY (id_idioma),
FOREIGN KEY fk_id_persona_idioma (id_persona) REFERENCES persona (id_persona)
)