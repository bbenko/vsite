<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
  <head>
	<title>Prva PHP aplikacija</title>
    <meta http-equiv="content-type" content="text/html; charset=utf-8" />

  </head>

  <body>
  	<h1>Prva PHP aplikacija</h1>

  	<?php
  		print "Ovo je ispis iz PHP-a. ";
  		echo "Opet ispis.";

  		$a = 5;
  		$b = 6;
  		print $a * $b;
  	?>

  	<form action="bok.php" method="post">
  		<p>
  			<label for="ime">Ime</label>
  			<input type="text" name="ime" id="ime" />
  		</p>
  		<p>
  			<label for="prezime">Prezime</label>
  			<input type="text" name="prezime" id="prezime" />
  		</p>
  		<p>
  			<input type="submit" value="Pošalji"/>
  		</p>
  	</form>
  </body>
 </html>