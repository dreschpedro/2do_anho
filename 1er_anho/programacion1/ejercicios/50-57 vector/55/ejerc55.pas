{Desarrolle un programa en Pascal que
-llene un vector con 10 números enteros al azar,
-luego imprima la lista de números y
-determine cual es el menor y en que posición está}

program ejerc55;

uses Crt;

const
	cant=10;

type
	arrai=array [1..cant] of integer;

var
	i,menor,pos:Integer;
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
						pos:=i;
					end;
			end;

	end;

procedure imprimir;
	begin
		clrscr;
		writeln('El numero mas chico es: ',menor,' y esta en la posicion ',pos);
		writeln;
		for i:=1 to cant do
			begin
				writeln('numero #',i,': ',vector[i]);
			end;
	end;


begin
	cargar;
	imprimir;

	readln;
end.