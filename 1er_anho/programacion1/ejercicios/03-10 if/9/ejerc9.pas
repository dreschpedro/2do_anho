{Desarrolle un programa en Pascal que solicite al usuario el ingreso de dos pares de números, luego sume cada par y determine cual es el mayor total}

program ejercicio9;

var
	A,B,C,D:Integer;
	ab,cd:longInt;

begin
	{Se ingresan los numeros}
	write('Ingrese el 1er numero: ');
	readln(A);
	write('Ingrese el 2do numero: ');
	readln(B);
	write('Ingrese el 3er numero: ');
	readln(C);
	write('Ingrese el 4to numero: ');
	readln(D);

	{Se calcula cual es mayor}

	ab:= A + B;
	cd:= C + D;

	if ab>cd then
		write('La suma del primer par de numeros (', A, ', ', B, ') es mayor que el segundo par de numeros (', C, ', ', D, ')')
			else
				write('La suma del segundo par de numeros (', C, ', ', D, ') es mayor que el primer par de numeros (', A, ', ', B, ')');
	readln();
end.