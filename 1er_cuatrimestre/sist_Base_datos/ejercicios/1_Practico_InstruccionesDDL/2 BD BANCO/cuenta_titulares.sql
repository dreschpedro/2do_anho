CREATE TABLE cuenta_titulares (
id_cuenta_titular INT NOT NULL AUTO_INCREMENT,
cedula_cliente INT NOT NULL,
num_cuenta INT NOT NULL,
PRIMARY KEY (id_cuenta_titular),
FOREIGN KEY fk_cedula_cte (cedula_cliente) REFERENCES cliente (cedula_cliente),
FOREIGN KEY fk_num_cta (num_cuenta) REFERENCES cuenta (num_cuenta)
)