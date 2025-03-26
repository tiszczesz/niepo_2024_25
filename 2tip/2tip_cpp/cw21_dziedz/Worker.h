#pragma once
#include "Person.h"
class Worker : public Person
{
private:
	int salary;
	std::string workplace;
public:
	Worker();
	Worker(std::string firstname, std::string lastname, int age, 
		int salary, std::string workplace);
	
	friend std::ostream& operator<<(std::ostream& os, const Worker& w);
};

