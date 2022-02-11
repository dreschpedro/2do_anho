{Desarrolle un programa en Pascal que:
-solicite el ingreso de 15 notas de alumnos, 
-luego calcule el promedio de las notas y 
-liste con color verde las notas superiores al promedio y con color rojo las notas inferiores al promedio}

program ejerc52;

uses Crt;

const
	cant=5;

type
	arrai=array [1..cant] of integer;

var
	i,suma,prom:Integer;
	vector:arrai;

procedure cargar;//														cargar notas
	begin
		for i:=1 to cant do
			begin
				write('Ingrese nota #',i,': '); readln(vector[i]);
				suma:= suma + vector[i];
			end;
		prom:= suma div cant;//											promedio
	end;

procedure imprimir;
	begin
		for i:=1 to cant do
			begin

				if vector[i]>= prom then//								color de nota
					textcolor(green)
				else
					textcolor(red);
					writeln('nota #',i,': ',vector[i]);
			end;
	end;


begin

	cargar;
	clrscr;
	imprimir;

	readln;
end.