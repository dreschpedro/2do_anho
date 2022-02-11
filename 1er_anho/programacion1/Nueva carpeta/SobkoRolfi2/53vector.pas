program vector53;

uses 
	crt;

type
	vector = array [1..10] of integer;

var
	n,sum,max,min:integer;
	sueldos:vector;
	prom:real;
begin

									
	max:=0;						//inicializo las variables.
	sum:=0;
	min:=0;
	n:=0;
	while n <> 10 do

		begin
			n:=n+1;
			writeln('ingrese el sueldo de los empleados');
			readln(sueldos[n]);
			min:=sueldos[n];

			if (sueldos[n] <= min) or (min = 0) then					//el sueldo mas bajo
				min:=sueldos[n];
				
			if (sueldos[n] >= max) then									//el sueldo mas elevado
				max:=sueldos[n];
			
				
			sum:=sueldos[n]+sum;						//suma para promediar
		end;


	prom:=sum/10;										//promedio

	for n:=1 to 10 do
		begin
			if (sueldos[n] < prom) then 				//ipresion de sueldos con color
				begin
					textcolor(yellow);
					writeln(sueldos[n]);
				end
			else if (sueldos[n] > prom) then
				begin
					textcolor(blue);
					writeln(sueldos[n]);
				end;									//impresion de sueldo con color/>

		end;

	writeln('El sueldo mas bajo es ', min, ' y el mas alto es ', max);		//impredsion final
	readln();

end.

