program crt38;

uses 
	crt;

var
	i,m,y,x,n:integer;

begin												//toma los datos
	textcolor(10);
	gotoxy(10,40);
	writeln('ingrese el numero que nunca supo multiplicar:');
	readln(n);
	clrscr;
	y:=5;
	x:=5;
		
		for i:=0 to 10 do							//imprime y realiza las operaciones 
			begin
				m:=n*i;
				gotoxy(x,y);
				write(n, ' x ', i, ' = ', m);
				y:=y+1;
			end;

	readln();
end.