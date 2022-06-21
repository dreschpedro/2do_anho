-- LISTADO DEL PROMEDIO DE PEDIDOS POR CATEGORIA DE PRODUCTO

SELECT categorías.`idcategoría` AS categoria, AVG(pedidos.idpedido) AS pedidos_por_cat
FROM pedidos
JOIN detalles_de_pedidos ON pedidos.idpedido = detalles_de_pedidos.idpedido
JOIN productos ON productos.idproducto = detalles_de_pedidos.idproducto
JOIN categorías ON categorías.`idcategoría` = productos.`idcategoría`
GROUP BY categorías.`idcategoría`