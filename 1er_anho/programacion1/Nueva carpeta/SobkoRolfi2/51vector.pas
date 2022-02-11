program verctor50;

uses
	crt;

const
	n=25;

type
	nvector = array [65..90] of integer;

var 
	abc:nvector;
	opc,i:integer;								//lo hice con numeros


begin
writeln('queres el abecedario de forma ascendente o descendente?(1 o 2)');
readln(opc);
	if opc = 1 then 													//abc descendiente
	begin
		for i:=65 to 90 do 
			writeln(chr(abc[i]))
	end
	else if opc = 2 then
	begin
		for i:=90 downto 65 do 											//abc descendiente
			writeln(chr(abc[i]))
	end;

	readln();
end.
