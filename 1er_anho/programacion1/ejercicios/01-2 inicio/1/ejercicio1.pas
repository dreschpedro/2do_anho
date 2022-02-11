program ejercicio1;

{Declaro las variables}

var 
	A,B:Integer;
	TOT:longInt;

begin
	write('ingrese un numero: ');
	readln(A);
	write('Ingrese el 2do numero: ');
	readln(B);
	TOT:=A+B;
	writeln('El resultado es: ', TOT);
	readln;
end.
