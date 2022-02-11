{Desarrolle un programa en Pascal que solicite al usuario un número entre 0 y 255, y luego devuelva el carácter ASCII correspondiente a ese código}

program ejerc33;

uses
	CRT;

var
	num:Integer;

begin

	repeat

		write('Ingresa un numero: ');
		readln(num);
		writeln(CHR(num));
		delay(1000);
		CLRSCR;

	Until num=0;





	readln();
end.