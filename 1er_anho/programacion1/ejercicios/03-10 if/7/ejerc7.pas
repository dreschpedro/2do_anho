{Desarrolle un programa en Pascal que determine si un número ingresado por el usuario es Par o Impar}

program ejercicio7;

var 
	A:Integer;

begin
	write('Ingrese un numero: ');
	readln(A);

	if A MOD 2=0 then
		write('El numero ', A, ' es par')
		else
			write('El numero ', A, ' es impar');
	readln();
end.