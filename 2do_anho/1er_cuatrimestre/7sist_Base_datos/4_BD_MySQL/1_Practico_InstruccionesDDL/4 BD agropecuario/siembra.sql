CREATE TABLE siembra (
id_siembra INT NOT NULL AUTO_INCREMENT,
periodo VARCHAR (10) DEFAULT NULL,
tipo_siembra VARCHAR (15) DEFAULT NULL,
rinde_ha INT DEFAULT NULL,
fecha_cosecha VARCHAR (10) DEFAULT NULL,
fecha_siembra VARCHAR (10) DEFAULT NULL,
id_parcela INT NOT NULL,
PRIMARY KEY (id_siembra),
FOREIGN KEY fk_id_parcela_s (id_parcela) REFERENCES parcela (id_parcela)
)