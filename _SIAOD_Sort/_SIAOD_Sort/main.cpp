#include "iostream"

void ShellSort(float Array[], int Size) {
	int lSize = Size / 2, buff = 0;
	while (lSize > 0) {
		std::cout << "Ўаг сортировки: " << lSize << '\n';
		for (int i = 0, k = 0; i < Size - lSize; i++) {
			k = i;
			while (k >= 0 && Array[k] > Array[k + lSize]) {
				buff = Array[k];
				Array[k] = Array[k + lSize];
				Array[k + lSize] = buff;
				k--;
			}
			for (int out = 0; out < Size; out++) {
				std::cout << Array[out] << ' ';
			}
			std::cout << '\n';
		}
		lSize /= 2;
	}
}

int main() {
	setlocale(0, "");
	int Size;
	std::cout << "¬ведите число э-тов: "; std::cin >> Size;
	float * Array = new float[Size];
	std::cout << "¬ведите элементы:\n";
	for (int i = 0; i < Size; i++) {
		std::cin >> Array[i];
	}
	ShellSort(Array, Size);
	return 0;
}