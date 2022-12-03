SELECT *
FROM productos
WHERE (unidadesenexistencia > 0)
AND (preciounidad > 22)
ORDER BY unidadesenexistencia