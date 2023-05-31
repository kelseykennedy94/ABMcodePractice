import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class HelloWorld {
    public static void main(String[] args) {
        String address = "1113 Greenberir Dr, Waterloo, ON, N2L 4B3";

        String[] parts = address.split(",");

        List<String> addressItems = new ArrayList<>(Arrays.asList(parts));

        List<String> provinces = Arrays.asList("AB", "BC", "SK", "ON", "QB");

        for (String province : provinces) {
            if (address.contains(province)) {
                addressItems.add("CANADA");
            }
        }

        for (String item : addressItems) {
            System.out.println(item.trim());
        }
    }
}