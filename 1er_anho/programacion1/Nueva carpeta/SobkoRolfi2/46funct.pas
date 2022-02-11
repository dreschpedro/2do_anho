program funct46;

uses 

	crt;

var 
	num:integer;

function cubo(n:integer):integer;

	begin
		cubo:= n*n*n;
	end;

begin

	writeln('ingrese un numero para saber su cubo');
	readln(num);
	writeln('el cubo es: ', cubo(num));
	readln();
end.