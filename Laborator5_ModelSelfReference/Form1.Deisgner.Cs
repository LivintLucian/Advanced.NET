namespace Laboratorul5
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
            this.components = new System.ComponentModel.Container();
            this.selfReference_DBDataSet = new Laboratorul5.SelfReference_DBDataSet();
            this.selfReferenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selfReferenceTableAdapter = new Laboratorul5.SelfReference_DBDataSetTableAdapters.SelfReferenceTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.selfReference_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selfReferenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // selfReference_DBDataSet
            // 
            this.selfReference_DBDataSet.DataSetName = "SelfReference_DBDataSet";
            this.selfReference_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selfReferenceBindingSource
            // 
            this.selfReferenceBindingSource.DataMember = "SelfReference";
            this.selfReferenceBindingSource.DataSource = this.selfReference_DBDataSet;
            // 
            // selfReferenceTableAdapter
            // 
            this.selfReferenceTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "See Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(132, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(493, 236);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selfReference_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selfReferenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SelfReference_DBDataSet selfReference_DBDataSet;
        private System.Windows.Forms.BindingSource selfReferenceBindingSource;
        private SelfReference_DBDataSetTableAdapters.SelfReferenceTableAdapter selfReferenceTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
