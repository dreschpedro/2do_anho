select COUNT(*) 
from pedidos
where (paísdestinatario = "Alemania") and (importe > 100)