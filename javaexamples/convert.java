import java.math.BigDecimal;

public class HelloWorld {
    
    public static void main(String[] args) {
        String a = "1";
        int convertedInt = Integer.parseInt(a);
        System.out.println("Converted String to int: " + convertedInt);
        
        String strBoolean = "true";
        boolean convertedBoolean = Boolean.parseBoolean(strBoolean);
        System.out.println("Converted String to boolean: " + convertedBoolean);
        
        double number = 1.9;
        int floorValue = (int) Math.floor(number);
        int ceilValue = (int) Math.ceil(number);
        System.out.println("Original Number: " + number);
        System.out.println("Floor Value: " + floorValue);
        System.out.println("Ceil Value: " + ceilValue);
    }
}
