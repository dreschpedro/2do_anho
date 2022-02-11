program vector57;

uses 
	crt;

type

	nvector = array[1..20] of integer;

var
	vector:nvector;
	flag:boolean;
	n,busqueda,pos:integer;

begin
	
	for n:=1 to 20 do 
		begin
			writeln('ingrese un numero');
			readln(vector[n]);
		end;

	writeln('que elemento desea buscar');
	readln(busqueda);

	pos:=0;
	flag:=false;
	
	for n:=1 to 20 do
		if vector[n] = busqueda then
			begin
				pos:=n;
				flag:= true;
			if flag = true then 
				begin
					writeln('el elemento ', busqueda, ' se encuentra en la posicion: ', pos);
					readln();
					end
			else if (n = 20) and (vector [n] <> busqueda) then
				begin
					writeln('ningun elemento conincide con la busqueda');
				end;
	readln();
	end;
end.