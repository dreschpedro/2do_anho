program funct47;


uses 

	crt;

var 
	a,b:real;

function raiz(a,b:real):real;

	begin
		writeln('ingrese el radicando');
		readln(a);
		writeln('ingrese el radical');
		readln(b);
		raiz:=Exp((1/b)*Ln(a));
		writeln('la raiz es: ', raiz:5:2);
		
	end;

begin

	raiz(a,b);
	readln();
end.