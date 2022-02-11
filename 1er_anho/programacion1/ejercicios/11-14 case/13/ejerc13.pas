{
Desarrolle un programa en Pascal que solicite al usuario una fecha en formato “05 10 09” y devuelva la fecha en formato “05 de Octubre del 2009”
}

program ejerc13;

var
	D:String[2];
	M:String[2];
	A:String[2];

begin

	write('Ingrese el dia del mes en formato DD: ');
	readln(D);

	write('Ingrese el mes en formato MM: ');
	readln(M);
	write('Ingrese el anho en formato AA: ');
	readln(A);

	write(D, ' de');

	case M of
		'01','1':write(' Enero');
		'02','2':write(' Febrero');
		'03','3':write(' Marzo');
		'04','4':write(' Abril');
		'05','5':write(' Mayo');
		'06','6':write(' Junio');
		'07','7':write(' Julio');
		'08','8':write(' Agosto');
		'09','9':write(' Septiembre');
		'10':write(' Octubre');
		'11':write(' Noviembre');
		'12':write(' Diciembre');
	end;

	case A of
		'00'..'21':write(' del 20', A);
	else
		write(' del 19', A);
	end;

	readln();
end.