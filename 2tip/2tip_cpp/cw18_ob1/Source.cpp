#include <iostream>
#include <string>
#include "Book.h"

using namespace std;

int main() {
	Book book1; //tworzy na stosie obiekt klasy Book konstruktorem domyslnym
	Book book2("Wiedzmin", "Andrzej Sapkowski", 1993, 300); //tworzy na stosie obiekt klasy Book konstruktorem z parametrami
	//book1.title = "Wiedzmin";
	//cout << book1.title << endl;
	book1.Show();
	cout << "-------------------" << endl;
	book2.Show();
	return 0;
}