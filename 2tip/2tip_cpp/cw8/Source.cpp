#include <iostream>
#include <string>

using namespace std;
void Hello(int count) {
	cout << "Hello World! przed ifem: count = "<<count << endl;
	if (count > 0)	Hello(--count);//wywo³anie rekurencyjne
	cout << "Hello World! po ifie count = " << count << endl;
}
//3! = 3*2*1 = 6 =  2!*3 = 1!*2*3
//n! = n*(n-1)! = n*(n-1)*(n-2)! = ... = n*(n-1)*(n-2)*...*1
unsigned long SilniaRek(unsigned long n) {
	if (n <= 1) return 1;
	return n * SilniaRek(n - 1);
}

unsigned long SilniaIter(unsigned long n) {
	if (n <= 1) return 1;
	unsigned long wynik = 1;
	for (unsigned long i = 1; i <= n; i++) {
		wynik *= i; //wynik = wynik * i; += , -=, *=, /= 
	}
	return wynik;
}
//NWD iteracyjnie i rekurencyjnie
int main()
{
	Hello(4);
	cout << "Podaj n: ";
	unsigned long n;
	cin >> n;
	cout << n << "! = " << SilniaRek(n) << endl;
	return 0;
}




