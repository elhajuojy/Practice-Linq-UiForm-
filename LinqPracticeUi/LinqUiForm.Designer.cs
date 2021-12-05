namespace LinqPracticeUi
{
    partial class LinqUiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LinqUiForm));
            this.LsBox = new System.Windows.Forms.ListBox();
            this.btnAllData = new System.Windows.Forms.Button();
            this.btnWhere = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LsBox
            // 
            this.LsBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsBox.FormattingEnabled = true;
            this.LsBox.ItemHeight = 23;
            this.LsBox.Location = new System.Drawing.Point(12, 12);
            this.LsBox.Name = "LsBox";
            this.LsBox.Size = new System.Drawing.Size(427, 487);
            this.LsBox.TabIndex = 0;
            // 
            // btnAllData
            // 
            this.btnAllData.Location = new System.Drawing.Point(445, 12);
            this.btnAllData.Name = "btnAllData";
            this.btnAllData.Size = new System.Drawing.Size(111, 44);
            this.btnAllData.TabIndex = 1;
            this.btnAllData.Text = "All Data";
            this.btnAllData.UseVisualStyleBackColor = true;
            this.btnAllData.Click += new System.EventHandler(this.btnAllData_Click);
            // 
            // btnWhere
            // 
            this.btnWhere.Location = new System.Drawing.Point(445, 62);
            this.btnWhere.Name = "btnWhere";
            this.btnWhere.Size = new System.Drawing.Size(111, 44);
            this.btnWhere.TabIndex = 2;
            this.btnWhere.Text = "Where ";
            this.btnWhere.UseVisualStyleBackColor = true;
            this.btnWhere.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(445, 112);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(111, 44);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Orderby";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.Location = new System.Drawing.Point(445, 162);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(111, 44);
            this.btnGroup.TabIndex = 4;
            this.btnGroup.Text = "group";
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // LinqUiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 537);
            this.Controls.Add(this.btnGroup);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnWhere);
            this.Controls.Add(this.btnAllData);
            this.Controls.Add(this.LsBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LinqUiForm";
            this.Text = "Linq Ui Form ";
            this.Load += new System.EventHandler(this.LinqUiForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LsBox;
        private System.Windows.Forms.Button btnAllData;
        private System.Windows.Forms.Button btnWhere;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnGroup;
    }
}

