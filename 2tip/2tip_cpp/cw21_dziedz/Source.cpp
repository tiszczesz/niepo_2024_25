#include<iostream>
#include<string>
#include <cstdlib>
#include "Person.h"
#include "Worker.h"
using namespace std;
int main() {
	Person p1;
	Person p2("Jan", "Kowalski", 30);
	Person* pp3 = new Person("Anna", "Nowak", 25);
	cout << p1 << p2<< (*pp3) <<endl;
	cout << " -------------------" << endl;
	Worker w1;
	Worker w2("Jan", "Kowalski", 30,
		       5000, "PKO");
	cout << w1 << w2 << endl;
	delete pp3;
	pp3 = nullptr;
	return 0;
}