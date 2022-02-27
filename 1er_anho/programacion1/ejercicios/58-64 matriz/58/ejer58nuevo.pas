{Desarrolle un programa en Pascal que
-permita almacenar números ingresados por el usuario en la primera fila de una matriz de 5 columnas,
-y en la segunda fila almacene el cuadrado de cada número,
-luego imprima la matriz diferenciando el color de los números y su respectivo cuadrado}

program ejerc58Nuevo;

uses Crt;

//2 tabla vacia para cargar datos
type
	arrai=array [1..2, 1..5] of integer;

var
	x,y,i,j:integer;
	vector:arrai;

procedure cargar; // carga los numeros y su cuadrado en la sugunda fila
	begin
		for i:=1 to 5 do
			begin
				write('Ingrese el numero de la posicion: ',i,': ');
				readln(vector[1,i]);
				vector[2,i]:= sqr(vector[1,i]);
			end;//fin for
	end;//fin procedure

procedure table; //dibuja los cuadrados de la tabla
	begin
		x:=20;
		y:=10;
											//dibuja las lineas de las filas
		for i:=1 to 3 do//cantidad de saltos
			begin
				for j:=1 to 46 do//cantidad de caracteres
					begin
						gotoxy(x,y);
						// delay(1);
						write(' ');
						x:= x + 1;
					end;//fin 2do for
				x:=20;
				y:= y + 2;
			end;//fin 1er for

		x:=20;//reposicionamiento
		y:=11;
											//dibuja las lineas de las columnas
		for i:=1 to 6 do//cantidad de saltos
			begin
				for j:=1 to 3 do//cantidad de caracteres
					begin
						// delay(2);
						gotoxy(x,y);
						write(' ');
						y:= y + 1;
					end;
				y:= 11;
				x:= x + 9;
			end;
	end;//fin procedure

procedure imprimir;
	begin
		x:=21;
		y:=11;
		gotoxy(x,y);
		for j:=1 to 2 do //se ejecuta por la cantidad de filas
			for i:=1 to 5 do //se ejecuta por la cantidad de columnas
				begin
					if j=1 then
						begin
							gotoxy(x,y);
							write(vector[j,i]);
							x:= x + 10;
						end;

					if j=2 then
						begin
							y:= 13;
							gotoxy(x,y);
							write(vector[j,i]);
							x:= x + 10;
						end;
				end;
	end;//fin procedure

begin

	cargar;
	clrscr;
	textbackground(magenta);
	table;
	textbackground(cyan);
	imprimir;
	readln;
end.