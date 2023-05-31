public class HelloWorld {
    public static void main(String[] args) {
        String phoneNumber = "1234567890";

        String areaCode = phoneNumber.substring(0, 3);
        String firstNum = phoneNumber.substring(3, 6);
        String lastNum = phoneNumber.substring(6);

        String formatPhoneNum = "+1" + " (" + areaCode + ")-" + firstNum + "-" + lastNum;

        System.out.println(formatPhoneNum);
    }
}
