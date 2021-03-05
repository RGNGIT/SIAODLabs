
namespace _SIAODLIB
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.wholeList = new System.Windows.Forms.TabPage();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.inStock = new System.Windows.Forms.TabPage();
            this.dataGridViewInStock = new System.Windows.Forms.DataGridView();
            this.tabPageOut = new System.Windows.Forms.TabPage();
            this.dataGridViewOut = new System.Windows.Forms.DataGridView();
            this.labelBookTotal = new System.Windows.Forms.Label();
            this.labelBookRemain = new System.Windows.Forms.Label();
            this.labelBookGiven = new System.Windows.Forms.Label();
            this.dataGridViewSGive = new System.Windows.Forms.DataGridView();
            this.tabPageFile = new System.Windows.Forms.TabPage();
            this.labelFileInfo = new System.Windows.Forms.Label();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tabPageActGive = new System.Windows.Forms.TabPage();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonGive = new System.Windows.Forms.Button();
            this.labelGiveErr = new System.Windows.Forms.Label();
            this.textBoxGive = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageActRemove = new System.Windows.Forms.TabPage();
            this.dataGridViewSDel = new System.Windows.Forms.DataGridView();
            this.labelDelErr = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxDelName = new System.Windows.Forms.TextBox();
            this.labelDelName = new System.Windows.Forms.Label();
            this.tabPageActAdd = new System.Windows.Forms.TabPage();
            this.labelAddErr = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxAddYear = new System.Windows.Forms.TextBox();
            this.textBoxAddUDC = new System.Windows.Forms.TextBox();
            this.textBoxAddAuthor = new System.Windows.Forms.TextBox();
            this.textBoxAddName = new System.Windows.Forms.TextBox();
            this.labelAddYear = new System.Windows.Forms.Label();
            this.labelAddUDC = new System.Windows.Forms.Label();
            this.labelAddAuthor = new System.Windows.Forms.Label();
            this.labelAddName = new System.Windows.Forms.Label();
            this.tabControlActions = new System.Windows.Forms.TabControl();
            this.tabControl.SuspendLayout();
            this.wholeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            this.inStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInStock)).BeginInit();
            this.tabPageOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSGive)).BeginInit();
            this.tabPageFile.SuspendLayout();
            this.tabPageActGive.SuspendLayout();
            this.tabPageActRemove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSDel)).BeginInit();
            this.tabPageActAdd.SuspendLayout();
            this.tabControlActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.wholeList);
            this.tabControl.Controls.Add(this.inStock);
            this.tabControl.Controls.Add(this.tabPageOut);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(451, 426);
            this.tabControl.TabIndex = 0;
            this.tabControl.Click += new System.EventHandler(this.tabControl_Click);
            // 
            // wholeList
            // 
            this.wholeList.Controls.Add(this.dataGridViewList);
            this.wholeList.Location = new System.Drawing.Point(4, 22);
            this.wholeList.Name = "wholeList";
            this.wholeList.Padding = new System.Windows.Forms.Padding(3);
            this.wholeList.Size = new System.Drawing.Size(443, 400);
            this.wholeList.TabIndex = 0;
            this.wholeList.Text = "Все книги";
            this.wholeList.UseVisualStyleBackColor = true;
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewList.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.Size = new System.Drawing.Size(443, 400);
            this.dataGridViewList.TabIndex = 0;
            // 
            // inStock
            // 
            this.inStock.Controls.Add(this.dataGridViewInStock);
            this.inStock.Location = new System.Drawing.Point(4, 22);
            this.inStock.Name = "inStock";
            this.inStock.Padding = new System.Windows.Forms.Padding(3);
            this.inStock.Size = new System.Drawing.Size(443, 400);
            this.inStock.TabIndex = 1;
            this.inStock.Text = "В наличии";
            this.inStock.UseVisualStyleBackColor = true;
            // 
            // dataGridViewInStock
            // 
            this.dataGridViewInStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInStock.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewInStock.Name = "dataGridViewInStock";
            this.dataGridViewInStock.Size = new System.Drawing.Size(443, 400);
            this.dataGridViewInStock.TabIndex = 1;
            // 
            // tabPageOut
            // 
            this.tabPageOut.Controls.Add(this.dataGridViewOut);
            this.tabPageOut.Location = new System.Drawing.Point(4, 22);
            this.tabPageOut.Name = "tabPageOut";
            this.tabPageOut.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOut.Size = new System.Drawing.Size(443, 400);
            this.tabPageOut.TabIndex = 2;
            this.tabPageOut.Text = "На руках";
            this.tabPageOut.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOut
            // 
            this.dataGridViewOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOut.Name = "dataGridViewOut";
            this.dataGridViewOut.Size = new System.Drawing.Size(443, 400);
            this.dataGridViewOut.TabIndex = 1;
            // 
            // labelBookTotal
            // 
            this.labelBookTotal.AutoSize = true;
            this.labelBookTotal.Location = new System.Drawing.Point(470, 395);
            this.labelBookTotal.Name = "labelBookTotal";
            this.labelBookTotal.Size = new System.Drawing.Size(61, 13);
            this.labelBookTotal.TabIndex = 2;
            this.labelBookTotal.Text = "$bookTotal";
            // 
            // labelBookRemain
            // 
            this.labelBookRemain.AutoSize = true;
            this.labelBookRemain.Location = new System.Drawing.Point(470, 421);
            this.labelBookRemain.Name = "labelBookRemain";
            this.labelBookRemain.Size = new System.Drawing.Size(73, 13);
            this.labelBookRemain.TabIndex = 3;
            this.labelBookRemain.Text = "$bookRemain";
            // 
            // labelBookGiven
            // 
            this.labelBookGiven.AutoSize = true;
            this.labelBookGiven.Location = new System.Drawing.Point(470, 408);
            this.labelBookGiven.Name = "labelBookGiven";
            this.labelBookGiven.Size = new System.Drawing.Size(65, 13);
            this.labelBookGiven.TabIndex = 4;
            this.labelBookGiven.Text = "$bookGiven";
            // 
            // dataGridViewSGive
            // 
            this.dataGridViewSGive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSGive.Location = new System.Drawing.Point(9, 58);
            this.dataGridViewSGive.Name = "dataGridViewSGive";
            this.dataGridViewSGive.ReadOnly = true;
            this.dataGridViewSGive.Size = new System.Drawing.Size(296, 232);
            this.dataGridViewSGive.TabIndex = 2;
            this.dataGridViewSGive.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSGive_CellContentClick);
            // 
            // tabPageFile
            // 
            this.tabPageFile.Controls.Add(this.labelFileInfo);
            this.tabPageFile.Controls.Add(this.buttonRead);
            this.tabPageFile.Controls.Add(this.buttonSave);
            this.tabPageFile.Location = new System.Drawing.Point(4, 22);
            this.tabPageFile.Name = "tabPageFile";
            this.tabPageFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFile.Size = new System.Drawing.Size(311, 354);
            this.tabPageFile.TabIndex = 3;
            this.tabPageFile.Text = "Файл";
            this.tabPageFile.UseVisualStyleBackColor = true;
            // 
            // labelFileInfo
            // 
            this.labelFileInfo.AutoSize = true;
            this.labelFileInfo.Location = new System.Drawing.Point(6, 3);
            this.labelFileInfo.Name = "labelFileInfo";
            this.labelFileInfo.Size = new System.Drawing.Size(47, 13);
            this.labelFileInfo.TabIndex = 16;
            this.labelFileInfo.Text = "$FileInfo";
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(9, 325);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(296, 23);
            this.buttonRead.TabIndex = 15;
            this.buttonRead.Text = "Считать";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(9, 296);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(296, 23);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Записать";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // tabPageActGive
            // 
            this.tabPageActGive.Controls.Add(this.dataGridViewSGive);
            this.tabPageActGive.Controls.Add(this.buttonReturn);
            this.tabPageActGive.Controls.Add(this.buttonGive);
            this.tabPageActGive.Controls.Add(this.labelGiveErr);
            this.tabPageActGive.Controls.Add(this.textBoxGive);
            this.tabPageActGive.Controls.Add(this.label1);
            this.tabPageActGive.Location = new System.Drawing.Point(4, 22);
            this.tabPageActGive.Name = "tabPageActGive";
            this.tabPageActGive.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageActGive.Size = new System.Drawing.Size(311, 354);
            this.tabPageActGive.TabIndex = 2;
            this.tabPageActGive.Text = "Выдать/Вернуть";
            this.tabPageActGive.UseVisualStyleBackColor = true;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(9, 325);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(296, 23);
            this.buttonReturn.TabIndex = 14;
            this.buttonReturn.Text = "Вернуть";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonGive
            // 
            this.buttonGive.Location = new System.Drawing.Point(9, 296);
            this.buttonGive.Name = "buttonGive";
            this.buttonGive.Size = new System.Drawing.Size(296, 23);
            this.buttonGive.TabIndex = 13;
            this.buttonGive.Text = "Выдать";
            this.buttonGive.UseVisualStyleBackColor = true;
            this.buttonGive.Click += new System.EventHandler(this.buttonGive_Click);
            // 
            // labelGiveErr
            // 
            this.labelGiveErr.AutoSize = true;
            this.labelGiveErr.Location = new System.Drawing.Point(6, 42);
            this.labelGiveErr.Name = "labelGiveErr";
            this.labelGiveErr.Size = new System.Drawing.Size(49, 13);
            this.labelGiveErr.TabIndex = 12;
            this.labelGiveErr.Text = "$OnError";
            // 
            // textBoxGive
            // 
            this.textBoxGive.Location = new System.Drawing.Point(9, 19);
            this.textBoxGive.Name = "textBoxGive";
            this.textBoxGive.Size = new System.Drawing.Size(296, 20);
            this.textBoxGive.TabIndex = 4;
            this.textBoxGive.TextChanged += new System.EventHandler(this.textBoxGive_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название";
            // 
            // tabPageActRemove
            // 
            this.tabPageActRemove.Controls.Add(this.dataGridViewSDel);
            this.tabPageActRemove.Controls.Add(this.labelDelErr);
            this.tabPageActRemove.Controls.Add(this.buttonDelete);
            this.tabPageActRemove.Controls.Add(this.textBoxDelName);
            this.tabPageActRemove.Controls.Add(this.labelDelName);
            this.tabPageActRemove.Location = new System.Drawing.Point(4, 22);
            this.tabPageActRemove.Name = "tabPageActRemove";
            this.tabPageActRemove.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageActRemove.Size = new System.Drawing.Size(311, 354);
            this.tabPageActRemove.TabIndex = 1;
            this.tabPageActRemove.Text = "Удалить";
            this.tabPageActRemove.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSDel
            // 
            this.dataGridViewSDel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSDel.Location = new System.Drawing.Point(9, 58);
            this.dataGridViewSDel.Name = "dataGridViewSDel";
            this.dataGridViewSDel.ReadOnly = true;
            this.dataGridViewSDel.Size = new System.Drawing.Size(296, 232);
            this.dataGridViewSDel.TabIndex = 12;
            this.dataGridViewSDel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSDel_CellContentClick);
            // 
            // labelDelErr
            // 
            this.labelDelErr.AutoSize = true;
            this.labelDelErr.Location = new System.Drawing.Point(6, 42);
            this.labelDelErr.Name = "labelDelErr";
            this.labelDelErr.Size = new System.Drawing.Size(49, 13);
            this.labelDelErr.TabIndex = 11;
            this.labelDelErr.Text = "$OnError";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(9, 325);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(296, 23);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxDelName
            // 
            this.textBoxDelName.Location = new System.Drawing.Point(9, 19);
            this.textBoxDelName.Name = "textBoxDelName";
            this.textBoxDelName.Size = new System.Drawing.Size(296, 20);
            this.textBoxDelName.TabIndex = 3;
            this.textBoxDelName.TextChanged += new System.EventHandler(this.textBoxDelName_TextChanged);
            // 
            // labelDelName
            // 
            this.labelDelName.AutoSize = true;
            this.labelDelName.Location = new System.Drawing.Point(6, 3);
            this.labelDelName.Name = "labelDelName";
            this.labelDelName.Size = new System.Drawing.Size(57, 13);
            this.labelDelName.TabIndex = 2;
            this.labelDelName.Text = "Название";
            // 
            // tabPageActAdd
            // 
            this.tabPageActAdd.Controls.Add(this.labelAddErr);
            this.tabPageActAdd.Controls.Add(this.buttonAdd);
            this.tabPageActAdd.Controls.Add(this.textBoxAddYear);
            this.tabPageActAdd.Controls.Add(this.textBoxAddUDC);
            this.tabPageActAdd.Controls.Add(this.textBoxAddAuthor);
            this.tabPageActAdd.Controls.Add(this.textBoxAddName);
            this.tabPageActAdd.Controls.Add(this.labelAddYear);
            this.tabPageActAdd.Controls.Add(this.labelAddUDC);
            this.tabPageActAdd.Controls.Add(this.labelAddAuthor);
            this.tabPageActAdd.Controls.Add(this.labelAddName);
            this.tabPageActAdd.Location = new System.Drawing.Point(4, 22);
            this.tabPageActAdd.Name = "tabPageActAdd";
            this.tabPageActAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageActAdd.Size = new System.Drawing.Size(311, 354);
            this.tabPageActAdd.TabIndex = 0;
            this.tabPageActAdd.Text = "Добавить";
            this.tabPageActAdd.UseVisualStyleBackColor = true;
            // 
            // labelAddErr
            // 
            this.labelAddErr.AutoSize = true;
            this.labelAddErr.Location = new System.Drawing.Point(6, 159);
            this.labelAddErr.Name = "labelAddErr";
            this.labelAddErr.Size = new System.Drawing.Size(49, 13);
            this.labelAddErr.TabIndex = 12;
            this.labelAddErr.Text = "$OnError";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(9, 325);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(296, 23);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxAddYear
            // 
            this.textBoxAddYear.Location = new System.Drawing.Point(9, 136);
            this.textBoxAddYear.Name = "textBoxAddYear";
            this.textBoxAddYear.Size = new System.Drawing.Size(296, 20);
            this.textBoxAddYear.TabIndex = 8;
            // 
            // textBoxAddUDC
            // 
            this.textBoxAddUDC.Location = new System.Drawing.Point(9, 97);
            this.textBoxAddUDC.Name = "textBoxAddUDC";
            this.textBoxAddUDC.Size = new System.Drawing.Size(296, 20);
            this.textBoxAddUDC.TabIndex = 6;
            // 
            // textBoxAddAuthor
            // 
            this.textBoxAddAuthor.Location = new System.Drawing.Point(9, 58);
            this.textBoxAddAuthor.Name = "textBoxAddAuthor";
            this.textBoxAddAuthor.Size = new System.Drawing.Size(296, 20);
            this.textBoxAddAuthor.TabIndex = 4;
            // 
            // textBoxAddName
            // 
            this.textBoxAddName.Location = new System.Drawing.Point(9, 19);
            this.textBoxAddName.Name = "textBoxAddName";
            this.textBoxAddName.Size = new System.Drawing.Size(296, 20);
            this.textBoxAddName.TabIndex = 2;
            // 
            // labelAddYear
            // 
            this.labelAddYear.AutoSize = true;
            this.labelAddYear.Location = new System.Drawing.Point(6, 120);
            this.labelAddYear.Name = "labelAddYear";
            this.labelAddYear.Size = new System.Drawing.Size(70, 13);
            this.labelAddYear.TabIndex = 7;
            this.labelAddYear.Text = "Год издания";
            // 
            // labelAddUDC
            // 
            this.labelAddUDC.AutoSize = true;
            this.labelAddUDC.Location = new System.Drawing.Point(6, 81);
            this.labelAddUDC.Name = "labelAddUDC";
            this.labelAddUDC.Size = new System.Drawing.Size(31, 13);
            this.labelAddUDC.TabIndex = 5;
            this.labelAddUDC.Text = "УДК";
            // 
            // labelAddAuthor
            // 
            this.labelAddAuthor.AutoSize = true;
            this.labelAddAuthor.Location = new System.Drawing.Point(6, 42);
            this.labelAddAuthor.Name = "labelAddAuthor";
            this.labelAddAuthor.Size = new System.Drawing.Size(37, 13);
            this.labelAddAuthor.TabIndex = 3;
            this.labelAddAuthor.Text = "Автор";
            // 
            // labelAddName
            // 
            this.labelAddName.AutoSize = true;
            this.labelAddName.Location = new System.Drawing.Point(6, 3);
            this.labelAddName.Name = "labelAddName";
            this.labelAddName.Size = new System.Drawing.Size(57, 13);
            this.labelAddName.TabIndex = 1;
            this.labelAddName.Text = "Название";
            // 
            // tabControlActions
            // 
            this.tabControlActions.Controls.Add(this.tabPageActAdd);
            this.tabControlActions.Controls.Add(this.tabPageActRemove);
            this.tabControlActions.Controls.Add(this.tabPageActGive);
            this.tabControlActions.Controls.Add(this.tabPageFile);
            this.tabControlActions.Location = new System.Drawing.Point(469, 12);
            this.tabControlActions.Name = "tabControlActions";
            this.tabControlActions.SelectedIndex = 0;
            this.tabControlActions.Size = new System.Drawing.Size(319, 380);
            this.tabControlActions.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelBookGiven);
            this.Controls.Add(this.labelBookRemain);
            this.Controls.Add(this.labelBookTotal);
            this.Controls.Add(this.tabControlActions);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Учет библиотеки";
            this.tabControl.ResumeLayout(false);
            this.wholeList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            this.inStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInStock)).EndInit();
            this.tabPageOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSGive)).EndInit();
            this.tabPageFile.ResumeLayout(false);
            this.tabPageFile.PerformLayout();
            this.tabPageActGive.ResumeLayout(false);
            this.tabPageActGive.PerformLayout();
            this.tabPageActRemove.ResumeLayout(false);
            this.tabPageActRemove.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSDel)).EndInit();
            this.tabPageActAdd.ResumeLayout(false);
            this.tabPageActAdd.PerformLayout();
            this.tabControlActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage wholeList;
        private System.Windows.Forms.TabPage inStock;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.TabPage tabPageOut;
        private System.Windows.Forms.DataGridView dataGridViewInStock;
        private System.Windows.Forms.DataGridView dataGridViewOut;
        private System.Windows.Forms.Label labelBookTotal;
        private System.Windows.Forms.Label labelBookRemain;
        private System.Windows.Forms.Label labelBookGiven;
        private System.Windows.Forms.DataGridView dataGridViewSGive;
        private System.Windows.Forms.TabPage tabPageFile;
        private System.Windows.Forms.Label labelFileInfo;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TabPage tabPageActGive;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonGive;
        private System.Windows.Forms.Label labelGiveErr;
        private System.Windows.Forms.TextBox textBoxGive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageActRemove;
        private System.Windows.Forms.Label labelDelErr;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxDelName;
        private System.Windows.Forms.Label labelDelName;
        private System.Windows.Forms.TabPage tabPageActAdd;
        private System.Windows.Forms.Label labelAddErr;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxAddYear;
        private System.Windows.Forms.TextBox textBoxAddUDC;
        private System.Windows.Forms.TextBox textBoxAddAuthor;
        private System.Windows.Forms.TextBox textBoxAddName;
        private System.Windows.Forms.Label labelAddYear;
        private System.Windows.Forms.Label labelAddUDC;
        private System.Windows.Forms.Label labelAddAuthor;
        private System.Windows.Forms.Label labelAddName;
        private System.Windows.Forms.TabControl tabControlActions;
        private System.Windows.Forms.DataGridView dataGridViewSDel;
    }
}

