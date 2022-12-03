select * 
from clientes
where (nombrecontacto like 'a%n%') and (ciudad  in ('Madrid','LONDRES'))
order by nombrecontacto