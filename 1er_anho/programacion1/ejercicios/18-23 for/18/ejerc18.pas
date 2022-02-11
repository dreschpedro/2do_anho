{Desarrolle un programa en Pascal que imprima los números del 1 al 10 y luego del 10 al 1}

program ejer18;

var
	i,B:Integer;

begin

	for i:=1 to 10 do {for "A" es el valor en la vuelta 1, '10' es la cantidad de vueltas}
		writeln('Numero: ', i);

	writeln('');

	for i:=10 downto 1 do
		writeln('Numero: ', i);

	readln();
end.