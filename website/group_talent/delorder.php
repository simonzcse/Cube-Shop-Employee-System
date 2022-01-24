<!DOCTYPE html>
<html>
<head>	
<link rel="icon" type="image/x-icon"href="photo/cube-logo-geometric-polygonal-by-Vexels.svg">
<title>
Delete Order
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
  padding: 14px 16px;
  text-decoration: none;
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
  width: 11%;
  background-color: #5C5C5C;
  color: white;
  padding: 8px 10px;
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


	
<div id="form1" class="center" style="border-radius: 5px;
  background-color: #f2f4f8;
  padding: 150px;
  margin: auto;
 text-align: center;
  width: 60%;">
	<h1>Enter the <b>Order ID</b> which is you would like to delete.</h1>
 <label for="gnumber">Order ID</label>
 <form action="delorder.php" method="POST">
    <input type="number" id="orderid" name="orderid" min="1" placeholder="1" style="width: 18%;" step="1" required>
    <center>
	<input type="submit" value="Delete order"></center>
  </form>
  <?PHP
  	session_start();
	require('conn.php');	
	if (isset ($_SESSION["tID"]) && isset ($_POST["orderid"])){
		$sql = "SELECT * FROM Orders WHERE orderID='{$_POST["orderid"]}'";
		$rs = mysqli_query($conn, $sql) 
			or die(mysqli_error($conn));;
		if(mysqli_num_rows($rs) <= 0){
			echo "<h1>Order not found</h1>";
			mysqli_close($conn);
		}
		else{
		$sql_1 = "DELETE FROM OrderItem WHERE orderID='{$_POST["orderid"]}'";
		if (mysqli_query($conn, $sql_1)) {
			  //echo "Record deleted successfully";
			} else {
			  echo "<h1>Error deleting record: " . $conn->error."</h1>";
			}
		$sql_2 = "DELETE FROM Orders WHERE orderID='{$_POST["orderid"]}'";	
		if (mysqli_query($conn, $sql_2)) {
			  echo "<h1>Record deleted successfully</h1>";
			} else {
			  echo "<h1>Error deleting record: " . $conn->error."</h1>";
			}
		mysqli_close($conn);
		}		
	}
	if (!isset ($_SESSION["tID"])){
		header("Location: index_Tenant.php");}
		?>
</div>
<p></p>
	<!--Click the button will generate the report-->
	<!--<table id="report">
  <tr>

		<th>Goods Number</th>
		<th>Goods name</th>
	  	<th>Remaining Stock</th>
		<th>Stock Price</th>
	  	
		
  </tr>
  <tr>
    <td>Alfreds Futterkiste</td>
    <td>Maria Anders</td>
    <td>Germany</td>
	  <td>Alfreds Futterkiste</td>
    
  </tr>
  </tr>
  <td>Alfreds Futterkiste</td>
    <td>Maria Anders</td>
    <td>Germany</td>
	  <td>Alfreds Futterkiste</td>

  </tr>
</table>-->
</body>
</html>