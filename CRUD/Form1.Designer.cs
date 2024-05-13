namespace CRUD
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label dESCRIPTIONLabel;
            System.Windows.Forms.Label pRIORITYLabel;
            System.Windows.Forms.Label tARGET_DATELabel;
            System.Windows.Forms.Label cREATED_DATELabel;
            this.postsDatabaseDataSet = new CRUD.PostsDatabaseDataSet();
            this.pOSTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSTTableAdapter = new CRUD.PostsDatabaseDataSetTableAdapters.POSTTableAdapter();
            this.tableAdapterManager = new CRUD.PostsDatabaseDataSetTableAdapters.TableAdapterManager();
            this.pOSTBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pOSTBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pOSTDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.dESCRIPTIONTextBox = new System.Windows.Forms.TextBox();
            this.pRIORITYTextBox = new System.Windows.Forms.TextBox();
            this.tARGET_DATEDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cREATED_DATEDateTimePicker = new System.Windows.Forms.DateTimePicker();
            iDLabel = new System.Windows.Forms.Label();
            dESCRIPTIONLabel = new System.Windows.Forms.Label();
            pRIORITYLabel = new System.Windows.Forms.Label();
            tARGET_DATELabel = new System.Windows.Forms.Label();
            cREATED_DATELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.postsDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSTBindingNavigator)).BeginInit();
            this.pOSTBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pOSTDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // postsDatabaseDataSet
            // 
            this.postsDatabaseDataSet.DataSetName = "PostsDatabaseDataSet";
            this.postsDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pOSTBindingSource
            // 
            this.pOSTBindingSource.DataMember = "POST";
            this.pOSTBindingSource.DataSource = this.postsDatabaseDataSet;
            // 
            // pOSTTableAdapter
            // 
            this.pOSTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.POSTTableAdapter = this.pOSTTableAdapter;
            this.tableAdapterManager.UpdateOrder = CRUD.PostsDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pOSTBindingNavigator
            // 
            this.pOSTBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pOSTBindingNavigator.BindingSource = this.pOSTBindingSource;
            this.pOSTBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pOSTBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pOSTBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pOSTBindingNavigatorSaveItem});
            this.pOSTBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pOSTBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pOSTBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pOSTBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pOSTBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pOSTBindingNavigator.Name = "pOSTBindingNavigator";
            this.pOSTBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pOSTBindingNavigator.Size = new System.Drawing.Size(1202, 25);
            this.pOSTBindingNavigator.TabIndex = 0;
            this.pOSTBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pOSTBindingNavigatorSaveItem
            // 
            this.pOSTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pOSTBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pOSTBindingNavigatorSaveItem.Image")));
            this.pOSTBindingNavigatorSaveItem.Name = "pOSTBindingNavigatorSaveItem";
            this.pOSTBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pOSTBindingNavigatorSaveItem.Text = "Guardar datos";
            this.pOSTBindingNavigatorSaveItem.Click += new System.EventHandler(this.pOSTBindingNavigatorSaveItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.pOSTDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(iDLabel);
            this.splitContainer1.Panel2.Controls.Add(this.iDTextBox);
            this.splitContainer1.Panel2.Controls.Add(dESCRIPTIONLabel);
            this.splitContainer1.Panel2.Controls.Add(this.dESCRIPTIONTextBox);
            this.splitContainer1.Panel2.Controls.Add(pRIORITYLabel);
            this.splitContainer1.Panel2.Controls.Add(this.pRIORITYTextBox);
            this.splitContainer1.Panel2.Controls.Add(tARGET_DATELabel);
            this.splitContainer1.Panel2.Controls.Add(this.tARGET_DATEDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(cREATED_DATELabel);
            this.splitContainer1.Panel2.Controls.Add(this.cREATED_DATEDateTimePicker);
            this.splitContainer1.Size = new System.Drawing.Size(1202, 563);
            this.splitContainer1.SplitterDistance = 545;
            this.splitContainer1.TabIndex = 1;
            // 
            // pOSTDataGridView
            // 
            this.pOSTDataGridView.AutoGenerateColumns = false;
            this.pOSTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pOSTDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.pOSTDataGridView.DataSource = this.pOSTBindingSource;
            this.pOSTDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pOSTDataGridView.Location = new System.Drawing.Point(0, 0);
            this.pOSTDataGridView.Name = "pOSTDataGridView";
            this.pOSTDataGridView.Size = new System.Drawing.Size(545, 563);
            this.pOSTDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DESCRIPTION";
            this.dataGridViewTextBoxColumn2.HeaderText = "DESCRIPTION";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PRIORITY";
            this.dataGridViewTextBoxColumn3.HeaderText = "PRIORITY";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TARGET_DATE";
            this.dataGridViewTextBoxColumn4.HeaderText = "TARGET_DATE";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CREATED_DATE";
            this.dataGridViewTextBoxColumn5.HeaderText = "CREATED_DATE";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(13, 204);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 0;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pOSTBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(112, 201);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(514, 20);
            this.iDTextBox.TabIndex = 1;
            // 
            // dESCRIPTIONLabel
            // 
            dESCRIPTIONLabel.AutoSize = true;
            dESCRIPTIONLabel.Location = new System.Drawing.Point(13, 230);
            dESCRIPTIONLabel.Name = "dESCRIPTIONLabel";
            dESCRIPTIONLabel.Size = new System.Drawing.Size(83, 13);
            dESCRIPTIONLabel.TabIndex = 2;
            dESCRIPTIONLabel.Text = "DESCRIPTION:";
            // 
            // dESCRIPTIONTextBox
            // 
            this.dESCRIPTIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pOSTBindingSource, "DESCRIPTION", true));
            this.dESCRIPTIONTextBox.Location = new System.Drawing.Point(112, 227);
            this.dESCRIPTIONTextBox.Name = "dESCRIPTIONTextBox";
            this.dESCRIPTIONTextBox.Size = new System.Drawing.Size(514, 20);
            this.dESCRIPTIONTextBox.TabIndex = 3;
            // 
            // pRIORITYLabel
            // 
            pRIORITYLabel.AutoSize = true;
            pRIORITYLabel.Location = new System.Drawing.Point(13, 256);
            pRIORITYLabel.Name = "pRIORITYLabel";
            pRIORITYLabel.Size = new System.Drawing.Size(61, 13);
            pRIORITYLabel.TabIndex = 4;
            pRIORITYLabel.Text = "PRIORITY:";
            // 
            // pRIORITYTextBox
            // 
            this.pRIORITYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pOSTBindingSource, "PRIORITY", true));
            this.pRIORITYTextBox.Location = new System.Drawing.Point(112, 253);
            this.pRIORITYTextBox.Name = "pRIORITYTextBox";
            this.pRIORITYTextBox.Size = new System.Drawing.Size(514, 20);
            this.pRIORITYTextBox.TabIndex = 5;
            // 
            // tARGET_DATELabel
            // 
            tARGET_DATELabel.AutoSize = true;
            tARGET_DATELabel.Location = new System.Drawing.Point(13, 283);
            tARGET_DATELabel.Name = "tARGET_DATELabel";
            tARGET_DATELabel.Size = new System.Drawing.Size(86, 13);
            tARGET_DATELabel.TabIndex = 6;
            tARGET_DATELabel.Text = "TARGET DATE:";
            // 
            // tARGET_DATEDateTimePicker
            // 
            this.tARGET_DATEDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pOSTBindingSource, "TARGET_DATE", true));
            this.tARGET_DATEDateTimePicker.Location = new System.Drawing.Point(112, 279);
            this.tARGET_DATEDateTimePicker.Name = "tARGET_DATEDateTimePicker";
            this.tARGET_DATEDateTimePicker.Size = new System.Drawing.Size(514, 20);
            this.tARGET_DATEDateTimePicker.TabIndex = 7;
            // 
            // cREATED_DATELabel
            // 
            cREATED_DATELabel.AutoSize = true;
            cREATED_DATELabel.Location = new System.Drawing.Point(13, 309);
            cREATED_DATELabel.Name = "cREATED_DATELabel";
            cREATED_DATELabel.Size = new System.Drawing.Size(93, 13);
            cREATED_DATELabel.TabIndex = 8;
            cREATED_DATELabel.Text = "CREATED DATE:";
            // 
            // cREATED_DATEDateTimePicker
            // 
            this.cREATED_DATEDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pOSTBindingSource, "CREATED_DATE", true));
            this.cREATED_DATEDateTimePicker.Location = new System.Drawing.Point(112, 305);
            this.cREATED_DATEDateTimePicker.Name = "cREATED_DATEDateTimePicker";
            this.cREATED_DATEDateTimePicker.Size = new System.Drawing.Size(514, 20);
            this.cREATED_DATEDateTimePicker.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 588);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pOSTBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.postsDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSTBindingNavigator)).EndInit();
            this.pOSTBindingNavigator.ResumeLayout(false);
            this.pOSTBindingNavigator.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pOSTDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PostsDatabaseDataSet postsDatabaseDataSet;
        private System.Windows.Forms.BindingSource pOSTBindingSource;
        private PostsDatabaseDataSetTableAdapters.POSTTableAdapter pOSTTableAdapter;
        private PostsDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pOSTBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pOSTBindingNavigatorSaveItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView pOSTDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox dESCRIPTIONTextBox;
        private System.Windows.Forms.TextBox pRIORITYTextBox;
        private System.Windows.Forms.DateTimePicker tARGET_DATEDateTimePicker;
        private System.Windows.Forms.DateTimePicker cREATED_DATEDateTimePicker;
    }
}

