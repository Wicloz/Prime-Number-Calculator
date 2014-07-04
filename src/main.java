
public class main {
    public static void main(String args[]){

        calculations calculations = new calculations();
        int number = 1;

        while (number < 1000){
            calculations.primeFinder(number);
            number++;
        }

    }
}
