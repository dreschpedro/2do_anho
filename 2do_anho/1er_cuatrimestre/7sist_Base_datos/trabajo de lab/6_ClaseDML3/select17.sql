select paísdestinatario,COUNT(*) as CantPedidosPorPais
from pedidos
group by paísdestinatario desc
/* order by CantPedidosPorPais */