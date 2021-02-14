
namespace _16_String_Metotlar
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTrim = new System.Windows.Forms.Button();
            this.btnSubstring = new System.Windows.Forms.Button();
            this.btnLastIndexOf = new System.Windows.Forms.Button();
            this.btnToCharArray = new System.Windows.Forms.Button();
            this.btnLowerUpper = new System.Windows.Forms.Button();
            this.btnIndexOf = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnEndsWith = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.btnStartsWith = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnCotains = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtKontrolDeger = new System.Windows.Forms.TextBox();
            this.txtGelenDeger = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Count : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Kontrol Değer : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Girilen Değer : ";
            // 
            // btnTrim
            // 
            this.btnTrim.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTrim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrim.ForeColor = System.Drawing.Color.Lime;
            this.btnTrim.Location = new System.Drawing.Point(402, 351);
            this.btnTrim.Name = "btnTrim";
            this.btnTrim.Size = new System.Drawing.Size(161, 40);
            this.btnTrim.TabIndex = 57;
            this.btnTrim.Text = "TRIM";
            this.btnTrim.UseVisualStyleBackColor = false;
            this.btnTrim.Click += new System.EventHandler(this.btnTrim_Click);
            // 
            // btnSubstring
            // 
            this.btnSubstring.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubstring.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubstring.ForeColor = System.Drawing.Color.Lime;
            this.btnSubstring.Location = new System.Drawing.Point(402, 271);
            this.btnSubstring.Name = "btnSubstring";
            this.btnSubstring.Size = new System.Drawing.Size(161, 40);
            this.btnSubstring.TabIndex = 55;
            this.btnSubstring.Text = "SUBSTRING";
            this.btnSubstring.UseVisualStyleBackColor = false;
            this.btnSubstring.Click += new System.EventHandler(this.btnSubstring_Click);
            // 
            // btnLastIndexOf
            // 
            this.btnLastIndexOf.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLastIndexOf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastIndexOf.ForeColor = System.Drawing.Color.Lime;
            this.btnLastIndexOf.Location = new System.Drawing.Point(241, 311);
            this.btnLastIndexOf.Name = "btnLastIndexOf";
            this.btnLastIndexOf.Size = new System.Drawing.Size(161, 40);
            this.btnLastIndexOf.TabIndex = 49;
            this.btnLastIndexOf.Text = "LASTINDEXOF";
            this.btnLastIndexOf.UseVisualStyleBackColor = false;
            this.btnLastIndexOf.Click += new System.EventHandler(this.btnLastIndexOf_Click);
            // 
            // btnToCharArray
            // 
            this.btnToCharArray.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnToCharArray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToCharArray.ForeColor = System.Drawing.Color.Lime;
            this.btnToCharArray.Location = new System.Drawing.Point(402, 311);
            this.btnToCharArray.Name = "btnToCharArray";
            this.btnToCharArray.Size = new System.Drawing.Size(161, 40);
            this.btnToCharArray.TabIndex = 56;
            this.btnToCharArray.Text = "TOCHARARRAY";
            this.btnToCharArray.UseVisualStyleBackColor = false;
            this.btnToCharArray.Click += new System.EventHandler(this.btnToCharArray_Click);
            // 
            // btnLowerUpper
            // 
            this.btnLowerUpper.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLowerUpper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLowerUpper.ForeColor = System.Drawing.Color.Lime;
            this.btnLowerUpper.Location = new System.Drawing.Point(402, 231);
            this.btnLowerUpper.Name = "btnLowerUpper";
            this.btnLowerUpper.Size = new System.Drawing.Size(161, 40);
            this.btnLowerUpper.TabIndex = 54;
            this.btnLowerUpper.Text = "TOLOWER - TOUPPER";
            this.btnLowerUpper.UseVisualStyleBackColor = false;
            this.btnLowerUpper.Click += new System.EventHandler(this.btnLowerUpper_Click);
            // 
            // btnIndexOf
            // 
            this.btnIndexOf.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIndexOf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndexOf.ForeColor = System.Drawing.Color.Lime;
            this.btnIndexOf.Location = new System.Drawing.Point(241, 271);
            this.btnIndexOf.Name = "btnIndexOf";
            this.btnIndexOf.Size = new System.Drawing.Size(161, 40);
            this.btnIndexOf.TabIndex = 48;
            this.btnIndexOf.Text = "INDEXOF";
            this.btnIndexOf.UseVisualStyleBackColor = false;
            this.btnIndexOf.Click += new System.EventHandler(this.btnIndexOf_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.ForeColor = System.Drawing.Color.Lime;
            this.btnInsert.Location = new System.Drawing.Point(402, 191);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(161, 40);
            this.btnInsert.TabIndex = 53;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnEndsWith
            // 
            this.btnEndsWith.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEndsWith.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndsWith.ForeColor = System.Drawing.Color.Lime;
            this.btnEndsWith.Location = new System.Drawing.Point(241, 231);
            this.btnEndsWith.Name = "btnEndsWith";
            this.btnEndsWith.Size = new System.Drawing.Size(161, 40);
            this.btnEndsWith.TabIndex = 47;
            this.btnEndsWith.Text = "ENDSWITH";
            this.btnEndsWith.UseVisualStyleBackColor = false;
            this.btnEndsWith.Click += new System.EventHandler(this.btnEndsWith_Click);
            // 
            // btnSplit
            // 
            this.btnSplit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSplit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSplit.ForeColor = System.Drawing.Color.Lime;
            this.btnSplit.Location = new System.Drawing.Point(402, 151);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(161, 40);
            this.btnSplit.TabIndex = 52;
            this.btnSplit.Text = "SPLIT";
            this.btnSplit.UseVisualStyleBackColor = false;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // btnStartsWith
            // 
            this.btnStartsWith.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStartsWith.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartsWith.ForeColor = System.Drawing.Color.Lime;
            this.btnStartsWith.Location = new System.Drawing.Point(241, 191);
            this.btnStartsWith.Name = "btnStartsWith";
            this.btnStartsWith.Size = new System.Drawing.Size(161, 40);
            this.btnStartsWith.TabIndex = 46;
            this.btnStartsWith.Text = "STARTSWITH";
            this.btnStartsWith.UseVisualStyleBackColor = false;
            this.btnStartsWith.Click += new System.EventHandler(this.btnStartsWith_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplace.ForeColor = System.Drawing.Color.Lime;
            this.btnReplace.Location = new System.Drawing.Point(402, 111);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(161, 40);
            this.btnReplace.TabIndex = 51;
            this.btnReplace.Text = "REPLACE";
            this.btnReplace.UseVisualStyleBackColor = false;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnCotains
            // 
            this.btnCotains.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCotains.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCotains.ForeColor = System.Drawing.Color.Lime;
            this.btnCotains.Location = new System.Drawing.Point(241, 151);
            this.btnCotains.Name = "btnCotains";
            this.btnCotains.Size = new System.Drawing.Size(161, 40);
            this.btnCotains.TabIndex = 45;
            this.btnCotains.Text = "CONTAINS";
            this.btnCotains.UseVisualStyleBackColor = false;
            this.btnCotains.Click += new System.EventHandler(this.btnCotains_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.Color.Lime;
            this.btnRemove.Location = new System.Drawing.Point(241, 351);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(161, 40);
            this.btnRemove.TabIndex = 50;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCompare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompare.ForeColor = System.Drawing.Color.Lime;
            this.btnCompare.Location = new System.Drawing.Point(241, 111);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(161, 40);
            this.btnCompare.TabIndex = 44;
            this.btnCompare.Text = "COMPARE";
            this.btnCompare.UseVisualStyleBackColor = false;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(473, 85);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(90, 20);
            this.txtCount.TabIndex = 59;
            // 
            // txtKontrolDeger
            // 
            this.txtKontrolDeger.Location = new System.Drawing.Point(325, 85);
            this.txtKontrolDeger.Name = "txtKontrolDeger";
            this.txtKontrolDeger.Size = new System.Drawing.Size(90, 20);
            this.txtKontrolDeger.TabIndex = 60;
            // 
            // txtGelenDeger
            // 
            this.txtGelenDeger.Location = new System.Drawing.Point(325, 59);
            this.txtGelenDeger.Name = "txtGelenDeger";
            this.txtGelenDeger.Size = new System.Drawing.Size(238, 20);
            this.txtGelenDeger.TabIndex = 58;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTrim);
            this.Controls.Add(this.btnSubstring);
            this.Controls.Add(this.btnLastIndexOf);
            this.Controls.Add(this.btnToCharArray);
            this.Controls.Add(this.btnLowerUpper);
            this.Controls.Add(this.btnIndexOf);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnEndsWith);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.btnStartsWith);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnCotains);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtKontrolDeger);
            this.Controls.Add(this.txtGelenDeger);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTrim;
        private System.Windows.Forms.Button btnSubstring;
        private System.Windows.Forms.Button btnLastIndexOf;
        private System.Windows.Forms.Button btnToCharArray;
        private System.Windows.Forms.Button btnLowerUpper;
        private System.Windows.Forms.Button btnIndexOf;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnEndsWith;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Button btnStartsWith;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnCotains;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtKontrolDeger;
        private System.Windows.Forms.TextBox txtGelenDeger;
    }
}

