program crt40;

uses 
	crt;

var	
	x,y,n,j,i:integer;
	nt:extended;

begin
	textcolor(green);
	writeln('el numero que escriba sera la dimension de su triangulo de pascal');
	readln(n);
	
x:=40;
y:=5;
	for	i:=0 to n do
		begin
			gotoxy(x,y);
			nt:=1;
			for j:= 0 to i do 
				begin
					write(' ', nt:2:0, ' ');
					nt:= nt * (i - j) / (j + 1);
				end;
			x:=x-2;							//es lo mas triangular que lo pude dejar, pero no me gusta mucho por que 
											//sobrescribe los valores cuando el usuario pone un num elevado.
			y:=y+1;
		end;
	
	readln();
end.