#pragma once
#include <string>

class Engine
{
private:
	int capacity;
	std::string genre;
public:
	Engine();
	Engine(int capacity, std::string genre);
	void EngineStart();
	void EngineStop();
	std::string EngineInfo();
};

