{Desarrolle un programa que dibuje un rectángulo de 4 filas y 30 columnas en el centro de la pantalla}

program ejer34;

uses
	CRT;

var
	i,j,y,x:Integer;

begin

	y:=10;
	x:=10;

	for j:=1 to 4 do {filas}
		begin
			for i:=1 to 88 do
				begin
					delay(1);
					gotoxy(x,y);
					write('*'); {imprime horizontalmente}
					x:= x + 1;
				end;
			y:= y + 5; {hace salto de linea}
			x:= 10;
		end;

	y:=11;
	x:=10;

	for j:=1 to 30 do {columnas}
		begin
			for i:=1 to 14 do
				begin
					delay(1);
					gotoxy(x,y);
					textcolor(red);
					write('*'); {imprime verticalmente}
					y:= y + 1;
				end;
			x:= x + 3; {hace salto de columna}
			y:= 11;
		end;



	readln();
end.