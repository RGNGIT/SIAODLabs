using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace _SIAODLIB {

    public partial class Form1 : Form {

        public class BookItem { // Класс, определяющий узел, который хранит данные о каждой книге (1 экземпляр класса == 1 книга)
            public string Name; // Название книги
            public string Author; // Автор
            public string UDC; // УДК
            public string Year; // Год выпуска
            public bool Taken; // На руках или нет

            public BookItem Next; // Ссылка на следующий объект в списке
        }

        BookItem Head = null; // Головной объект, к которому прикрепляются все следующие Голова -Next-> Запись -Next-> Запись...
        int BookAmountTotal = 0; // Всего книг
        int BookAmountTaken = 0; // Книг взято

        List<DataGridView> GetGrids = new List<DataGridView>(); // Интерфейс List для объединения таблиц в одну коллекцию (для удобного массового манипулирования ими)

        public Form1() { // Стартовый метод, который стартует с начала работы класса (программы)
            InitializeComponent(); BookCount(); // Инициализация компонентов визуального окна + Подсчет количества книг (изначально по нулям)
            labelDelErr.Text = String.Empty; // Дадее очистка строк в окне
            labelGiveErr.Text = String.Empty;
            labelAddErr.Text = String.Empty;
            labelFileInfo.Text = String.Empty;
            dataGridViewSDel.Columns.Add("_name", "Предложенные варианты по первой литере"); // Далее добавление столбца в маленькие таблицы поиска
            dataGridViewSGive.Columns.Add("_name", "Предложенные варианты по первой литере");
            GetGrids.Add(dataGridViewList); // Добавляем большие таблицы в одну коллекцию
            GetGrids.Add(dataGridViewInStock);
            GetGrids.Add(dataGridViewOut);
            foreach (DataGridView CurrentGrid in GetGrids) { // Обход всех таблиц с заполнением их столбцами
                CurrentGrid.Columns.Add("_name", "Название");
                CurrentGrid.Columns.Add("_author", "Автор");
                CurrentGrid.Columns.Add("_UDC", "УДК");
                CurrentGrid.Columns.Add("_year", "Год издания");
            }
        }

        void BookCount() { // Подсчет книг 
            labelBookTotal.Text = $"Книг всего: {BookAmountTotal}";
            labelBookGiven.Text = $"Книг на руках: {BookAmountTaken}";
            labelBookRemain.Text = $"Книг осталось: {BookAmountTotal - BookAmountTaken}";
        }

        void Updater() { // Метод обновления таблиц
            BookItem LADR; // Объявляем локальный указатель на элементы связного списка
            foreach (DataGridView CurrentGrid in GetGrids) { // Обход всех таблиц
                LADR = Head; CurrentGrid.Rows.Clear(); // Ставим локальный указатель на голову и чистим таблицу
                while (LADR != null) { // Пока не конец списка
                    switch (CurrentGrid.Name) { // Заполняем каждую таблицу согласно ее условиям
                        case "dataGridViewList": ListGridAddList(LADR); break;
                        case "dataGridViewInStock": ListGridAddInStock(LADR); break;
                        case "dataGridViewOut": ListGridAddOut(LADR); break;
                    }
                    LADR = LADR.Next; // Переход на следующий узел
                }
            }
            BookCount(); // Вызов подсчета
        }

        void WriteFile() { // Запись в файл
            string GetData = $"Кол-во записей: <{BookAmountTotal}>\nКниг на руках: <{BookAmountTaken}>\n"; // Записываем количества книг
            BookItem LADR = Head; // Указатель
            int Node = 0; // Текущая запись
            while (LADR != null) { // Пока не конец
                GetData += $"[Запись {Node}]\n"; // Записываем поля
                GetData += $"Название: <{LADR.Name}>\n";
                GetData += $"Автор: <{LADR.Author}>\n";
                GetData += $"УДК: <{LADR.UDC}>\n";
                GetData += $"Год издания: <{LADR.Year}>\n";
                GetData += $"На руках?: <{Convert.ToInt32(LADR.Taken)}>\n";
                LADR = LADR.Next; Node++; // Переключамся на след. узел и делаем инкремент номера текущей записи
            }
            File.WriteAllText(@"file.txt", GetData); // Вывод в файл
        }

        void ReadFile() { // Считывание из файла
            try { // Пробуем выполнить считывание
                string[] GetData = File.ReadAllLines(@"file.txt"); // Считываем файл построчно в массив
                Regex lRegex = new Regex(@"<(.*)>"); // Регулярное выражение для извлечения данных между <//данные//>
                Head = new BookItem(); BookItem LADR = Head; // Создаем головной узел, делаем локальный указатель
                BookAmountTotal = Convert.ToInt32(lRegex.Match(GetData[0]).Groups[1].Value); // Забиваем количества книг в программу
                BookAmountTaken = Convert.ToInt32(lRegex.Match(GetData[1]).Groups[1].Value);
                for (int j = 0; j < BookAmountTotal - 1; j++) { // На основе количества книг создаем пустые узлы списка для последующего заполнения
                    LADR.Next = new BookItem();
                    LADR = LADR.Next;
                }
                int i = 3; LADR = Head; while (i < GetData.Length) { // Начиная с третьей (считая с нуля) строчки в файле начинаем записывать данные в список поэлементно по полочкам
                    LADR.Name = lRegex.Match(GetData[i]).Groups[1].Value; i++;
                    LADR.Author = lRegex.Match(GetData[i]).Groups[1].Value; i++;
                    LADR.UDC = lRegex.Match(GetData[i]).Groups[1].Value; i++;
                    LADR.Year = lRegex.Match(GetData[i]).Groups[1].Value; i++;
                    LADR.Taken = Convert.ToBoolean(Convert.ToInt32(lRegex.Match(GetData[i]).Groups[1].Value));
                    i += 2; LADR = LADR.Next; // Переход на след. узел
                }
                labelFileInfo.Text = "Файл успешно считан!"; Updater();
            }
            catch (FileNotFoundException) { // Если файла нет
                Head = null;
                foreach (DataGridView CurrentGrid in GetGrids) {
                    CurrentGrid.Rows.Clear(); // Чистим таблицы
                }
                labelFileInfo.Text = "Доступных для загрузки файлов не найдено!";
            }
            catch (FormatException) { // Если файл неверного формата
                Head = null;
                foreach (DataGridView CurrentGrid in GetGrids) {
                    CurrentGrid.Rows.Clear(); // Чистим таблицы
                }
                labelFileInfo.Text = "Файл имеет неверную структуру и/или поврежден!";
            }
        }

        void ListGridAddList(BookItem Item) { // Методы добавления записей в таблицы (по столбцам соответственно)
            dataGridViewList.Rows.Add(Item.Name, Item.Author, Item.UDC, Item.Year); 
        }
        void ListGridAddInStock(BookItem Item) { 
            if (!Item.Taken) dataGridViewInStock.Rows.Add(Item.Name, Item.Author, Item.UDC, Item.Year); 
        }
        void ListGridAddOut(BookItem Item) { 
            if (Item.Taken) dataGridViewOut.Rows.Add(Item.Name, Item.Author, Item.UDC, Item.Year); 
        }

        private void tabControl_Click(object sender, EventArgs e) => Updater(); // Лямбда-функции, отвечающие за обработку нажатий некоторых кнопок
        private void buttonSave_Click(object sender, EventArgs e) => WriteFile();
        private void buttonRead_Click(object sender, EventArgs e) => ReadFile();
        private void dataGridViewSGive_CellContentClick(object sender, DataGridViewCellEventArgs e) => textBoxGive.Text = dataGridViewSGive[0, dataGridViewSGive.CurrentRow.Index].Value.ToString(); // Тут забиваем данные из таблички поиска в строку поиска по нажатию
        private void dataGridViewSDel_CellContentClick(object sender, DataGridViewCellEventArgs e) => textBoxDelName.Text = dataGridViewSDel[0, dataGridViewSDel.CurrentRow.Index].Value.ToString();

        private void buttonAdd_Click(object sender, EventArgs e) { // Метод добавления в список
            if (textBoxAddName.Text == String.Empty || textBoxAddAuthor.Text == String.Empty || textBoxAddUDC.Text == String.Empty || textBoxAddYear.Text == String.Empty) {
                labelAddErr.Text = "Добавление невозможно. Некоторые поля пустые!"; return; // Если поля пустые, выкидываем
            }
            if (Head == null) { // Если список пуст (нет головы) создаем новый узел в голову
                Head = new BookItem();
                Head.Name = textBoxAddName.Text;
                Head.Author = textBoxAddAuthor.Text;
                Head.UDC = textBoxAddUDC.Text;
                Head.Year = textBoxAddYear.Text;
                Head.Next = null;
            } else {
                BookItem LADR = Head; // Если голова есть - просто прикрепляем к ней новый узел
                while (LADR.Next != null) {
                    LADR = LADR.Next;
                }
                LADR.Next = new BookItem();
                LADR.Next.Name = textBoxAddName.Text;
                LADR.Next.Author = textBoxAddAuthor.Text;
                LADR.Next.UDC = textBoxAddUDC.Text;
                LADR.Next.Year = textBoxAddYear.Text;
                LADR.Next.Next = null;
            }
            labelAddErr.Text = "Успешно!"; BookAmountTotal++; BookCount(); Updater(); // Инкремент количества книг + подсчет + записываем в таблицы
        }

        private void buttonDelete_Click(object sender, EventArgs e) { // Удаление узлов
            if (Head == null) { labelDelErr.Text = "Удаление невозможно, база книг пуста!"; return; } // Если список пуст (нет головы)
            if (!Head.Taken) { // Если книга не на руках
                if (Head.Name == textBoxDelName.Text && Head.Next == null) {
                    Head = null; DelActions(); return; // Если голова единственная - удаляем ее
                }
                if (Head.Name == textBoxDelName.Text && Head.Next != null) {
                    Head = Head.Next; DelActions(); return; // Если список из более двух нодов - ставим новую голову на следующий элемент
                }
            } else {
                labelDelErr.Text = "Удаление невозможно, книга на руках!"; return;
            }
            BookItem LADR = Head; // Локальный указатель
            while (LADR.Next != null) { // Пока не конец списка
                if (!LADR.Next.Taken) { // Если книга не на руках
                    if (LADR.Next.Name == textBoxDelName.Text && LADR.Next.Next == null) {
                        LADR.Next = null; DelActions(); return; // Если у узла нет потомков - удаляем
                    }
                    if (LADR.Next.Name == textBoxDelName.Text && LADR.Next.Next != null) {
                        LADR.Next = LADR.Next.Next; DelActions(); return; // Если у узла есть потомок - соединяем два соседствующих узла
                    }
                } else {
                    labelDelErr.Text = "Удаление невозможно, книга на руках!"; return;
                }
                LADR = LADR.Next;
            }
            labelDelErr.Text = "Книга не найдена!";
        }

        void DelActions() {
            labelDelErr.Text = "Успешно удалено!"; BookAmountTotal--; BookCount(); Updater(); // После удаления декремент кол-ва книг + подсчет + обновление таблиц
        }

        private void buttonGive_Click(object sender, EventArgs e) { // Выдача книги
            if (textBoxGive.Text == String.Empty) { // Если поле пустое
                labelGiveErr.Text = "Выдача невозможна, поле пустое!"; return;
            }
            BookItem LADR = Head; // Локальный указатель
            while (LADR != null) { // Пока не конец списка
                if (LADR.Name == textBoxGive.Text && !LADR.Taken) { // Если совпало название и книга не была выдана
                    LADR.Taken = true; labelGiveErr.Text = "Книга выдана!"; BookAmountTaken++; Updater(); return;
                } else if (LADR.Name == textBoxGive.Text && LADR.Taken) { // Если книга уже на руках
                    labelGiveErr.Text = "Книга уже на руках!"; return;
                }
                LADR = LADR.Next;
            }
            labelGiveErr.Text = "Книга не найдена!";
        }

        private void buttonReturn_Click(object sender, EventArgs e) { // Метод возврата книги в библиотеку (почти идентично выше)
            if (textBoxGive.Text == String.Empty) {
                labelGiveErr.Text = "Возврат невозможен, поле пустое!"; return;
            }
            BookItem LADR = Head;
            while (LADR != null) {
                if (LADR.Name == textBoxGive.Text && LADR.Taken) {
                    LADR.Taken = false; labelGiveErr.Text = "Книга изъята!"; BookAmountTaken--; Updater(); return;
                } else if(LADR.Name == textBoxGive.Text && !LADR.Taken) {
                    labelGiveErr.Text = "Книга не выдана!"; return;
                }
                LADR = LADR.Next;
            }
            labelGiveErr.Text = "Книга не найдена!";
        }

        private void textBoxDelName_TextChanged(object sender, EventArgs e) { // Методы заполнения табличек поиска
            dataGridViewSDel.Rows.Clear(); // Сначала чистка таблицы
            if (textBoxDelName.Text == String.Empty) return; // Если строка поиска пуста - завершаем метод
            BookItem LADR = Head;
            while (LADR != null) {
                if (textBoxDelName.Text[0] == LADR.Name[0]) { // Ищем книги по первой букве
                    dataGridViewSDel.Rows.Add(LADR.Name); // Добавляем совпадения в список
                }
                LADR = LADR.Next;
            }
        }

        private void textBoxGive_TextChanged(object sender, EventArgs e) { // Идентично выше, но для выдачи
            dataGridViewSGive.Rows.Clear();
            if (textBoxGive.Text == String.Empty) return;
            BookItem LADR = Head; 
            while (LADR != null)
            {
                if (textBoxGive.Text[0] == LADR.Name[0])
                {
                    dataGridViewSGive.Rows.Add(LADR.Name);
                }
                LADR = LADR.Next;
            }
        }

    }
}
