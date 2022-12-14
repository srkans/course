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
            this.btnLambda = new System.Windows.Forms.Button();
            this.btnExtension = new System.Windows.Forms.Button();
            this.btnAnonymous = new System.Windows.Forms.Button();
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
            // btnLambda
            // 
            this.btnLambda.Location = new System.Drawing.Point(326, 129);
            this.btnLambda.Name = "btnLambda";
            this.btnLambda.Size = new System.Drawing.Size(116, 41);
            this.btnLambda.TabIndex = 14;
            this.btnLambda.Text = "Lambda Expression";
            this.btnLambda.UseVisualStyleBackColor = true;
            this.btnLambda.Click += new System.EventHandler(this.btnLambda_Click);
            // 
            // btnExtension
            // 
            this.btnExtension.Location = new System.Drawing.Point(326, 54);
            this.btnExtension.Name = "btnExtension";
            this.btnExtension.Size = new System.Drawing.Size(116, 43);
            this.btnExtension.TabIndex = 13;
            this.btnExtension.Text = "Extension Methods";
            this.btnExtension.UseVisualStyleBackColor = true;
            this.btnExtension.Click += new System.EventHandler(this.btnExtension_Click);
            // 
            // btnAnonymous
            // 
            this.btnAnonymous.Location = new System.Drawing.Point(83, 271);
            this.btnAnonymous.Name = "btnAnonymous";
            this.btnAnonymous.Size = new System.Drawing.Size(117, 47);
            this.btnAnonymous.TabIndex = 12;
            this.btnAnonymous.Text = "Anonymous Types";
            this.btnAnonymous.UseVisualStyleBackColor = true;
            this.btnAnonymous.Click += new System.EventHandler(this.btnAnonymous_Click);
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
            this.Controls.Add(this.btnLambda);
            this.Controls.Add(this.btnExtension);
            this.Controls.Add(this.btnAnonymous);
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
        private System.Windows.Forms.Button btnLambda;
        private System.Windows.Forms.Button btnExtension;
        private System.Windows.Forms.Button btnAnonymous;
        private System.Windows.Forms.Button btnColInı;
        private System.Windows.Forms.Button btnObjInit;
        private System.Windows.Forms.Button btnAutoProp;
        private System.Windows.Forms.Button btnVar;
    }
}

