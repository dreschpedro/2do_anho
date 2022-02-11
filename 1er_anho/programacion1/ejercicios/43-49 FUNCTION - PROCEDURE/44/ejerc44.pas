{Desarrolle un programa en Pascal con una Función para calcular el promedio de N números}

program ejerc44;

uses
	crt;

var
	suma,cant,num,prom,i:Integer;

function promedio ():integer;
	begin
		write('Cuantos numeros queres promediar: '); readln(cant);
		writeln;
		for i:=1 to cant do
			begin
				write('Ingrese #',i,' numero: '); readln(num);
				suma:= suma + num;
			end;

		prom:= suma div cant;
		writeln;
		write('El promedio de los ',cant,' numeros ingresados es: ',prom);
	end;

begin

	promedio();
	readln;
end.