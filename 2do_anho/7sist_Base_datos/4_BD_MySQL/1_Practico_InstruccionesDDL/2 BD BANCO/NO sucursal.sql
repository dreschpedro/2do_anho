CREATE TABLE sucursal(
cod_sucursal INT NOT NULL AUTO_INCREMENT,
cuidad VARCHAR(30) NOT NULL,
PRIMARY KEY (cod_sucursal),
FOREIGN KEY fk_cSuc_em (cod_sucursal) REFERENCES empleado (cod_sucursal),
FOREIGN KEY fk_cSuc_pr (cod_sucursal) REFERENCES prestamo (cod_sucursal)
)