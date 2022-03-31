{Desarrolle un programa en Pascal que
-permita cargar el horario de entrada y salida de lunes a sábado,
-luego el usuario ingresa un día y el programa le devuelve el horario correspondiente a ese día}

program ejerc66;

uses Crt;

type
	arrai=record
		dia:string[10];
		Hsal:string[4];
		Hent:string[4];
	end;

var
	i:integer;
	diaB:string[10];
	bandera:boolean;
	vector:array [1..6] of arrai;

procedure cargar;
	begin
		for i:=1 to 6 do
			begin
				write('Que dia queres cargar: '); readln(vector[i].dia);
				write('A que hora entraste: '); readln(vector[i].Hent);
				write('A que hora a que hora saliste: '); readln(vector[i].Hsal);
			end;
	end;

procedure buscar;
	begin
		clrscr;
		bandera:=false;
		writeln('Menu: 1>Lunes; 2>Martes; 3>Miercoles; 4>Jueves; 5>Viernes; 6>Sabado');
		write('Que dia queres buscar: '); readln(diaB);
		for i:=1 to 6 do
			begin
				if diaB=vector[i].dia then
					begin
						bandera:=true;
						writeln;
						writeln('El dia ',i);
						writeln('entraste a las ',vector[i].Hent);
						writeln('y saliste a las ',vector[i].Hsal);
					end;
			end;
	end;

begin

	cargar;
	buscar;

	readln;
end.