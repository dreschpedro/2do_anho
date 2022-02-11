{Desarrolle un programa en Pascal que:
-solicite el ingreso del sueldo de 10 empleados,
-determine cuál es el mayor y el menor,
-luego calcule el promedio de los sueldos y
-liste con color azul los sueldos superiores al promedio y con color amarillo los sueldos inferiores al promedio}

program ejerc53;

uses Crt;

const
	cant=10;

type
	arrai=array [1..cant] of integer;

var
	i,mayor,suma,prom,menor:Integer;
	vector:arrai;

procedure cargar;
	begin
		for i:=1 to cant do
			begin
				write('Ingrese sueldo #',i,': '); readln(vector[i]);
				suma:= suma + vector[i];
				if vector[i]> mayor then//									calculo menor/mayor
					mayor:= vector[i]
				else
					if (vector[i]< menor) or (menor=0) then
						menor:= vector[i];
			end;
			prom:= suma div cant;//											promedio

	end;

procedure imprimir;
	begin
		clrscr;
		writeln('El promedio de los sueldos es: ',prom);
		writeln('El mayor sueldo es: ',mayor);
		writeln('El menor sueldo es: ',menor);
		writeln;
		for i:=1 to cant do//												color de impresion
			begin
				if vector[i]>=prom then
					textcolor(cyan)//										sueldos menores al promedio
				else
					textcolor(yellow);//									sueldos mayores al promedio
				writeln('sueldo #',i,': ',vector[i]);
			end;
	end;


begin
	cargar;
	imprimir;

	readln;
end.