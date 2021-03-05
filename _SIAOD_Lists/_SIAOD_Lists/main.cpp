#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
#include <conio.h>
#include "fstream"
#include "sstream"

using namespace std;

struct Node {
    int ID;

    string SNF;
    string Category;
    int Year;
    string Status;
    string DOC;

    Node * Next;
};

typedef Node * PNode;
PNode Head = NULL;

string int_to_string(int x) {
    char buffer[99];
    sprintf(buffer, "%d", x);
    return buffer;
}

void FileForm(PNode & Head) {
    string str;
    ofstream file;
    PNode LADR = Head;
    file.open("struct.txt");

    for (int i = 0; i < 5; i++) {
        switch (i) {
        case 0: str = "SNF"; file << str; break;
        case 1: str = "Category"; file << str; break;
        case 2: str = "Year"; file << str; break;
        case 3: str = "Status"; file << str; break;
        case 4: str = "DateOfChange"; file << str; break;
        }
        for (int j = 0; j < (15 - str.length()); j++) {
            file << " ";
        }
        str.clear();
    }

    file << '\n';

    while (LADR && LADR != NULL) {
        for (int m = 0; m < 5; m++) {
            switch (m) {
            case 0: str = LADR->SNF; file << str; break;
            case 1: str = LADR->Category; file << str; break;
            case 2: str = int_to_string(LADR->Year); file << str;	break;
            case 3: str = LADR->Status; file << str; break;
            case 4: str = LADR->DOC; file << str; break;
            }

            for (int j = 0; j < (15 - str.length()); j++) {
                file << " ";
            }
            str.clear();
        }

        file << '\n';
        LADR = LADR->Next;
    }
    cout << "Файл успешно сформирован!\n";
    file.close();
}

PNode CreateNode() { // Создание нода/Добавление инфы (новый адрес)
    PNode NewNode = new Node;

    cout << "ФИО Автора: "; cin >> NewNode->SNF;
    cout << "Категория: "; cin >> NewNode->Category;
    cout << "Год: "; cin >> NewNode->Year;
    cout << "Статус: "; cin >> NewNode->Status;
    cout << "Дата изменения статуса: "; cin >> NewNode->DOC;
    cout << "ID книги: "; cin >> NewNode->ID;
    
    NewNode->Next = NULL;
    return NewNode;
}

void AddFirst(PNode & Head, PNode NewNode) { // Добавление первого нода (в начало списка)
    NewNode->Next = Head;
    Head = NewNode;
}

void Add(PNode ADR, PNode NewNode) { // Последующее добавление, наращивание
    NewNode->Next = ADR->Next;
    ADR->Next = NewNode;
}

void LastAdd(PNode & Head, PNode NewNode) { // Добавление в конец
    PNode LADR = Head;
    if (Head == NULL) {
        AddFirst(Head, NewNode);
        return;
    }
    while (LADR->Next) LADR = LADR->Next;
    Add(LADR, NewNode);
    
}

void BeforeAdd(PNode & Head, PNode ADR, PNode NewNode) { // Добавление перед заданным
    PNode LADR = Head;
    if (Head == ADR) {
        AddFirst(Head, NewNode);
        return;
    }
    while (LADR && LADR->Next != ADR) LADR = LADR->Next;
    if (LADR) Add(LADR, NewNode);
}

PNode Search(PNode Head, int SID) { // Поиск (возврат адреса)
    PNode LADR = Head;
    while (LADR && SID != LADR->ID) {
        LADR = LADR->Next;
    }
    return LADR;
}

void Delete(PNode & Head, PNode ADR) { // Удаление
    PNode LADR = Head;
    if (Head == ADR)
        Head = ADR->Next;
    else {
        while (LADR && LADR->Next != ADR)
            LADR = LADR->Next;
            if (LADR == NULL) return;
            LADR->Next = ADR->Next;
    }
    delete ADR;
}

void Show(PNode & Head, bool byID) {
    PNode LADR = Head;
    int ID;
    if (byID) {
        cout << "Введите ID: "; cin >> ID;
        LADR = Search(Head, ID);
    }
    while (LADR && LADR != NULL) {
        cout << "ФИО Автора: "; cout << LADR->SNF << '\n';
        cout << "Категория: "; cout << LADR->Category << '\n';
        cout << "Год: "; cout << LADR->Year << '\n';
        cout << "Статус: "; cout << LADR->Status << '\n';
        cout << "Дата изменения статуса: "; cout << LADR->DOC << '\n';
        LADR = LADR->Next;
    }
}

int main() {
    setlocale(0, "");
    int ID;
    cout << "1 - Создать список/Забить первый элемент\n2 - Добавить нов. элемент в список\n3 - Добавление в конец\n4 - Добавление перед указанным\n5 - Удалить\n6 - Найти (адрес)\n7 - Показать по ID или все сразу\n8 - Сформировать файл\n";
    switch (_getch()) {
    case 49: AddFirst(Head, CreateNode()); break;
    case 50: Add(Head, CreateNode()); break;
    case 51: LastAdd(Head, CreateNode()); break;
    case 52:
        cout << "Введите ID, перед которым надо добавить: "; cin >> ID; BeforeAdd(Head, Search(Head, ID), CreateNode());
        break;
    case 53: 
        cout << "Введите ID, который надо удалить: "; cin >> ID; Delete(Head, Search(Head, ID));
        break;
    case 54: 
        cout << "Введите ID, адрес которого надо найти: "; cin >> ID; cout << "Адрес: " << Search(Head, ID) << '\n';
        break;
    case 55:
        cout << "1 - Вывести по ID\n2 - Вывести все\n";
        switch (_getch()) {
        case 49: Show(Head, true); break;
        case 50: Show(Head, false); break;
        }
        break;
    case 56: FileForm(Head); break;
    }
    main();
}
