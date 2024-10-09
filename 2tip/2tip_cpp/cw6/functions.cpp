#include <iostream>
#include <string>
#include <ctime>
#include <cstdlib>

void Show(std::string text) {
	std::cout << text << std::endl;
}

void Hello() {
	std::cout << "Podaj imie: ";
	std::string firstname;
	std::cin >> firstname;
	std::cout << "Podaj nazwisko: ";
	std::string lastname;
	std::cin >> lastname;
	std::cout << "Witaj " << firstname << " " << lastname
	  << "!" << std::endl;
}

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
int HowMany(int tab[],int size,int number) {
	int result = 0;
	for(int i=0;i<size;i++) {
		if (tab[i] == number) {
			result++;
		}
	}
	return result;
}


int CountAll(int target[],int sizeTar,int source[],int sizeSou) {
	int result = 0;
	for(int i=0;i<sizeSou;i++) {
		for(int j=0;j<sizeTar;j++) {
			if (target[j] == source[i]) result++;
		}
	}
	return result;
}