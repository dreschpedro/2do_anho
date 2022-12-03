CREATE TABLE alumno_materia (
id_alum_materia INT NOT NULL AUTO_INCREMENT,
id_alumno INT NOT NULL,
cod_materia INT NOT NULL,
PRIMARY KEY (id_alum_materia),
UNIQUE uk_id_alumno (id_alumno),
FOREIGN KEY (id_alumno) REFERENCES alumnos (idAlumno),
FOREIGN KEY (cod_materia) REFERENCES materia (cod_materia)
)