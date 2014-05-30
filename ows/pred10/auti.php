<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
  <head>
	<title>Automobili</title>
    <meta http-equiv="content-type" content="text/html; charset=utf-8" />
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min.js"></script>
    <script type="text/javascript">
        function getXmlHttpRequest() {
          var xmlHttp = null;
          try {
            xmlHttp = new XMLHttpRequest();
          } catch (e) {
            try {
              // starije verzije IE-a
              xmlHttp = new ActiveXObject("Msxml12.XMLHTTP");
            } catch (f) {
              xmlHttp = new ActiveXObject("Microsoft.XMLHTTP");
            }
          }
          return xmlHttp;
        }

        var xmlHttp = getXmlHttpRequest();

        function opis(id) {
          if (xmlHttp == null) {
            document.getElementById("opis").innerHTML = "Vaš preglednik ne podržava AJAX";
            return;
          }
          var url = "autoJSON.php";
          url += "?id=" + id;
          xmlHttp.onreadystatechange = procesirajRezultat;
          xmlHttp.open("GET", url, true);
          xmlHttp.send(null);
        }

        function opisJQ(id) {
          var ajax_load = '<img src="load.gif" alt="učitvam..." />';
          $("#opis").html(ajax_load);
          $.ajax({
            url: 'autoJSON2.php',
            type: 'GET',
            data: {id: id},
            success: ispisi,
            async: true
          });
        }



        function procesirajRezultat() {
          // console.log(xmlHttp.readyState);
          if (xmlHttp.readyState == 4) {
            ispisi(xmlHttp.responseText);
          }
        }

        function ispisi(poruka) {
          var auto = eval('(' + poruka + ')');
          document.getElementById("opis").innerHTML = auto.opis;
        }


    </script>

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
      $rezultat = mysql_query("SELECT * FROM auto");

      while ($redak = mysql_fetch_array($rezultat)) {
        echo "<tr>";
        echo "<td><a href='auto.php?id=" . $redak["id"] . "'>Detalji</a></td>";
        echo "<td>" . $redak["naziv"] . "</td>";
        echo "<td>" . $redak["snaga"] . "</td>";
        echo "<td>" . $redak["boja"] . "</td>";
        echo "<td><input type='button' onclick='opis(" . $redak["id"] . ")' value='Opis' /></td>";
        echo "<td><input type='button' onclick='opisJQ(" . $redak["id"] . ")' value='Opis JQ' /></td>";
        echo "</tr>";
      }
      mysql_close($conn);
    ?>
    </table>
    <div id="opis">
        Ovdje će ići opis.
    </div>
  </body>
 </html>
