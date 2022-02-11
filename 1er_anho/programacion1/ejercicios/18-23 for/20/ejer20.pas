{Desarrolle un programa en Pascal que imprima los números del 1 al 100 con una pausa cada 20 números}

program ejerc20;

var

	i:Integer;

begin


	for i:=1 to 100 do
		begin
			writeln('Numero: ', i);

			if i MOD 20=0 then {si es multiplo de 20 que haga el readln}
				readln();

		end;

end.