{Desarrolle un programa en Pascal que permita sumar números ingresados por el usuario, hasta que ingrese cero, luego imprimir el total y el promedio}

program ejer29;

var
	num, suma, cont:Integer;

begin

	repeat

		write('Ingresa un numero: ');
		readln(num);
		suma:= suma + num;
		cont:= cont + 1;

	Until num=0;

	cont:= cont - 1;

	writeln();
	writeln('El total es: ', suma);
	writeln('El promedio es: ', (suma div cont));


	readln();
end.