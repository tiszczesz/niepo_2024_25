#include <iostream>
#include <string>
#include "functions.h"
using namespace std;

int main() {
	int tab[50];

	//napisa� funkcj�, kt�ra wype�ni tablic� liczbami losowymi
	FillTab(tab, 50);
	//napisa� funkcj�, kt�ra wypisze tablic�
	ShowTab(tab, 50);
	Show("To jest z funkcji: Hello World!");//uzycie funkcji z pliku functions.h
	Hello();//uzycie funkcji z pliku functions.cpp
}