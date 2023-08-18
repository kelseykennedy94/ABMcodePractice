<?php
$inputArray = [1, 2, 2, 4, 3, 9, 7, 4, 5, 4, 6, 10, 9, 7, 8, 9, 10, 10, 10, 10];

$newArray = array_unique($inputArray);

sort($newArray);

echo "Sorted Array: ";
foreach ($newArray as $number) {
    echo $number . " ";
}
?>