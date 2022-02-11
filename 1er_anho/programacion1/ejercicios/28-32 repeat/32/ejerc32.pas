{Desarrolle un programa en Pascal que permita agrupar personas ingresadas por el usuario por su Edad, hasta que ingrese cero, luego imprimir el total y el porcentaje por grupo, si:
Hasta 10 años = Niño
Hasta 18 años = Adolescente
Hasta 40 años = Adulto
Hasta 60 años = Mayor
Más de 60 años = Anciano}

program ejerc32;

var

	edad,A,B,C,D,E:Integer;

begin

	edad:=1;

	repeat
		write('Ingrese una edad (1 - 100); 0 para detener: ');
		readln(edad);

		case edad of
			1..10: A:=A + 1;
			11..18: B:= B + 1;
			19..40: C:= C + 1;
			41..60: D:= D + 1;
			61..100: E:= E + 1;
		end;

	Until edad= 0;

	writeln('');
	writeln('Ninhos: ', A);
	writeln('Adolescentes: ', B);
	writeln('Adultos: ', C);
	writeln('Mayores: ', D);
	writeln('Ancianos: ', E);


	readln();
end.