program verctor50;


const
	n=40;

type
	nvector = array [1..20] of integer;

var 
	vector:nvector;
	i:integer;


begin

	for i:= 1 to n do
		begin
			if (i mod 2 = 0) then 
				vector[i]:= i;	
		end;
	

	for i:= 1 to 20 do
	begin
		if (vector[i] <> 0) then 
			writeln(vector[i]);	
		end; 
		

	readln();
end.

