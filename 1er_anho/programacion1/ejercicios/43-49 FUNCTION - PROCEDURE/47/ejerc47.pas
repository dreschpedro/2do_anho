{Desarrolle un programa en Pascal con una Función para calcular la raíz cuadrada de un número}

program ejerc47;

uses
	crt;

var
	raiz,num:integer;

function raiz2(num:integer):integer;
	begin
		write('Ingresa un numero para saber su raiz: '); readln(num);
		raiz:= trunc(Sqrt(num));
		writeln;
		write('la raiz de ',num,' es: ',raiz);
	end;

begin

	raiz2(num);
	readln;
end.