program vector66;

uses
	crt;
var

	hora: array [1..6] of 
		record
			entrada: string;
			salida:	string;
		end;

	i:integer;

begin
	for i:=1 to 6 do  //cargo el vector
		begin
			writeln('(lunes = 1, martes = 2, miercoles =3, jueves = 4, viernes = 5, sabado = 6)');
			writeln('ingrese el horario de entrada del dia ', i);
			readln(hora[i].entrada);
			writeln('ingrese el horario de salida del dia ', i);
			readln(hora[i].salida);
			writeln();
		end;

	ClrScr;		//imprime la busqueda
	writeln('(lunes = 1, martes = 2, miercoles =3, jueves = 4, viernes = 5, sabado = 6)');
	writeln('ingrese el dia que desee saber el horario');
	readln(i);
	writeln('horario de entrada: ', hora[i].entrada);
	writeln('horario de salida: ', hora[i].salida);


readln();
end.