{Desarrolle un programa que
-llene con números enteros una matriz de 6 x 3,
-luego sume cada columna y
-almacene los totales en una fila adicional, luego imprima la matriz diferenciando el color de los totales}

program ejerc60new;

uses Crt;

type arrai=array[1..7,1..3] of integer;

var
	i,j,x,y:Integer;
	vector:arrai;

procedure cargar;
	begin
		randomize;
		for i:= 1 to 6 do
			begin
				for j:=1 to 3 do
					begin
						vector[i,j]:= random(50);
						vector[7,j]:= vector[7,j] + vector[i,j];
					end;
			end;
	end;

procedure imprimir;
	begin
		x:= 20;
		y:= 10;
		for i:=1 to 7 do
			begin
				for j:=1 to 3 do
					begin
						gotoxy(x,y);

						if i<> 7 then
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