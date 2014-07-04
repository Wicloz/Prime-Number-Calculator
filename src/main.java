import java.io.BufferedWriter;
import java.io.FileWriter;

public class main {

    public static void main(String args[]){

        String file = "Numbers.txt";
//        BufferedWriter out = new BufferedWriter(new FileWriter(file));
        calculations calculations = new calculations();
        int number = 1;
        boolean prime;

        while (true){
            calculations.primeFinder(number);
            prime = calculations.getPrime();
            if (prime){
                System.out.println(number + " is a prime number.");
//            out.write(number + " is a prime number");
            }
            number++;
        }
    }

}
