{Desarrolle un programa en Pascal que determine si un número ingresado por el usuario es Positivo o Negativo}

program ejerc3;

var A:Integer;
	num:boolean;

begin
	write('Ingrese un numero: ');
	readln(A);
	if A>0 then
		writeln('el numero es positivo')
	else
		writeln('El numero es negativo');
	readln();
	end.