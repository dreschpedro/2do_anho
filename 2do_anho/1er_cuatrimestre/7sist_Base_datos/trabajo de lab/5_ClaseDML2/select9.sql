select * 
from pedidos
where (fechapedido >= '1997-01-01') and (fechapedido <= '1997-12-31')
order by fechapedido
