CREATE TABLE empleado(
cod_empleado INT NOT NULL AUTO_INCREMENT,
fecha_vinculo VARCHAR(8) NOT NULL,
antiguedad INT NOT NULL,
cod_sucursal INT NOT NULL,
PRIMARY KEY (cod_empleado),
FOREIGN KEY fk_cod_sucursal_e (cod_sucursal) REFERENCES sucursal (cod_sucursal)
)