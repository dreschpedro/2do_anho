{desarrollar un programa que identifica el dia de la semana segun el numero que ingrese el usuario}

program diaSemana;

var
	dia:Integer;

begin

	write('Ingrese un numero del 1 al 7: ');
	readln(dia);

	case dia of
		1:write('Domingo');
		2:write('Lunes');
		3:write('Martes');
		4:write('Miercoles');
		5:write('Jueves');
		6:write('Viernes');
		7:write('Sabado');
	else
		write('No es un dia de la semana');
	end;

	readln();
end.