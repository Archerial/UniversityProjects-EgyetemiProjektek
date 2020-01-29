<?php

session_start();

$username = "";
$email = "";
$errors = array();
//db connect
$db = mysqli_connect("localhost", "root", "", "aawebprog");

if (isset($_POST['register'])) {
    $username =  ($_POST['username']);
    $email= ($_POST['email']);
    $password = ($_POST['password']);
    $password2 = ($_POST['password2']);

    if (empty($username)){
        array_push($errors, "Username is required");
    }

    if (empty($email)){
        array_push($errors, "Email is required");
    }

    if (empty($password)){
        array_push($errors, "Password is required");
    }

    if ($password != $password2) {
        array_push($errors, "The two passwords do not match");
    }

    //if no error, save the user to the db

    if (count($errors) == 0) {
        $password = md5($password); //encrypt password
        $sql = "INSERT INTO users (username,email,password) VALUES ('$username', '$email', '$password')";
        mysqli_query($db,$sql);
        $_SESSION['username'] = $username;
        $_SESSION['succes'] = "Succesfully logged in";
        header('location: index.php'); //kezdőlapra irányít
    }
}

//login from loginpage
if (isset($_POST['login'])){

    $username =  ($_POST['username']);
    $password = ($_POST['password']);

    if (empty($username)){
        array_push($errors, "Username is required");
    }

    if (empty($password)){
        array_push($errors, "Password is required");
    }

    if(count($errors) == 0){
        $password = md5($password);
        $query = "SELECT * FROM users WHERE username='$username' AND password='$password'";
        $result = mysqli_query($db,$query);
        if (mysqli_num_rows($result) == 1){
            $_SESSION['username'] = $username;
            $_SESSION['succes'] = "Succesfully logged in";
            header('location: index.php'); //kezdőlapra irányít
        }else{
            array_push($errors, "The username/password combination not correct");
        }
    }
}


//kilépés
if (isset($_GET['logout'])){
    session_destroy();
    unset($_SESSION['username']);
    header('location: login.php');
}



?>