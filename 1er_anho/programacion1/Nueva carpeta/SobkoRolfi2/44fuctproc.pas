program fuctproc44;

uses
	crt;


function dyv (sum,i,n1,n2:integer):real;						//division
		begin
			writeln('cuantos numeros vas a promediar?');
			readln(n1);
				for i:=1 to n1 do 
					begin
					writeln('ingrese un numero');
					readln(n2);
					sum:=sum+n2;
			dyv:=sum/n1;
			writeln('la division de los numeros es: ', dyv:5:2);
		end;

var 
n1,n2:integer;

begin
	writeln('cuantos numeros vas a promediar?');
	dyv(n1,n2)
	readln();
end.
	