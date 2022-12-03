CREATE TABLE precipitaciones (
id_precipitaciones INT NOT NULL AUTO_INCREMENT,
mes VARCHAR (12) DEFAULT NULL,
mm_caidos INT DEFAULT NULL,
id_parcela INT NOT NULL,
PRIMARY KEY (id_precipitaciones),
FOREIGN KEY fk_id_parcela_p (id_parcela) REFERENCES parcela (id_parcela)
)