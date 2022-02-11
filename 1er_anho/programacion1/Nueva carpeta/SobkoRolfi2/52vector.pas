program vector52;

uses 
	crt;

type 

	notas = array [1..15] of integer;

var
	prom:real;
	n,sum:integer;
	vector:notas;

begin
	sum:=0;
	for n:=1 to 15 do
		begin
			writeln('ingrese las notas');
			readln(vector[n]);
			sum:=sum+vector[n];
		end;
 

	prom:=sum/15;

	for n:=1 to 15 do
		begin
			if (vector[n] < prom) then 
				begin
					textcolor(red);
					write(vector[n]);
				end
			else if (vector[n] > prom) then
				begin
					textcolor(green);
					write(vector[n]);
				end;

		end;
	readln();
end.

