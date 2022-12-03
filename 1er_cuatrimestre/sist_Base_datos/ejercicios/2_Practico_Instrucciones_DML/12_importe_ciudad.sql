SELECT ciudaddestinatario, ROUND(SUM(importe), 2) AS importe_cuidad
FROM pedidos
GROUP BY ciudaddestinatario