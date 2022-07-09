select SUM(importe) as TotalImportes
from pedidos
where (paísdestinatario = "Alemania") /* and (importe > 100) */