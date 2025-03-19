#include <iostream>
#include <string>
enum class Worksite {
    Office,
    Remote,
    Onsite
};
class Worker {
public:
	Worker()
		: name("noname"), worksite(Worksite::Office) {
	}

    Worker(const std::string& name, Worksite worksite)
        : name(name), worksite(worksite) {
    }

    std::string displayWorksite() const {
        std::string info = "Worker " + name + " works ";
        switch (worksite) {
        case Worksite::Office:
            return info +"in the office.\n" ;
            
        case Worksite::Remote:
            return info+ "remotely.\n" ;           
        case Worksite::Onsite:
            return info+ "onsite.\n";
		default:
            return info + "Unknown worksite.\n";
        }
    }
	friend std::ostream& operator<<(std::ostream& os, const Worker& w) {
		os << w.displayWorksite();
		return os;
	}

private:
    std::string name;
    Worksite worksite;
};

