CREATE TABLE postulante (
id_postulante INT NOT NULL AUTO_INCREMENT,
remun_pretend VARCHAR (15),
experiencia VARCHAR (30),
rango_edad VARCHAR (10),
id_persona INT NOT NULL,
id_puesto INT NOT NULL,
PRIMARY KEY (id_postulante),
FOREIGN KEY fk_id_persona_postul (id_persona) REFERENCES persona (id_persona),
FOREIGN KEY fk_id_puesto_postul (id_puesto) REFERENCES puesto (id_puesto)
)