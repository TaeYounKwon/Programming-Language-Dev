#include <iostream>
#include <fstream>
#include <string>
#include <iomanip>

using namespace std;

int main(){
	const int TESTS = 72;
	if (argc != 3){
		cerr << "Not working" << endl;
		cerr << "Usage: " << endl;
		cerr << argv[0] << " key-output your-output" << endl;
		return 1;
	}
	ifstream student(argv[2]);
	ifstream key(argv[1]);
	string studentAnswer, keyAnswer;
	int count = 0, total = 0;
	while (student >> studentAnswer && key >> keyAnswer){
		if (studentAnswer == keyAnswer)
			count++;
		total++;
	}
	cout << "Correct Answers:  " << count << endl;
	cout << "Queries executed: " << total << endl;
	cout << "Total tests:      " << TESTS << endl;
	cout << "Percentage of tests passed: "
			 << static_cast<double>(count) / TESTS * 100.0
			 << endl;
	student.close();
	key.close();
	return 0;
}
