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

    int maxn = (pnumber / 2);
    int dnumber = 2;
    bool prime = true;

    while (dnumber <= maxn && dnumber != 0) {
        int rest = pnumber % dnumber;
        if (rest == 0) {
            dnumber = -1;
            prime = false;
        }

        dnumber++;
    }
return prime;
}
