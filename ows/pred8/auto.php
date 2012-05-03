<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
  <head>
	<title>Automobil</title>
    <meta http-equiv="content-type" content="text/html; charset=utf-8" />

  </head>

  <body>
  	<h1>Automobil</h1>
    <?php
      $conn = mysql_connect("localhost", "root", "");
      if (!$conn)
      {
        die("Ne mogu se spojiti na MySql database server.");
      }

      $baza = mysql_select_db("ows", $conn);
      if (!$baza)
      {
        die("Ne mogu se spojiti na OWS bazu.");
      }

      mysql_query("SET NAMES 'utf8'"); //hrv. slova
      $id = $_REQUEST["id"];
      $rezultat = mysql_query("SELECT * FROM auto WHERE id=" . $id); //podložno sql injectionu

      $redak = mysql_fetch_array($rezultat);
      if (!$redak) 
      {
        die("Ne postoji taj automobil.");
      }
      echo "<p>" . $redak["id"] . "</p>";
      echo "<p>" . $redak["naziv"] . "</p>";
      echo "<p>" . $redak["snaga"] . "</p>";
      echo "<p>" . $redak["boja"] . "</p>";
      echo "<p>" . $redak["opis"] . "</p>";
      mysql_close($conn);
    ?>
    </table>
  </body>
 </html>