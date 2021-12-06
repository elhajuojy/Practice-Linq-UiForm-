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
            this.btnNestedQuery = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnJoin2 = new System.Windows.Forms.Button();
            this.btnDistinct = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnAvg = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnAlais = new System.Windows.Forms.Button();
            this.btnStartWith = new System.Windows.Forms.Button();
            this.btnEndWith = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LsBox
            // 
            this.LsBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsBox.FormattingEnabled = true;
            this.LsBox.ItemHeight = 23;
            this.LsBox.Location = new System.Drawing.Point(12, 13);
            this.LsBox.Name = "LsBox";
            this.LsBox.Size = new System.Drawing.Size(529, 441);
            this.LsBox.TabIndex = 0;
            // 
            // btnAllData
            // 
            this.btnAllData.Location = new System.Drawing.Point(570, 13);
            this.btnAllData.Name = "btnAllData";
            this.btnAllData.Size = new System.Drawing.Size(111, 44);
            this.btnAllData.TabIndex = 1;
            this.btnAllData.Text = "All Data";
            this.btnAllData.UseVisualStyleBackColor = true;
            this.btnAllData.Click += new System.EventHandler(this.btnAllData_Click);
            // 
            // btnWhere
            // 
            this.btnWhere.Location = new System.Drawing.Point(570, 63);
            this.btnWhere.Name = "btnWhere";
            this.btnWhere.Size = new System.Drawing.Size(111, 44);
            this.btnWhere.TabIndex = 2;
            this.btnWhere.Text = "Where ";
            this.btnWhere.UseVisualStyleBackColor = true;
            this.btnWhere.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(570, 113);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(111, 44);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Orderby";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.Location = new System.Drawing.Point(570, 163);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(111, 44);
            this.btnGroup.TabIndex = 4;
            this.btnGroup.Text = "group";
            this.btnGroup.UseVisualStyleBackColor = true;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // btnNestedQuery
            // 
            this.btnNestedQuery.Location = new System.Drawing.Point(570, 213);
            this.btnNestedQuery.Name = "btnNestedQuery";
            this.btnNestedQuery.Size = new System.Drawing.Size(111, 44);
            this.btnNestedQuery.TabIndex = 5;
            this.btnNestedQuery.Text = "Nested Query ";
            this.btnNestedQuery.UseVisualStyleBackColor = true;
            this.btnNestedQuery.Click += new System.EventHandler(this.btnNestedQuery_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(570, 263);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(111, 44);
            this.btnJoin.TabIndex = 6;
            this.btnJoin.Text = "Join ";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnJoin2
            // 
            this.btnJoin2.Location = new System.Drawing.Point(570, 313);
            this.btnJoin2.Name = "btnJoin2";
            this.btnJoin2.Size = new System.Drawing.Size(111, 44);
            this.btnJoin2.TabIndex = 7;
            this.btnJoin2.Text = "Join 2";
            this.btnJoin2.UseVisualStyleBackColor = true;
            this.btnJoin2.Click += new System.EventHandler(this.btnJoin2_Click);
            // 
            // btnDistinct
            // 
            this.btnDistinct.Location = new System.Drawing.Point(570, 363);
            this.btnDistinct.Name = "btnDistinct";
            this.btnDistinct.Size = new System.Drawing.Size(111, 44);
            this.btnDistinct.TabIndex = 8;
            this.btnDistinct.Text = "Distinct";
            this.btnDistinct.UseVisualStyleBackColor = true;
            this.btnDistinct.Click += new System.EventHandler(this.btnDistinct_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(687, 163);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(111, 44);
            this.btnMax.TabIndex = 12;
            this.btnMax.Text = "Max";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(687, 113);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(111, 44);
            this.btnMin.TabIndex = 11;
            this.btnMin.Text = "Min";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnAvg
            // 
            this.btnAvg.Location = new System.Drawing.Point(687, 63);
            this.btnAvg.Name = "btnAvg";
            this.btnAvg.Size = new System.Drawing.Size(111, 44);
            this.btnAvg.TabIndex = 10;
            this.btnAvg.Text = "Avg";
            this.btnAvg.UseVisualStyleBackColor = true;
            this.btnAvg.Click += new System.EventHandler(this.btnAvg_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(687, 13);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(111, 44);
            this.btnSum.TabIndex = 9;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnAlais
            // 
            this.btnAlais.Location = new System.Drawing.Point(570, 413);
            this.btnAlais.Name = "btnAlais";
            this.btnAlais.Size = new System.Drawing.Size(111, 44);
            this.btnAlais.TabIndex = 13;
            this.btnAlais.Text = "All Data Alais ";
            this.btnAlais.UseVisualStyleBackColor = true;
            this.btnAlais.Click += new System.EventHandler(this.btnAlais_Click);
            // 
            // btnStartWith
            // 
            this.btnStartWith.Location = new System.Drawing.Point(687, 213);
            this.btnStartWith.Name = "btnStartWith";
            this.btnStartWith.Size = new System.Drawing.Size(111, 44);
            this.btnStartWith.TabIndex = 14;
            this.btnStartWith.Text = "Start With";
            this.btnStartWith.UseVisualStyleBackColor = true;
            this.btnStartWith.Click += new System.EventHandler(this.btnStartWith_Click);
            // 
            // btnEndWith
            // 
            this.btnEndWith.Location = new System.Drawing.Point(687, 263);
            this.btnEndWith.Name = "btnEndWith";
            this.btnEndWith.Size = new System.Drawing.Size(111, 44);
            this.btnEndWith.TabIndex = 15;
            this.btnEndWith.Text = "End With";
            this.btnEndWith.UseVisualStyleBackColor = true;
            this.btnEndWith.Click += new System.EventHandler(this.btnEndWith_Click);
            // 
            // LinqUiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 556);
            this.Controls.Add(this.btnEndWith);
            this.Controls.Add(this.btnStartWith);
            this.Controls.Add(this.btnAlais);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnAvg);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnDistinct);
            this.Controls.Add(this.btnJoin2);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.btnNestedQuery);
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
        private System.Windows.Forms.Button btnNestedQuery;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnJoin2;
        private System.Windows.Forms.Button btnDistinct;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnAvg;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnAlais;
        private System.Windows.Forms.Button btnStartWith;
        private System.Windows.Forms.Button btnEndWith;
    }
}

