#include <iostream>
#include <string>

using namespace std;
int main()
{
	
	int a; //Definicja zmiennej a
	a = 45; //Zainicjowanie zmiennej a
	double b = 3.14; //Definicja zmiennej b i zainicjowanie jej wartoscia 3.14
	//wskazniki sa zmiennymi, ktore przechowuja adresy innych zmiennych
	//nazwa tablicy przechowuje adres pierwszego elementu tablicy
	int c = 12;
	int* pa; //Definicja wskaznika pa
	cout << "Wartosc zmiennej a: " << a << endl; //Wyswietlenie wartosci zmiennej a
	cout << "Adres zmiennej a: " << &a << endl; //Wyswietlenie adres zmiennej a
	//cout << "Wartosc wskaznika pa: " << pa << endl; //Wyswietlenie wartosci wskaznika pa
	//inicjalizacja wskaznika pa
	pa = &a;
	//pa = &b;
	cout << "Wartosc wskaznika pa: " << pa << endl; //Wyswietlenie wartosci wskaznika pa
	cout << "Wartosc na ktora wskazuje pa: " << *pa << endl; //Wyswietlenie wartosci zmiennej a
	*pa = 100; //Zmiana wartosci zmiennej a przez wskaznik pa
	//pa = &c;
	cout << "Wartosc zmiennej a: " << a << endl; //Wyswietlenie wartosci zmiennej a
	return 0;
}