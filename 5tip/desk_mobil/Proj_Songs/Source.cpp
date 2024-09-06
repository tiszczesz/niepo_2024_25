#include <iostream>
#include <vector>
#include <string>
#include <fstream>
#include "Song.h"

using namespace std;

vector<string> GetLinesFromFile(const string& filename) {
	ifstream input;
	input.open(filename);
	vector<string> lines;
	if(input.is_open()) {
		string line;
		while (getline(input,line)) {
			lines.push_back(line);
		}
	}
	return lines;
}
vector<Song> GetSongs(const vector<string>& lines) {
	vector<Song> songs;
	string record[5];
	int licznik = 0;
	for (string line : lines) {
		if(line == "" ) {
			Song s = Song(record[0], record[1],
				stoi(record[2]), stoi(record[3]),
				record[4]);
			songs.push_back(s);
			licznik = 0;
			
		}
		if(line!="") record[licznik++] = line;
		
		
	}
	//ostatnie 5 liniejek
	Song s = Song(record[0], record[1],
		stoi(record[2]), stoi(record[3]),
		record[4]);
	songs.push_back(s);
	return songs;
}


//void GenerFile(const string& filename) {
//	ofstream out;
//	out.open(filename);
//	out << "dfdsfdsfsdf" << endl;
//}
int main() {
	vector<string> lines = GetLinesFromFile("Data.txt");
	vector<Song> songs = GetSongs(lines);
	for (auto song : songs)
	{
		song.ShowSong();
	}
	//GenerFile("text.txt");
	return 0;
}