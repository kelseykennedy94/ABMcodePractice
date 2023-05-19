import java.util.*;

public class MenuSelection {
    private static Map<Integer, String> continentMap;
    private static Map<String, Map<Integer, String>> countryMap;
    private static Map<String, Map<Integer, List<String>>> provinceMap;
    private static Map<String, Map<Integer, List<String>>> cityMap;

    public static void load() {
        continentMap = new HashMap<>();
        countryMap = new HashMap<>();
        provinceMap = new HashMap<>();
        cityMap = new HashMap<>();

        continentMap.put(1, "North America");
        continentMap.put(2, "Europe");

        Map<Integer, String> northAmericaCountries = new HashMap<>();
        northAmericaCountries.put(1, "Canada");
        northAmericaCountries.put(2, "United States");
        countryMap.put("North America", northAmericaCountries);

        Map<Integer, String> europeCountries = new HashMap<>();
        europeCountries.put(1, "United Kingdom");
        europeCountries.put(2, "Germany");
        countryMap.put("Europe", europeCountries);

        Map<Integer, List<String>> canadaProvinces = new HashMap<>();
        List<String> canadaProvinceList = new ArrayList<>();
        canadaProvinceList.add("British Columbia");
        canadaProvinceList.add("Alberta");
        canadaProvinces.put(1, canadaProvinceList);
        provinceMap.put("Canada", canadaProvinces);

        Map<Integer, List<String>> bcCities = new HashMap<>();
        List<String> bcCityList = new ArrayList<>();
        bcCityList.add("Vancouver");
        bcCityList.add("Kelowna");
        bcCityList.add("Victoria");
        bcCityList.add("Nanaimo");
        bcCities.put(1, bcCityList);
        cityMap.put("British Columbia", bcCities);

        Map<Integer, List<String>> albertaCities = new HashMap<>();
        List<String> albertaCityList = new ArrayList<>();
        albertaCityList.add("Calgary");
        albertaCityList.add("Edmonton");
        albertaCityList.add("Red Deer");
        albertaCityList.add("Lethbridge");
        albertaCities.put(2, albertaCityList);
        cityMap.put("Alberta", albertaCities);

        Map<Integer, List<String>> usaStates = new HashMap<>();
        List<String> usaStateList = new ArrayList<>();
        usaStateList.add("New York");
        usaStateList.add("California");
        usaStates.put(2, usaStateList);
        provinceMap.put("United States", usaStates);

        Map<Integer, List<String>> ukProvinces = new HashMap<>();
        List<String> ukProvinceList = new ArrayList<>();
        ukProvinceList.add("England");
        ukProvinceList.add("Scotland");
        ukProvinces.put(1, ukProvinceList);
        provinceMap.put("United Kingdom", ukProvinces);

        Map<Integer, List<String>> germanyProvinces = new HashMap<>();
        List<String> germanyProvinceList = new ArrayList<>();
        germanyProvinceList.add("Bavaria");
        germanyProvinceList.add("Berlin");
        germanyProvinces.put(1, germanyProvinceList);
        provinceMap.put("Germany", germanyProvinces);

        Map<Integer, List<String>> englandCities = new HashMap<>();
        List<String> englandCityList = new ArrayList<>();
        englandCityList.add("London");
        englandCityList.add("Manchester");
        englandCityList.add("Birmingham");
        englandCities.put(1, englandCityList);
        cityMap.put("England", englandCities);

        Map<Integer, List<String>> scotlandCities = new HashMap<>();
        List<String> scotlandCityList = new ArrayList<>();
        scotlandCityList.add("Edinburgh");
        scotlandCityList.add("Glasgow");
        scotlandCityList.add("Aberdeen");
        scotlandCities.put(2, scotlandCityList);
        cityMap.put("Scotland", scotlandCities);

        Map<Integer, List<String>> bavariaCities = new HashMap<>();
        List<String> bavariaCityList = new ArrayList<>();
        bavariaCityList.add("Munich");
        bavariaCityList.add("Nuremberg");
        bavariaCityList.add("Augsburg");
        bavariaCities.put(1, bavariaCityList);
        cityMap.put("Bavaria", bavariaCities);

        Map<Integer, List<String>> berlinCities = new HashMap<>();
        List<String> berlinCityList = new ArrayList<>();
        berlinCityList.add("Berlin City Center");
        berlinCityList.add("Charlottenburg");
        berlinCityList.add("Prenzlauer Berg");
        berlinCities.put(2, berlinCityList);
        cityMap.put("Berlin", berlinCities);

        Map<Integer, List<String>> newyorkCities = new HashMap<>();
        List<String> newyorkCityList = new ArrayList<>();
        newyorkCityList.add("New York City");
        newyorkCityList.add("Buffalo");
        newyorkCityList.add("Rochester");
        newyorkCities.put(1, newyorkCityList);
        cityMap.put("New York", newyorkCities);

        Map<Integer, List<String>> californiaCities = new HashMap<>();
        List<String> californiaCityList = new ArrayList<>();
        californiaCityList.add("Los Angeles");
        californiaCityList.add("San Francisco");
        californiaCityList.add("San Diego");
        californiaCities.put(2, californiaCityList);
        cityMap.put("California", californiaCities);
    }

    public static void main(String[] args) {
        load();
        Scanner scanner = new Scanner(System.in);

        boolean startAgain = true;
        while (startAgain) {
            System.out.println("Area:");
            for (Map.Entry<Integer, String> entry : continentMap.entrySet()) {
                System.out.println(entry.getKey() + ". " + entry.getValue());
            }

            System.out.print("Enter the number of your continent: ");
            int continentNumber = scanner.nextInt();
            scanner.nextLine();

            String continent = continentMap.get(continentNumber);
            if (continent != null) {
                Map<Integer, String> countries = countryMap.get(continent);

                System.out.println("\nSubArea in " + continent + ":");
                for (Map.Entry<Integer, String> entry : countries.entrySet()) {
                    System.out.println(entry.getKey() + ". " + entry.getValue());
                }

                System.out.print("Enter the number of your country: ");
                int countryNumber = scanner.nextInt();
                scanner.nextLine();

                String country = countries.get(countryNumber);
                if (country != null) {
                    Map<Integer, List<String>> provinces = provinceMap.get(country);

                    System.out.println("\nProvinces/States in " + country + ":");
                    for (Map.Entry<Integer, List<String>> entry : provinces.entrySet()) {
                        List<String> provinceList = entry.getValue();
                        for (int i = 0; i < provinceList.size(); i++) {
                            System.out.println((i + 1) + ". " + provinceList.get(i));
                        }
                    }

                    System.out.print("Enter the number of your province/state: ");
                    int provinceNumber = scanner.nextInt();
                    scanner.nextLine();

                    List<String> selectedProvinceList = provinces.get(provinceNumber);
                    if (selectedProvinceList != null) {
                        String province = selectedProvinceList.get(provinceNumber - 1);
                        Map<Integer, List<String>> cities = cityMap.get(province);

                        System.out.println("\nCities in " + province + ":");
                        for (Map.Entry<Integer, List<String>> entry : cities.entrySet()) {
                            List<String> cityList = entry.getValue();
                            for (int i = 0; i < cityList.size(); i++) {
                                System.out.println((i + 1) + ". " + cityList.get(i));
                            }
                        }

                        System.out.print("Enter the number of your city: ");
                        int cityNumber = scanner.nextInt();
                        scanner.nextLine();

                        List<String> selectedCityList = cities.get(cityNumber);
                        if (selectedCityList != null) {
                            String city = selectedCityList.get(cityNumber - 1);
                            System.out.println("\nSelected city: " + city);
                        } else {
                            System.out.println("Invalid city number!");
                        }
                    } else {
                        System.out.println("Invalid province/state number!");
                    }
                } else {
                    System.out.println("Invalid country number!");
                }
            } else {
                System.out.println("Invalid continent number!");
            }

            System.out.print("\nWould you like to start again? (Y/N): ");
            String choice = scanner.nextLine();
            if (!choice.equalsIgnoreCase("Y")) {
                startAgain = false;
            }
        }
    }
}
