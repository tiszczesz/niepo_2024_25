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

void pointers(int* pa,int* pb) {
	//int fake = 0;
	//pa = &fake;
	int temp = *pa;
	*pa = *pb;
	*pb = temp;
	cout << "wewnatrz funkcji: a: " << *pa << " b: " << *pb << endl;
	cout << "adresy w funkcji: a: " << pa << " b: " << pb << endl;
}

int main() {
	int a = 5;
	int b = 10;
	cout << "adresy w main: a: " << &a << " b: " << &b << endl;
	cout << "przed funkcja: a: " << a << " b: " << b << endl;
	//copy(a, b);
	//reference(a, b);
	pointers(&a, &b);
	cout << "po funkcji: a: " << a << " b: " << b << endl;
	return 0;
}