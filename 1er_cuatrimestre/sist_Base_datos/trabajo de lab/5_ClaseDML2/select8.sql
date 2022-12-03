SELECT *
FROM productos
where (preciounidad between 20 and 100) and (idcategoría in (4,5)) and (idproveedor between 5 and 15)
order by preciounidad