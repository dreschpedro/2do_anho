program fuctproc43;

uses 
	crt;


PROCEDURE operacion;

	function suma (n1,n2:integer):integer;						//suma
		begin
			suma:=n1+n2;
			writeln('la suma de los numeros es: ', suma);
		end;

	function resta (n1,n2:integer):integer;					//resta
		begin
			resta:=n1-n2;
			writeln('la resta de los numeros es: ', resta);
		end;
	
	function mul (n1,n2:integer):integer;					//multiplicacion
		begin
			mul:=n1*n2;
			writeln('la multiplicacion de los numeros es: ', mul);
		end;

	function dyv (n1,n2:integer):real;						//division
		begin
			dyv:=n1/n2;
			writeln('la division de los numeros es: ', dyv);
		end;
		
	var
			n1,n2:integer;
			ope:string[4];

	begin
		writeln('ingrese dos numeros.');
		readln(n1,n2);
		writeln('que operacion va a realizar?');
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
				end;
		end;
begin

	operacion;
	readln();

end.




