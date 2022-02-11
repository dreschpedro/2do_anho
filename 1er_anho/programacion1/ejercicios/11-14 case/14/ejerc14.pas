{
Desarrolle un programa en Pascal que, de acuerdo a la nota ingresada por el usuario, determine la nota literal de un alumno, de acuerdo a la siguiente escala de puntuación:

90 – 100= A
80 – 89= B
70 – 79= C
60 – 69= D
0 – 59= E
}

program ejerc14;

var
	nota:Integer;

begin
	write('Ingresa la nota que obtuviste: ');
	readln(nota);

	case nota of
		90..100:write('Tu nota es A');
		80..89:write('Tu nota es B');
		70..79:write('Tu nota es C');
		60..69:write('Tu nota es D');
		0..59:write('Tu nota es E');
	else
		write('No es una nota valida')

	end;

	readln();
end.