#include "iostream"
#include "Windows.h"

using namespace std;

int main() {
	CreateProcess(L"H:\Aye.jpg", NULL, NULL, NULL, FALSE, NULL, NULL, NULL, NULL, NULL);
}