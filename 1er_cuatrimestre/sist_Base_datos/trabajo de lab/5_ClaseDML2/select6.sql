select idcliente,país,ciudad,nombrecontacto,códpostal 
from clientes
where (país = 'ALEMANIA') XOR (ciudad = 'Resende')
order by país,ciudad,nombrecontacto;