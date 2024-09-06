#pragma once
#include <string>
#include <iostream>
class Song
{
private:
	std::string artist;
	std::string album;
	int songNumber;
	int year;
	std::string downloadNumber;
public:
	Song(std::string artist, std::string album, int songNumber, int year, 
		    std::string downloadNumber) {
		this->artist = artist;
		this->album = album;
		this->songNumber = songNumber;
		this->year = year;
		this->downloadNumber = downloadNumber;
	}
	void ShowSong() {
		std::cout << artist << std::endl;
		std::cout << album << std::endl;
		std::cout << songNumber << std::endl;
		std::cout << year << std::endl;
		std::cout << downloadNumber << std::endl;
		std::cout << std::endl;
	}
};

