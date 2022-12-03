select idcliente,país,ciudad,nombrecontacto,códpostal 
from clientes
where país not in ('ALEMANIA','BRASIL','ARGENTINA')
order by país,ciudad,nombrecontacto;