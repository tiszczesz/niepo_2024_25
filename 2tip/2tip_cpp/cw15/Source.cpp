#include <iostream>
#include <string>

using namespace std;
void fun1(int t[], int size) {
	for (int i = 0; i < size; i++) {
		t[i] = i;
	}
}
void fun2(int* t, int size) {
	for (int i = 0; i < size; i++) {
		t[i] = i;
	}
}
void fun3() {
	int a;
	float b;
	double c;
	char d;
	char str[100];

	// Wczytanie liczby ca³kowitej
	printf("Podaj liczbê ca³kowit¹: ");
	scanf("%d", &a);

	// Wczytanie liczby zmiennoprzecinkowej
	printf("Podaj liczbê zmiennoprzecinkow¹: ");
	scanf("%f", &b);

	// Wczytanie liczby zmiennoprzecinkowej typu double
	printf("Podaj liczbê zmiennoprzecinkow¹ typu double: ");
	scanf("%lf", &c);

	// Wczytanie pojedynczego znaku
	printf("Podaj pojedynczy znak: ");
	scanf(" %c", &d); // Uwaga: spacja przed %c jest wa¿na, aby pomin¹æ bia³e znaki

	// Wczytanie ci¹gu znaków
	printf("Podaj ci¹g znaków: ");
	scanf("%s", str);

	// Wyœwietlenie wczytanych wartoœci
	printf("Wczytane wartoœci: %d, %f, %lf, %c, %s\n", a, b, c, d, str);
}
int main() {
	int a;
	scanf("%d", &a);
	int tab[10]; //deklaracja tablicy dla 10 elementow na stosie
	tab[4] = 6;
	tab[7] = 9;
	//dynamiczne alokowanie pamieci dla tablicy
	cout << "Podaj rozmiar tablicy: ";
	int size;
	cin >> size;
	double* pa = new double(3);
	cout << *pa << endl;
	*pa = 4.78;
	cout << *pa << endl;
	int* tab2 = new int[size];


	for (int i = 0; i < size; i++) {
		tab2[i] = i;
	}
	for (int i = 0; i < size; i++) {
		cout << tab2[i] << " ";
	}
	//zwolnienie pamieci
	delete[] tab2;
	//tab2 = nullptr;//wyczyszczenie wskaznika
	delete pa;
	pa = nullptr;

	//......



	//........
	if (tab2!=nullptr) {
		//dzialanie na tablicy
	}
	return 0;
}