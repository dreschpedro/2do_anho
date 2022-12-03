SELECT idcliente, nombrecontacto, cargocontacto, ciudad, país
FROM clientes
WHERE (cargocontacto LIKE 'Gerente%') AND 
país IN ('Brasil', 'Alemania')