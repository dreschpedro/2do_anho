{
Desarrolle un programa en Pascal que, de acuerdo a la cantidad de kilómetros ingresados por el usuario, calcule el valor Acumulativo de un pasaje, si:

Hasta 300 km = $1 x km

Más de 300 y hasta 1000 km= $2 x km

Más de 1000 km= $3 x km
}

program ejercicio11;

var
	A:LongInt;

begin

	write('Ingrese la cantidad de Km: ');
	readln(A);

	case A of
		0..300:write('Tiene que pagar $', A);
		301..1000:write('Tiene que pagar $', (A*2));
		1001..100000:write('Tiene que pagar $', (A*3));
	else
		write('es bastante grande el numero');
	end;
	readln();
end.