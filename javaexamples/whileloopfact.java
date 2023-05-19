public class Main {
    public static void main(String[] args) {
        fact(5);
        System.out.println();
        fact(10);
        System.out.println();
        fact(20);
    }

    public static void fact(int n) {
        int i = 1;
        while (i <= n) {
            System.out.print(i + " ");
            i++;
        }
    }
}