{Desarrolle un programa en Pascal que llene un vector con el abecedario y luego imprima en orden ascendente o descendente a elección del usuario}

program ejerc51;
uses
	crt;

const
	n=25;

type
	arrai = array [65..90] of integer;

var 
	vector:arrai;
	opc,i:integer;


begin
	writeln('Queres el abecedario de forma ascendente (1) o descendente (2)?: ');
	readln(opc);
	writeln;

	if opc = 1 then
	begin
		for i:=65 to 90 do 
			write(chr(i),' ')
	end
	else 
		if opc = 2 then
			begin
				for i:=90 downto 65 do
					write(chr(i),' ');
			end;

	readln();
end.