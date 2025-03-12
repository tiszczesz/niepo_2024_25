#pragma once
#include <string>
enum class Role2;
enum Role;//deklaracja stara wersja
class User
{
private:
	std::string login;
	std::string password;
	Role role;
	Role2 role2;
public:
	User() {
		login = "noname";
		password = "noname";
		role = Role(5);
	}
	User(std::string login,std::string password,Role role = Role(5)) {
		this->login = login;
		this->password = password;
		this->role = role;
	}
	std::string GetLogin() const {
		return this->login;
	}
	std::string GetPassword() const {
		return this->password;
	}
	Role GetRole() const {
		return this->role;
	}
	Role2 GetRole2() const {
		return this->role2;
	}
	std::string GetRoleName() const {
		switch (this->role) {
		case 1:
			return "ADMIN";
		case 2:
			return "USER";
		case 3:
			return "EDITOR";
		case 5:
			return "VIEWER";
		default:
			return "UNKNOWN";
		}
	}
	std::string GetRoleName2() const {
		switch (this->role2) {
		case Role2::ADMIN:
			return "ADMIN";
		case Role2::USER:
			return "USER";
		case Role2::EDITOR:
			return "EDITOR";
		case Role2::VIEWER:
			return "VIEWER";
		default:
			return "UNKNOWN";
		}

};

enum Role { //definicja
	ADMIN=1,
	USER,
	EDITOR,
	VIEWER = 5
};
enum class Role2 { //definicja
	ADMIN = 1,
	USER,
	EDITOR,
	VIEWER = 5
};


