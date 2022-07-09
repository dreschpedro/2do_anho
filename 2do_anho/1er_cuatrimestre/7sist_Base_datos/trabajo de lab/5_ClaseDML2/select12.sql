SELECT idproducto,nombreproducto,preciounidad,(preciounidad * 1.21) as PrecioConIva,unidadesenexistencia,
(preciounidad * unidadesenexistencia) as PrecioTotal 
from productos
where (unidadesenexistencia > 0)
order by PrecioTotal desc