#include "iostream"
#include "conio.h"
#include "cmath"

using namespace std;

void T1(int mSize) {
    // Метод треугольника

    if (mSize != 3) { // Проверка на валидную размерность
        cout << "Данный метод доступен только для матриц 3х3!\n";
        _getch();  return; // Выброс к рекурсии ф-ции main()
    }

    float ** Array = new float * [mSize]; // Объявление массива
    for (int i = 0; i < mSize; i++) {
        Array[i] = new float[mSize];
    }

    float Arg1 = 1, Arg2 = 1, Arg3 = 1, Arg4 = 1, Arg5 = 1, Arg6 = 1;

    cout << "Введите матрицу:\n";

    for (int i = 0; i < mSize; i++) {
        for (int j = 0; j < mSize; j++) {
            cin >> Array[i][j];
        }
    }

    // Расчеты
    // Диагонали
    for (int i = 0, j = 0; i < mSize; i++) {
        Arg1 *= Array[i][j];
        j++;
    }
    for (int i = mSize - 1, j = 0; j < mSize; j++) {
        Arg4 *= Array[i][j];
        i--;
    }
    // Побочки главной диагонали
    Arg2 = Array[mSize - 1][0] * Array[0][mSize - 2] * Array[mSize - 2][mSize - 1];
    Arg3 = Array[0][mSize - 1] * Array[mSize - 2][0] * Array[mSize - 1][mSize - 2];
    // Побочки побочной диагонали
    Arg5 = Array[0][0] * Array[mSize - 2][mSize - 1] * Array[mSize - 1][mSize - 2];
    Arg6 = Array[mSize - 1][mSize - 1] * Array[0][mSize - 2] * Array[mSize - 2][0];

    cout << "Детерминант данной матрицы: " << Arg1 + Arg2 + Arg3 - Arg4 - Arg5 - Arg6 << '\n';

    _getch();

}

void T2(int mSize) {
    // Треугольная матрица

    float ** Array = new float * [mSize]; // Объявление массива
    for (int i = 0; i < mSize; i++) {
        Array[i] = new float[mSize];
    }

    cout << "Введите матрицу:\n";

    for (int i = 0; i < mSize; i++) {
        for (int j = 0; j < mSize; j++) {
            cin >> Array[i][j];
        }
    }

    if (mSize == 1) {
        cout << "Детерминант данной матрицы: " << Array[0][0] << '\n';
        _getch(); return;
    }

    float buff = 0, times = 1;

    // Триангуляция матрицы
    for (int i = 0; i < mSize - 1; i++) {
        for (int j = i + 1; j < mSize; j++) {
            if (Array[i][i] != 0) {
                buff = Array[j][i] / Array[i][i];
            }
            for (int k = i; k < mSize; k++)
                Array[j][k] -= Array[i][k] * buff;
        }
    }

    /*
    1 2 3
    4 5 6
    7 8 9
    */

    // Поиск детерминанта

    for (int i = 0, j = 0; i < mSize; i++) {
        times *= Array[i][j];
        j++;
    }

    if (times == 0) {
        times *= -1;
    }

    cout << "Детерминант данной матрицы: " << round(times) << '\n';

    _getch();

}

void T3(int mSize) {
    // Разложение определителя по строке или столбцу

    float ** Array = new float * [mSize]; // Объявление массива
    for (int i = 0; i < mSize; i++) {
        Array[i] = new float[mSize];
    }

    float ** exArray = new float * [mSize - 1]; // Объявление доп. матрицы для вычислений детерминантов
    for (int i = 0; i < mSize; i++) {
        exArray[i] = new float[mSize - 1];
    }

    cout << "Введите матрицу:\n";

    for (int i = 0; i < mSize; i++) {
        for (int j = 0; j < mSize; j++) {
            cin >> Array[i][j];
        }
    }

    if (mSize == 1) {
        cout << "Детерминант данной матрицы: " << Array[0][0] << '\n';
        _getch(); return;
    }

    float buff = 0, times = 1, result = 0;

    for (int currentRay = 0; currentRay < mSize; currentRay++) {
        for (int i = 0, exi = 0; i < mSize; i++) {
            for (int j = 0, exj = 0; j < mSize; j++) {
                if (j != currentRay && i != 0) {
                    exArray[exi][exj] = Array[i][j];
                    exj++;
                    if (exj == mSize - 1) {
                        exj = 0; exi++;
                    }
                }
            }
        }

        for (int i = 0; i < (mSize - 1) - 1; i++) {
            for (int j = i + 1; j < mSize - 1; j++) {
                if (exArray[i][i] != 0) {
                    buff = exArray[j][i] / exArray[i][i];
                }
                for (int k = i; k < mSize; k++)
                    exArray[j][k] -= exArray[i][k] * buff;
            }
        }

        for (int i = 0, j = 0; i < mSize - 1; i++) {
            times *= exArray[i][j];
            j++;
        }

        result += ((Array[0][currentRay]) * pow((-1), (1 + (currentRay + 1))) * times);
        times = 1; buff = 0;

    }

    cout << "Детерминант данной матрицы: " << round(result) << '\n';

    _getch();

}

int main() {
    system("cls");
    int mSize;
    setlocale(LC_ALL, "Rus");
    cout << "Введите порядок квдратной матрицы: "; cin >> mSize;
    cout << "Выберите метод поиска определителя\n1 - Метод треугольника (только 3й порядок)\n2 - Метод Гаусса (любой порядок)\n3 - Метод строк (любой порядок)\n";
    switch (_getch()) {
    case 49: system("cls"); T1(mSize); break;
    case 50: system("cls"); T2(mSize); break;
    case 51: system("cls"); T3(mSize); break;
    }
    main(); return 0;
}