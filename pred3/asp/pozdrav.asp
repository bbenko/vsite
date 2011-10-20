<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
    <title>Pozdrav</title>
</head>
<body>
    <div>
        <% 
            response.write("Pozdrav, " & request.querystring("ime") & " " & request.querystring("prezime"))
        %>
    </div>
</body>
</html>