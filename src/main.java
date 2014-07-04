

public class main {
    public static void main(String args[]){

        calculations calculations = new calculations();
        int number = 1;

        while (true){
            calculations.primeFinder(number);
            number++;
        }

    }
}
