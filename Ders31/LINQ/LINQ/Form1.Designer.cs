namespace LINQ
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnColInı = new System.Windows.Forms.Button();
            this.btnObjInit = new System.Windows.Forms.Button();
            this.btnAutoProp = new System.Windows.Forms.Button();
            this.btnVar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(326, 186);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 15;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(326, 129);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(116, 41);
            this.button7.TabIndex = 14;
            this.button7.Text = "Lambda Expression";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(326, 54);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(116, 43);
            this.button6.TabIndex = 13;
            this.button6.Text = "Extension Methods";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(83, 271);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 47);
            this.button5.TabIndex = 12;
            this.button5.Text = "Anonymous Types";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnColInı
            // 
            this.btnColInı.Location = new System.Drawing.Point(89, 200);
            this.btnColInı.Name = "btnColInı";
            this.btnColInı.Size = new System.Drawing.Size(106, 40);
            this.btnColInı.TabIndex = 11;
            this.btnColInı.Text = "Collection Initializer";
            this.btnColInı.UseVisualStyleBackColor = true;
            this.btnColInı.Click += new System.EventHandler(this.btnColInı_Click);
            // 
            // btnObjInit
            // 
            this.btnObjInit.Location = new System.Drawing.Point(99, 146);
            this.btnObjInit.Name = "btnObjInit";
            this.btnObjInit.Size = new System.Drawing.Size(93, 36);
            this.btnObjInit.TabIndex = 10;
            this.btnObjInit.Text = "Object Initializer";
            this.btnObjInit.UseVisualStyleBackColor = true;
            this.btnObjInit.Click += new System.EventHandler(this.btnObjInit_Click);
            // 
            // btnAutoProp
            // 
            this.btnAutoProp.Location = new System.Drawing.Point(99, 89);
            this.btnAutoProp.Name = "btnAutoProp";
            this.btnAutoProp.Size = new System.Drawing.Size(87, 33);
            this.btnAutoProp.TabIndex = 9;
            this.btnAutoProp.Text = "Auto Property";
            this.btnAutoProp.UseVisualStyleBackColor = true;
            // 
            // btnVar
            // 
            this.btnVar.Location = new System.Drawing.Point(115, 40);
            this.btnVar.Name = "btnVar";
            this.btnVar.Size = new System.Drawing.Size(51, 43);
            this.btnVar.TabIndex = 8;
            this.btnVar.Text = "var";
            this.btnVar.UseVisualStyleBackColor = true;
            this.btnVar.Click += new System.EventHandler(this.btnVar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 358);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnColInı);
            this.Controls.Add(this.btnObjInit);
            this.Controls.Add(this.btnAutoProp);
            this.Controls.Add(this.btnVar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnColInı;
        private System.Windows.Forms.Button btnObjInit;
        private System.Windows.Forms.Button btnAutoProp;
        private System.Windows.Forms.Button btnVar;
    }
}

