{Desarrolle un programa en Pascal que de tres números ingresados por el usuario determine cual es el mayor}

program ejercicio10;

var
A,B,C:LongInt;

begin
	{Se ingresan los numeros}
	write('Ingrese el 1er numero: ');
		readln(A);
	write('Ingrese el 2do numero: ');	
		readln(B);
	write('Ingrese el 3er numero: ');
		readln(C);

		if (A=B) and (A=C) then {Inicio 1er IF}
			begin
				write('Los numeros son iguales')
			end
	
		else
			begin
				if (A>B) and (A>C) then		{Inicio 2do IF}
					begin
						write('El numero mayor es: ', A)
					end
				else
					begin
						if (B>A) and (B>C) then
							write('El numero mayor es: ', B)
						else
							write('El numero mayor es: ', C)
				end;						{Final 2do IF}
			end;							{Final 1er IF}
	readln();
end.