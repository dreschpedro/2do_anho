{Desarrolle un programa en Pascal que permita agrupar personas ingresadas por el usuario por su Edad, hasta que ingrese cero, luego imprimir el total y el porcentaje por grupo, si:
Hasta 10 años = Niño
Hasta 18 años = Adolescente
Hasta 40 años = Adulto
Hasta 60 años = Mayor
Más de 60 años = Anciano}

program ejerc27;

var

	edad,A,B,C,D,E:Integer;

begin

	edad:=1;

	while edad<>0 do

		begin
			write('Ingrese una edad: ');
			readln(edad);

			case edad of
				1..10: A:=A + 1;
				11..18: B:= B + 1;
				19..40: C:= C + 1;
				41..60: D:= D + 1;
				61..100: E:= E + 1;

		end;end;

	writeln('');
	writeln('Ninhos es: ', A);
	writeln('Adolescentes es: ', B);
	writeln('Adultos es: ', C);
	writeln('Mayores es: ', D);
	writeln('Ancianos es: ', E);


	readln();
end.