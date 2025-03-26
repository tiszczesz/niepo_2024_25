#pragma once
#include <string>

//klasa domyslnie jest prywatna
class Person
{
protected:
	std::string firstname;
	std::string lastname;
	int age;
public:
	Person();
	Person(std::string firstname, std::string lastname, int age);
	friend std::ostream& operator<<(std::ostream& os, const Person& p);
};
//struktura domyslnie jest publiczna
//struct Test {
//	int a;
//};
//Test t;
//t.a = 10; // Error: 't' does not name a type

