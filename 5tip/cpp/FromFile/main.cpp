#include <iostream>
#include <string>
#include <vector>
#include <fstream>
#include "Header.h"
#include "Person.h"

using namespace std;

int main() {
	vector<string> lines;
	GetFromFile(lines, FILENAME);

	PrintLines(lines);
	//FileGenerator();
	vector<Person> people = GetPeopleFromFile(lines);
	for (Person person : people) {
		person.to_string();
	}
	return 0;
   
}