{Desarrolle un programa en Pascal que imprima los números múltiplos de 5 entre 200 y 400}

program ejer22;

var

	i:Integer;

begin

	for i:=200 to 400 do

		if i MOD 5= 0 then
			writeln('Numero: ', i);


	readln();
end.