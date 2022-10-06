SELECT *
FROM pedidos
WHERE (fechapedido BETWEEN '1997-06-01' AND '1997-12-31') 
AND (importe > 100)
ORDER BY importe 