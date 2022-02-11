program crt36;

uses
	crt;

var
 	con,x,y:integer;

begin
x:=38;
y:=17;
	repeat
		
		for con:=0 to 12 do						//lineas verticales
			begin
				gotoxy(x,y);
				write(chr(219));
				x:=x+1;
			end;	
			
		y:=y+2;
		x:=x-13;
	until y = 23;								//lineas verticales/>


	for con:= 0 to 6  do						//lineas horizontales
		begin
			gotoxy(x,18);
			write(chr(219));
			gotoxy(x,20);
			write(chr(219));
			x:=x+2;
		end;									//lineas hoizontale/z>

	readln();
end.