{Desarrolle un programa en Pascal que de dos números ingresados por el usuario determine si uno de ellos es múltiplo del otro}

program ejercicio8;

var
	A,B:Integer;

begin

	write('Ingrese el primer numero: ');
	readln(A);
	write('Ingrese el segundo numero: ');
	readln(B);

	if A MOD B=0 then
		begin
			write('El numero ', A, ' es multiplo de ', B)
		end 

		else
			begin
				if B MOD A=0 then
					write('El numero ', B, ' es multiplo de ', A)

					else
						write('Los numeros ingresados no son multiplos')
			end;
	readln();
end.