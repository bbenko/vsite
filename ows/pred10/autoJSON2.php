<?php
  $mysqli = new mysqli("localhost", "root", "", "ows");
  if (mysqli_connect_errno()) {
      printf("Ne mogu se spojiti na MySql database server: %s\n", mysqli_connect_error());
      exit();
  }

  $mysqli->set_charset("utf8"); //hrv. slova
  $id = $_REQUEST["id"];

  $upit = $mysqli->prepare("SELECT id, naziv, snaga, boja, opis FROM auto WHERE id=?");
  $upit->bind_param('i', $id);
  $upit->execute();
  $upit->bind_result($id, $naziv, $snaga, $boja, $opis);

  if (!$upit->fetch())
  {
    die("Ne postoji taj automobil.");
  }

  echo "{";
  echo "id: '" . $id . "',";
  echo "naziv: '" . $naziv . "',";
  echo "snaga: '" . $snaga . "',";
  echo "boja: '" . $boja . "',";
  echo "opis: '" . $opis . "'";
  echo "}";

  $upit->close();
  $mysqli->close();
  sleep(2); // simuliramo sporu vezu
?>
