import java.io.BufferedWriter;
import java.io.FileWriter;

public class calculations {
    public void primeFinder(int number) {

        String file = "Numbers.txt";
//        BufferedWriter out = new BufferedWriter(new FileWriter(file));

        int dnumber = (number / 2) + 1;
        boolean prime = true;

        while (dnumber > 1) {
            int rest = number % dnumber;
            if (rest == 0) {
                dnumber = 0;
                prime = false;
            }
            dnumber--;
        }

        if (prime){
            System.out.println(number + " is a prime number.");
//            out.write(number + " is a prime number");
        }

    }
}
