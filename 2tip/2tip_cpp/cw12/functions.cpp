#include <fstream>
#include <iostream>
#include <string>
#include <vector>
void GetFromFile(std::vector<std::string>& container, const std::string& filename) {
	//tworzenie obiektu do czytania z pliku
	std::ifstream fileStream;

	//otwarcie pliku
	fileStream.open(filename);
	if(fileStream.is_open()) {
		std::cout << "Plik zostal otwarty" << std::endl;
		std::string line;
		//wczytywanie wszystkich linii z pliku do wektora
		while (std::getline(fileStream, line)) {
			container.push_back(line);
		}
		std::cout << "Plik zostal wczytany" << std::endl;
		//zamkniecie pliku
		fileStream.close();
	}else {
		std::cout << "Plik nie zostal otwarty" << std::endl;
	}
}
void ShowContent(const std::vector<std::string>& container) {
	//wyswietlanie zawartosci wektora
	// for(typ elem : zbior ){ ... }
	for (const auto& line : container) {
		std::cout << line << std::endl;
	}
}
int CountChars(const std::vector<std::string>& container) {
	int total{ 0 };
	for (const auto& line : container) {
		total += line.size();
	}
	return total;
}
void SaveToFile(
				const std::vector<std::string>& container,//wiadro
				const std::string resultFile,//plik wynikowy
				const std::string filename = "plik.txt" //plik zrodlowy
				) {
	//zapisanie do pliku  zawartosci wektora
	std::ofstream fileStream;
	fileStream.open(resultFile);
	if(fileStream.is_open()) {
		fileStream << "Ilosc znakow w pliku: " << filename << " wynosi: "
		      << CountChars(container) << std::endl;
		fileStream.close();
	}
}
