CREATE TABLE prestamo_cliente (
id_prest_cte INT NOT NULL AUTO_INCREMENT,
num_prestamo INT NOT NULL,
cedula_cliente INT NOT NULL,
PRIMARY KEY (id_prest_cte),
FOREIGN KEY fk_num_prestamo (num_prestamo) REFERENCES prestamo (num_prestamo),
FOREIGN KEY fk_ced_cte (cedula_cliente) REFERENCES cliente (cedula_cliente)
)