program crt42;

uses 
	crt;

var
n,x,y,num:integer;


begin
randomize;
x:=26;
y:=8;
clrscr;
		

		repeat							//esto imprime los finos renglones de la cuadrilla
			FOR	N:=0 TO 6 do 
				begin
					textcolor(15);
					gotoxy(x,y);
					write(chr(219));
					x:=x+1;
				end;
				x:=x-7;
				y:=y+2;
		until y = 16;

Y:=Y-7;


	repeat
		for n:=0 to 6 do 						//y esto de aca imprime los laterales y los colorsitos
			begin
				if (x mod 2 = 0) then
					begin 
						textcolor(15);
						gotoxy(x,y);
						write(chr(219));
						x:=x+1;
					end
				else 
					begin
						num:= random(15);		//aca imprime los colores random.
						textcolor(num);
						gotoxy(x,y);
						write(chr(219));
						x:=x+1;
					end;
				end;
		x:=x-7;
		y:=y+2;
	until y = 15;
				
readln();
end.

