#include <iostream>
#include <string>

using namespace std;

int main() {
	int tab[] = { 1, 2, 3, 4, 5 };//definicja tablicy z inicjalizacj¹
	int tab2[10]; //definicja tablicy 10-elementowej
	for(int i = 0; i<5;i++)
		cout << tab[i] << " ";
	cout << endl;
	for (int i = 0; i < 10; i++)
		cout << tab2[i] << " ";
	cout << endl;
	//tab[5] = 6; //przypisanie wartoœci do elementu tablicy spoza zakresu

	double liczby[10];//deklaracja tablicy 10-elementowej double
	liczby[0] = 3.14; //przypisanie wartoœci do elementu tablicy
	for (int i = 0; i < 10; i++)
		cout << liczby[i] << " ";
	cout << endl;
	//deklaracja i inicjalizacja tablicy napisów
	string napisy[] = { "Ala", "ma", "kota", "a", "kot" };
	for(auto napis : napisy)
		cout << napis << " ";
	return 0;

}