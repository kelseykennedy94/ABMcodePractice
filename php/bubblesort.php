<?php
$inputArray = [1, 2, 2, 4, 3, 9, 7, 4, 5, 4, 6, 10, 9, 7, 8, 9, 10, 10, 10, 10];

$newArray = [];
foreach ($inputArray as $number) {
    $isDuplicate = false;
    foreach ($newArray as $uniqueNumber) {
        if ($number === $uniqueNumber) {
            $isDuplicate = true;
            break;
        }
    }
    if (!$isDuplicate) {
        $newArray[] = $number;
    }
}

$length = count($newArray);
for ($i = 0; $i < $length - 1; $i++) {
    for ($j = 0; $j < $length - $i - 1; $j++) {
        if ($newArray[$j] > $newArray[$j + 1]) {
            $temp = $newArray[$j];
            $newArray[$j] = $newArray[$j + 1];
            $newArray[$j + 1] = $temp;
        }
    }
}

echo "Sorted Array: ";
foreach ($newArray as $number) {
    echo $number . " ";
}
?>
