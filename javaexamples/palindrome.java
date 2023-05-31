public class HelloWorld {
    public static void main(String[] args) {
        int[] arr1 = {1,2,3,4,3,2,1};
        System.out.println(isPalindrome(arr1));
        
        char[] arr2 = {'b','a','s','a','n','t','n','a','s','a','b'};
        System.out.println(isPalindrome(arr2));
        
        int[] arr3 = {5,6,7,8};
        System.out.println(isPalindrome(arr3));
        
        char[] arr4 = {'k','e','l','s','e','y'};
        System.out.println(isPalindrome(arr4));
    }
    
    public static boolean isPalindrome(int[] arr){
        int start = 0;
        int end = arr.length - 1;
        
        while (start < end){
            if (arr[start] != arr[end]){
                return false;
            }
            start++;
            end--;
        }
        return true;
    }
    
    public static boolean isPalindrome(char[] arr){
        int start = 0;
        int end = arr.length - 1;
        
        while (start < end){
            if(arr[start] != arr[end]){
                return false;
            }
            start++;
            end--;
        }
        return true;
    }
}
