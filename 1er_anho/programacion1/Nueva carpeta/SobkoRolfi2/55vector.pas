program vecto55.pas;

uses 
	crt;

type

	vector = array[1..10] of integer;

var
	n,min,pos:integer;
	azar:vector;



begin


	min:=0;

	randomize;
	for n:=1 to 10 do 
		begin

			azar[n]:=random(5);											//genera el numero al azar

			if (azar[n] <= min) or (min = 0) then						//el numero mas bajo
				begin
					min:=azar[n];
					pos:=n;
				end;

		end;

	for n:=1 to 10 do
		begin
			textcolor(white);
			writeln(azar[n]);
		end;

		writeln('El numero mas bajo es ', min, ' y esta en la posicion ', pos);		//impredsion final
	readln();
end.