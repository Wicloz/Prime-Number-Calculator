#include <iostream>
#include <fstream>
#include <string>
using namespace std;
bool PrimeCheck(int pnumber);

int main()
{
    ofstream file1;
    string line;
    bool prime;
    int number = 0;

    file1.open("Numbers.txt");
    while (true){
        number++;
        prime = PrimeCheck(number);
        if (prime == true){
        cout << number << " is a prime number." << endl;
        file1 << number << " is a prime number." << endl;
        }
    }
file1.close();
return 0;
}

bool PrimeCheck(int pnumber){

    int dnumber = (pnumber / 2);
    bool prime = true;

    if (pnumber % 2 == 0 && pnumber >= 10){
        dnumber = 0;
        prime = false;
    }

    while (dnumber > 1) {
        int rest = pnumber % dnumber;
        if (rest == 0) {
            dnumber = 0;
            prime = false;
        }

        dnumber--;
    }
return prime;
}
