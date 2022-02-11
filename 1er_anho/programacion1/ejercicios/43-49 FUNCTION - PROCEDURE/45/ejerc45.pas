{Desarrolle una Calculadora en Pascal con las cuatro operaciones básicas}

program ejerc43;

uses
	crt;

var
	oper:Integer;
	calc,num2,num1:real;

function ingresar():Integer;						//ingresar los numeros
	begin
		write('Ingrese 2 numeros: ');
		readln(num1,num2)
	end;

function operacion():Integer;					//elegir la operacion
	begin
		writeln;
		writeln('operaciones disponibles:');
		writeln;
		writeln('1--> suma');
		writeln('2--> resta');
		writeln('3--> multiplicacion');
		writeln('4--> division');
		writeln;
		while (oper<1) or (oper>4) do	//verifica que la operacion sellecionada sea una de las posibles
			begin
				clrscr;
				write('Ingrese operacion: ');
				readln(oper);
			end;
	end;

function imprimir():Integer;						//hace el calculo e imprime el resultado
	begin
		writeln;
		case oper of
			1:calc:= (num1 + num2);
			2:calc:= (num1 - num2);
			3:calc:= (num1 * num2);
			4:calc:= (num1 / num2);
		end;
		write('el resultado es: ', calc:5:2);
	end;

begin									//main begin
	ingresar();
	operacion();
	imprimir();

	readln;
end.