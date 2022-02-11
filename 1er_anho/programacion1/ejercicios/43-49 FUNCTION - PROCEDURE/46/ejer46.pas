{Desarrolle un programa en Pascal con una Función para calcular el cubo de un número}

program ejerc46;

uses
	crt;

var
	ncubo,num:integer;

function cubo(num:integer):integer;
	begin
		write('Ingresa un numero para saber su cubo: '); readln(num);
		ncubo:= num*num*num;
		writeln;
		write('el cubo de ',num,' es: ',ncubo);
	end;



begin

	cubo(num);
	readln;
end.