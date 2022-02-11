{Desarrolle un programa en Pascal que permita sumar números ingresados por el usuario, preguntando luego de cada ingreso si “desea continuar”, luego imprimir el total y el promedio}

program ejerc30;

var
	cont:Integer;
	preg:Char;
	num, suma:LongInt;
	prom:real;


begin

	suma:=0;

	repeat

		cont:= cont + 1;
		write('Ingresa un numero: ');
		readln(num);

		write('Queres continuar? "n": no; "s":si: ');
		readln(preg);

		suma:= suma + num;

	Until preg='n';

	writeln('');

	writeln('el resultado de la suma de los ', cont, ' numeros es ', suma);
	prom:= suma / cont;
	writeln('El promedio es ', prom:6:2);


	readln;
end.