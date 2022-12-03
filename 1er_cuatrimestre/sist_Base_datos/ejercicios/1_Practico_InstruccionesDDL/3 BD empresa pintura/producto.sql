CREATE TABLE producto (
id_producto INT NOT NULL AUTO_INCREMENT,
nombre_prod VARCHAR (30) NOT NULL,
stock INT DEFAULT NULL,
precio_venta INT DEFAULT NULL,
stock_seguridad INT DEFAULT NULL,
id_categoria INT NOT NULL,
id_envase INT NOT NULL,
PRIMARY KEY (id_producto),
UNIQUE uk_nombre_prod (nombre_prod),
FOREIGN KEY fk_id_categoria (id_categoria) REFERENCES categoria (id_categoria),
FOREIGN KEY fk_id_envase (id_envase) REFERENCES envase (id_envase)
)