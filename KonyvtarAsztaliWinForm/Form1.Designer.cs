namespace KonyvtarAsztaliWinForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_Konyvek = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Pages = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Load = new System.Windows.Forms.Button();
            this.button_Insert = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.textBox_Year = new System.Windows.Forms.TextBox();
            this.textBox_Author = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox_Konyvek
            // 
            this.listBox_Konyvek.FormattingEnabled = true;
            this.listBox_Konyvek.ItemHeight = 16;
            this.listBox_Konyvek.Location = new System.Drawing.Point(13, 13);
            this.listBox_Konyvek.Name = "listBox_Konyvek";
            this.listBox_Konyvek.Size = new System.Drawing.Size(304, 436);
            this.listBox_Konyvek.TabIndex = 0;
            this.listBox_Konyvek.SelectedIndexChanged += new System.EventHandler(this.listBox_Konyvek_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(354, 42);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 22);
            this.textBox_id.TabIndex = 2;
            this.textBox_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Szerző";
            // 
            // textBox_Title
            // 
            this.textBox_Title.Location = new System.Drawing.Point(598, 118);
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(176, 22);
            this.textBox_Title.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Könyv címe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kiadás éve";
            // 
            // textBox_Pages
            // 
            this.textBox_Pages.Location = new System.Drawing.Point(598, 217);
            this.textBox_Pages.Name = "textBox_Pages";
            this.textBox_Pages.Size = new System.Drawing.Size(176, 22);
            this.textBox_Pages.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(595, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Oldalak száma";
            // 
            // button_Load
            // 
            this.button_Load.Location = new System.Drawing.Point(421, 306);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(78, 34);
            this.button_Load.TabIndex = 12;
            this.button_Load.Text = "Frissít";
            this.button_Load.UseVisualStyleBackColor = true;
            this.button_Load.Click += new System.EventHandler(this.button_Load_Click);
            // 
            // button_Insert
            // 
            this.button_Insert.Location = new System.Drawing.Point(598, 306);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Size = new System.Drawing.Size(78, 34);
            this.button_Insert.TabIndex = 13;
            this.button_Insert.Text = "Új";
            this.button_Insert.UseVisualStyleBackColor = true;
            this.button_Insert.Click += new System.EventHandler(this.button_Insert_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(421, 363);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(78, 34);
            this.button_Update.TabIndex = 14;
            this.button_Update.Text = "Módosít";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(598, 363);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(78, 34);
            this.button_Delete.TabIndex = 15;
            this.button_Delete.Text = "Törlés";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // textBox_Year
            // 
            this.textBox_Year.Location = new System.Drawing.Point(354, 217);
            this.textBox_Year.Name = "textBox_Year";
            this.textBox_Year.Size = new System.Drawing.Size(176, 22);
            this.textBox_Year.TabIndex = 16;
            // 
            // textBox_Author
            // 
            this.textBox_Author.Location = new System.Drawing.Point(354, 118);
            this.textBox_Author.Name = "textBox_Author";
            this.textBox_Author.Size = new System.Drawing.Size(176, 22);
            this.textBox_Author.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_Author);
            this.Controls.Add(this.textBox_Year);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Insert);
            this.Controls.Add(this.button_Load);
            this.Controls.Add(this.textBox_Pages);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Title);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Konyvek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Pages;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Load;
        private System.Windows.Forms.Button button_Insert;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Delete;
        public System.Windows.Forms.ListBox listBox_Konyvek;
        private System.Windows.Forms.TextBox textBox_Year;
        private System.Windows.Forms.TextBox textBox_Author;
    }
}

