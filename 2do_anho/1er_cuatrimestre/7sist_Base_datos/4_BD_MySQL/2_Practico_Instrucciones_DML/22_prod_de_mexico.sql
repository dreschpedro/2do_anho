-- LISTAR LA CANTIDAD DE PRODUCTOS PEDIDOS POR LOS CLIENTES DE “MEXICO”

SELECT productos.nombreproducto AS producto, COUNT(*) AS cantidad_prod, clientes.`país` AS pais
FROM productos
JOIN detalles_de_pedidos ON detalles_de_pedidos.idproducto = productos.idproducto
JOIN pedidos ON pedidos.idpedido = detalles_de_pedidos.idpedido
JOIN clientes ON clientes.idcliente = pedidos.idcliente
WHERE clientes.`país` IN ('México')
GROUP BY productos.nombreproducto 
ORDER BY cantidad_prod DESC 