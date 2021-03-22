
namespace lab_1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.lab_1DataSet = new lab_1.lab_1DataSet();
            this.lab1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.группаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.группаTableAdapter = new lab_1.lab_1DataSetTableAdapters.ГруппаTableAdapter();
            this.преподовательBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.преподовательTableAdapter = new lab_1.lab_1DataSetTableAdapters.ПреподовательTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.группаСтудентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.студентыTableAdapter = new lab_1.lab_1DataSetTableAdapters.СтудентыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lab_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподовательBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группаСтудентыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1060, 668);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Форма 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lab_1DataSet
            // 
            this.lab_1DataSet.DataSetName = "lab_1DataSet";
            this.lab_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lab1DataSetBindingSource
            // 
            this.lab1DataSetBindingSource.DataSource = this.lab_1DataSet;
            this.lab1DataSetBindingSource.Position = 0;
            // 
            // группаBindingSource
            // 
            this.группаBindingSource.DataMember = "Группа";
            this.группаBindingSource.DataSource = this.lab1DataSetBindingSource;
            // 
            // группаTableAdapter
            // 
            this.группаTableAdapter.ClearBeforeFill = true;
            // 
            // преподовательBindingSource
            // 
            this.преподовательBindingSource.DataMember = "Преподователь";
            this.преподовательBindingSource.DataSource = this.lab1DataSetBindingSource;
            // 
            // преподовательTableAdapter
            // 
            this.преподовательTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.группаBindingSource, "ID группы", true));
            this.label1.Location = new System.Drawing.Point(177, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.группаBindingSource, "Название группы", true));
            this.label2.Location = new System.Drawing.Point(279, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.группаBindingSource, "Преподователь", true));
            this.label3.Location = new System.Drawing.Point(431, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID группы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Название группы";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(431, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Преподователь";
            // 
            // группаСтудентыBindingSource
            // 
            this.группаСтудентыBindingSource.DataMember = "ГруппаСтуденты";
            this.группаСтудентыBindingSource.DataSource = this.группаBindingSource;
            // 
            // студентыTableAdapter
            // 
            this.студентыTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 719);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lab_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподовательBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группаСтудентыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource lab1DataSetBindingSource;
        private lab_1DataSet lab_1DataSet;
        private System.Windows.Forms.BindingSource группаBindingSource;
        private lab_1DataSetTableAdapters.ГруппаTableAdapter группаTableAdapter;
        private System.Windows.Forms.BindingSource преподовательBindingSource;
        private lab_1DataSetTableAdapters.ПреподовательTableAdapter преподовательTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource группаСтудентыBindingSource;
        private lab_1DataSetTableAdapters.СтудентыTableAdapter студентыTableAdapter;
    }
}