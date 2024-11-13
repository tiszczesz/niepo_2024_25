#include <iostream>
#include <string>
#include <vector>
#include <cstdlib>
#include "Header.h"
#include <ctime>

using namespace std;
int main() {
	int a = 12121212112121;//nie sprawdza czy jest to za du¿o
	int b { 1212121444 };// sprawdza czy jest to za du¿o
	int c  = { 1212121211 };// sprawdza czy jest to za du¿o
	vector<string> container;
	const string filename  {"plik.txt"};
	GetFromFile(container, filename);
	ShowContent(container);
	//zapisywanie do pliku
	cout << " ===========================\n";
	SaveToFile(container, "wynik.txt", filename);
	//srand(time(0));
	//for (int i = 0; i < 50000; i++) {
	//	cout << rand() << endl;
	//}
	return EXIT_SUCCESS;
}