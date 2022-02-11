	program matriz61;

uses 
	crt;

type
	matriz = array [1..5, 1..6] of integer;

procedure proceso;
	
	var
	n,y,x,f,c:integer;
	matrix:matriz;

	begin					//esto almacena los datos cargados por el usuario
		for f:=1 to 4 do
			for c:=1 to 5 do
				begin
					writeln('ingres el numero de la fila ', f, ' columna ', c);		
					readln(matrix[f,c]);
				end;



		for f:= 1 to 4 do 			//esto suma las filas cargadas
			begin
				matrix[f,6]:= matrix[f,1] + matrix[f,2] + matrix[f,3] + matrix[f,4] + matrix[f,5];
			end;


		for c:=1 to 5 do 			//esto suma las columnas cargadas
			begin
				matrix[5,c]:= matrix[1,c] +  matrix[2,c] +  matrix[3,c] +  matrix[4,c];
			end;

		clrscr;
		gotoxy(40,12);
		x:=40;
		y:=12;
		n:=1;

	matrix[5,6]:= matrix[5,6] + matrix[1,6] + matrix[2,6] + matrix[3,6] + matrix[4,6]; //la suma de los totales



	for f:=1 to 5 do					//esto imprime todo los datos cagados
		begin
			for c:=1 to 6 do
				begin
					
					if (f = 5) or (c = 6) then
						begin
							textcolor(blue);
							gotoxy(x,y);
							write(matrix[f,c], ' ');
							x:=x+5;
						end
					else if (f <> 5) or (c <> 6 ) then
						begin
							textcolor(green);
							gotoxy(x,y);
							write(matrix[f,c], ' ');
							x:=x+5;
						end;
				end;
			x:=x-30;
			y:=y+2;
		end;
	
	end;

begin						//begin principal
	proceso;
	readln;
end.
