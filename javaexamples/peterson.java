import java.util.Scanner;

public class PetersonNumber {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int number;
        while (true) {
            System.out.print("Enter a number: ");
            number = scanner.nextInt();
            if (number == -1) {
                break;
            }
            if (isPetersonNumber(number)) {
                System.out.println(number + " is a Peterson number");
            } else {
                System.out.println(number + " is not a Peterson number");
            }
        }

        scanner.close();
    }

    private static boolean isPetersonNumber(int number) {
        int sum = 0;
        int i = number;

        while (i > 0) {
            int digit = i % 10;
            sum += factorial(digit);
            i /= 10;
        }

        return sum == number;
    }

    private static int factorial(int n) {
        int result = 1;
        for (int i = 2; i <= n; i++) {
            result *= i;
        }
        return result;
    }
}
