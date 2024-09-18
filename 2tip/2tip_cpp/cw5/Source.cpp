//aplkacja prosi uzytkownika o podanie 10 wyrazow i zapisuje do tablicy
//string words[10]
//podaj 1 wyraz:
//podaj 2 wyraz:
//...
//potem wyswietla te wyrazy w odwrotnej kolejnosci

#include <iostream>
#include <string>
using namespace std;
void ShowWords(string a[],int size) {
	for (int i = 0; i < size; i++) {
		cout << a[i] << " ";
	}
	cout << endl;
}
//string getMaxLenth(string texts[],int size){}
//narysowac schemat blokowy
//napisac funkcje ktora przyjmuje tablice stringow i jej rozmiar
// zwraca string najdluzsze slowo
//napisac funkcje ktora przyjmuje tablice stringow i jej rozmiar
// zwraca string najkrotsze slowo
int main() {
	string napisy[10] = { "ala","ma","kota","a","kot","ma"
		,"roman","zofia","rudy","dzisiec" };
	ShowWords(napisy, 10);
	/*string words[10];
	for (int i = 0; i < 10; i++) {
		cout << "Podaj " << i + 1 << " wyraz: ";
		cin >> words[i];
	}
	for (auto text : words) {
		cout << text << " ";
	}
	cout << endl;
	for (int i = 9; i >= 0; i--) {
		cout << words[i] << " ";
	}
	cout << endl;
	string dd = "asadadadad";
	cout << dd.size() << endl;*/
	return 0;
}
