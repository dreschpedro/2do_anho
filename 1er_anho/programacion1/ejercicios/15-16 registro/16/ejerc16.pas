{Desarrolle un programa en Pascal que solicite al usuario los siguientes datos de un Cliente: Nombre, Apellido, Fecha, Importe y Concepto. Luego con esos datos imprimir un Recibo de Cobro}

program ejerc16;

uses
	CRT;

type
	person=record
		nombre:String[15];
		apellido:String[10];
		importe:real;
		fecha:String[8];
		concepto:String[15];
	end;

var
	agenda:person;

begin

	textcolor(green);
	write('Ingresa tu apellido: ');
	readln(agenda.apellido);
	write('Ingresa tu nombre: ');
	readln(agenda.nombre);
	write('Ingresa el Importe: ');
	readln(agenda.importe);
	write('Ingresa la fecha en formato DD-MM-AA (01-05-21): ');
	readln(agenda.fecha);
	write('Ingresa el concepto: ');
	readln(agenda.concepto);

	CLRSCR; textcolor(black); textbackground(white);
	gotoxy(50,5);
	writeln('RECIBO DE COBRO');
	gotoxy(15,7);
	write('Recibi de: '); textcolor(black); textbackground(green); write(' ',agenda.nombre, ' ', agenda.apellido);
	gotoxy(15,8); textcolor(black); textbackground(white);
	write('la cantidad de: '); textcolor(black); textbackground(green); write('$ ',agenda.importe:6:2);
	gotoxy(15,9); textcolor(black); textbackground(white);
	write('por concepto de: '); textcolor(black); textbackground(green); write(' ',agenda.concepto);
	gotoxy(22,11); textcolor(black); textbackground(white);
	write('En la fecha: '); textcolor(black); textbackground(green); write(' ',agenda.fecha);

	readln();
end.