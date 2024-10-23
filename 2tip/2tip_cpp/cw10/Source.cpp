#include<iostream>
#include <string>
#include <vector>

using namespace std;
int NWD(int a, int b) {
	if (b == 0 ) return a;
	return NWD(b, a % b);	
}
void Repeater(const string& text,int counter) {
	for (int i = 0; i < counter; i++) {
		cout << text << endl;
	}
}
int main() {
	//int a,b;
	//cin >> a >> b;
	//for (int i=0;i<size;i++) {
	//	cout << "Hello World!" << endl;
	//}
	//cout << NWD(a, b) << endl;
	//int r;
	//string text;
	//cin >> r;
	//cin >> text;
	//Repeater(text, r);
	vector<string> words; //wektor napisów
	string word;
	const string end = "koniec";
	do {
		cout << "Podaj slowo: ("<<end<<" to stop): ";
		cin >> word;
		if (word != end) {
			words.push_back(word);
		}
	} while (word != end);
	for (string& w : words) { //foreach w c++
		cout << w << endl;
	}
	cout << "Ilosc slow: " << words.size() << endl;
	return 0;
}