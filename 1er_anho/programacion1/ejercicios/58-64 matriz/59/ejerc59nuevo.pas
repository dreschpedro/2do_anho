{Desarrolle un programa en Pascal que
-llene con números enteros una matriz de 3 x 8,
-luego sume cada fila y
-almacene los totales en una columna adicional,
-luego imprima la matriz diferenciando el color de los totales}

program ejerc59new;

uses Crt;

type arrai=array[1..3,1..9] of integer;

var
	i,j,x,y:integer;
	vector:arrai;

procedure cargar;
	begin
		randomize;
		for i:= 1 to 3 do //filas
			begin
				for j:=1 to 8 do //columnas
					begin
						vector[i,j]:= random(40);
						vector[i,9]:= vector[i,9] + vector[i,j]; //total en una columna mas
					end;
			end;
	end;

procedure imprimir;
	begin
		x:= 20;
		y:= 10;

		for i:=1 to 3 do
			begin
				for j:=1 to 9 do
					begin
						gotoxy(x,y);
						delay(25);
						if j=9 then
							textcolor(red)
						else
							textcolor(yellow);

						write(vector[i,j]);
						x:= x + 3;
					end;

					x:= 20;
					y:= y + 2;

			end;
	end;

begin
	cargar;
	imprimir;
	readln;
end.