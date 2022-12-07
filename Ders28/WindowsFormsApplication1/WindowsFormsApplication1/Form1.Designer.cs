namespace WindowsFormsApplication1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnXML = new System.Windows.Forms.Button();
            this.btnDataSet = new System.Windows.Forms.Button();
            this.btnConBuilder = new System.Windows.Forms.Button();
            this.btnAppConfig = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnMultiQuery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(368, 242);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(50, 45);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "SELECT";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnXML
            // 
            this.btnXML.Location = new System.Drawing.Point(191, 45);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(75, 23);
            this.btnXML.TabIndex = 2;
            this.btnXML.Text = "XML";
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // btnDataSet
            // 
            this.btnDataSet.Location = new System.Drawing.Point(343, 45);
            this.btnDataSet.Name = "btnDataSet";
            this.btnDataSet.Size = new System.Drawing.Size(75, 23);
            this.btnDataSet.TabIndex = 3;
            this.btnDataSet.Text = "DATA SET";
            this.btnDataSet.UseVisualStyleBackColor = true;
            this.btnDataSet.Click += new System.EventHandler(this.btnDataSet_Click);
            // 
            // btnConBuilder
            // 
            this.btnConBuilder.Location = new System.Drawing.Point(50, 334);
            this.btnConBuilder.Name = "btnConBuilder";
            this.btnConBuilder.Size = new System.Drawing.Size(110, 23);
            this.btnConBuilder.TabIndex = 4;
            this.btnConBuilder.Text = "ConnectionBuilder";
            this.btnConBuilder.UseVisualStyleBackColor = true;
            this.btnConBuilder.Click += new System.EventHandler(this.btnConBuilder_Click);
            // 
            // btnAppConfig
            // 
            this.btnAppConfig.Location = new System.Drawing.Point(343, 334);
            this.btnAppConfig.Name = "btnAppConfig";
            this.btnAppConfig.Size = new System.Drawing.Size(75, 23);
            this.btnAppConfig.TabIndex = 5;
            this.btnAppConfig.Text = "AppConfig";
            this.btnAppConfig.UseVisualStyleBackColor = true;
            this.btnAppConfig.Click += new System.EventHandler(this.btnAppConfig_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnList);
            this.groupBox1.Controls.Add(this.btnMultiQuery);
            this.groupBox1.Location = new System.Drawing.Point(460, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 242);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bağlantılı";
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(32, 63);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(128, 23);
            this.btnList.TabIndex = 3;
            this.btnList.Text = "List<>";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnMultiQuery
            // 
            this.btnMultiQuery.Location = new System.Drawing.Point(32, 34);
            this.btnMultiQuery.Name = "btnMultiQuery";
            this.btnMultiQuery.Size = new System.Drawing.Size(128, 23);
            this.btnMultiQuery.TabIndex = 2;
            this.btnMultiQuery.Text = "BirdenFazlaSorgu";
            this.btnMultiQuery.UseVisualStyleBackColor = true;
            this.btnMultiQuery.Click += new System.EventHandler(this.btnMultiQuery_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 408);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAppConfig);
            this.Controls.Add(this.btnConBuilder);
            this.Controls.Add(this.btnDataSet);
            this.Controls.Add(this.btnXML);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnXML;
        private System.Windows.Forms.Button btnDataSet;
        private System.Windows.Forms.Button btnConBuilder;
        private System.Windows.Forms.Button btnAppConfig;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnMultiQuery;
    }
}

