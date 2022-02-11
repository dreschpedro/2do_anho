program fuctproc45;

uses 
	crt;



PROCEDURE operacion;

	function suma (n1,n2:integer):integer;						//suma
		begin
			writeln('ingrese el sumado 1');
			readln(n1);
			writeln('ingrese el sumado 2');
			readln(n2);
			suma:=n1+n2;
			writeln('la suma de los numeros es: ', suma);
		end;

	function resta (n1,n2:integer):integer;					//resta
		begin
			writeln('ingrese el minuendo');
			readln(n1);
			writeln('ingrese el sustraendo');
			readln(n2);
			resta:=n1-n2;
			writeln('la resta de los numeros es: ', resta);
		end;
	
	function mul (n1,n2:integer):integer;					//multiplicacion
		begin
			writeln('ingrese el multiplicando');
			readln(n1);
			writeln('ingrese el multiplicador');
			readln(n2);
			mul:=n1*n2;
			writeln('la multiplicacion de los numeros es: ', mul);
		end;

	function dyv (n1,n2:integer):real;						//division
		begin
			writeln('ingrese el dividendo');
			readln(n1);
			writeln('ingrese el divisor');
			readln(n2);
			dyv:=n1/n2;
			writeln('la division de los numeros es: ', dyv:5:2);
		end;

		
		var
			n1,n2:integer;					//me dice que no se usan pero cuando las quito me tira error.
			ope:string[4];

		begin	

			readln(ope);

				if ope = 'suma' then 
					begin
						suma(n1,n2)
					end
				else if ope = 'rest' then 
					begin
						resta(n1,n2)
					end
				else if ope = 'mult' then 
					begin
						mul(n1,n2)
					end
				else if ope = 'divi' then
					begin
						dyv(n1,n2)
					end
		end;
begin
	writeln('que operacion va a realizar?(suma, resta, multiplicacion, division)');
	operacion;
	readln();
end.