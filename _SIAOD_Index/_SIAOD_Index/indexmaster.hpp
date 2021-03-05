#pragma once
#include "iostream"
#include "vector"

namespace Hash {

	bool FL = true;

	std::vector<std::vector<int>> List(10);
	int Chain[10] = { 0, 0, 0, 0, 0, 0, 0, 0 , 0, 0 };

	int HashFunction(int GetData) {
		return GetData % 10;
	}

}
