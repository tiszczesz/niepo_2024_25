#pragma once
#include <iostream>
#include <string>
class Book
{
private:
	std::string title;
	std::string author;
	int year;
	int pages;
public:
	Book(std::string title, std::string author, int year, int pages);

};

