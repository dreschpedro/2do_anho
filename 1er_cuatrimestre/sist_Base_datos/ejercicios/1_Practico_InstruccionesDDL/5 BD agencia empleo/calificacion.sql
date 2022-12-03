CREATE TABLE calificacion (
id_calificacion INT NOT NULL AUTO_INCREMENT,
calificacion VARCHAR (15),
mes VARCHAR (15),
id_empleo INT NOT NULL,
PRIMARY KEY (id_calificacion),
FOREIGN KEY fk_id_empleo (id_empleo) REFERENCES empleo (id_empleo)
)