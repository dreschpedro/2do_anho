program matriz59;

uses 
	crt;

type
	matriz = array [1..3, 1..8] of integer;

procedure proceso;
	
	var
	x,f,c:integer;
	matrix:matriz;

	begin
		for f:=1 to 2 do
			for c:=1 to 8 do
				begin
					writeln('ingres el numero de la fila ', f, ' columna ', c);
					readln(matrix[f,c]);
					
				end;

		
			for c:=1 to 8 do
				begin
					matrix[3,c]:=matrix[1,c] + matrix[2,c];
				end;

		clrscr;
		gotoxy(40,12);
		x:=40;
			
		for f:=1 to 2 do
			for c:=1 to 8 do
				begin
					if (f = 1)  then
						begin
							textcolor(green);
							write(matrix[f,c], '  ');
						end
					else if (f = 2)  then
						begin
							gotoxy(x,14);
							write(matrix[f,c], '  ');
							x:=x+3;
						end;
				end;
	
		x:=x-24;

			for f:=2 to 3 do
				for c:=1 to 8 do
					begin
					if f = 3 then
						begin
							gotoxy(x,16);
							textcolor(red);
							write(matrix[f,c]);
							x:=x+3;
						end;
					end;
		end;

begin
	proceso;
	readln;
end.
