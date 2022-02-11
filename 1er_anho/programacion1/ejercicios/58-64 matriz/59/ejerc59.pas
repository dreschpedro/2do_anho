{Desarrolle un programa en Pascal que
-llene con números enteros una matriz de 3 x 8,
-luego sume cada fila y
-almacene los totales en una columna adicional,
-luego imprima la matriz diferenciando el color de los totales}

program ejerc59;

uses Crt;

type
	arrai=array[1..3,1..9] of integer;

var
	i,j,x,y:Integer;
	vector:arrai;

procedure cargar;
	begin
		randomize;
		for i:=1 to 2 do
			for j:=1 to 9 do
				begin
					vector[i,j]:= random(55);
					vector[3,j]:= vector[3,j] + vector[i,j];//					total inferior horizantal
				end;
	end;

procedure imprimir;
	begin
		x:=20;
		y:=10;
		for i:=1 to 3 do
			begin
				for j:=1 to 9 do
					begin
						gotoxy(x,y);

						if i=3 then
							begin
								textcolor(red);
							end
						else
								textcolor(yellow);

						writeln(vector[i,j],' ');
						x:= x + 3;
					end;//							fin 2do for

				x:= 20;
				y:= y + 2;
			end;//									fin 1er for
	end;

begin

	cargar;
	imprimir;

	readln;
end.