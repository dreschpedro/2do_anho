{Desarrolle un programa en Pascal que permita sumar números ingresados por el usuario, preguntando luego de cada ingreso si “desea continuar”, luego imprimir el total y el promedio}

program ejerc25;

var
	preg:Char;
	num, suma, i:LongInt;
	prom:real;


begin

	i:=0;
	suma:=0;
	{preg:='s';}

	while preg <> 'n' do
		begin
			write('Ingresa un numero: ');
			readln(num);

			write('Queres continuar? Ingresa "n" si no queres seguir: ');
			readln(preg);

			suma:= suma + num;
			i:=i + 1;

			// writeln('');
			// writeln('Valor i: ', i);
		end;

		writeln('');
		// writeln('Valor i: ', i);

	writeln('el resultado de la suma de los numeros es ', suma);
	prom:= suma / i;
	writeln('El promedio es ', prom:6:2);




	readln;
end.