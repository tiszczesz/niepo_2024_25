#include "Engine.h"

#include <iostream>

Engine::Engine()
//lista inicjujaca pola klasy
:capacity(1000),genre("benzynowy")
//poczatek ciala konstruktora
{
	std::cout << "wywolanie konstruktora domyslnego engine" << std::endl;
}

Engine::Engine(int capacity, std::string genre)
//lista inicjujaca pola klasy
	:capacity(capacity),genre(genre)
{
	std::cout << "wywolanie konstruktora z argumentami engine" << std::endl;
}
void Engine::EngineStart() {
	std::cout << "Silnik został uruchomiony!!!\n";
}
void Engine::EngineStop() {
	std::cout << "Silnik został zatrzymany!!!\n";
}
std::string Engine::EngineInfo() {
	return "\nInformacje o silniku: pojemnosc: "
	 + std::to_string(capacity) + " rodzaj: " +
		genre + "\n";
}




