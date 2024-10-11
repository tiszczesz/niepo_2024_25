#include <iostream>
#include <string>
#include "functions.h"

using namespace std;
const int MAXSIZE = 1000;
int main() {
	int size = GetSize(MAXSIZE);
	int tab[MAXSIZE];
	FillTab(tab, size);
	ShowTab(tab, size);
	int max = GetMax(tab, size);
	cout << "i = "<< GetMaxInd(tab, size) << endl;
	cout << "i = "<< GetMaxInd(tab, size,6) << endl;
	cout << "max = " << max << endl;

	int a = 5;
	int b = 10;
	SwapWrong(a, b);
	cout << "a = " << a << " b = " << b << endl;
	SwapGood(a, b);
	cout << "a = " << a << " b = " << b << endl;

	SortW(tab, size);
	cout << "Po sortowaniu: ===========================  \n	";
	ShowTab(tab, size);
	return 0;
}

