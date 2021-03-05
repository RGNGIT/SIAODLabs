#include "indexmaster.hpp"
#include "conio.h"

void Write() {
	system("cls");

	int Readline;
	std::cout << "Введите данные: "; std::cin >> Readline;
	Hash::List[Hash::HashFunction(Readline)][Hash::Chain[Hash::HashFunction(Readline)]] = Readline; 
	std::cout << "Данные " << Readline << ' ';
	std::cout << "записались в блок " << Hash::HashFunction(Readline) << ' ';
	std::cout << "с индексом " << Hash::Chain[Hash::HashFunction(Readline)] << '\n';
	Hash::Chain[Hash::HashFunction(Readline)]++;

	_getch();
}

void Read() {
	system("cls");

	int Readline;
	bool check = true;
	std::cout << "Введите ключ: "; std::cin >> Readline;
	std::cout << "Блок: " << Hash::HashFunction(Readline) << "\nДанные блока: ";
	if (Hash::Chain[Hash::HashFunction(Readline)] == 0) {
		std::cout << "Пусто\n";
		check = false;
	}
	if (check) {
		for (int i = 0; i < Hash::Chain[Hash::HashFunction(Readline)]; i++) {
			std::cout << "\nЯчейка " << i + 1 << ": " << Hash::List[Hash::HashFunction(Readline)][i];
		}
	}

	_getch();
}

void Tab() {
	system("cls");

	for (int i = 0; i < 10; i++) {
		for (int j = 0; j < 10; j++) {
			std::cout << Hash::List[i][j] << ' ';
		}
		std::cout << '\n';
	}

	_getch();
}

void Delete() {
	system("cls");

	int Readline, Index;
	std::cout << "1 - Удалить блок\n2 - Удалить запись по индексу\n";
	switch (_getch()) {
	case 49:
		std::cout << "Номер блока: "; std::cin >> Readline;
		for (int i = 0; i < 10; i++) {
			Hash::List[Readline - 1][i] = 0;
		}
		Hash::Chain[Readline - 1] = 0;
		break;
	case 50:
		std::cout << "Номер блока: "; std::cin >> Readline;
		std::cout << "Номер индекса блока: "; std::cin >> Index;
		Hash::List[Readline - 1][Index - 1] = 0;
		break;
	}

	std::cout << "Успешно!\n";
	_getch();
}

int main() {
	system("cls");

	if (Hash::FL) {
		setlocale(0, "");
		for (int i = 0; i < 10; i++) {
			Hash::List[i] = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
		}
		Hash::FL = false;
	}

	std::cout << "Выберите опцию\n";
	std::cout << "1 - Записать данные\n2 - Считать данные (по хешу)\n3 - Вывод таблицы блоков\n4 - Удаление блока/Записи\n";
	switch (_getch()) {
	case 49: Write(); break;
	case 50: Read(); break;
	case 51: Tab(); break;
	case 52: Delete(); break;
	}

	main();
}