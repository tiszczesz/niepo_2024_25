#include <iostream>
#include <string>
#include "Book.h"
#include "BooksRepo.h"

using namespace std;

int main() {
	Book book1; //tworzy na stosie obiekt klasy Book konstruktorem domyslnym
	Book book2("Wiedzmin", "Andrzej Sapkowski", 1993, 300); //tworzy na stosie obiekt klasy Book konstruktorem z parametrami
	Book book3("ksiazka 3", "autor", 2007, 200);
	//book1.title = "Wiedzmin";
	//cout << book1.title << endl;
	book1.Show();
	cout << "-------------------" << endl;
	book2.Show(true);
	book3.Show(false);
	cout << "-------------------" << endl;
	cout << "-------------------" << endl;
	vector<Book> books = BooksRepo::GetBooks();//odwolanie do metody GetBooks z klasy BooksRepo
	for (auto book : books) {
		book.Show(true);		
	}
	return 0;
}