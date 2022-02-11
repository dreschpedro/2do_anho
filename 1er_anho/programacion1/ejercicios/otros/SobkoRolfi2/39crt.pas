program crt38;

uses 
	crt;

var
	n:integer;

begin
	write('Codigo ASCII (num icono):', chr(10));     //titulo
	
	textcolor(10);
	
	for n:=1 to 240 do								//esto grafica el codigo y su respectivo numero.
		begin
			write('(', n, ' ', chr(n), ')');
		end;

	readln();
end.