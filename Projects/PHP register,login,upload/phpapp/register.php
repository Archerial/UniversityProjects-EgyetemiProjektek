<?php include ('server.php'); ?>
<!DOCTYPE html>
<html>
<head>
    <title>Registration</title>
    <link rel="stylesheet" type="text/css" href="register.css">
</head>
<body>
    
<div class="background-wrap">
        <video id="video-bg-elem" preload="auto" autoplay="true" loop="loop" muted="muted">
            <source src="bg.mp4" tpye="video/mp4">
            Video not supported
        </video>
</div>

    <div class="box">
    <div class="header">
        <h2> Register </h2>
    </div>
    <form method="post" action="register.php">
        <?php include ('errors.php'); ?>
        <div class="inputBox">
            <label> Username </label>
            <input type="text" name="username" value="<?php echo $username; ?>">
        </div>
        <div class="inputBox">
            <label> Email </label>
            <input type="text" name="email" value="<?php echo $email; ?>">
        </div>
        <div class="inputBox">
            <label> Password </label>
            <input type="password" name="password">
        </div>
        <div class="inputBox">
            <label> Confrim Password </label>
            <input type="password" name="password2">
        </div>
        <div id="wrapper">
            <input type="submit" name="register" value="Register"></button>
        </div>
        <p>
            Already a member? <a href="login.php">Login</a>
        </p>
    </form>
</div>
</body>
</html>