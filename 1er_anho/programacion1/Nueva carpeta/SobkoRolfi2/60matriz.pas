program matriz60;

uses 
	crt;

type
	matriz = array [1..7, 1..3] of integer;

procedure proceso;
	
	var
	n,y,x,f,c:integer;
	matrix:matriz;

	begin					//esto almacena los datos cargados por el usuario
		for f:=1 to 6 do
			for c:=1 to 3 do
				begin
					writeln('ingres el numero de la fila ', f, ' columna ', c);		
					readln(matrix[f,c]);
					
				end;


		for c:=1 to 7 do 			//esto suma todo los datos cargados
			begin
				matrix[7,c]:= matrix[1,c] +  matrix[2,c] +  matrix[3,c] +  matrix[4,c] +  matrix[5,c] + matrix[6,c];
			end;

		clrscr;
		gotoxy(40,12);
		x:=40;
		y:=12;
		n:=1;

	for f:=1 to 6 do					//esto imprime todo los datos cagados
		begin
			for c:=1 to 3 do
				begin
					textcolor(green);
					gotoxy(x,y);
					write(matrix[f,c], ' ');
					x:=x+5;
				end;
			x:=x-15;
			y:=y+2;
		end;



	for f:=7 to 7 do 				//esto imprime todos los totales de los datos cagados
		for c:=1 to 3 do 
			begin 
				textcolor(blue);
				gotoxy(x,y);
				write(matrix[7,c], ' ');
				x:=x+5;
			end;
	
		end;

begin						//begin principal
	proceso;
	readln;
end.
