
namespace Aaron_Rash_CPT_206_Lab_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tSearchProductDesc = new System.Windows.Forms.TextBox();
            this.bSearchProductDesc = new System.Windows.Forms.Button();
            this.tSearchProductNum = new System.Windows.Forms.TextBox();
            this.bSearchProductNum = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.ProductListBox = new System.Windows.Forms.ListBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.productBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.bMoreThan = new System.Windows.Forms.Button();
            this.bLessThan = new System.Windows.Forms.Button();
            this.tMoreThan = new System.Windows.Forms.TextBox();
            this.tLessThan = new System.Windows.Forms.TextBox();
            this.bSortPrice = new System.Windows.Forms.Button();
            this.bSortUnits = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lMin = new System.Windows.Forms.Label();
            this.lMax = new System.Windows.Forms.Label();
            this.tMin = new System.Windows.Forms.TextBox();
            this.tMax = new System.Windows.Forms.TextBox();
            this.bBetween = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).BeginInit();
            this.productBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tSearchProductDesc
            // 
            this.tSearchProductDesc.Location = new System.Drawing.Point(161, 310);
            this.tSearchProductDesc.Name = "tSearchProductDesc";
            this.tSearchProductDesc.Size = new System.Drawing.Size(62, 20);
            this.tSearchProductDesc.TabIndex = 9;
            // 
            // bSearchProductDesc
            // 
            this.bSearchProductDesc.Location = new System.Drawing.Point(16, 310);
            this.bSearchProductDesc.Name = "bSearchProductDesc";
            this.bSearchProductDesc.Size = new System.Drawing.Size(121, 23);
            this.bSearchProductDesc.TabIndex = 8;
            this.bSearchProductDesc.Text = "Search Product Desc:";
            this.bSearchProductDesc.UseVisualStyleBackColor = true;
            this.bSearchProductDesc.Click += new System.EventHandler(this.bSearchProductDesc_Click);
            // 
            // tSearchProductNum
            // 
            this.tSearchProductNum.Location = new System.Drawing.Point(161, 279);
            this.tSearchProductNum.Name = "tSearchProductNum";
            this.tSearchProductNum.Size = new System.Drawing.Size(62, 20);
            this.tSearchProductNum.TabIndex = 7;
            // 
            // bSearchProductNum
            // 
            this.bSearchProductNum.Location = new System.Drawing.Point(16, 279);
            this.bSearchProductNum.Name = "bSearchProductNum";
            this.bSearchProductNum.Size = new System.Drawing.Size(121, 23);
            this.bSearchProductNum.TabIndex = 6;
            this.bSearchProductNum.Text = "Search Product Number:";
            this.bSearchProductNum.UseVisualStyleBackColor = true;
            this.bSearchProductNum.Click += new System.EventHandler(this.bSearchProductNum_Click);
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(252, 433);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(125, 23);
            this.closeButton.TabIndex = 10;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ProductListBox
            // 
            this.ProductListBox.FormattingEnabled = true;
            this.ProductListBox.Location = new System.Drawing.Point(518, 43);
            this.ProductListBox.Name = "ProductListBox";
            this.ProductListBox.Size = new System.Drawing.Size(215, 225);
            this.ProductListBox.TabIndex = 11;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Aaron_Rash_CPT_206_Lab_1.Product);
            // 
            // productBindingNavigator
            // 
            this.productBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productBindingNavigator.BindingSource = this.productBindingSource;
            this.productBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.productBindingNavigatorSaveItem});
            this.productBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productBindingNavigator.Name = "productBindingNavigator";
            this.productBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productBindingNavigator.Size = new System.Drawing.Size(769, 25);
            this.productBindingNavigator.TabIndex = 12;
            this.productBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // productBindingNavigatorSaveItem
            // 
            this.productBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productBindingNavigatorSaveItem.Enabled = false;
            this.productBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productBindingNavigatorSaveItem.Image")));
            this.productBindingNavigatorSaveItem.Name = "productBindingNavigatorSaveItem";
            this.productBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // productDataGridView
            // 
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(12, 48);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.Size = new System.Drawing.Size(456, 220);
            this.productDataGridView.TabIndex = 12;
            // 
            // bMoreThan
            // 
            this.bMoreThan.Location = new System.Drawing.Point(252, 277);
            this.bMoreThan.Name = "bMoreThan";
            this.bMoreThan.Size = new System.Drawing.Size(125, 23);
            this.bMoreThan.TabIndex = 13;
            this.bMoreThan.Text = "More than:";
            this.bMoreThan.UseVisualStyleBackColor = true;
            this.bMoreThan.Click += new System.EventHandler(this.bMoreThan_Click);
            // 
            // bLessThan
            // 
            this.bLessThan.Location = new System.Drawing.Point(252, 309);
            this.bLessThan.Name = "bLessThan";
            this.bLessThan.Size = new System.Drawing.Size(125, 23);
            this.bLessThan.TabIndex = 14;
            this.bLessThan.Text = "Less than:";
            this.bLessThan.UseVisualStyleBackColor = true;
            this.bLessThan.Click += new System.EventHandler(this.bLessThan_Click);
            // 
            // tMoreThan
            // 
            this.tMoreThan.Location = new System.Drawing.Point(406, 279);
            this.tMoreThan.Name = "tMoreThan";
            this.tMoreThan.Size = new System.Drawing.Size(62, 20);
            this.tMoreThan.TabIndex = 16;
            // 
            // tLessThan
            // 
            this.tLessThan.Location = new System.Drawing.Point(406, 311);
            this.tLessThan.Name = "tLessThan";
            this.tLessThan.Size = new System.Drawing.Size(62, 20);
            this.tLessThan.TabIndex = 17;
            // 
            // bSortPrice
            // 
            this.bSortPrice.Location = new System.Drawing.Point(252, 359);
            this.bSortPrice.Name = "bSortPrice";
            this.bSortPrice.Size = new System.Drawing.Size(125, 23);
            this.bSortPrice.TabIndex = 22;
            this.bSortPrice.Text = "Sort by Price";
            this.bSortPrice.UseVisualStyleBackColor = true;
            this.bSortPrice.Click += new System.EventHandler(this.bSortPrice_Click);
            // 
            // bSortUnits
            // 
            this.bSortUnits.Location = new System.Drawing.Point(253, 389);
            this.bSortUnits.Name = "bSortUnits";
            this.bSortUnits.Size = new System.Drawing.Size(125, 23);
            this.bSortUnits.TabIndex = 23;
            this.bSortUnits.Text = "Sort by Units";
            this.bSortUnits.UseVisualStyleBackColor = true;
            this.bSortUnits.Click += new System.EventHandler(this.bSortUnits_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Product_Number";
            this.dataGridViewTextBoxColumn1.HeaderText = "Product_Number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Units_On_Hand";
            this.dataGridViewTextBoxColumn3.HeaderText = "Units_On_Hand";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Price";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // lMin
            // 
            this.lMin.AutoSize = true;
            this.lMin.Location = new System.Drawing.Point(16, 47);
            this.lMin.Name = "lMin";
            this.lMin.Size = new System.Drawing.Size(51, 13);
            this.lMin.TabIndex = 21;
            this.lMin.Text = "Min Price";
            // 
            // lMax
            // 
            this.lMax.AutoSize = true;
            this.lMax.Location = new System.Drawing.Point(16, 76);
            this.lMax.Name = "lMax";
            this.lMax.Size = new System.Drawing.Size(54, 13);
            this.lMax.TabIndex = 20;
            this.lMax.Text = "Max Price";
            // 
            // tMin
            // 
            this.tMin.Location = new System.Drawing.Point(79, 47);
            this.tMin.Name = "tMin";
            this.tMin.Size = new System.Drawing.Size(41, 20);
            this.tMin.TabIndex = 19;
            // 
            // tMax
            // 
            this.tMax.Location = new System.Drawing.Point(79, 73);
            this.tMax.Name = "tMax";
            this.tMax.Size = new System.Drawing.Size(41, 20);
            this.tMax.TabIndex = 18;
            // 
            // bBetween
            // 
            this.bBetween.Location = new System.Drawing.Point(17, 12);
            this.bBetween.Name = "bBetween";
            this.bBetween.Size = new System.Drawing.Size(101, 23);
            this.bBetween.TabIndex = 15;
            this.bBetween.Text = "Between";
            this.bBetween.UseVisualStyleBackColor = true;
            this.bBetween.Click += new System.EventHandler(this.bBetween_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bBetween);
            this.panel1.Controls.Add(this.tMax);
            this.panel1.Controls.Add(this.tMin);
            this.panel1.Controls.Add(this.lMax);
            this.panel1.Controls.Add(this.lMin);
            this.panel1.Location = new System.Drawing.Point(16, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 106);
            this.panel1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(515, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Read Mode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Detail Mode";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(769, 468);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bSortUnits);
            this.Controls.Add(this.bSortPrice);
            this.Controls.Add(this.tLessThan);
            this.Controls.Add(this.tMoreThan);
            this.Controls.Add(this.bLessThan);
            this.Controls.Add(this.bMoreThan);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.productBindingNavigator);
            this.Controls.Add(this.ProductListBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.tSearchProductDesc);
            this.Controls.Add(this.bSearchProductDesc);
            this.Controls.Add(this.tSearchProductNum);
            this.Controls.Add(this.bSearchProductNum);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).EndInit();
            this.productBindingNavigator.ResumeLayout(false);
            this.productBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tSearchProductDesc;
        private System.Windows.Forms.Button bSearchProductDesc;
        private System.Windows.Forms.TextBox tSearchProductNum;
        private System.Windows.Forms.Button bSearchProductNum;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ListBox ProductListBox;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingNavigator productBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton productBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.Button bMoreThan;
        private System.Windows.Forms.Button bLessThan;
        private System.Windows.Forms.TextBox tMoreThan;
        private System.Windows.Forms.TextBox tLessThan;
        private System.Windows.Forms.Button bSortPrice;
        private System.Windows.Forms.Button bSortUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label lMin;
        private System.Windows.Forms.Label lMax;
        private System.Windows.Forms.TextBox tMin;
        private System.Windows.Forms.TextBox tMax;
        private System.Windows.Forms.Button bBetween;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

