#include <iostream>
#include <string>

using namespace std;

int main() {
	//utworzyc zmienna a i b typu double
	//dwa wskazniki pa pb do a i b
	//wykonac dodawanie wartosci z a i b ale bez uzycia a i b (a+b)
	double a{ 5.6 };
	double b{ 15.2 }; //a + b = 20.8
	double* pa = &a;
	double* pb = &b;	
	cout << (*pa) + (*pb) << endl;
	double tab[] = { 1.2, 3.4, 5.6, 7.8, 9.0 };
	//double* ptab = tab;
	cout << tab << endl;
	cout << *tab << endl;
	cout << *(tab + 1) << endl;
	cout << tab[1] << endl; //to samo co *(tab + 1)
	for (int i=0;i<5;i++) {
		cout << *(tab + i) << endl; //uzycie jawne zapisu wskaznikowego
		cout << tab[i] << endl;//uzycie jawne zapisu tablicowego
	}
	int* tab2[2]; //tablica wskaznikow na int
	double* tab3[5]; //tablica wskaznikow na double
	for (int i=0;i<5;i++) {
		tab3[i] = &tab[i];
	}
	for (int i = 0; i < 5; i++) {
		cout << tab3[i] << endl;
	}
	cout << "----------------" << endl;
	cout << *tab3[0] << endl;
	cout << *tab3 << endl;
	return 0;
}