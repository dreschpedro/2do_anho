-- LISTAR EL IMPORTE TOTAL DE PEDIDOS DE CLIENTES POR CADA CIUDAD
SELECT clientes.ciudad AS cuidad, ROUND(SUM(pedidos.importe), 2)  AS importe
FROM pedidos
JOIN clientes ON clientes.idcliente = pedidos.idcliente
GROUP BY clientes.ciudad