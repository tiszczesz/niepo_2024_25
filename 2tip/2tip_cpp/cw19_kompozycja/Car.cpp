#include "Car.h"

#include <iostream>

Car::Car():engine(),brand("noname"),maxSpeed(200.0),speed(0)
           ,color("czarny") {}
Car::Car(Engine engine, std::string brand, double maxSpeed,
	double speed, std::string color) {
	this->engine = engine;
	this->brand = brand;
	this->maxSpeed = maxSpeed;
	this->speed = speed;
	this->color = color;
}
void Car::Start() {
	std::cout << "uruchomienie samochodu\n";
	engine.EngineStart();
}
void Car::Stop() {
	std::cout << "wylaczenie samochodu\n";
	engine.EngineStop();
}
std::string Car::Info() {
	return "\n Informacje o samochodzie marka: "+ brand +
		engine.EngineInfo() +
		" predkosc maksymalna: " + std::to_string(maxSpeed) +
		" predkosc aktualna " + std::to_string(speed) +
		" kolor samochodu: " + color+"\n";
}
void Car::SpeedChange(double speed) {
	this->speed = speed;
}


