<?php include('server.php'); ?>
<!DOCTYPE html>
<html>
<head>
    <title>Login</title>
    <link rel="stylesheet" type="text/css" href="loginbg.css">
</head>
<body>
    
    <div class="background-wrap">
        <video id="video-bg-elem" preload="auto" autoplay="true" loop="loop" muted="muted">
            <source src="bg.mp4" tpye="video/mp4">
            Video not supported
        </video>
</div>

    <form method="post" action="login.php">
        <?php include('errors.php'); ?>

        <div class="logo">
            <a>Welcome<br></a>
        </div>

        <div class="box">
        
        <h1> Login </h1>
        <form>
            <div class="inputBox">
                <input type="text" name="username" required="">
                <label> Username </label>
            </div>
            <div class="inputBox">
                <input type="password" name="password" required="">
                <label>Password</label>
            </div>
            <div id="wrapper">
                <input type="submit" name="login" value="Login">
            </div>
            <p> <br>
            Not a member yet? <a href="register.php">Register</a>
            </p>
        </form>
    </div>
    </form>


</body>
</html>