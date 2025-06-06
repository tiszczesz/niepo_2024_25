﻿#include <iostream>
#include <string>
#include <cstdlib>
#include "User.h"
#include "Worker.h"
//uzycie zmiennej do przechowywania roli uzytkownika
using namespace std;
string GetUserInfo(const User& u);
int main() {
	Worker w1;
	Worker w2("Roman", Worksite::Remote);
	cout << w1 << w2;
	User u1;
	User u2("gienek", "gienek", Role(2));
	cout << GetUserInfo(u2);
	return 0;
}
string GetUserInfo(const User& u) {
	return "Info: login: " + u.GetLogin() + " haslo: "
		+ u.GetPassword() + " rola: " + u.GetRoleName();
}