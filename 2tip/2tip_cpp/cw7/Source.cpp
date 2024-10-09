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
	return 0;
}

