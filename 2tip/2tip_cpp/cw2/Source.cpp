#include <iostream>
#include <string>

using namespace std;
void cw1();//naglowek funkcji -> deklaracja
void cw2();
int main() {
	//cw1();
	cw2();
	return 0;
}

void cw1() {
	cout << "Podaj liczbe: ";
	int a; //deklaracja;
	cin >> a;
	if(a>0) {
		cout << " a jest dodatnie" << endl;
	}else if(a<0) {
		cout << " a jest ujemne" << endl;
	}else {
		cout << " a jest zero" << endl;
	}
	cout << "a = " << a << endl;
}
void cw2() {
	//kalkulator + - * /
	cout << "Podaj liczbe a : ";
	int a; 
	cin >> a;
	cout << "Podaj liczbe b : ";
	int b; 
	cin >> b;
	cout << a << " + " << b << " = " << (a + b) << endl;
	cout << a << " - " << b << " = " << (a - b) << endl;
	cout << a << " * " << b << " = " << (a * b) << endl;
	if(b!=0) {
			cout << a << " / " << b << " = "
		      << ((double)a / b) << endl;
	}else {
		cout << a << " / " << b << " = BRAK Wyniku \n";
	}
	cout << a << " + " << b << " = "
	  << (b!=0 ? to_string((double) a / b )
		   : " Brak wyniku") << endl;

}