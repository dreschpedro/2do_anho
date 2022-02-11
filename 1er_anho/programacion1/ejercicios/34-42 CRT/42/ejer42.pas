{Desarrolle un programa en Pascal que dibuje una grilla de 3 x 3 en el centro de la pantalla, y luego pinte cada recuadro con un color distinto}

program crt42;

uses
	crt;

var
	m,x,y,num:integer;


begin
randomize;
x:=26;
y:=8;
clrscr;
		repeat
			for m:=0 to 6 do 
				begin
					textbackground(15);
					gotoxy(x,y);
					write(chr(00));
					x:=x+1;
				end;
				x:=x-7;
				y:=y+2;
		until y = 16;

Y:=Y-7;


	repeat
		for m:=0 to 6 do
			begin
				if (x mod 2 = 0) then
					begin 
						textbackground(15);
						gotoxy(x,y);
						write(chr(00));
						x:=x+1;
					end
				else 
					begin
						num:= random(15);
						textbackground(num);
						gotoxy(x,y);
						write(chr(00));
						x:=x+1;
					end;
				end;
		x:=x-7;
		y:=y+2;
	until y = 15;
				
readln();
end.
