/*LISTAR PEDIDOS DE LOS CLIENTES DE “ALEMANIA”*/
SELECT pedidos.idpedido, pedidos.destinatario, 
clientes.idcliente, clientes.nombrecontacto, clientes.`país`
FROM pedidos
JOIN clientes ON clientes.idcliente = pedidos.idcliente
WHERE país IN ("Alemania")