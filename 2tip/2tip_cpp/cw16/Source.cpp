#include <iostream>
#include <string>
using namespace std;

void copy(int a, int b) {
	int temp = a;
	a = b;
	b = temp;
	cout << "wewnatrz funkcji: a: " << a << " b: " << b << endl;
	cout << "adresy w funkcji: a: " << &a << " b: " << &b << endl;
}
void reference(int& a, int& b) {
	int temp = a;
	a = b;
	b = temp;
	cout << "wewnatrz funkcji: a: " << a << " b: " << b << endl;
	cout << "adresy w funkcji: a: " << &a << " b: " << &b << endl;
}

int main() {
	int a = 5;
	int b = 10;
	cout << "adresy w main: a: " << &a << " b: " << &b << endl;
	cout << "przed funkcja: a: " << a << " b: " << b << endl;
	copy(a, b);
	//reference(a, b);
	cout << "po funkcji: a: " << a << " b: " << b << endl;
	return 0;
}