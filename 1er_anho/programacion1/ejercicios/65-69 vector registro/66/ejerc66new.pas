{Desarrolle un programa en Pascal que
-permita cargar el horario de entrada y salida de lunes a sábado,
-luego el usuario ingresa un día y el programa le devuelve el horario correspondiente a ese día}

program ejerc66new;

uses crt;

type arrai=record
	entrada:string[10];
	salida:string[10];
	end;

var
	i,dia:integer;
	vector:array[1..6] of arrai;

procedure cargar;
	begin
		write('Vas a ingresar los horarios de E/S de lunes a sabado en orden creciente!!'); 
		delay(1000);
		clrscr;

		for i:=1 to 6 do
			begin
				write('Ingresa hora de entrada para el dia #',i,' : '); readln(vector[i].entrada); writeln;
				write('Ingresa hora de salida para el dia #',i,' : '); readln(vector[i].salida); writeln;
			end;
	end;

procedure buscar;
	begin
		write('Ingresa el dia a buscar: '); readln(dia);

		for i:=1 to 6 do
			begin
				if i=dia then
					write('El dia #',i,' entraste a las ',vector[i].entrada,' y saliste a las ',vector[i].salida);
			end;
	end;

begin
	cargar;
	clrscr;
	buscar;
	readln;
end.