CREATE TABLE pago (
num_pago INT NOT NULL AUTO_INCREMENT,
num_prestamo INT NOT NULL,
importe INT NOT NULL,
fecha_pago VARCHAR(10) NOT NULL,
PRIMARY kEY (num_pago),
FOREIGN KEY fk_num_prest (num_prestamo) REFERENCES prestamo (num_prestamo)
)