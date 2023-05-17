public class NumberPrinter {
    public static void main(String[] args) {
        printNumbers();
        System.out.println();
        printEvenNumbers();
        System.out.println();
        printOddNumbers();
        System.out.println();
        printMultiplesOfEight();
        System.out.println();
        printNames();
    }
    
    public static void printNumbers() {
        System.out.println("Question One:");
        for (int i = 1; i <= 100; i++) {
            System.out.println(i);
        }
    }
    
    public static void printEvenNumbers() {
        System.out.println("Question Two:");
        for (int i = 1; i <= 100; i++) {
            if (i % 2 == 0) {
                System.out.println(i);
            }
        }
    }
    
    public static void printOddNumbers() {
        System.out.println("Question Three:");
        for (int i = 100; i >= 1; i--) {
            if (i % 2 != 0) {
                System.out.println(i);
            }
        }
    }
    
    public static void printMultiplesOfEight() {
        System.out.println("Question Four:");
        for (int i = 8; i <= 80; i += 8) {
            System.out.println(i);
        }
    }
    
    public static void printNames() {
        System.out.println("Question Five:");
        String[] names = {"Kelsey", "Rownie", "Israa", "Rakesh", "Dmytro"};
        for (String name : names) {
            System.out.println(name);
        }
    }
}
