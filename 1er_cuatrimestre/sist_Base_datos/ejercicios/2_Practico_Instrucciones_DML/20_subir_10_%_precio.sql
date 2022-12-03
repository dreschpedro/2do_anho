-- INCREMENTAR UN 10% LOS PRECIOS DE LOS PRODUCTOS DE LA CATEGORÍA BEBIDAS

UPDATE productos
SET preciounidad =  (preciounidad * 1.10)
WHERE idcategoría = 1