import java.util.*;

public class McDonaldsMenu {
    private static Map<String, Map<Integer, String>> menuMap;
    private static Map<String, Map<String, Double>> priceMap;

    public static void load() {
        menuMap = new HashMap<>();
        priceMap = new HashMap<>();

        Map<Integer, String> ontarioMenu = new HashMap<>();
        ontarioMenu.put(1, "Big Mac");
        ontarioMenu.put(2, "Quarter Pounder");
        ontarioMenu.put(3, "McChicken");
        menuMap.put("Ontario", ontarioMenu);

        Map<Integer, String> albertaMenu = new HashMap<>();
        albertaMenu.put(1, "Cheeseburger");
        albertaMenu.put(2, "Filet-O-Fish");
        albertaMenu.put(3, "Chicken McNuggets");
        menuMap.put("Alberta", albertaMenu);

        Map<Integer, String> bcMenu = new HashMap<>();
        bcMenu.put(1, "McDouble");
        bcMenu.put(2, "McChicken");
        bcMenu.put(3, "Chicken McNuggets");
        menuMap.put("British Columbia", bcMenu);

        Map<String, Double> ontarioPrices = new HashMap<>();
        ontarioPrices.put("Big Mac", 20.0);
        ontarioPrices.put("Quarter Pounder", 18.0);
        ontarioPrices.put("McChicken", 15.0);
        priceMap.put("Ontario", ontarioPrices);

        Map<String, Double> albertaPrices = new HashMap<>();
        albertaPrices.put("Cheeseburger", 16.0);
        albertaPrices.put("Filet-O-Fish", 17.0);
        albertaPrices.put("Chicken McNuggets", 13.0);
        priceMap.put("Alberta", albertaPrices);

        Map<String, Double> bcPrices = new HashMap<>();
        bcPrices.put("McDouble", 14.0);
        bcPrices.put("McChicken", 15.0);
        bcPrices.put("Chicken McNuggets", 13.0);
        priceMap.put("British Columbia", bcPrices);
    }

    public static void main(String[] args) {
        load();

        Scanner scanner = new Scanner(System.in);

        System.out.print("Enter your province: ");
        String province = scanner.nextLine();

        if (menuMap.containsKey(province)) {
            Map<Integer, String> menuItems = menuMap.get(province);

            System.out.println("\nMcDonald's Menu for " + province + ":");
            for (Map.Entry<Integer, String> entry : menuItems.entrySet()) {
                System.out.println(entry.getKey() + ". " + entry.getValue());
            }

                System.out.println("\nOrder details:");
                System.out.println("-----------------------------------");
                double totalAmount = 0.0;

                System.out.print("Enter the name of person A: ");
                String personA = scanner.nextLine();
System.out.print("Enter the name of person B: ");
String personB = scanner.nextLine();

Map<String, Double> provincePrices = priceMap.get(province);

Map<String, Double> personAOrder = new HashMap<>();
Map<String, Double> personBOrder = new HashMap<>();

System.out.println("\nPerson A's order:");
for (Map.Entry<Integer, String> entry : menuItems.entrySet()) {
    String menuItem = entry.getValue();
    double price = provincePrices.get(menuItem);
    System.out.print("Enter the quantity of " + menuItem + " for Person A: ");
    int quantity = scanner.nextInt();
    scanner.nextLine();
    double itemTotal = price * quantity;
    personAOrder.put(menuItem, itemTotal);
    totalAmount += itemTotal;
}

System.out.println("\nPerson B's order:");
for (Map.Entry<Integer, String> entry : menuItems.entrySet()) {
    String menuItem = entry.getValue();
    double price = provincePrices.get(menuItem);
    System.out.print("Enter the quantity of " + menuItem + " for Person B: ");
    int quantity = scanner.nextInt();
    scanner.nextLine();
    double itemTotal = price * quantity;
    personBOrder.put(menuItem, itemTotal);
    totalAmount += itemTotal;
}

System.out.println("\nOrder Summary:");
System.out.println("-----------------------------------");
for (Map.Entry<String, Double> entry : personAOrder.entrySet()) {
    String menuItem = entry.getKey();
    double price = entry.getValue();
    System.out.println(personA + "\t\t" + menuItem + "\t$" + price);
}
for (Map.Entry<String, Double> entry : personBOrder.entrySet()) {
    String menuItem = entry.getKey();
    double price = entry.getValue();
    System.out.println(personB + "\t\t" + menuItem + "\t$" + price);
}

double serviceTax = totalAmount * 0.1;
double gst = totalAmount * 0.05;
double grandTotal = totalAmount + serviceTax + gst;

System.out.println("-----------------------------------");
System.out.println("Total Amount: $" + totalAmount);
System.out.println("Service Tax (10%): $" + serviceTax);
System.out.println("GST (5%): $" + gst);
System.out.println("Grand Total: $" + grandTotal);

} else {
System.out.println("No McDonald's menu found for " + province);
}
}
}


