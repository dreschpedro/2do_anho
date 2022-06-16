from pedidos
right join clientes on clientes.idcliente = pedidos.idcliente
/* where clientes.ciudad in("Madrid","Berlín","México D.F.") */
order by pedidos.idpedido