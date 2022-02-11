{Desarrolle un programa que imprima el Código ASCII completo (clave y carácter), en una sola pantalla}

program ejer39;

uses
	CRT;

var
	i,j,x,y,cont:Integer;

begin

	x:=4;
	y:=1;

	for i:=1 to 15 do//<<<<<<<<<       imprime las filas          >>>>>>>>>>>>>>
		begin
			for j:=1 to 115 do{imprime punto a punto hacia la derecha}
				begin
					gotoxy(x,y);
					write('-');
					x:= x + 1;{hace un salto hacia el costado}
				end;
				y:= y + 2; {salta hacia abajo}
				x:=4;
		end;

	x:=4; {posicionar nuevamente al puntero arriba a la izquierda}
	y:=2;

	for i:= 1 to 20 do //<<<<<<<<<        imprime las columnas      >>>>>>>>>>>>>
		begin
			for j:=1 to 14 do{imprime punto a puntpo hacia abajo}
				begin
					gotoxy(x,y);
					textcolor(j);
					write('|');
					y:= y + 2;{hace un salto hacia abajo}
				end;
			x:= x + 6; {salta hacia el costado}
			y:=2;
		end;

	x:= 5;
	y:= 2;
	cont:= 1;
	while cont <= 247 do
		begin
			for i:=1 to 19 do {imprime los valores de las casillas ACSII}
				begin
					gotoxy(x,y);
					textcolor(8);
					write(cont,'=',chr(cont));
					cont:= cont + 1; {incrementa el contador}
					x:= x + 6;{salta hacia la derecha}
				end;
				y:= y + 2; {salta hacia abajo}
				x:=5;
			end;

			for i:=1 to 8 do {imprime los valores de las casillas ACSII}
				begin
					gotoxy(x,y);
					write(cont,'=',chr(cont));
					cont:= cont + 1; {incrementa el contador}
					x:= x + 6;{salta hacia la derecha}
				end;
				y:= y + 2; {salta hacia abajo}
				x:=5;

	readln();
end.