{Desarrolle un programa en Pascal que permita sumar “N” números ingresados por el usuario, luego imprimir el total y el promedio}

program ejerc23;

var
	i, N, num, suma:Integer;

begin

	suma:=0;

	write('Cuantos numeros queres sumar: ');
	readln(N);
	writeln('');

	for i:=1 to N do
		begin

			write('Ingresa el numero #', i, ': ');
			readln(num);
			suma:= suma + num;

		end;

	writeln('');
	writeln('El total de la suma de los ', N, ' numeros es: ', suma);
	writeln('El promedio de los ', N, ' numeros es: ',(suma div N));


	readln();
end.