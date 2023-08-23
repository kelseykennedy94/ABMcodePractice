<?php
echo "1-100 Prime: \n";
function isPrime($num) {
    if ($num <= 1) {
        return false;
    }
    for ($d = 2; $d <= sqrt($num); $d++) {  // Corrected $c to $d here
        if ($num % $d == 0) {
            return false;
        }
    }
    return true;
}
for ($d = 2; $d <= 100; $d++) {  // Corrected $c to $d here
    if (isPrime($d)) {
        echo $d . " ";
    }
}
?>