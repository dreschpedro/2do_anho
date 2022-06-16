/*LISTAR LA CANTIDAD DE PEDIDOS POR CATEGORIA DE PRODUCTOS*/
SELECT categorías.`idcategoría`, categorías.`nombrecategoría`, COUNT(*) AS pedidosCategorias
FROM pedidos
JOIN pedidos ON pedidos.idpedido = 