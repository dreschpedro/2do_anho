program jepo;

uses
	crt;

const
	cant=3;

var
	i,total,prom: integer;
	NOTA:array[1..10] of integer;

begin

for i:=1 to cant do
	begin
		write('Ingrese nota: ');
		readln(NOTA[i]);
		total:= total + NOTA[i];
	end;

prom:= total div cant;

for i:= 1 to cant do
	begin
		if NOTA[i]>= prom then
			textcolor(green)
		else 
			textcolor(red);

		writeln('Nota: ',NOTA[i]);
	end;



	readln();
end.