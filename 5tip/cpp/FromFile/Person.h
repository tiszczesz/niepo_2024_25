#pragma once
#include <string>

class Person
{
private:
	std::string name;
	int age;
public:
	Person() {
		name = "";
		age = 0;
	}
	Person(std::string name, int age) {
		this->name = name;
		this->age = age;
	}
	
	std::string GetName() const {
		return name;
	}
	int GetAge() const {
		return age;
	}
	void SetName(std::string name) {
		this->name = name;
	}
	void SetAge(int age) {
		this->age = age;
	}
	void to_string() const {
		std::cout << "Name: " << name << ", Age: " << age << "\n";
	}
	~Person() = default; // Destructor
};

