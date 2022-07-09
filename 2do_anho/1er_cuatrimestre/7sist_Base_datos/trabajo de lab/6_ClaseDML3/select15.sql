select MAX(importe) as ImporteMaximoDeBrasil
from pedidos
where (paísdestinatario = "Brasil")