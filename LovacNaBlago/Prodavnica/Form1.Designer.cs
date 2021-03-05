namespace Blago
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
            this.cmdRead = new System.Windows.Forms.Button();
            this.cmdCreate = new System.Windows.Forms.Button();
            this.cmdManytoOne = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmdOneToMany = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdRead
            // 
            this.cmdRead.Location = new System.Drawing.Point(12, 41);
            this.cmdRead.Name = "cmdRead";
            this.cmdRead.Size = new System.Drawing.Size(271, 23);
            this.cmdRead.TabIndex = 0;
            this.cmdRead.Text = "Ucitavanje podataka o Lokaciji blaga";
            this.cmdRead.UseVisualStyleBackColor = true;
            this.cmdRead.Click += new System.EventHandler(this.cmdRead_Click);
            // 
            // cmdCreate
            // 
            this.cmdCreate.Location = new System.Drawing.Point(13, 70);
            this.cmdCreate.Name = "cmdCreate";
            this.cmdCreate.Size = new System.Drawing.Size(271, 23);
            this.cmdCreate.TabIndex = 1;
            this.cmdCreate.Text = "Dodavanje nove Lokacije i Zastite";
            this.cmdCreate.UseVisualStyleBackColor = true;
            this.cmdCreate.Click += new System.EventHandler(this.cmdCreate_Click);
            // 
            // cmdManytoOne
            // 
            this.cmdManytoOne.Location = new System.Drawing.Point(13, 99);
            this.cmdManytoOne.Name = "cmdManytoOne";
            this.cmdManytoOne.Size = new System.Drawing.Size(271, 23);
            this.cmdManytoOne.TabIndex = 2;
            this.cmdManytoOne.Text = "Veza Many-to-One";
            this.cmdManytoOne.UseVisualStyleBackColor = true;
            this.cmdManytoOne.Click += new System.EventHandler(this.cmdManytoOne_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ucitavanje podataka o izgubljenom blagu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(270, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Informacije o Blagu i Lokaciji na osnovu predmeta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 247);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(270, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Prikazi informacije o obicnom Nalazistu zlata";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmdOneToMany
            // 
            this.cmdOneToMany.Location = new System.Drawing.Point(13, 128);
            this.cmdOneToMany.Name = "cmdOneToMany";
            this.cmdOneToMany.Size = new System.Drawing.Size(271, 23);
            this.cmdOneToMany.TabIndex = 3;
            this.cmdOneToMany.Text = "Veza One-to-Many";
            this.cmdOneToMany.UseVisualStyleBackColor = true;
            this.cmdOneToMany.Click += new System.EventHandler(this.cmdOneToMany_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(271, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Prikazi legendu o blagu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 186);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(270, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Prikazi ime Lovca na blago";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(14, 157);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(270, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "HasManytoMany";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(315, 128);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(268, 23);
            this.button7.TabIndex = 10;
            this.button7.Text = "Get Zastita";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(315, 40);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(268, 23);
            this.button8.TabIndex = 11;
            this.button8.Text = "Prikazati sve lokacije (upit)";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(315, 11);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(268, 23);
            this.button9.TabIndex = 12;
            this.button9.Text = "Prikazati sva blaga (upit)";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(315, 70);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(268, 23);
            this.button10.TabIndex = 13;
            this.button10.Text = "Prikazati Lokacije sa odredjenom Zastitom (upit)";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(315, 99);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(268, 23);
            this.button11.TabIndex = 14;
            this.button11.Text = "Predmeti od odredjenog materijala (upit)";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(315, 186);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(268, 23);
            this.button12.TabIndex = 15;
            this.button12.Text = "Delete Predmet";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(315, 157);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(268, 23);
            this.button13.TabIndex = 16;
            this.button13.Text = "Delete Zastita";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(608, 42);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(268, 23);
            this.button14.TabIndex = 17;
            this.button14.Text = "Pregled Lokacija";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(608, 119);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(268, 22);
            this.button15.TabIndex = 18;
            this.button15.Text = "Pregled Tabela";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(664, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Pregled Lokacija( Dodaj i Obrisi )";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(678, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Pregled ostalih tabela";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 345);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdOneToMany);
            this.Controls.Add(this.cmdManytoOne);
            this.Controls.Add(this.cmdCreate);
            this.Controls.Add(this.cmdRead);
            this.Name = "Form1";
            this.Text = "BazePodataka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdRead;
        private System.Windows.Forms.Button cmdCreate;
        private System.Windows.Forms.Button cmdManytoOne;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button cmdOneToMany;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

