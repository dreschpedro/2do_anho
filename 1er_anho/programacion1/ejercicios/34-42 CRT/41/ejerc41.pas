{Desarrolle un programa en Pascal que pinte toda la pantalla con la Bandera Argentina}

program ejerc41;

uses
	CRT;

var
	i,j,x,y:Integer;

begin

	x:=1;
	y:=1;

	for i:=1 to 30 do //badera
		begin

			if (y>10) and (y<20) then
				textbackground(white)
			else
				textbackground(cyan);

			for j:=1 to 119 do //crea las filas
				begin
					gotoxy(x,y);
					write(chr(00));
					x:= x + 1;
				end;
				x:= 1;
				y:= y + 1; //crea las columnas
			end;

	x:=50;
	y:=12;

	for i:=1 to 7 do //sol central
		begin
			textbackground(yellow);

			for j:=1 to 19 do //lineas
				begin
					gotoxy(x,y);
					write(chr(00));
					x:= x + 1;
				end;
				x:= 50;//columnas
				y:= y + 1;
			end;
			textbackground(cyan);
			gotoxy(119,30);
	readln();
end.