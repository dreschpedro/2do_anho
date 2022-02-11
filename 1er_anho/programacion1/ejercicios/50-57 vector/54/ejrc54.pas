{Desarrolle un programa en Pascal que:
-llene un vector con 10 números enteros al azar,
-determine cuál es el mayor y el menor,
-luego calcule el promedio y
-liste con color blanco los números superiores al promedio y con color naranja los números inferiores al promedio}

program ejerc54;

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
		randomize;
		for i:=1 to cant do
			begin
				vector[i]:=random(500);
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
		writeln('El promedio de los numeros es: ',prom);
		writeln('El mayor numero es: ',mayor);
		writeln('El menor numero es: ',menor);
		writeln;
		for i:=1 to cant do//												color de impresion
			begin
				if vector[i]>=prom then//									numeros mayores al promedio
					textcolor(white)
				else
					textcolor(yellow);//									numeros menores al promedio
				writeln('numero #',i,': ',vector[i]);
			end;
	end;


begin
	cargar;
	imprimir;

	readln;
end.