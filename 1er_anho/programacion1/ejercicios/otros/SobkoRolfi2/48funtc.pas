program funtc48;

uses 
	crt;

var
	a,b,pot:REAL;


function poten (a,b:real):real;
	begin
		pot:=Exp(b*Ln(a));
		writeln('la potencia es igual a = ',pot:5:2);
	end;

begin
	writeln('ingrese la base');
	readln(a);
	writeln('ingrese el exponente');
	readln(b);
	poten(a,b);
	readln();
end.