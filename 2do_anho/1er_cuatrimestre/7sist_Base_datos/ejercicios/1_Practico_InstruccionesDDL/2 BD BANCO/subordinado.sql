CREATE TABLE subordinados (
id_subordinado INT NOT NULL AUTO_INCREMENT,
cod_empleado INT NOT NULL,
nom_ape VARCHAR (30) NOT NULL,
PRIMARY KEY (id_subordinado),
UNIQUE uk_nomApe (nom_ape),
FOREIGN KEY fk_cod_empleado (cod_empleado) REFERENCES empleado (cod_empleado)
)