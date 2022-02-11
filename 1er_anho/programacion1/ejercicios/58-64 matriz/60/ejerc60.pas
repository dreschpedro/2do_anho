{Desarrolle un programa que
-llene con números enteros una matriz de 6 x 3,
-luego sume cada columna y
-almacene los totales en una fila adicional, luego imprima la matriz diferenciando el color de los totales}

program ejerc61;

uses Crt;

type
	arrai=array[1..6,1..3] of integer;

var
	i,j,x,y:Integer;
	vector:arrai;

procedure cargar;
	begin
		randomize;
		for i:=1 to 6 do

			begin//										inicio 1er for

				for j:=1 to 2 do

					begin//								inicio 2do for
						vector[i,j]:=random(50);
						vector[i,3]:= vector[i,3] + vector[i,j];//			total derecho vertical
					end;//								fin 2do for

			end;//										fin 1er for
	end;

procedure imprimir;
	begin

		x:=50;
		y:=10;
		
		for i:=1 to 6 do
			begin//										inicio 1er for
				for j:=1 to 3 do
					begin//								inicio 2do for

						gotoxy(x,y);
						if j=3 then
							textcolor(cyan)
						else
							textcolor(green);

						if vector[i,j]=0 then
							textcolor(red)
						else
							if vector[i,j]=1 then
								textcolor(yellow);

						write(vector[i,j],' ');
						x:= x + 3;
					end;//								fin 2do for

					x:= 50;
					y:= y + 2;
				end;//									fin 1er for
	end;//												fin begin

begin

	cargar;
	imprimir;

	readln;
end.