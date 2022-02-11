{Desarrolle un programa en Pascal que imprima los números Pares entre 100 y 200}

program ejer21;

var
	i:Integer;

begin

	for i:=100 to 200 do
		if (i MOD 2 = 0) then
			writeln('Numero: ', i);

	readln();
end.