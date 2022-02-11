{Desarrolle un programa en Pascal que dibuje una tabla de 4 filas y 6 columnas en el centro de la pantalla}

program ejer36;

uses
	CRT;

var
	i,j,y,x,k,l:Integer;

begin

	y:=8;
	x:=30;

	for j:=1 to 4 do {filas}
		begin
			for i:=1 to 51 do
				begin
					delay(1);
					gotoxy(x,y);
					write('*'); {imprime horizontalmente}
					x:= x + 1;
				end;
			y:= y + 5; {hace salto de linea}
			x:= 30;
		end;

	y:=8;
	x:=30;

	for k:=1 to 6 do {columnas}
		begin
			for l:=1 to 15 do
				begin
					delay(1);
					gotoxy(x,y);
					// textcolor(red);
					write('*'); {imprime verticalmente}
					y:= y + 1;
				end;
			x:= x + 10; {hace salto de columna}
			y:= 8;
		end;



	readln();
end.