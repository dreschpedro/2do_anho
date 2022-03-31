{Desarrolle un programa en Pascal que
-permita cargar el menú de almuerzo y cena de lunes a viernes,
-luego el usuario ingresa un día y el programa le devuelve el menú correspondiente a ese día}

program ejerc65;

uses Crt;

// const
	

type
	menu=record
		almuerzo:string[20];
		cena:string[20];
	end;

var
	i,dia:integer;
	vector:array [1..5] of menu;

procedure cargar;
	begin
		textcolor(green);
		write('Menu: 1>Lunes; 2>Martes; 3>Miercoles; 4>Jueves; 5>Viernes');
		writeln;
		for i:=1 to 5 do
			begin
				write('Menu para el almuerzo del dia #',i,': '); readln(vector[i].almuerzo);
				write('Menu para la cena del dia #',i,': '); readln(vector[i].cena);
				writeln;
			end;
	end;

procedure buscar;
	begin
		clrscr;
		textcolor(cyan);
		write('Menu: 1>Lunes; 2>Martes; 3>Miercoles; 4>Jueves; 5>Viernes');
		writeln;
		write('que dia queres buscar (numero): '); readln(dia);
		writeln;
		for i:=1 to 5 do
			begin
				if i=dia then
					begin
						writeln('Amuerzo del dia #',i,' es: ',vector[i].almuerzo);
						writeln('Cena del dia #',i,' es: ',vector[i].cena);
					end;
			end;
	end;

begin
	cargar;
	buscar;

	readln;
end.