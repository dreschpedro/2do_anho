{Desarrolle un programa en Pascal que determine si un número ingresado por el usuario es Positivo, Negativo o Neutro}

program ejercicio4;

var num:Integer;
	valor:boolean;

begin 
	write('Ingrese un numero: ');
	readln(num);

	if num>0 then
		writeln('El numero es positivo')
	else 
		if num<0 then
			write('El numero es negativo')
	else 
		if num=0 then
			write ('El numero es neutro');
	readln();
end.

