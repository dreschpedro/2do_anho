-- LISTAR LA CANTIDAD DE PEDIDOS POR CATEGORIA DE PRODUCTOS

SELECT categorías.`idcategoría` AS categoria, COUNT(*) AS pedidos_por_cat
FROM pedidos
JOIN detalles_de_pedidos ON pedidos.idpedido = detalles_de_pedidos.idpedido
JOIN productos ON productos.idproducto = detalles_de_pedidos.idproducto
JOIN categorías ON categorías.`idcategoría` = productos.`idcategoría`
GROUP BY categorías.`idcategoría`