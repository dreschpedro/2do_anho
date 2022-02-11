program crt35;

uses
	crt;

var
 	con,x:integer;

begin
x:=35;

	repeat								//lineas verticales
		begin
			gotoxy(x,17);
			write(chr(219));
			gotoxy(x,19);
			write(chr(219));
			gotoxy(x,21);
			write(chr(219));
			x:=x+1;
		end;
	until x = 42;						//lineas verticales/>

	x:= x - 7;							//emparejo el eje x.

	for con:= 0 to 3  do				//lineas horizontales
		begin
			gotoxy(x,18);
			write(chr(219));
			gotoxy(x,20);
			write(chr(219));
			x:=x+2;
		end;							//lineas hoizontale/z>

	readln();
end.