public class javaExamples {
    public static void main(String[] args) {
        int number = 5;
        int factorial = 1;

        for (int i = number; i >= 1; i--) {
            factorial *= i;
        }

        System.out.println(number + " factorial = " + factorial);
    }
}

public class ArraySumCalculator {
    public static void main(String[] args) {
        int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        int sum = calculateArraySum(numbers);

        System.out.println("Sum of the array: " + sum);
    }

    public static int calculateArraySum(int[] arr) {
        int sum = 0;
        for (int num : arr) {
            sum += num;
        }
        return sum;
    }
}


