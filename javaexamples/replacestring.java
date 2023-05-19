public class Main {
    public static void main(String[] args) {
        String students = "!Basant<;///,Adamma<>>>,Castro<>_Dymtro=Kelsey#Israa||Rakesh//John//\\\\MJ]Jared<WaLID";

        StringBuilder newString = new StringBuilder();
        for (char c : students.toCharArray()) {
            if (Character.isLetter(c) || c == '<' || c == '>') {
                newString.append(c);
            } else if (newString.length() > 0 && newString.charAt(newString.length() - 1) != ' ') {
                newString.append(' ');
            }
        }

        String[] parts = newString.toString().split("<|>");

        for (String part : parts) {
            String name = part.toLowerCase().trim();
            if (!name.isEmpty()) {
                System.out.println(name);
            }
        }
    }
}