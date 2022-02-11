{Desarrolle un programa en Pascal que permita sumar “N” números ingresados por el usuario, luego imprimir el total y el promedio}

program ejer28;

var

	suma, A, num, cont:Integer;

begin

	write('Cuantos numeros queres ingresar: ');
	readln(num);

	cont:= 0;

	repeat 
		cont:= cont + 1;
		write('Ingrese el #', cont, ' numero: ');
		readln(A);
		suma:= suma + A;

	Until cont= num; {Until define la condicion de fin}

	writeln('');
	writeln('El total de la suma es de: ', suma);


	readln();
end.