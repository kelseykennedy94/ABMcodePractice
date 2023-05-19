public class Main {
    public static void main(String[] args) {
        printEven();
        printOdd();
    }

    public static void printEven() {
        int i = 2;
        while (i <= 100) {
            System.out.print(i + " ");
            i += 2;
        }
    }

    public static void printOdd() {
        int i = 1;
        while (i <= 100) {
            System.out.print(i + " ");
            i += 2;
        }
    }
}