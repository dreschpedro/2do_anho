select idcliente,país,ciudad,nombrecontacto,códpostal 
from clientes
where (país = 'ALEMANIA') OR (país = 'BRASIL')
order by país,ciudad,nombrecontacto;