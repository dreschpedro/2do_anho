CREATE TABLE titulo (
id_titulo INT NOT NULL AUTO_INCREMENT,
titutlo VARCHAR (20),
habilita VARCHAR (15),
id_persona INT NOT NULL,
PRIMARY KEY (id_titulo),
FOREIGN KEY fk_id_persona_tit (id_persona) REFERENCES persona (id_persona)
)