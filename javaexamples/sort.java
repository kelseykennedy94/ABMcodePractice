import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class StringManipulation {
    public static void main(String[] args) {
        List<String> names = new ArrayList<>();
        names.add("israa");
        names.add("basant");
        names.add("MJ");
        names.add("kelSEY");
        names.add("rownie");
        names.add("Israa");
        names.add("BASANT");

        List<String> uniqueNames = new ArrayList<>();
        for (String name : names) {
            String formattedName = formatName(name);
            if (!uniqueNames.contains(formattedName)) {
                uniqueNames.add(formattedName);
            }
        }

        Collections.sort(uniqueNames);

        for (int i = 0; i < uniqueNames.size(); i++) {
            String name = uniqueNames.get(i);
            uniqueNames.set(i, (i + 1) + ". " + name);
        }

        for (String name : uniqueNames) {
            System.out.println(name);
        }
    }

    public static String formatName(String name) {
        String formattedName = name.substring(0, 1).toUpperCase() + name.substring(1).toLowerCase();
        return formattedName;
    }
}
