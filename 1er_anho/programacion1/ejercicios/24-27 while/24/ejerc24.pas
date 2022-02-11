{Desarrolle un programa en Pascal que permita sumar números ingresados por el usuario, hasta que ingrese cero, luego imprimir el total y el promedio}

Program ejerc24;

Var
	i,suma,N: integer;
Begin

	suma:=0;
	i:=0;
	N:=1;

	while N<>0 do
		Begin
			write('Ingrese un numero: ');
			readln(N);
			suma:= suma + N;
			i:= i + 1;

			if N=0 then
				i:= i - 1;

		end;

		writeln('');
		writeln('El total de la suma es: ', suma);
		writeln('El promedio es ', (suma div i));

	readln;
End.