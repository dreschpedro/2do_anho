{Desarrolle una Calculadora en Pascal con las cuatro operaciones básicas, la potencia y la raíz}

program ejerc43;

uses
	crt;

var
	calc,oper:Integer;
	num2,num1:real;

procedure ingresar;						//ingresar los numeros
	begin
		write('Ingrese 2 numeros: ');
		readln(num1,num2)
	end;

procedure operacion;					//elegir la operacion
	begin
		writeln;
		writeln('operaciones disponibles:');
		writeln;
		writeln('1--> suma');
		writeln('2--> resta');
		writeln('3--> multiplicacion');
		writeln('4--> division');
		writeln('5--> raiz');
		writeln('6--> potencia');
		writeln;
		while (oper<1) or (oper>7) do	//verifica que la operacion sellecionada sea una de las posibles
			begin
				write('Ingrese operacion: ');
				readln(oper);
			end;
	end;

procedure imprimir;						//hace el calculo e imprime el resultado
	begin
		writeln;
		case oper of
			1:calc:= trunc((num1 + num2));
			2:calc:= trunc((num1 - num2));
			3:calc:= trunc((num1 * num2));
			4:calc:= trunc((num1 / num2));
			5:calc:= trunc(Exp((1/num2)*Ln(num1)));
			6:calc:= trunc(Exp(num2*Ln(num1)));
		end;
		write('el resultado es: ', calc);
	end;

begin									//main begin
	ingresar;
	operacion;
	imprimir;

	readln;
end.