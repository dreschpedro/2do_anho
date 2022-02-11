{Desarrolle un programa en Pascal con una Función para calcular la potencia N de un número}

program ejerc48;

uses
	crt;

var
	pot,num:integer;

function potencia(num:integer):integer;
	begin
		write('Ingresa un numero para saber su potencia: '); readln(num);
		pot:= Sqr(num);
		writeln;
		write('la potencia de ',num,' es: ',pot);
	end;

begin

	potencia(num);
	readln;
end.