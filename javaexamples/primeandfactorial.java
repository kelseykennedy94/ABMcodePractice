public class Main {
    public static void main(String[] args) {
        printPrimeNumbers();
        printFactorial();
    }

    public static void printPrimeNumbers() {
        int i = 2;
        while (i <= 100) {
            boolean isPrime = true;
            int j = 2;
            while (j <= Math.sqrt(i)) {
                if (i % j == 0) {
                    isPrime = false;
                    break;
                }
                j++;
            }
            if (isPrime) {
                System.out.print(i + " ");
            }
            i++;
        }
    }
    
    public static void printFactorial() {
        int number = 5;
        int factorial = 1;
        int i = 1;
        while (i <= number) {
            factorial *= i;
            i++;
        }
        System.out.println("Factorial of " + number + " = " + factorial);
    }
}
