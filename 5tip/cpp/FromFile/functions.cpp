#include <fstream>
#include <iostream>
#include <string>
#include <vector>
#include "Header.h"
#include "Person.h"

void GetFromFile(std::vector<std::string>& lines, std::string filename) {
	std::ifstream file(filename);
	std::string line;
	while (std::getline(file, line)) {
		lines.push_back(line);
	}
}
void PrintLines(const std::vector<std::string>& lines) {
	for (const auto& line : lines) {
		std::cout << line << "\n";
	}
}
void FileGenerator() {

    std::vector<Person> people = {
        Person("John Doe", 30),
        Person("Jane Smith", 25),
        Person("Alice Johnson", 28),
        Person("Bob Brown", 35),
        Person("Charlie Davis", 22),
        Person("Diana Evans", 27),
        Person("Evan Harris", 33),
        Person("Fiona Green", 29),
        Person("George White", 31),
        Person("Hannah Black", 26)
    };

    std::ofstream outFile(FILENAME);
    if (outFile.is_open()) {
        for (const auto& person : people) {
            outFile << person.GetName() << "\n";
            outFile << person.GetAge() << "\n\n";
        }
        outFile.close();
    }
    else {
        std::cerr << "Unable to open file";
    }
}
std::vector<Person> GetPeopleFromFile(std::vector<std::string> lines) {
    std::vector<Person> people;
    int linesNumberPerRecord{ 3 };
	for (size_t i = 0; i < lines.size(); i += linesNumberPerRecord) {
		std::string name = lines[i];
		int age = std::stoi(lines[i + 1]);
        people.push_back(Person(name, age));
		//people.emplace_back(name, age); //lepsze niz push_back(new Person(name, age))
	}
	return people;
}
