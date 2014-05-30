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
  echo "{";
  echo "id: '" . $redak["id"] . "',";
  echo "naziv: '" . $redak["naziv"] . "',";
  echo "snaga: '" . $redak["snaga"] . "',";
  echo "boja: '" . $redak["boja"] . "',";
  echo "opis: '" . $redak["opis"] . "'";
  echo "}";
  mysql_close($conn);

  sleep(2); // simuliramo sporu vezu
?>
