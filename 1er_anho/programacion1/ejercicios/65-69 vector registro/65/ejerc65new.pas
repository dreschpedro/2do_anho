{Desarrolle un programa en Pascal que
-permita cargar el menú de almuerzo y cena de lunes a viernes,
-luego el usuario ingresa un día y el programa le devuelve el menú correspondiente a ese día}

program ejerc65new;

uses crt;

type arrai=record
	almuerzo:string[20];
	cena:string[20];
end;

var
	i,dia:integer;
	vector:array[1..5] of arrai;

procedure cargar;
	begin
		textcolor(red);
		write('Menu> 1:Lunes, 2:Martes, 3:Miercoles; 4:Jueves, 5:viernes');
		writeln;
		writeln;
		textcolor(yellow);
		delay(1000);
		for i:=1 to 5 do
			begin
				write('Almuerzo para el dia #',i,' : '); readln(vector[i].almuerzo); writeln;
				write('Cena para el dia #',i,' : '); readln(vector[i].cena); writeln;
			end;
	end;

procedure buscar;
	begin
		clrscr;
		textcolor(cyan);
		write('Ingrese el dia a buscar la comida: '); readln(dia);

		if i=dia then
			begin
				writeln('Almuerzo del dia #',i,' es ',vector[i].almuerzo);
				writeln('Cena del dia #',i,' es ',vector[i].cena);
			end;

	end;

begin
	cargar;
	buscar;
	readln;
end.