-- LISTADO DEL TOTAL DE PEDIDOS AGRUPADOS POR LA CIUDAD DE LOS VENDEDORES

SELECT empleados.ciudad AS cuidad, SUM(pedidos.idpedido) AS cantidad_pedidos
FROM pedidos
JOIN empleados ON empleados.idempleado = pedidos.idempleado
GROUP BY empleados.ciudad