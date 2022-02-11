{Desarrolle un programa en Pascal que
-llene un vector con 20 números enteros al azar,
-luego imprima la lista de números y
-determine cual es el mayor, el menor y en que posición está cada uno}

program ejerc55;

uses Crt;

const
	cant=20;

type
	arrai=array [1..cant] of integer;

var
	i,menor,mayor,posMayor,posMenor:Integer;
	vector:arrai;

procedure cargar;
	begin
		randomize;
		for i:=1 to cant do
			begin
				vector[i]:=random(500);
				if (vector[i]<menor) or (menor=0) then//									calculo menor
					begin
						menor:= vector[i];//												posicion del menor
						posMenor:=i;
					end
				else
					if vector[i]>mayor then//												calculo mayor
						begin
							mayor:=vector[i];//												posicion del mayor
							posMayor:=i;
					end;
			end;

	end;

function imprimir():Integer;
	begin
		clrscr;
		writeln('El numero mas chico es: ',menor,' y esta en la posicion ',posMenor);
		writeln('El numero mas grande es: ',mayor,' y esta en la posicion ',posMayor);
		writeln;
		for i:=1 to cant do
			begin
				writeln('numero #',i,': ',vector[i]);
			end;
	end;


begin
	cargar;
	imprimir();

	readln;
end.