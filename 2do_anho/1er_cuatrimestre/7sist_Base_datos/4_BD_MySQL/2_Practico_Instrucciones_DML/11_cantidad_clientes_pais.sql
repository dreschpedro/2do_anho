SELECT país, COUNT(*) AS pais_cliente
FROM clientes
GROUP BY país