{Desarrolle un programa en Pascal que dibuje el Triángulo de Pascal de una dimensión dada por el usuario, en el centro de la pantalla}

program ejerc40;

uses 
	CRT;

var
	x,y,n,j,i:integer;
	cj:extended;

begin
	textcolor(3);
	write('Ingresa un numero <=19: ');
	readln(n);

	x:=40;
	y:=5;

	for i:=0 to n do
		begin
			gotoxy(x,y);
			cj:=1;
			for j:= 0 to i do 
				begin
					write(' ', cj:2:0, ' ');
					cj:= cj * (i - j) / (j + 1);
				end;
			x:=x-2;
			y:=y+1;
		end;
	readln();
end.