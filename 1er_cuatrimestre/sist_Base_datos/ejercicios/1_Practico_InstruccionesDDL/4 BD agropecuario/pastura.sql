CREATE TABLE pastura (
id_pastura INT NOT NULL AUTO_INCREMENT,
periodo VARCHAR (10) DEFAULT NULL,
tipo_ganado VARCHAR (15) DEFAULT NULL,
cantidad INT DEFAULT NULL,
id_parcela INT NOT NULL,
PRIMARY KEY (id_pastura),
FOREIGN KEY fk_id_parcela_pas (id_parcela) REFERENCES parcela (id_parcela)
)