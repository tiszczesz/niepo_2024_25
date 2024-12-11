#include <iostream>
#include <string>
#include <cstdio>
#include <filesystem>
using namespace std;
namespace fs = std::filesystem;

void AddCString(const char* str1,const char* str2) {
	//napisz funkcje zwracajaca rozmiar c-stringa
	//po³¹cz str1 i str2 i wypisz wynik ala\0
	//cout << str1 << " " << str2 << endl;
}
void cw1() {
	const char* info = "Hello, World!";
	//char** war =  {"dddd","gggg"} ;
	const char* war[] = { "dddd", "gggg" };
	char** warPtr = const_cast<char**>(war);
	cout << warPtr[0] << endl;
	auto info3 = "Hello, World!";
	char info2[] = "Hello, cpp!";
	string n1 = "ala";
	auto gg = n1.c_str();
	char zmienna[100];
	scanf_s("%s", zmienna,_countof(zmienna));
	printf_s(zmienna);
	cout << '\n' <<strlen(zmienna) << endl;
	string n2 = "ma";
	string n3 = "kota";
	string result2 = n1 + " " + n2 + " " + n3;
	//string result = info + " " + info2 ;
	cout << info2 << endl;
}
int getSize(const char* str) {
	int i = 0;
	while (str[i] != '\0') {
		i++;
	}
	return i;
}
void ScanDir(const std::string path) {	
	for (const auto& entry : fs::directory_iterator(path))
		std::cout << entry.path() << std::endl;

}
//napisac funkcje ktora prosi o podanie imienia, nazwiska i wieku
//ale uzywamy tylko scanf printf c-stringi
int main()
{
	cw1();
	char napis1[] = "ala";
	char napis2[] = "ma";
	cout << getSize(napis1) << endl;
	AddCString(napis1, napis2);//polacz napis1 i napis2 i wypisz wynik
	fs::path currentPath = fs::current_path();
	ScanDir(currentPath.string());
	return 0;
}