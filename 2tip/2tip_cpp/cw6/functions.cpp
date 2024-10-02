#include <iostream>
#include <string>

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