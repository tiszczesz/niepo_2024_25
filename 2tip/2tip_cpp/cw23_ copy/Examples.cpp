#pragma once
#include <string>
#include <iostream>
struct First {
//public:
	int a;
	std::string text;

	First() :a(0),text("Hello"){
		/*a = 0;
		text = "Hello";*/
	}
	First(int a, std::string text) :a(a),text(text){
		/*this->a = a;
		this->text = text;*/
	}
	void Display() {
		std::cout << "a = " << a << std::endl;
		std::cout << "text = " << text << std::endl;
	}
};

struct Second {
	int* pa;
	std::string text;
	Second() :pa(new int(0)), text("Hello") {
		/*pa = new int(0);
		text = "Hello";*/
	}
	Second(int a, std::string text) :pa(new int(a)), text(text) {
		/*this->pa = new int(a);
		this->text = text;*/
	}
	//konstruktor kopiujacy wbudowany płytkie kopiowanie
//tutaj kopiowanie tylko adresu pa jest jedno miejsce na 12
	//Second(const Second& obj) :pa(obj.pa), text(obj.text) {
	//	this->pa = obj.pa;
	//	this->text = obj.text;*/
	//}
	//utowrzenie nowego pa do ktorego przypisujemy wartosc z obj
//konstruktor kopiujacy napisany przez nas głebokie kopiowanie
	Second(const Second& obj) :pa(new int(*obj.pa)), text(obj.text) {
		/*this->pa = new int(*obj.pa);
		this->text = obj.text;*/
	}
	void Display() {
		std::cout << "a = " << *pa << std::endl;
		std::cout << "text = " << text << std::endl;
	}
	~Second() {
		delete pa;
	}
};
