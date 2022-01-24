<!DOCTYPE html>
<html>
<head>
<link rel="icon" type="image/x-icon"href="photo/cube-logo-geometric-polygonal-by-Vexels.svg">
<title>
Goods information
</title>
<style>
	body{
		border-color:#D8D4DB;
		font-family: -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, "Helvetica Neue", Arial, "Noto Sans", sans-serif, "Apple Color Emoji", "Segoe UI Emoji", "Segoe UI Symbol", "Noto Color Emoji";
	}
.topnav {
  
  overflow: hidden;
  background-color: #333;
}

.topnav a {
  float: left;
  color: gray;
  text-align: center;
  text-decoration: none;
  padding: 14px 16px;
  font-size: 17px;

}

.topnav a:hover {
  
  color: #CFCFCF;
}

.topnav a.active {
  
  color: white;
	font-size:20px;
}	
.topnav a.home {
  
  color: white;
	
}	
	
	
input[type=text], select {
  width: 18%;
  padding: 12px 20px;
  margin: 8px 0;
  display: inline-block;
  border: 1px solid #ccc;
  border-radius: 4px;
  box-sizing: border-box;
}
input[type=number], select {
  width: 18%;
  padding: 12px 20px;
  margin: 8px 0;
  display: inline-block;
  border: 1px solid #ccc;
  border-radius: 4px;
  box-sizing: border-box;
}

input[type=submit] {
  width: 20%;
  background-color: #5C5C5C;
  color: white;
  padding: 8px 5px;
  margin: 8px 0;
  border: none;
  border-radius: 4px;
  cursor: pointer;
	text-align:center;
}

input[type=submit]:hover {
  background-color: #CDD0F4;
	color:#4D4A4A;
}

	
	
#report {
  font-family: "Trebuchet MS", Arial, Helvetica, sans-serif;
  border-collapse: collapse;
  width: 60%;
  margin: auto;
text-align:center;
}

#report td, #report th {
  border: 1px solid #ddd;
  padding: 8px;
}

#report tr:nth-child(odd){background-color: #f2f2f2;}

#report tr:hover {background-color: #ddd;}

#report th {
  padding-top: 12px;
  padding-bottom: 12px;
  text-align: left;
  background-color: #696969;
  color: white;
	text-align:center;
}
	
	
	
	
	
</style>
<head>
<body>
<div class="topnav">
  <a class="active" href="index_Tenant.php">HKCS</a>
  <a class="home"href="home_Tenant.php">Home</a>
  <a href="goinfo.php">Manange Goods</a>
  <a href="report.php">Report</a>
	<a href="delorder.php">Delete order</a>
</div>

 <?php
	session_start();
	require('conn.php');	
?>
	
<div id="form1" class="center" style="border-radius: 5px;
  background-color: #f2f4f8;
  padding: 80px;
  margin: auto;
 text-align: center;
  width: 60%;">
	<h1>Find and Edit the Goods</h1>
	 <form action="goinfo.php" method="POST">
 <label for="gnumber"style="margin: 1px;">Goods Number</label>
    <input type="number" id="gnumber" name="gnumber" placeholder="1" step="1"  min="1" style="width: 18%;" required>
<label for="gname">Goods Name</label>
    <input type="text" id="gname" name="gname" placeholder="Nelson-class battleship" style="margin: 1px;" required><br>
<label for="squantity">Stock Quantity</label>
    <input type="number" id="squantityname" name="squantity" min="0"  step="1" placeholder="1" required>
<label for="sprice" style="margin: 4px 6px 4px 5px;">Stock Price</label >
    <input type="number" id="sprice" name="sprice" min="0" placeholder="1.0" pattern="^\d*(\.\d{0,1})?$" step="0.1" style="margin-left: 8px;" required><br>
<label for="Status">Status</label>
	<input type="radio" id="Availavle" name="status" value="1" checked>
<label for="male">Availavle</label>
	<input type="radio" id="Unavailavle" name="status" value="2">
<label for="female">Unavailavle</label><br>
   <!--<center><input type="button" value="Search">-->
	<input type="submit" value="Edit"></center>
  </form>
  <?PHP
  if (isset ($_POST["gnumber"]) && isset ($_POST["gname"]) && isset ($_POST["squantity"]) && isset ($_POST["sprice"]) && isset ($_POST["status"])){
		$sqli = "SELECT * FROM Goods WHERE goodsNumber='{$_POST["gnumber"]}'";
		$rs = mysqli_query($conn, $sqli) 
			or die(mysqli_error($conn));;

		if(mysqli_num_rows($rs) <= 0){
			echo "<h1>Goods not found</h1>";
		}
		else{
		$sql_2 = "UPDATE Goods
			SET goodsName='{$_POST["gname"]}', remainingStock='{$_POST["squantity"]}', stockPrice='{$_POST["sprice"]}', status='{$_POST["status"]}'
			WHERE goodsNumber='{$_POST["gnumber"]}'";
		if (mysqli_query($conn, $sql_2)) {
			echo "<h2>Record update successfully</h2>";
		}else {
			echo "<h1>Error deleting record: " . $conn->error."</h1>";
		}
		}
  }
  ?>
</div>
<p></p>
	<!--Click the button will generate the report-->
	<table id="report">
  <tr>
		<th>Goods Number</th>
		<th>Goods name</th>
	  	<th>Remaining Stock</th>
		<th>Stock Price</th>
		<th>Status</th>
  </tr>
   <?php
   	if (isset ($_SESSION["tID"])){
		$sql = "SELECT DISTINCT g.goodsNumber, g.consignmentStoreID, 
					g.goodsName, g.stockPrice, g.remainingStock, g.status
				FROM  Goods g, Tenant t, ConsignmentStore_Shop css, ConsignmentStore cs 
				WHERE t.tenantID='{$_SESSION["tID"]}' and t.tenantID=cs.tenantID 
					and cs.consignmentStoreID=css.consignmentStoreID 
					and cs.consignmentStoreID=g.consignmentStoreID
				ORDER BY g.goodsNumber ASC";
		$rs = mysqli_query($conn, $sql) 
		or die(mysqli_error($conn));;
		while($row = mysqli_fetch_assoc($rs)){
			echo "<tr>";
			echo "<td>{$row["goodsNumber"]}</td>";
			echo "<td>{$row["goodsName"]}</td>";
			echo "<td>{$row["remainingStock"]}</td>";
			echo "<td>{$row["stockPrice"]}</td>";
			switch ($row["status"]) {
			  case 1:
				echo "<td>Availavle</td>";
				break;
			  case 2:
				echo "<td>Unavailable</td>";
				break;
			  default:
				echo "<td>{$row["status"]}</td>";
			}
			echo "</tr>";
		}
	}
	mysqli_close($conn);
	if (!isset ($_SESSION["tID"])){
		header("Location: index_Tenant.php");}
		?>
</table>
</body>
</html>