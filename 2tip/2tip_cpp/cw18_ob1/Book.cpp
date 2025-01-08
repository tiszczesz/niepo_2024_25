#include "Book.h"

Book::Book(std::string title, std::string author, int year, int pages) {
	this->title = title;
	this->author = author;
	this->year = year;
	this->pages = pages;
}
Book::Book() {
	this->title = "Brak tytulu";
	this->author = "Brak autora";
	this->year = 0;
	this->pages = 0;
}
void Book::Show() {
	std::cout << "Tytul: " << title << std::endl;
	std::cout << "Autor: " << author << std::endl;
	std::cout << "Rok wydania: " << year << std::endl;
	std::cout << "Liczba stron: " << pages << std::endl;
}
void Book::Show(bool isBorder) {
	if (isBorder) {
		std::cout << "-------------------" << std::endl;
	}else {
		std::cout << " =================== " << std::endl;
	}
	Show();//to nie jest rekurencja, tylko wywolanie innej metody
	if (isBorder) {
		std::cout << "-------------------" << std::endl;
	}
	else {
		std::cout << " =================== " << std::endl;
	}
}

