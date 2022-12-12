
namespace экзамен
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
            this.Panel1_List = new System.Windows.Forms.Panel();
            this.Вutton2_7 = new System.Windows.Forms.Button();
            this.Button3_All = new System.Windows.Forms.Button();
            this.Panel1_Min = new System.Windows.Forms.Panel();
            this.Button1_Min = new System.Windows.Forms.Button();
            this.textBox1_Min = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1_Entity = new System.Windows.Forms.Button();
            this.panel1_del = new System.Windows.Forms.Panel();
            this.button1_DelStud = new System.Windows.Forms.Button();
            this.textBox1_DelStud = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1_FindGroup = new System.Windows.Forms.Panel();
            this.button1_AVG = new System.Windows.Forms.Button();
            this.textBox1_group = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1_Async = new System.Windows.Forms.Button();
            this.button1_Offline = new System.Windows.Forms.Button();
            this.button1_Online = new System.Windows.Forms.Button();
            this.Panel1_List.SuspendLayout();
            this.Panel1_Min.SuspendLayout();
            this.panel1_del.SuspendLayout();
            this.panel1_FindGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1_List
            // 
            this.Panel1_List.Controls.Add(this.Вutton2_7);
            this.Panel1_List.Controls.Add(this.Button3_All);
            this.Panel1_List.Location = new System.Drawing.Point(595, 40);
            this.Panel1_List.Name = "Panel1_List";
            this.Panel1_List.Size = new System.Drawing.Size(162, 224);
            this.Panel1_List.TabIndex = 21;
            this.Panel1_List.Visible = false;
            // 
            // Вutton2_7
            // 
            this.Вutton2_7.Location = new System.Drawing.Point(2, 125);
            this.Вutton2_7.Name = "Вutton2_7";
            this.Вutton2_7.Size = new System.Drawing.Size(151, 61);
            this.Вutton2_7.TabIndex = 11;
            this.Вutton2_7.Text = "Студенты, получившие за экзамен оценку выше 7";
            this.Вutton2_7.UseVisualStyleBackColor = true;
            this.Вutton2_7.Click += new System.EventHandler(this.Вutton2_7_Click);
            // 
            // Button3_All
            // 
            this.Button3_All.Location = new System.Drawing.Point(2, 32);
            this.Button3_All.Name = "Button3_All";
            this.Button3_All.Size = new System.Drawing.Size(151, 62);
            this.Button3_All.TabIndex = 10;
            this.Button3_All.Text = "Список студентов, сгруппированный по оценкам";
            this.Button3_All.UseVisualStyleBackColor = true;
            this.Button3_All.Click += new System.EventHandler(this.Button3_All_Click);
            // 
            // Panel1_Min
            // 
            this.Panel1_Min.Controls.Add(this.Button1_Min);
            this.Panel1_Min.Controls.Add(this.textBox1_Min);
            this.Panel1_Min.Controls.Add(this.label3);
            this.Panel1_Min.Location = new System.Drawing.Point(491, 301);
            this.Panel1_Min.Name = "Panel1_Min";
            this.Panel1_Min.Size = new System.Drawing.Size(240, 116);
            this.Panel1_Min.TabIndex = 19;
            this.Panel1_Min.Visible = false;
            // 
            // Button1_Min
            // 
            this.Button1_Min.Location = new System.Drawing.Point(15, 83);
            this.Button1_Min.Name = "Button1_Min";
            this.Button1_Min.Size = new System.Drawing.Size(193, 23);
            this.Button1_Min.TabIndex = 6;
            this.Button1_Min.Text = "Минимальная оценка за экзамен ";
            this.Button1_Min.UseVisualStyleBackColor = true;
            this.Button1_Min.Click += new System.EventHandler(this.Button1_Min_Click);
            // 
            // textBox1_Min
            // 
            this.textBox1_Min.Location = new System.Drawing.Point(15, 42);
            this.textBox1_Min.Name = "textBox1_Min";
            this.textBox1_Min.Size = new System.Drawing.Size(193, 20);
            this.textBox1_Min.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите группу:";
            // 
            // button1_Entity
            // 
            this.button1_Entity.Location = new System.Drawing.Point(43, 232);
            this.button1_Entity.Name = "button1_Entity";
            this.button1_Entity.Size = new System.Drawing.Size(151, 42);
            this.button1_Entity.TabIndex = 20;
            this.button1_Entity.Text = "Entity Framework";
            this.button1_Entity.UseVisualStyleBackColor = true;
            this.button1_Entity.Click += new System.EventHandler(this.button1_Entity_Click);
            // 
            // panel1_del
            // 
            this.panel1_del.Controls.Add(this.button1_DelStud);
            this.panel1_del.Controls.Add(this.textBox1_DelStud);
            this.panel1_del.Controls.Add(this.label2);
            this.panel1_del.Location = new System.Drawing.Point(255, 301);
            this.panel1_del.Name = "panel1_del";
            this.panel1_del.Size = new System.Drawing.Size(213, 116);
            this.panel1_del.TabIndex = 18;
            this.panel1_del.Visible = false;
            // 
            // button1_DelStud
            // 
            this.button1_DelStud.Location = new System.Drawing.Point(15, 83);
            this.button1_DelStud.Name = "button1_DelStud";
            this.button1_DelStud.Size = new System.Drawing.Size(193, 23);
            this.button1_DelStud.TabIndex = 6;
            this.button1_DelStud.Text = "Удалить студента";
            this.button1_DelStud.UseVisualStyleBackColor = true;
            this.button1_DelStud.Click += new System.EventHandler(this.button1_DelStud_Click);
            // 
            // textBox1_DelStud
            // 
            this.textBox1_DelStud.Location = new System.Drawing.Point(15, 42);
            this.textBox1_DelStud.Name = "textBox1_DelStud";
            this.textBox1_DelStud.Size = new System.Drawing.Size(193, 20);
            this.textBox1_DelStud.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите номер строки для удаления:";
            // 
            // panel1_FindGroup
            // 
            this.panel1_FindGroup.Controls.Add(this.button1_AVG);
            this.panel1_FindGroup.Controls.Add(this.textBox1_group);
            this.panel1_FindGroup.Controls.Add(this.label1);
            this.panel1_FindGroup.Location = new System.Drawing.Point(43, 301);
            this.panel1_FindGroup.Name = "panel1_FindGroup";
            this.panel1_FindGroup.Size = new System.Drawing.Size(180, 116);
            this.panel1_FindGroup.TabIndex = 17;
            this.panel1_FindGroup.Visible = false;
            // 
            // button1_AVG
            // 
            this.button1_AVG.Location = new System.Drawing.Point(15, 83);
            this.button1_AVG.Name = "button1_AVG";
            this.button1_AVG.Size = new System.Drawing.Size(151, 23);
            this.button1_AVG.TabIndex = 6;
            this.button1_AVG.Text = "Найти средний балл";
            this.button1_AVG.UseVisualStyleBackColor = true;
            this.button1_AVG.Click += new System.EventHandler(this.button1_AVG_Click);
            // 
            // textBox1_group
            // 
            this.textBox1_group.Location = new System.Drawing.Point(15, 42);
            this.textBox1_group.Name = "textBox1_group";
            this.textBox1_group.Size = new System.Drawing.Size(151, 20);
            this.textBox1_group.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите группу:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(214, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(365, 245);
            this.dataGridView1.TabIndex = 16;
            // 
            // button1_Async
            // 
            this.button1_Async.Location = new System.Drawing.Point(43, 165);
            this.button1_Async.Name = "button1_Async";
            this.button1_Async.Size = new System.Drawing.Size(151, 42);
            this.button1_Async.TabIndex = 15;
            this.button1_Async.Text = "Асинхронный режим";
            this.button1_Async.UseVisualStyleBackColor = true;
            this.button1_Async.Click += new System.EventHandler(this.button1_Async_Click);
            // 
            // button1_Offline
            // 
            this.button1_Offline.Location = new System.Drawing.Point(43, 97);
            this.button1_Offline.Name = "button1_Offline";
            this.button1_Offline.Size = new System.Drawing.Size(151, 42);
            this.button1_Offline.TabIndex = 14;
            this.button1_Offline.Text = "Автономный режим";
            this.button1_Offline.UseVisualStyleBackColor = true;
            this.button1_Offline.Click += new System.EventHandler(this.button1_Offline_Click);
            // 
            // button1_Online
            // 
            this.button1_Online.Location = new System.Drawing.Point(43, 29);
            this.button1_Online.Name = "button1_Online";
            this.button1_Online.Size = new System.Drawing.Size(151, 42);
            this.button1_Online.TabIndex = 13;
            this.button1_Online.Text = "Подключенный режим";
            this.button1_Online.UseVisualStyleBackColor = true;
            this.button1_Online.Click += new System.EventHandler(this.button1_Online_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 434);
            this.Controls.Add(this.Panel1_List);
            this.Controls.Add(this.Panel1_Min);
            this.Controls.Add(this.button1_Entity);
            this.Controls.Add(this.panel1_del);
            this.Controls.Add(this.panel1_FindGroup);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1_Async);
            this.Controls.Add(this.button1_Offline);
            this.Controls.Add(this.button1_Online);
            this.Name = "Form1";
            this.Text = "Студенты";
            this.Panel1_List.ResumeLayout(false);
            this.Panel1_Min.ResumeLayout(false);
            this.Panel1_Min.PerformLayout();
            this.panel1_del.ResumeLayout(false);
            this.panel1_del.PerformLayout();
            this.panel1_FindGroup.ResumeLayout(false);
            this.panel1_FindGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel1_List;
        private System.Windows.Forms.Button Вutton2_7;
        private System.Windows.Forms.Button Button3_All;
        private System.Windows.Forms.Panel Panel1_Min;
        private System.Windows.Forms.Button Button1_Min;
        private System.Windows.Forms.TextBox textBox1_Min;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1_Entity;
        private System.Windows.Forms.Panel panel1_del;
        private System.Windows.Forms.Button button1_DelStud;
        private System.Windows.Forms.TextBox textBox1_DelStud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1_FindGroup;
        private System.Windows.Forms.Button button1_AVG;
        private System.Windows.Forms.TextBox textBox1_group;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1_Async;
        private System.Windows.Forms.Button button1_Offline;
        private System.Windows.Forms.Button button1_Online;
    }
}

