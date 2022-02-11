{Desarrolle un programa en Pascal que calcule la Edad exacta de una persona en Años, Meses y Días}

program ejer17;

var

	A,M,D:LongInt;
	dato:string;

begin
	writeln('Podes ingresar la cantidad de meses, anhos o dias');
	writeln('A= anhos');
	writeln('M= meses');
	writeln('D= dias');
	write('Que valor queres ingresar?: ');
	readln(dato);

	if (dato='A') or (dato='a') then
		begin
			write('Ingresa la cantidad de anhos: ');
			readln(A);
			M:= A * 12;
			D:= M * 30;
			write(A,' anhos son ',M,' meses y ', D, ' dias de vida');
		end

	else
		if (dato='M') or (dato='m') then
			begin
				write('Ingresa la cantidad de meses: ');
				readln(M);
				A:= M div 12;
				D:= M * 30;
				write(M,' meses son ',A,' anhos y ', D, ' dias de vida');
			end

		else
			if (dato='D') or (dato='d') then
				begin
					write('Ingresa la cantidad de dias: ');
					readln(D);
					A:= D div 365;
					M:= D div 30;
					write(D,' dias son ',M,' meses y ', A, ' anhos de vida');
				end;

	readln();
end.