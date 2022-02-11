{Desarrolle un programa en Pascal que permita agrupar personas ingresadas por el usuario por Sexo, hasta que ingrese “X”, luego imprimir el total y el porcentaje por sexo}

program ejer31;

var
	sexo:char;
	hombre,mujer,total:Integer;

begin

	repeat

		write('Ingrese el sexo (m o f), x para detener: ');
		readln(sexo);


		if (sexo='F') or (sexo='f') or (sexo='M') or (sexo='m') or (sexo='x') or (sexo='X') then
			Begin

				if (sexo='F') or (sexo='f') then
					begin
						mujer:= mujer +1;
					end
				else
					if (sexo='M') or (sexo='m') then
						Begin
							hombre:= hombre + 1;
						end
			end
		Until sexo= 'x';


		total:= mujer + hombre;
		writeln('');
		writeln('Mujeres: ', ((mujer*100) div total), ' %');
		writeln('Hombres: ', ((hombre*100) div total), ' %');

	readln();
end.