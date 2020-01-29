<?php include('server.php'); 
    if (empty($_SESSION['username'])){
        header('location: login.php');
    }

?>
<?php include('_hamburger.php'); ?>

<?php
    if (isset($_POST['upload'])){
        $target = "images/".basename($_FILES['image']['name']);

        $db = mysqli_connect("localhost", "root", "", "aawebprog");

        $image = $_FILES['image']['name'];
        $text = $_POST['text'];
        $uploader = $_SESSION['username'];
        $name = $_POST['imagename'];

        $sql = "INSERT INTO pictures (image, text, uploader, picname) VALUES ('$image', '$text', '$uploader', '$name')";
        mysqli_query($db,$sql);

        if (move_uploaded_file($_FILES['image']['tmp_name'], $target)){
            $msg = "Image uploaded succesfully!<br> 
                    <a href='index.php'>Check it on the homepage</a>";
            
        } else{
            $msg = "There was a problem during the upload, try again";
        }
        echo "<div id='succesmsg'>";
            echo ("$msg");
        echo "</div>";
        
    }

?>




<!DOCTYPE html>
<html>
<head>
    <title>Image upload</title>
    <link rel="stylesheet" type="text/css" href="style2.css">
</head>
<body>
        <form method="POST" action="upload.php" enctype="multipart/form-data">
            <input type="hidden" name="size" value="100000">
            <div>
                <input type="file" required="" name="image">
            </div>
            <div>
                <label> Name of the picture </labe> <br>
                <input type="text" required="" name="imagename">
            </div>
            <div class="tarea">
                <textarea name="text" required="" cols="40" rows="4" placeholder="Says something about the image"></textarea>
            </div>
            <div class="btn">
                <input type="submit"  name="upload" value="Upload image">
            </div>
        </form>
        <div class="howto">
            <p> 1.st step: Choose an image </p>
            <p> 2.nd step: Give a description of the picture </p>
            <P> 3.rd step: Click to the "Upload image" button </p>
        </div>
</body>
</html>