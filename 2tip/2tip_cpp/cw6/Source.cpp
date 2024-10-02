#include <iostream>
#include <string>
#include "functions.h"
using namespace std;

int main() {
	const int MAXSIZE = 5000;	
	int tab[MAXSIZE];

	//napisac funkcje ktora zwraca rozmiar miedzy 0 a MAXSIZE
	int size = GetSize(MAXSIZE);

	//napisaæ funkcjê, która wype³ni tablicê liczbami losowymi
	//w zakresie od 0 do 100
	FillTab(tab, size);
	//napisaæ funkcjê, która wypisze tablicê
	ShowTab(tab, size);
	Show("To jest z funkcji: Hello World!");//uzycie funkcji z pliku functions.h
	//napisac funkcje ktora sprawdzi ile jest liczb o okreslonej wrtosci
	//w tablicy
	// HowMany(tab, size, 5); ---> int
	cout << "Podaj liczbe do sprawdzenia: ";
	int number;
	cin >> number;
	cout << "Liczba " << number << " wystepuje "
	      << HowMany(tab, size, number) << " razy." << endl;


	//Hello();//uzycie funkcji z pliku functions.cpp
	//napisac funkcje ktora sprawdzi wszystkie liczby z tablicy tab1
	//ile razy wystepuja w tablicy tab
	int numbers[] = {1,2,3,4,5,6,7,8,9,10};
}