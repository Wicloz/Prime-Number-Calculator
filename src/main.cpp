#include <iostream>
using namespace std;

int main()
{
    int number = 0;
    bool prime;

    while (true){
        number++;

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

        if (prime == true){
        cout << number << " is a prime number." << endl ;
        }
    }
}
