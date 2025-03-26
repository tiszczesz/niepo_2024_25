#include "Person.h"
#include <iostream>
Person::Person():firstname("noname"),lastname("noname"),age(0) {
	std::cout << "Person()" << std::endl;
}
Person::Person(std::string firstname, std::string lastname, int age)
:firstname(firstname), lastname(lastname), age(age)
{
	std::cout << "Person(z argumentami)" << std::endl;
}

std::ostream& operator<<(std::ostream& os, const Person& p) {
	os << "Imie: " << p.firstname << " Nazwisko: " << p.lastname
	<< " Wiek: " << p.age<<std::endl;
	return os;
}