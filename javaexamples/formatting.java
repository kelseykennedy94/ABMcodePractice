import java.text.DecimalFormat;

public class HelloWorld {
    
    public static void main(String[] args) {
        double number = 1.2456789;
        
        String formattedNum1 = formatUsingStringFormatting(number);
        System.out.println("String Formatting: " + formattedNum1);
        
        String formattedNum2 = formatUsingDecimalFormat(number);
        System.out.println("Decimal Formatting: " + formattedNum2);
    }
    
    public static String formatUsingStringFormatting(double number) {
        return String.format("%.2f", number);
    }
    
    public static String formatUsingDecimalFormat(double number) {
        DecimalFormat decimalFormat = new DecimalFormat("#.##");
        return decimalFormat.format(number);
    }
}
