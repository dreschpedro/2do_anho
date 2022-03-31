{Desarrolle un programa en Pascal que
-llene con números enteros una matriz de 4 x 5,
-luego sume cada fila y columna,
-y la suma total de la matriz, luego imprima la matriz diferenciando el color de los totales}

program ejerc61new;

uses Crt;

type arrai=array[1..5,1..6] of integer;

var
	i,j,x,y:Integer;
	vector:arrai;

procedure cargar;
	begin
		randomize;
		for i:=1 to 4 do
			begin
				for j:=1 to 5 do
					begin
						vector[i,j]:= random(2);
						vector[5,j]:= vector[5,j] + vector[i,j];
						vector[i,6]:= vector[i,6] + vector[i,j];
						
					end;
				// vector[5,6]:= vector[5,6] + vector[i,6] + vector[5,j];
			end;
	end;

procedure imprimir;
	begin
		x:= 20;
		y:= 10;
		for i:=1 to 5 do
			begin
				for j:=1 to 6 do
					begin
						gotoxy(x,y);

						if (i=5) or (j=6) then
							textcolor(red)
						else
							textcolor(yellow);

						write(vector[i,j]);
						x:= x + 5;
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