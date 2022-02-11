program skdc;

uses
	crt;

const
	cant=10;

var
	i: integer;
	nota: array[1..10]of integer;

begin

randomize;

for i:=1 to cant do
	begin
		nota[i] := random(100);
		writeln('nota: ',nota[i]);
	end;


	readln();
end.