{Desarrolle un programa en Pascal que de dos números ingresados por el usuario determine cual es el mayor}

program ejercicio5;

var 
	A,B:Integer;

begin
	write('Ingrese un numero: ');
	readln(A);
	write('Ingrese el segundo numero: ');
	readln(B);

	if A=B then
		begin
			write('Los numeros son iguales');
		end
	else 
		begin
			if A>B then
				writeln('El numero ', A,' es mayor que el numero ', B)
			else
				writeln('El numero ', B,' es mayor que el numero ', A);
		end;	
	readln();
end.