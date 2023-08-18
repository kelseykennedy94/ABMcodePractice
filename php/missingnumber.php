<?php
$start = 1;
$end = 50;
$removed = 37;

$numbersCount = [];
for ($i = $start; $i <= $end; $i++) {
    if ($i !== $removed) {
        $numbersCount[] = $i;
    }
}

$missingNumber = null;

foreach ($numbersCount as $number) {
    if ($missingNumber !== null && $number !== $missingNumber + 1) {
        $missingNumber = $missingNumber + 1;
        break;
    }
    
    $missingNumber = $number;
}

echo "Missing number: " . $missingNumber;
?>