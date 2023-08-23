<?php
$courseCap = 1;
$courseIn = 0;

class Course {
    public $student = "error";
    
    public function __construct($student) {
        $this->student = $student;
        
        global $courseIn;
        global $courseCap;
        
        if ((int)$courseIn < (int)$courseCap) {
            echo "$student in \n";
            $courseIn++;
        } else {
            echo "$student out";
        }
    }
}

$eric = new Course('eric');
$rownie = new Course('rownie');
?>
