SELECT ciudaddestinatario, ROUND(AVG(importe), 2) AS prom_ciudad
FROM pedidos
GROUP BY ciudaddestinatario