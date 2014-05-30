<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
  <head>
	<title>Automobili</title>
    <meta http-equiv="content-type" content="text/html; charset=utf-8" />

  </head>

  <body>
  	<h1>Automobili</h1>
    <table>
      <tr>
        <th></th>
        <th>Naziv</th>
        <th>Snaga</th>
        <th>Boja</th>
      </tr>
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
      $rezultat = mysql_query("SELECT id, naziv, snaga, boja FROM auto");

      while ($redak = mysql_fetch_array($rezultat)) {
        echo "<tr>";
        echo "<td><a href='auto.php?id=" . $redak["id"] . "'>Detalji</a></td>";
        echo "<td>" . $redak["naziv"] . "</td>";
        echo "<td>" . $redak["snaga"] . "</td>";
        echo "<td>" . $redak["boja"] . "</td>";
        echo "</tr>";
      }
      mysql_close($conn);
    ?>
    </table>
  </body>
 </html>
