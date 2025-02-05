#include <iostream>
#include <cstdlib>
#include <ctime>
#include "Array.h"

using namespace std;

int main() {
	cout << "Podaj rozmiar tablicy: ";
	int size;
	cin >> size;
	//wywo�anie konstruktora
	Array arr(size);
	//wywo�anie metody show
	arr.ShowArray();
	cout << "Podaj element do wyszukania: ";
	int toFind;
	cin >> toFind;
	//wywo�anie metody search
	int index = arr.SearchArray(toFind);
	if (index==-1) {
		cout << "Nie znaleziono elementu: " <<toFind << endl;
	}
	else {
		cout << "Znaleziono element: "<<toFind<<" na pozycji: " << index << endl;
	}
	cout << "Liczba liczb nieparzystych: " << arr.ShowOdd() << endl;
	return 0;
}