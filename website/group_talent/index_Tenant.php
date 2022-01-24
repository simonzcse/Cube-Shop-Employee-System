<!doctype html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="Mark Otto, Jacob Thornton, and Bootstrap contributors">
    <meta name="generator" content="Jekyll v4.0.1">
    <title>Tenant Login</title>
	<link rel="icon" type="image/x-icon"href="photo/cube-logo-geometric-polygonal-by-Vexels.svg">
    <link rel="canonical" href="https://getbootstrap.com/docs/4.5/examples/sign-in/">

    <!-- Bootstrap core CSS -->
<link href="css/bootstrap.css" rel="stylesheet">

    <style>
      .bd-placeholder-img {
        font-size: 1.125rem;
        text-anchor: middle;
        -webkit-user-select: none;
        -moz-user-select: none;
        -ms-user-select: none;
        user-select: none;
      }

      @media (min-width: 768px) {
        .bd-placeholder-img-lg {
          font-size: 3.5rem;
        }
      }
    </style>
    <!-- Custom styles for this template -->
    <link href="css/signin.css" rel="stylesheet">
  </head>
  <body class="text-center">


    <form class="form-signin" action='index_Tenant.php' method='post'>
		<img src="photo/cube-logo-geometric-polygonal-by-Vexels.svg" alt="" width='72' height='72'/>
		<!--picture source https://www.vexels.com/png-svg/preview/137578/cube-logo-geometric-polygonal !-->
  <h1 class="h3 mb-3 font-weight-normal">Hong Kong Cube Shop Shopping System</h1>
		  <h1 class="h3 mb-3 font-weight-normal" style="font-weight: bold">Tenant</h1>
		  <?php
		  session_start();	
		  if (isset ($_SESSION["tID"])){
			  echo "<h1 class='h3 mb-3 font-weight-normal' style='font-weight: bold; color:blue;'>You are successfully logout</h1>";
			  session_destroy();
		  }
		  if (isset ($_POST["tID"]) && isset ($_POST["tPwd"] )){
			  require('conn.php');
			  $sql = "SELECT * FROM Tenant WHERE tenantID='{$_POST["tID"]}' and password='{$_POST["tPwd"]}'";
			  $rs = mysqli_query($conn, $sql) 
				or die(mysqli_error($conn));;
				if(mysqli_num_rows($rs) <= 0)
					echo "<h1 class='h3 mb-3 font-weight-normal' style='font-weight: bold; color:red;'>Invalid user</h1>";
				else  {
					session_start();			
					$_SESSION["tID"]=$_POST["tID"];
					header("Location: home_Tenant.php");
					}
		  }
		?>

  <label for="Tenant ID" class="sr-only">Tenant ID</label>
  <input type="text" id="Tenant ID" class="form-control" name='tID'placeholder="Tenant ID" required autofocus >
  <label for="Password" class="sr-only">Password</label>
  <input type="password" id="Password" class="form-control" name='tPwd' placeholder="Password" required>
  <!--<div class="checkbox mb-3"><!--
    <label>
      <input type="checkbox" value="remember-me"> Remember me
    </label>
  </div>!-->
  <button class="btn btn-lg btn-primary btn-block" style='border-radius :10px;'type="submit">Login</button>
<button style=
 "background-color: #4CAF50;
  border: none;
  color: white;
  padding: 15px 32px;
  text-align: center;
  text-decoration: none;
  display: inline-block;
  font-size: 18px;
  margin: 4px 2px;
  background-color: #f44336;
  border-radius :10px;
  cursor: pointer;" type="button" onclick="window.location.href='../group_customers/index_signin.html'">Customer Login Page</button>
  <p class="mt-5 mb-3 text-muted">&copy; 2020</p>
</form>
</body>
</html>
