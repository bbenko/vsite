<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
    <title>Pozdrav</title>
</head>
<body>
    <div>
        <form action="zbrajalo.asp" method="post">
			<input type="text" id="suma" name="suma" readonly="readonly" 
			value="<% response.write(cint(request.form("suma")) + cint(request.form("x"))) %>"
			/>
			<input type="text" id="x" name="x" />
			<input type="submit" />
		</form>
<!--		
		<% 
            response.write("Pozdrav, " & request.querystring("ime") & " " & request.querystring("prezime"))
        %>
		-->
    </div>
</body>
</html>