CREATE TABLE materia (
cod_materia INT NOT NULL AUTO_INCREMENT,
nom_materia VARCHAR (20) NOT NULL,
id_profesor INT NOT NULL,
PRIMARY KEY (cod_materia),
UNIQUE uk_nom_materia (nom_materia),
FOREIGN KEY (id_profesor) REFERENCES profesor (id_profesor)
) 