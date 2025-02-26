#include <iostream>
#include <string>
#include "Car.h"
#include "Engine.h"

using namespace std;

int main() {
	//utworzenie obiektu car na stosie
	Car car1; //uzycie konstruktora domyslnego

	//to jest tylko agregacja bo silnik "zyje" bez samochodu
	Engine en1(2000, "hybryda");
	Engine* pen2 = new Engine();
	//uzycie konstruktora z argumentami
	Car car2(en1, "opel", 300, 0, "czerwony");
	cout << car1.Info();
	cout << " -------- drugi samochod -------- \n";
	cout << car2.Info();

	//tworzenie obiektu dynamicznie na stercie
	Car* pcar1 = new Car(en1, "fiat"
		, 250, 0, "niebieski");
	//(*pcar1).SpeedChange(100);
	pcar1->SpeedChange(100);
	//cout << (*pcar1).Info();
	cout << pcar1->Info();
	//w car3 uzyc pen2
	Car car3();
	//zwolnienie pamieci
	delete pen2;
	pen2 = nullptr;
	delete pcar1;
	pcar1 = nullptr;
	return 0;
}