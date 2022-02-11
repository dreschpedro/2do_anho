{Desarrolle un programa en Pascal que llene un vector con los números pares comprendidos entre 0 y 40, y luego imprima en orden descendente}

program ejerc50;

uses
	crt;

type
	arrai=array [1..20] of integer;

var
	i,j,num,x,y:integer;
	vector:arrai;

begin
	randomize;

//																		<<< crear numeros aleatorios
	for i:=1 to 20 do
		begin
			repeat
				num:= random(40);//										guarda numeros pares nada mas
				vector[i]:=num;
			until (num mod 2=0);
		end;

	x:= 7;
	y:= 11;

//																		<<< crear las grillas
	for i:=1 to 2 do//cantidad de lineas horizontales
		begin
			for j:=1 to 101 do//cantidad de puntos de la linea
				begin
					gotoxy(x,y);
					textbackground(red);
					write(chr(00));
					x:= x + 1;
				end;
				x:= 7;
				y:= y + 4;
		end;

	x:= 7;
	y:= 12;

	for i:=1 to 21 do//cantidad de columnas
		begin
			for j:=1 to 3 do//cantidad de puntos de la linea
				begin
					gotoxy(x,y);
					textbackground(green);
					write(chr(00));
					y:= y + 1;
				end;
				y:= 12;
				x:= x + 5;
		end;

//																		<<< imprime los valores/numeros en cada celda

	x:= 9;
	y:= 13;

	for i:=1 to 20 do//cantidad de lineas horizontales
		begin
			gotoxy(x,y);
			textbackground(0);
			write(vector[i]);
			x:= x + 5;
		end;

	readln;
end.
//no logro hacer que se impriman en 2 filas de 10 numeros cada una, se imprimen los resultados de arriba si hago un for anidado o incluso con 2 for separados