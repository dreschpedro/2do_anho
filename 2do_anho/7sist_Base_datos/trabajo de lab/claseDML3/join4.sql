select pedidos.idpedido,pedidos.fechapedido,pedidos.importe,clientes.idcliente,clientes.nombrecontacto,clientes.ciudad,clientes.`teléfono`
from pedidos
right join clientes on clientes.idcliente = pedidos.idcliente
/* where clientes.ciudad in("Madrid","Berlín","México D.F.") */
order by pedidos.idpedido