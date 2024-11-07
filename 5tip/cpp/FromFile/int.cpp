#include <iostream>
#include <string>

int main_example() {
    int age;
    std::string name;

    std::cout << "Enter your age: ";
    std::cin >> age;

    // Wyczyœæ znak nowej linii pozostawiony przez std::cin
    std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');

    std::cout << "Enter your name: ";
    std::getline(std::cin, name);

    std::cout << "Name: " << name << ", Age: " << age << std::endl;

    return 0;
}
