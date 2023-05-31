public class DataTypeChecker {
    public static void main(String[] args) {
        Object[] values = {"one", 1.3, 1, 'A', true};

        for (Object value : values) {
            if (value instanceof Integer) {
                System.out.println(value + " is an integer.");
            } else if (value instanceof String) {
                System.out.println(value + " is a string.");
            } else if (value instanceof Double) {
                System.out.println(value + " is a double/decimal.");
            } else if (value instanceof Character) {
                System.out.println(value + " is a char.");
            } else if (value instanceof Boolean) {
                System.out.println(value + " is a boolean expression.");
            }
        }
    }
}
