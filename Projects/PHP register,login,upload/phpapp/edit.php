<?php include('server.php'); 
    if (empty($_SESSION['username'])){
        header('location: login.php');
    }

?>
<?php include('_hamburger.php');?>

<!DOCTYPE html>
<html>
<head>
    <title>Edit pictures</title>
    <link rel="stylesheet" type="text/css" href="style.css">
</head>
<body>

<?php 
    if (isset($_POST['update'])){
        $picname = $_POST['editpicname'];
        $newtext = $_POST['edittext'];
        $db = mysqli_connect("localhost", "root", "", "aawebprog");
         $sql = "UPDATE pictures SET text='$newtext' WHERE picname = '$picname'";
         $result = mysqli_query($db,$sql);
         if($result) {
         echo "<div id='succesdelete'>";
            echo ("Sikeres módosítás");
        echo "</div>";}
    } 
    ?>

<?php 
    if (isset($_POST['deleteone'])){
        $deletepic = $_POST['deletepic'];
        $db = mysqli_connect("localhost", "root", "", "aawebprog");
         $sql = "DELETE FROM pictures WHERE picname = '$deletepic'";
         $result = mysqli_query($db,$sql);
         if($result) {
         echo "<div id='succesdelete'>";
            echo ("Sikeres módosítás");
        echo "</div>";}
    } 
    ?>

<?php if (isset($_POST['deleteall'])){
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






    <div class="header">
        <h2> Edit pictures </h2>
        
    </div>

    <div class="edittext">
    <form method="POST" action="edit.php">
        <label> Name of the picture what you want to update </label><br>
        <input type="text" name="editpicname" required=""><br><br>
        <label> The new text </label><br>
        <input type="text" name="edittext" required=""><br><br>
        <button type="submit" name="update" class="btn">Edit text</button>
    </div>
    </form>
     <div class="deleteone">
        <form method="POST" action="edit.php">
     <label> Name of the picture what you want to delete </label><br>
        <input type="text" name="deletepic" required=""><br><br>
        <button type="submit" name="deleteone" class="btn">Delete</button>
        </form>
        </div>
        
     <div class="deleteall">
        <form method="POST" action="edit.php">
            <label> Delete all of your pictures!!! </label><br><br>
            <button type="submit" name="deleteall" class="btn">Delete all</button>
        </form>
    </div>

    <div class="list">
        <form method="POST" action="edit.php">
        <p> You don't remember the name of a picutre? </p>
        <button type="submit" name="showme" class="btn">Show me</button>

    <?php if (isset($_POST['showme'])){
        $owner = $_SESSION['username'];
         $db = mysqli_connect("localhost", "root", "", "aawebprog");
         $sql = "SELECT picname FROM pictures WHERE uploader = '$owner'";
         $result = mysqli_query($db,$sql);
         while ($row = mysqli_fetch_array($result)) {
            echo "<div id='show'>";
            echo "<p>" .$row['picname']. "</p>";
            echo "</div>";
        }
    } ?>

    
</div>
    
</body>
</html>