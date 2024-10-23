#include <iostream>
#include <string>
#include <ctime>
#include <cstdlib>
#include <cmath>

void FillTab(int tab[], int size) {
	srand(time(0));
	for (int i = 0; i < size; i++) {
		tab[i] = rand() % 101;
	}
}
void ShowTab(int tab[], int size) {
	for (int i = 0; i < size; i++) {
		std::cout << tab[i] << " ";
	}
	std::cout << std::endl;
}

int GetSize(const int SIZE) {
	int result = 0;
	do {
		std::cout << "Podaj rozmiar tablicy (0 - " << SIZE << "): ";
		std::cin >> result;
	} while (result<0 || result>SIZE);
	return result;
}

int GetMax(int t[],int size) {
	if (size <= 0) return -9999999;
	int max = t[0];
	for(int i=0;i<size;i++) {
		if(max<t[i]) {
			max = t[i];
		}
	}
	return max;
}
int GetMaxInd(int t[], int size,int start = 0) {//szukanie miejsca minimum od indeksu = start
	if (start>=size) return -9999999;
	int max = t[start];
	int index = start;
	for (int i = start; i < size; i++) {
		if (max < t[i]) {
			max = t[i];
			index = i;
		}
	}
	return index;
}
int GetMinInd(int t[], int size, int start = 0) {//szukanie miejsca minimum od indeksu = start
	if (start >= size) return -9999999;
	int min = t[start];
	int index = start;
	for (int i = start; i < size; i++) {
		if (min > t[i]) {
			min = t[i];
			index = i;
		}
	}
	return index;
}
int GetMin(int t[], int size) {
	if (size <= 0) return -9999999;
	int min = t[0];
	for (int i = 0; i < size; i++) {
		if (min > t[i]) {
			min = t[i];
		}
	}
	return min;
}
int GetAmp(int t[], int size) {
	return abs(GetMax(t, size) - GetMin(t, size));
}

void SwapWrong(int a, int b) { //kopiowanie zmiennych
	int temp = a;
	a = b;
	b = temp;
}
void SwapGood(int& a, int& b) { //uzycie referencji
	int temp = a;
	a = b;
	b = temp;
}

void SortW(int tab[], int size) {
	for(int i=0;i<size-1;i++) {
		SwapGood(tab[i], tab[GetMaxInd(tab, size, i)]);
	}
}
void SortWInc(int tab[], int size) {
	for (int i = 0; i < size - 1; i++) {
		SwapGood(tab[i], tab[GetMinInd(tab, size, i)]);
	}
}

int BinarySearch(int tab[],int size, int target) {
	int left = 0;
	int right = size - 1;

	while (left <= right) {
		int mid = left + (right - left) / 2;

		// SprawdŸ, czy target jest w œrodku
		if (tab[mid] == target) {
			return mid;
		}

		// Jeœli target jest wiêkszy, ignoruj lew¹ po³owê
		if (tab[mid] < target) {
			left = mid + 1;
		}
		// Jeœli target jest mniejszy, ignoruj praw¹ po³owê
		else {
			right = mid - 1;
		}
	}

	// Jeœli element nie jest obecny w tablicy
	return -1;
}



//sortowanie b¹belkowe !!!!
