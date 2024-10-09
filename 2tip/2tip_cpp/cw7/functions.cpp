#include <iostream>
#include <string>
#include <ctime>
#include <cstdlib>

void FillTab(int tab[], int size) {
	srand(time(0));
	for (int i = 0; i < size; i++) {
		tab[i] = rand() % 101;
	}
}
void ShowTab(int tab[], int size) {
	for (int i = 0; i < size; i++) {
		std::cout << tab[i] << " ";
	}
	std::cout << std::endl;
}

int GetSize(const int SIZE) {
	int result = 0;
	do {
		std::cout << "Podaj rozmiar tablicy (0 - " << SIZE << "): ";
		std::cin >> result;
	} while (result<0 || result>SIZE);
	return result;
}



