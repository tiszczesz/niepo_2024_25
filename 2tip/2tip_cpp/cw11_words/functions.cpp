#include <iostream>
#include <string>
#include <vector>

void FillWords( std::vector<std::string>& words) {
	std::string word;
	while (std::cin >> word) {
		words.push_back(word);
	}
}
void PrintWords(const std::vector<std::string>& words) {
	for (const auto& word : words) {
		std::cout << word << " ";
	}
	std::cout << std::endl;
}
