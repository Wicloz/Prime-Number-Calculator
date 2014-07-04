
public class calculations {
    private boolean prime;

    public void primeFinder(int number){

        int dnumber = (number / 2);
        prime = true;

        if (number % 2 == 0 && number >= 10){
            dnumber = 0;
            prime = false;
        }

        while (dnumber > 1) {
            int rest = number % dnumber;
            if (rest == 0) {
                dnumber = 0;
                prime = false;
            }
            dnumber--;
        }
    }

    public boolean getPrime(){
        return prime;
    }

}
