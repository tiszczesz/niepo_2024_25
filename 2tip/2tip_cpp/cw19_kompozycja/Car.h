#pragma once
#include <string>

#include "Engine.h"
class Car
{
private:
	Engine engine;
	std::string brand;
	double maxSpeed;
	double speed;
	std::string color;

public:
	Car();
	Car(Engine engine, std::string brand, double maxSpeed,
		double speed, std::string color);
	void Start();
	void Stop();
	void SpeedChange(double speed);
	std::string Info();
};

