#pragma once
class Person;
void GetFromFile(std::vector<std::string>& lines, std::string filename);
void PrintLines(const std::vector<std::string>& lines);
void FileGenerator();
const std::string FILENAME = "people.txt";
std::vector<Person> GetPeopleFromFile(std::vector<std::string> lines);