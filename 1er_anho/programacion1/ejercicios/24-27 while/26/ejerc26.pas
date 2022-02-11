{Desarrolle un programa en Pascal que permita agrupar personas ingresadas por el usuario por Sexo, hasta que ingrese “X”, luego imprimir el total y el porcentaje por sexo}

program ejer26;

var
	sexo:char;
	hombre,mujer,total:Integer;

begin

	while (sexo <>'x') do
		Begin

			write('Ingrese el sexo de la persona M o F: ');
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

		end;


		total:= mujer + hombre;
		writeln('');
		writeln('El promedio de mujeres es de ', ((mujer*100) div total), ' %');
		writeln('La cantidad de hombres es de ', ((hombre*100) div total), ' %');

	readln();
end.