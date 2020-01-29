<?php include('server.php'); 
    if (empty($_SESSION['username'])){
        header('location: login.php');
    }

?>
<?php include('_hamburger.php'); ?>
<!DOCTYPE html>
<html>
<head>
    <title>HomePage</title>
    <link rel="stylesheet" type="text/css" href="style.css">
</head>
<body>


    <div class="header">
        <h2> Home page </h2>
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
        <div class="welcome">

        <?php if (isset($_SESSION["username"])): ?>
            <p>Welcome <strong><?php echo $_SESSION['username']; ?></strong></p> 
        <?php endif ?>

        <?php  
            $user = $_SESSION['username'];
            $db = mysqli_connect("localhost", "root", "", "aawebprog");
            $sql = "SELECT COUNT(uploader) FROM `pictures`";
            $result = mysqli_query($db,$sql);
            $row = mysqli_fetch_assoc($result);
            foreach ($row as $r){
                if ($r > 0){
                    echo "<div id='welcommsg'>";
                        echo "Here you can find the pictures what the others upload:";
                     echo "</div>";
                } else{
                    echo "<div id='welcommsg'>";
                        echo "Seems, nobody uploaded pictures. <br>";
                        echo "<a href='upload.php'> Be the first! </a>";
                     echo "</div>";
                    
                }
            }
            
        ?>


        </div>
        
        <div id="content2">

    <?php 
        $db = mysqli_connect("localhost", "root", "", "aawebprog");
        $sql = "SELECT * FROM pictures";
        $result = mysqli_query($db,$sql);
        $user = $_SESSION['username'];
        while ($row = mysqli_fetch_array($result)) {
        echo "<div id='picandtext'>";
            echo "<div id='owner'>";
                echo "<p> Uploader: " .$row['uploader']. "</p>";
            echo "</div>";
            echo "<div id='img_div'>";
                echo "<img src='images/".$row['image']."' >"; 
            echo "</div>";
            echo "<div id='text_div'>";
                echo "<p>" .$row['text']. "</p>";
            echo "</div>";
        echo "</div>";
        }
    ?>



     
</body>
</html>