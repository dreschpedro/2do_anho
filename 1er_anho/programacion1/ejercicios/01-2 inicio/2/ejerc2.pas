{Desarrolle un programa en Pascal para Sumar, Restar, Multiplicar y Dividir dos números ingresados por el usuario.}

program ejerc2; {doy nombre al programa}

var 
	oper:char;
	A,B,tot:real;

begin 
	write('Ingrese el primer numero: ');
	readln(A);
	write('Ingrese el segundo numero: ');
	readln(B);
	write('Tenes 4 operaciones: a= sumar, b=restar, c=multiplicar, d=dividir.');
	write('Ingresa una letra: ');
	readln(oper);

	if (oper='a') or (oper='A') then
		begin
			tot:=A + B;
		end
	else
		if (oper='B') or (oper='b') then
			begin
				tot:=A - B;
			end
		else
			if (oper='C') or (oper='c') then
				begin
					tot:=A * B;
				end
			else
				begin
					tot:=A / B;
				end;
	write('El total es ', tot:5:2);

	readln();
end.