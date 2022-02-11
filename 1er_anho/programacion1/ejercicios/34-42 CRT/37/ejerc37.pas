{Desarrolle un programa en Pascal que sume los números del 1 al 100}

program ejer37;

var

	i,suma:Integer;

begin

	suma:=1;

	for i:=1 to 99 do
		begin
			suma:= suma + 1;
			writeln('El numero ',i,' + 1= ',suma);
		end;

	readln();
end.