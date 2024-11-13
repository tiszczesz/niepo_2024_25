#pragma once
#include <string>
#include <vector>
void GetFromFile(std::vector<std::string>& container, const std::string& filename);
void ShowContent(const std::vector<std::string>& container);
void SaveToFile(
	const std::vector<std::string>& container,//wiadro
	const std::string resultFile,//plik wynikowy
	const std::string filename = "plik.txt" //plik zrodlowy
);
