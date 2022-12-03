CREATE TABLE prestamo (
num_prestamo INT NOT NULL AUTO_INCREMENT,
cod_sucursal INT NOT NULL,
importe FLOAT NOT NULL,
PRIMARY KEY (num_prestamo),
FOREIGN KEY fk_cod_sucursal (cod_sucursal) REFERENCES sucursal (cod_sucursal)
)