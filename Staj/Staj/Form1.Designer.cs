using System;

namespace Staj
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpGirme1 = new System.Windows.Forms.DateTimePicker();
            this.dtpCixma1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNetice = new System.Windows.Forms.Label();
            this.btnHesabla = new System.Windows.Forms.Button();
            this.btnElaveEt = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İşə qəbul tarixi";
            // 
            // dtpGirme1
            // 
            this.dtpGirme1.CustomFormat = "dd.MM.yyyy";
            this.dtpGirme1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGirme1.Location = new System.Drawing.Point(32, 34);
            this.dtpGirme1.Name = "dtpGirme1";
            this.dtpGirme1.Size = new System.Drawing.Size(147, 20);
            this.dtpGirme1.TabIndex = 1;
            // 
            // dtpCixma1
            // 
            this.dtpCixma1.CustomFormat = "dd.MM.yyyy";
            this.dtpCixma1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCixma1.Location = new System.Drawing.Point(205, 34);
            this.dtpCixma1.Name = "dtpCixma1";
            this.dtpCixma1.Size = new System.Drawing.Size(147, 20);
            this.dtpCixma1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "İşdən çıxma tarixi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cəm iş stajı: ";
            // 
            // lblNetice
            // 
            this.lblNetice.AutoSize = true;
            this.lblNetice.Location = new System.Drawing.Point(236, 366);
            this.lblNetice.Name = "lblNetice";
            this.lblNetice.Size = new System.Drawing.Size(13, 13);
            this.lblNetice.TabIndex = 5;
            this.lblNetice.Text = "0";
            // 
            // btnHesabla
            // 
            this.btnHesabla.Location = new System.Drawing.Point(32, 356);
            this.btnHesabla.Name = "btnHesabla";
            this.btnHesabla.Size = new System.Drawing.Size(75, 23);
            this.btnHesabla.TabIndex = 6;
            this.btnHesabla.Text = "Hesabla";
            this.btnHesabla.UseVisualStyleBackColor = true;
            this.btnHesabla.Click += new System.EventHandler(this.btnHesabla_Click);
            // 
            // btnElaveEt
            // 
            this.btnElaveEt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnElaveEt.Location = new System.Drawing.Point(358, 33);
            this.btnElaveEt.Name = "btnElaveEt";
            this.btnElaveEt.Size = new System.Drawing.Size(69, 22);
            this.btnElaveEt.TabIndex = 7;
            this.btnElaveEt.Text = "Əlavə et";
            this.btnElaveEt.UseVisualStyleBackColor = false;
            this.btnElaveEt.Click += new System.EventHandler(this.btnElaveEt_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(13, 38);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(13, 13);
            this.lbl1.TabIndex = 9;
            this.lbl1.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 407);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnElaveEt);
            this.Controls.Add(this.btnHesabla);
            this.Controls.Add(this.lblNetice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpCixma1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpGirme1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staj Hesablama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpGirme1;
        private System.Windows.Forms.DateTimePicker dtpCixma1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNetice;
        private System.Windows.Forms.Button btnHesabla;
        private System.Windows.Forms.Button btnElaveEt;
        private System.Windows.Forms.Label lbl1;
    }
}

