import java.io.BufferedWriter;
import java.io.FileWriter;
import java.io.IOException;

public class main {

    public static void main(String args[]) throws IOException {

        BufferedWriter out = new BufferedWriter(new FileWriter("Numbers.txt"));
        calculations calculations = new calculations();
        int number = 0;
        boolean prime;

        while (true){
            number++;
            calculations.primeFinder(number);
            prime = calculations.getPrime();

            if (prime){
                System.out.println(number + " is a prime number.");
                out.write(number + " is a prime number");
                out.newLine();
            }
        }
    }

}
