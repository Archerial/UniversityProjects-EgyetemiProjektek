<?php include('server.php'); 
    if (empty($_SESSION['username'])){
        header('location: login.php');
    }

?>
<?php include('_hamburger.php');?>

<!DOCTYPE html>
<html>
<head>
    <title>My pictures</title>
    <link rel="stylesheet" type="text/css" href="style.css">
</head>
<body>


    <div class="header">
        <h2> Your pictures: </h2>
    </div>

    <div class="content">
        <?php if (isset($_SESSION['succes'])): ?>
            <div class="error succes">
                <h3>
                    <?php 
                        echo $_SESSION['succes'];
                        unset($_SESSION['succes']);
                    ?>
                </h3>
            </div>
        <?php endif ?>
        
        <?php  
            $user = $_SESSION['username'];
            $db = mysqli_connect("localhost", "root", "", "aawebprog");
            $sql = "SELECT COUNT(uploader) FROM `pictures` WHERE uploader = '$user'";
            $result = mysqli_query($db,$sql);
            $row = mysqli_fetch_assoc($result);
            foreach ($row as $r){
                if ($r > 0){
                    echo "<div id='yourpics'>";
                        echo "Here you can find your pictures:";
                     echo "</div>";
                } else{
                    echo "<div id='yourpics'>";
                        echo "You not uploaded yet! <br>";
                        echo "<a href='upload.php'> Upload now </a>";
                     echo "</div>";
                    
                }
            }
            
        ?>

        <?php if (isset($_SESSION["username"])): ?>
            <?php 
            $user = $_SESSION['username'];
        $db = mysqli_connect("localhost", "root", "", "aawebprog");
        $sql = "SELECT * FROM pictures WHERE uploader = '$user'";
        $result = mysqli_query($db,$sql);
        while ($row = mysqli_fetch_array($result)) {
        echo "<div id='picandtext'>";
            echo "<div id='img_div'>";
                echo "<img src='images/".$row['image']."' >"; 
            echo "</div>";
            echo "<div id='text_div'>";
                echo "<p>" .$row['text']. "</p>";
            echo "</div>";
        echo "</div>";
        }
    ?>
        <?php endif ?>

        <?php
    if (isset($_POST['delete'])){
        $uploader = $_SESSION['username'];
         $db = mysqli_connect("localhost", "root", "", "aawebprog");
         $sql = "DELETE FROM pictures WHERE uploader = '$uploader'";
         $result = mysqli_query($db,$sql);
         if($result) {
         echo "<div id='succesdelete'>";
            echo ("Sikeres törlés");
        echo "</div>";}
        } 
    ?>
    </div>

    
</body>

<div class="formbtn">
    <form method="POST" action="userpics.php">
                <button type="submit" name="delete" class="btn">Delete all</button>
        </form>
    </div>
</html>

