{Desarrolle un programa en Pascal que
-permita almacenar números ingresados por el usuario en la primera fila de una matriz de 5 columnas,
-y en la segunda fila almacene el cuadrado de cada número,
-luego imprima la matriz diferenciando el color de los números y su respectivo cuadrado}

program ejerc58;

uses Crt;

type
	matriz=array[1..2, 1..5] of integer;//										1..2 filas			1..5 columnas

var
	i,x,y,j:Integer;
	vector:matriz;

procedure cargar;
	begin
		for i:=1 to 5 do
			begin
				write('ingres el numero de la posicion ', i,': ');
				readln(vector[1,i]);
				vector[2,i]:= sqr(vector[1,i]);
			end;
	end;

procedure imprimir;
	begin
		clrscr;

		x:=20;
		y:=20;
		gotoxy(x,y);

		for j:=1 to 2 do //se ejecuta por la cantidad de filas
			for i:=1 to 5 do //se ejecuta por la cantidad de columnas
				begin
					if j=1 then
						begin
							textcolor(red);
							write(vector[j,i],'   ');
						end;

					if j=2 then
						begin
							y:= 22;
							gotoxy(x,y);
							textcolor(cyan);
							write(vector[j,i],'   ');
							x:= x + 3;
						end;
				end;
	end;

begin

	cargar;
	imprimir;


	readln;
end.