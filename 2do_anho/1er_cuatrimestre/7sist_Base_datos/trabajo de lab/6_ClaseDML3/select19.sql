select paísdestinatario,SUM(importe) as CantPedidosPorPais
from pedidos
where (idempleado = 4) or (idempleado = 6)
group by paísdestinatario
having paísdestinatario <> "Alemania"