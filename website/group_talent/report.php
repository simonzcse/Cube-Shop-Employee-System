<!DOCTYPE html>
<html>
<head>
<link rel="icon" type="image/x-icon"href="photo/cube-logo-geometric-polygonal-by-Vexels.svg">
<title>
Report
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
	
	
input[type=text], select {
  width: 10%;
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
  padding: 10px 7px;
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
  width: 100%;
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
  padding: 20px;
  margin: auto;
  width: 60%;">
 <div style="font-size:24px; font-weight: bold"><center><b>Click the button to Generate the Report</b></center></div>
    <center>
	<form action="report.php" method="POST">
	<input type='hidden' name ='gett' value="abc"></input>
	<input type="submit" value="Generate the report" ></input></center>
  </form>
   <?php
	session_start();
	require('conn.php');	
	if (isset ($_SESSION["tID"]) && isset ($_POST["gett"])){
		$sql = "SELECT o.orderID, o.orderDateTime, o.customerEmail, c.firstName,
					c.lastName, s.address, oi.goodsNumber, g.goodsName,
					oi.quantity, o.status, oi.sellingPrice 
				FROM Orders o, Customer c, Goods g, Shop s, OrderItem oi , Tenant t,
					ConsignmentStore_Shop css, ConsignmentStore cs 
				WHERE t.tenantID='{$_SESSION["tID"]}' and t.tenantID=cs.tenantID 
					and cs.consignmentStoreID=css.consignmentStoreID and css.shopID=s.ShopID
					and css.shopID=o.shopID and oi.goodsNumber=g.goodsNumber and  c.customerEmail=o.customerEmail
					and o.orderID=oi.orderID and cs.consignmentStoreID=g.consignmentStoreID
				ORDER BY o.orderDateTime DESC";
		$rs = mysqli_query($conn, $sql) 
		or die(mysqli_error($conn));;

?>
</div>
<p></p>
<?PHP
   	if(mysqli_num_rows($rs) <= 0){
			echo "<h1><center>Record not found</center></h1>";
	}
	else{
	?>
	<!--Click the button will generate the report-->
	<table id="report">
		<tr>
			<th>Order ID</th>
			<th>Order Date</th>
			<th>Customer ID</th>
			<th>Customer Name</th>
			<th>Shop address</th>
			<th>Goods Number</th>
			<th>Goods name</th>
			<th>Selling price of each goods</th>
			<th>Quantity</th>
			<th>Total Price</th>
			<th>Order status</th>
		</tr>
   <?php
	while($row = mysqli_fetch_assoc($rs)){
		echo "<tr>";
		echo "<td>{$row["orderID"]}</td>";
		echo "<td>{$row["orderDateTime"]}</td>";
		echo "<td>{$row["customerEmail"]}</td>";
		echo "<td>{$row["firstName"]} {$row["lastName"]}</td>";
		echo "<td>{$row["address"]}</td>";
		echo "<td>{$row["goodsNumber"]}</td>";
		echo "<td>{$row["goodsName"]}</td>";
		echo "<td>{$row["sellingPrice"]}</td>";
		echo "<td>{$row["quantity"]}</td>";
		$x=$row["sellingPrice"]*$row["quantity"];
		echo "<td>{$x}</td>";
		switch ($row["status"]) {
		  case 1:
			echo "<td>Delivery</td>";
			break;
		  case 2:
			echo "<td>Awaiting</td>";
			break;
		  case 3:
			echo "<td>Completed</td>";
			break;
		  default:
		  	echo "<td>{$row["status"]}</td>";
		}
		echo "</tr>";	
	}
	}
	}
	if (!isset ($_SESSION["tID"])){
		header("Location: index_Tenant.php");}
	mysqli_close($conn);	
	?>
</table>
</body>
</html>