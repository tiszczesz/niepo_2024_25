#include <iostream>
#include <string>
#include "Examples.cpp"

using namespace std;
int main() {
	First obj1(12,"gggg");
	obj1.Display();
	First obj2 = obj1;
	obj2.Display();
	cout << "========================\n";
	obj1.a = 100;
	obj1.Display();
	obj2.Display();
	cout << "========================\n";
	Second obj3(12, "gggg");
	Second obj4 = obj3;
	obj3.Display();
	obj4.Display();
	cout << "========================\n";
	*obj3.pa = 100;
	obj3.Display();
	obj4.Display();
	cout << "================= tttttttttttt =======\n";
	//Inny sposob tworzenia obiektu
	Second obj5;
	obj5 = obj3;
	obj3.Display();
	obj5.Display();
	*obj5.pa = 9900;
	obj3.Display();
	obj5.Display();
	return 0;
}