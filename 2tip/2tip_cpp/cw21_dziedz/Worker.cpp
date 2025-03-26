#include "Worker.h"
#include <iostream>


Worker::Worker():salary(2000),workplace("zapomoga") {
	std::cout << "Worker()" << std::endl;
}
Worker::Worker(std::string firstname, std::string lastname, int age,
	   int salary, std::string workplace)
	:Person(firstname, lastname, age),
      salary(salary), workplace(workplace)
{
	std::cout << "Worker(z argumentami)" << std::endl;
}
std::ostream& operator<<(std::ostream& os, const Worker& w) {
	os << "Imie: " << w.firstname << " Nazwisko: " << w.lastname
		<< " Wiek: " << w.age << std::endl << " Wynagrodzenie: " << w.salary
		<< " Miejsce pracy: " << w.workplace << std::endl;
	return os;
}
