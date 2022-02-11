{Desarrolle un programa en Pascal que solicite al usuario los siguientes datos de un Alumno: Nombre, Apellido, DNI, Curso, Fecha y Materia. Luego con esos datos imprimir una Constancia de Inscripción a un Examen}

program ejer15;

uses
	CRT;

type
	person=record
		nombre:String[15];
		apellido:String[10];
		DNI:LongInt;
		curso:String[10];
		fecha:String[8];
		materia:String[15];
	end;

var
	agenda:person;

begin

	textcolor(green);

	write('Ingresa tu apellido: ');
	readln(agenda.apellido);
	write('Ingresa tu nombre: ');
	readln(agenda.nombre);
	write('Ingresa tu DNI: ');
	readln(agenda.DNI);
	write('Ingresa tu curso: ');
	readln(agenda.curso);
	write('Ingresa la fecha en formato DD-MM-AA (01-05-21): ');
	readln(agenda.fecha);
	write('Ingresa la materia: ');
	readln(agenda.materia);

	CLRSCR; textcolor(black); textbackground(white);
	gotoxy(50,2);
	writeln('Instituto Combate Mborore');
	gotoxy(46,4);
	write('CONSTANCIA DE ASISTENCIA A EXAMEN');
	gotoxy(20,6);
	write('Se deja constancia de que el/la alumno/a'); 
	gotoxy(15,7);
	write('Apellido y Nombre:'); textcolor(green); textbackground(black); write(' ',agenda.nombre, ' ', agenda.apellido);
	gotoxy(15,8); textcolor(black); textbackground(white);
	write('DNI: '); textcolor(green); textbackground(black); write(' ',agenda.DNI);
	gotoxy(15,9); textcolor(black); textbackground(white);
	write('Ha rendido examen de la asignatura: '); textcolor(green); textbackground(black); write(' ',agenda.materia);
	gotoxy(15,10); textcolor(black); textbackground(white);
	write('Corresondiente al curso: '); textcolor(green); textbackground(black); write(' ',agenda.curso);
	gotoxy(15,11); textcolor(black); textbackground(white);
	write('En la fecha: '); textcolor(green); textbackground(black); write(' ',agenda.fecha);
	
	readln();
end.