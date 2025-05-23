#include <iostream>
#include <cstdlib>
#include <ctime>
#include "Array.h"

using namespace std;

int main() {
	Array* arr2 = new Array(10);
	cout << "Podaj rozmiar tablicy: ";
	int size;
	cin >> size;
	//wywołanie konstruktora
	Array arr(size);
	//wywołanie metody show
	arr.ShowArray();
	cout << "Podaj element do wyszukania: ";
	int toFind;
	cin >> toFind;
	//wywołanie metody search
	int index = arr.SearchArray(toFind);
	if (index==-1) {
		cout << "Nie znaleziono elementu: " <<toFind << endl;
	}
	else {
		cout << "Znaleziono element: "<<toFind<<" na pozycji: " << index << endl;
	}
	cout << "Liczba liczb nieparzystych: " << arr.ShowOdd() << endl;
	cout << "Srednia arytmetyczna: " << arr.GetAvg() << endl;
	//przciążenie operatora <<
	cout << arr;
	cout << 1 / 2 << endl;
	return 0;
}