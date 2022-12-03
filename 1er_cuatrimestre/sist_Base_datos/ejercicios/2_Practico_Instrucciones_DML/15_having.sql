SELECT ciudaddestinatario, ROUND(SUM(importe), 2) AS importe_total
FROM pedidos
WHERE importe > 30
GROUP BY ciudaddestinatario
HAVING importe_total < 500