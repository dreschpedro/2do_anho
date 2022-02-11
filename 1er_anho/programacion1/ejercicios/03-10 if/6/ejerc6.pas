{Desarrolle un programa en Pascal que solicite al usuario los catetos de un triángulo rectángulo y calcule el 
valor de su hipotenusa}


program ejercicio8;

var
	A,B,HIPO:real;

begin
	write('Ingrese el primer numero: ');
	readln(A);
	write('ingrese el segundo numero: ');
	readln(B);

	HIPO:= Sqrt((A*A)+(B*B));
	write('La Hipotenusa de los numeros ', A:5:2, ' y ', B:5:2, ' es: ', HIPO:5:2);

	readln();
end.
