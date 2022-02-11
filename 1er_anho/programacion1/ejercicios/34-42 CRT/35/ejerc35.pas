{Desarrolle un programa en Pascal que dibuje una tabla de 2 filas y 3 columnas en el centro de la pantalla}

program ejer35;

uses
	CRT;

var
	i,j,y,x,k,l:Integer;

begin

	y:=13;
	x:=50;

	for j:=1 to 2 do {filas}
		begin
			for i:=1 to 21 do
				begin
					delay(1);
					gotoxy(x,y);
					write('*'); {imprime horizontalmente}
					x:= x + 1;
				end;
			y:= y + 5; {hace salto de linea}
			x:= 50;
		end;

	y:=13;
	x:=50;

	for k:=1 to 3 do {columnas}
		begin
			for l:=1 to 5 do
				begin
					delay(1);
					gotoxy(x,y);
					write('*'); {imprime verticalmente}
					y:= y + 1;
				end;
			x:= x + 10; {hace salto de columna}
			y:= 13;
		end;



	readln();
end.