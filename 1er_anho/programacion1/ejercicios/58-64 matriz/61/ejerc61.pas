{Desarrolle un programa en Pascal que
-llene con números enteros una matriz de 4 x 5,
-luego sume cada fila y columna,
-y la suma total de la matriz, luego imprima la matriz diferenciando el color de los totales}

program ejerc61;

uses Crt;

type
	arrai=array[1..5,1..7] of integer;

var
	i,j,x,y:Integer;
	vector:arrai;

procedure cargar;
	begin
		randomize;
		for i:=1 to 4 do
			begin//									inicio 1ro
				for j:=1 to 5 do
					begin//							inicio 2do
						vector[i,j]:= random(50);
						vector[i,6]:= vector[i,6] + vector[i,j];//			total derecho vertical
						vector[5,j]:= vector[5,j] + vector[i,j];//			total inferior horizontal
						vector[5,6]:= vector[1,6] + vector[2,6] + vector[3,6] + vector[4,6] + vector[5,1] + vector[5,2] + vector[5,3] + vector[5,4] + vector[5,5];
					end;//							fin 2do
			end;//									fin 1ro
	end;

procedure imprimir;
	begin
		x:=35;
		y:=10;
		for i:=1 to 5 do
			begin//									inicio 1ro
				gotoxy(x,y);
				for j:=1 to 6 do
					begin//							inicio 2do
						if (j=6) or (i=5) then
							textcolor(red)
						else
							textcolor(cyan);

						if (i=5) and (j=6) then
							textcolor(green);
						write(vector[i,j],' ');

						x:= x + 4;
					end;//							fin 2do
					x:= 35;
					y:= y + 2;
			end;//									fin 1ro
	end;


begin
	cargar;
	imprimir;
	readln;
end.