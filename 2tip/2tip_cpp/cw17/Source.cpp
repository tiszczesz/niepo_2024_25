#include <iostream>
#include <string>
#include <cstdio>
using namespace std;
//napisac funkcje ktora prosi o podanie imienia, nazwiska i wieku
//ale uzywamy tylko scanf printf c-stringi
int main()
{
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
	scanf_s("%s", zmienna);
	printf_s(zmienna);
	string n2 = "ma";
	string n3 = "kota";
	string result2 = n1 + " " + n2 + " " + n3;
	//string result = info + " " + info2 ;
	cout << info2 << endl;
	return 0;
}