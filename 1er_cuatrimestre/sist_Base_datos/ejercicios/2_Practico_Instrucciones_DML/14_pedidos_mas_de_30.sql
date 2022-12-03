SELECT ciudaddestinatario, COUNT(*) AS importe_total
FROM pedidos
WHERE (importe > 30)
GROUP BY ciudaddestinatario