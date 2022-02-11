{
Desarrolle un programa en Pascal que, de acuerdo al importe del sueldo ingresado por el usuario, calcule la Categoría de un Empleado, si:

Hasta $ 1500= Cadete
Más de $ 1500 y hasta $ 3000= Maestranza
Más de $ 3000 y hasta $ 4500= Vendedor
Más de $ 4500 y hasta $ 6000= Encargado
Más de $ 6000= Gerente
}

program sueldo;

var
	monto:LongInt;

begin

	write('Ingrese el monto de su sueldo: ');
	readln(monto);

	case monto of
	-6546..0:write('Tu categoria es: Vago');
	1..1500:write('Tu categoria es: Cadete');
	1501..3000:write('Tu categoria es: Maestranza');
	3001..4500:write('Tu categoria es: Vendedor');
	4501..6000:write('Tu categoria es: Encargado');
	6001..100000:write('Tu categoria es: Gerente');
	end;

	readln();
end.