#include <iostream>
#include <fstream>
#include <string>
using namespace std;

int main()
{
    fstream file;
    bool prime;
    int number = 0;
    string line;
    file.open("Numbers.txt");

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
        cout << number << " is a prime number." << endl;
        file << number << " is a prime number." << endl;
        }
    }
}
