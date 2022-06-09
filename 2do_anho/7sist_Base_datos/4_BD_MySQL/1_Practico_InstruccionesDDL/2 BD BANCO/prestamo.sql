CREATE TABLE prestamo (
num_prestamo INT NOT NULL AUTO_INCREMENT,
cod_sucursal INT NOT NULL,
importe INT NOT NULL,
PRIMARY KEY (num_prestamo),
UNIQUE uk_cod_sucursal (cod_sucursal)
)