#pragma once
#include <cstdlib>
#include <ctime>
#include <iostream>

using namespace std;
class Array
{
private:
	int* arr;
	int size;
	void FillArray() {
		srand(time(0));
		for (int i = 0; i < size; i++) {
			arr[i] = rand() % 1000;
		}
	}
public:
	Array(int size) {
		this->size = size;
		arr = new int[size];
		FillArray();
	}
	void ShowArray() {
		for (int i = 0;i<size;i++) {
			cout << i << " : " << arr[i] << endl;
		}
	}
	//destruktor
	~Array() {
		delete[] arr;
		arr = nullptr;
	}
	int SearchArray(int toFind) {
		for (int i=0;i<size;i++) {
			if (toFind == arr[i]) return i;
		}
		return -1;
	}
	int ShowOdd() {
		int count = 0;
		for (int i = 0; i < size; i++) {
			if (arr[i] % 2 != 0) {
				cout  << arr[i] << endl;
				count++;
			}
		}
		return count;
	}
};

