#pragma once
#include "Book.h"
#include <vector>
class BooksRepo
{
public:
	static std::vector<Book> GetBooks() {
		std::vector<Book> books;
		books.push_back(Book("Wiedzmin", "Andrzej Sapkowski", 1993, 300));
		books.push_back(Book("Wladca Pierscieni", "J.R.R. Tolkien", 1954, 1000));
		books.push_back(Book("Harry Potter", "J.K. Rowling", 1997, 500));
		books.push_back(Book("Zakopane noca", "Roman Boman", 2004, 200));
	}
	
};

