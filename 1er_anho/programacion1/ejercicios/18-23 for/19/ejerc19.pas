{Desarrolle un programa en Pascal que sume 10 números enteros ingresados por el usuario, y luego calcule el total y el promedio}

program ejer19;

var

	A,B,C,D:LongInt;


begin

	C:=0;
	D:=10;

	for A:=1 to D do
		begin
			write('Ingrese el #', A, ' numero: ');
			readln(B);
			C:= C + B; 
		end;

	writeln('');
	writeln('El total de la suma de los ', D, ' numeros es: ',C);
	writeln('El promedio de la suma es de: ', (C div 10));


	readln();
end.