#include <iostream>
#include <string>
#include <Windows.h>
#include <cstdlib>
#include <ctime>
using namespace std;
void show(int howMany, string text);
void counter(int howMany, string text);
int main() {
	show(10, "ala ma kota");
	show(2, " ----- ");
	counter(10, "do wybuchu");
	srand(time(0));//ustawienie losowego startu
	cout << (rand() % 100) << endl; //losuje liczbe z przedzialu 0,99
}

void show(int howMany,string text) {
	for(int i=0 ;i<howMany ; i++) {		
		cout << text << " i = " << i << endl;
	}
	//cout << i << endl;
}
void counter(int howMany , string text) {
	for(int i = howMany; i>0;i--) {
		Sleep(100);
		cout << text << " i = " << i << endl;
	}
	cout << " BOOOMMMM!!!! " << endl;
}

//break
//continue