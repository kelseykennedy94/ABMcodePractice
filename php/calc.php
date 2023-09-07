<?php
interface CalculatorInterface {
    public function calculate($a, $b, $operation);
}

class Calculator implements CalculatorInterface {
    public function calculate($a, $b, $operation) {
        switch ($operation) {
            case 'add':
                return $a + $b;
            case 'subtract':
                return $a - $b;
            case 'multiply':
                return $a * $b;
            case 'divide':
                if ($b != 0) {
                    return $a / $b;
                } else {
                    return "division by zero is not allowed.";
                }
            case 'modulus':
                if ($b != 0) {
                    return $a % $b;
                } else {
                    return "modulus by zero is not allowed.";
                }
            default:
                return "invalid operation.";
        }
    }
}

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $a = $_POST["num1"];
    $b = $_POST["num2"];
    $operation = $_POST["operation"];

    $calculator = new Calculator();
    $result = $calculator->calculate($a, $b, $operation);
}
?>

<!DOCTYPE html>
<html>
<head>
    <title>Calculator</title>
</head>
<body>
    <h2>Calculator</h2>
    <form method="POST" action="">
        <input type="number" name="num1" placeholder="Enter number 1" required>
        <select name="operation">
            <option value="add">+</option>
            <option value="subtract">-</option>
            <option value="multiply">*</option>
            <option value="divide">/</option>
            <option value="modulus">%</option>
        </select>
        <input type="number" name="num2" placeholder="Enter number 2" required>
        <input type="submit" value="Calculate">
    </form>
    <?php
    if (isset($result)) {
        echo "<p>Result: $result</p>";
    }
    ?>
</body>
</html>
