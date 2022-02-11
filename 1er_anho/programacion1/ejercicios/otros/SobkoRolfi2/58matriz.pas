program matriz58;

uses 
	crt;

type
	matriz = array [1..2, 1..5] of integer;

procedure proceso;
	
	var
	x,f,c:integer;
	matrix:matriz;

	begin
		for c:=1 to 5 do
			begin
				writeln('ingres el numero de la posicion ', c);
				readln(matrix[1,c]);
				matrix[2,c]:=sqr(matrix[1,c]);
			end;
		clrscr;
		x:=40;
		gotoxy(40,12);
			for f:=1 to 2 do
				for c:=1 to 5 do
					begin
						if f = 1 then
							begin
								textcolor(green);
								write(matrix[f,c], '  ');
							end;
						if f = 2 then
							begin
								gotoxy(x,14);
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
