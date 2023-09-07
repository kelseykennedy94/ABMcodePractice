<?php
session_start();

if (isset($_SESSION["username"])) {
    $username = $_SESSION["username"];
} else {
    header("Location: login.php");
    exit;
}
?>

<!DOCTYPE html>
<html>
<head>
    <title>Homepage</title>
</head>
<body>
    <h2>Welcome to the Homepage</h2>
    <?php
    echo "<p>Hello, $username!</p>";
    ?>
    <a href="logout.php">Logout</a>
</body>
</html>
