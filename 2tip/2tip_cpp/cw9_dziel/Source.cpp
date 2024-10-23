#include <iostream>
#include <string>
#include "Header.h"
using namespace std;
const int MAXSIZE = 10000;
int main() {
	int tab[MAXSIZE];
	int size = GetSize(MAXSIZE);
	FillTab(tab, size);
	ShowTab(tab, size);
	cout << "===sortowanie===\n";
	SortWInc(tab, size);
	ShowTab(tab, size);
	//todo: wyszukiwanie w zbiorze
	//todo: uporzadkowanym
	cout << "Podaj szukana wartosc: ";
	int target;
	cin >> target;
	int index = BinarySearch(tab, size, target);
	if(index == -1) {
		cout << "Nie znaleziono\n";
	}
	else {
		cout << "Znaleziono na pozycji: " << index << endl;
	}
	return 0;
}