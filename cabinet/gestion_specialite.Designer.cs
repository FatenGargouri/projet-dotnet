namespace cabinet
{
    partial class gestion_specialite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestion_specialite));
            System.Windows.Forms.Label id_specLabel;
            System.Windows.Forms.Label nom_specLabel;
            this.gestion_cabinetDataSet = new cabinet.gestion_cabinetDataSet();
            this.specialitesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specialitesTableAdapter = new cabinet.gestion_cabinetDataSetTableAdapters.specialitesTableAdapter();
            this.tableAdapterManager = new cabinet.gestion_cabinetDataSetTableAdapters.TableAdapterManager();
            this.specialitesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.specialitesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.specialitesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_specTextBox = new System.Windows.Forms.TextBox();
            this.nom_specTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            id_specLabel = new System.Windows.Forms.Label();
            nom_specLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_cabinetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialitesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialitesBindingNavigator)).BeginInit();
            this.specialitesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specialitesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gestion_cabinetDataSet
            // 
            this.gestion_cabinetDataSet.DataSetName = "gestion_cabinetDataSet";
            this.gestion_cabinetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specialitesBindingSource
            // 
            this.specialitesBindingSource.DataMember = "specialites";
            this.specialitesBindingSource.DataSource = this.gestion_cabinetDataSet;
            // 
            // specialitesTableAdapter
            // 
            this.specialitesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.dossiersTableAdapter = null;
            this.tableAdapterManager.medecinsTableAdapter = null;
            this.tableAdapterManager.patientsTableAdapter = null;
            this.tableAdapterManager.rendezvousTableAdapter = null;
            this.tableAdapterManager.specialitesTableAdapter = this.specialitesTableAdapter;
            this.tableAdapterManager.UpdateOrder = cabinet.gestion_cabinetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // specialitesBindingNavigator
            // 
            this.specialitesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.specialitesBindingNavigator.BindingSource = this.specialitesBindingSource;
            this.specialitesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.specialitesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.specialitesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.specialitesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.specialitesBindingNavigatorSaveItem});
            this.specialitesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.specialitesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.specialitesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.specialitesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.specialitesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.specialitesBindingNavigator.Name = "specialitesBindingNavigator";
            this.specialitesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.specialitesBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.specialitesBindingNavigator.TabIndex = 0;
            this.specialitesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 20);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // specialitesBindingNavigatorSaveItem
            // 
            this.specialitesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.specialitesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("specialitesBindingNavigatorSaveItem.Image")));
            this.specialitesBindingNavigatorSaveItem.Name = "specialitesBindingNavigatorSaveItem";
            this.specialitesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.specialitesBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.specialitesBindingNavigatorSaveItem.Click += new System.EventHandler(this.specialitesBindingNavigatorSaveItem_Click);
            // 
            // specialitesDataGridView
            // 
            this.specialitesDataGridView.AutoGenerateColumns = false;
            this.specialitesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.specialitesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.specialitesDataGridView.DataSource = this.specialitesBindingSource;
            this.specialitesDataGridView.Location = new System.Drawing.Point(80, 223);
            this.specialitesDataGridView.Name = "specialitesDataGridView";
            this.specialitesDataGridView.RowHeadersWidth = 51;
            this.specialitesDataGridView.RowTemplate.Height = 24;
            this.specialitesDataGridView.Size = new System.Drawing.Size(300, 220);
            this.specialitesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_spec";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_spec";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nom_spec";
            this.dataGridViewTextBoxColumn2.HeaderText = "nom_spec";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // id_specLabel
            // 
            id_specLabel.AutoSize = true;
            id_specLabel.Location = new System.Drawing.Point(118, 67);
            id_specLabel.Name = "id_specLabel";
            id_specLabel.Size = new System.Drawing.Size(54, 16);
            id_specLabel.TabIndex = 2;
            id_specLabel.Text = "id spec:";
            // 
            // id_specTextBox
            // 
            this.id_specTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specialitesBindingSource, "id_spec", true));
            this.id_specTextBox.Location = new System.Drawing.Point(193, 64);
            this.id_specTextBox.Name = "id_specTextBox";
            this.id_specTextBox.Size = new System.Drawing.Size(100, 22);
            this.id_specTextBox.TabIndex = 3;
            // 
            // nom_specLabel
            // 
            nom_specLabel.AutoSize = true;
            nom_specLabel.Location = new System.Drawing.Point(118, 95);
            nom_specLabel.Name = "nom_specLabel";
            nom_specLabel.Size = new System.Drawing.Size(69, 16);
            nom_specLabel.TabIndex = 4;
            nom_specLabel.Text = "nom spec:";
            // 
            // nom_specTextBox
            // 
            this.nom_specTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.specialitesBindingSource, "nom_spec", true));
            this.nom_specTextBox.Location = new System.Drawing.Point(193, 92);
            this.nom_specTextBox.Name = "nom_specTextBox";
            this.nom_specTextBox.Size = new System.Drawing.Size(100, 22);
            this.nom_specTextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(546, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(546, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(546, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gestion_specialite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_specLabel);
            this.Controls.Add(this.id_specTextBox);
            this.Controls.Add(nom_specLabel);
            this.Controls.Add(this.nom_specTextBox);
            this.Controls.Add(this.specialitesDataGridView);
            this.Controls.Add(this.specialitesBindingNavigator);
            this.Name = "gestion_specialite";
            this.Text = "gestion_specialite";
            this.Load += new System.EventHandler(this.gestion_specialite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestion_cabinetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialitesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialitesBindingNavigator)).EndInit();
            this.specialitesBindingNavigator.ResumeLayout(false);
            this.specialitesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specialitesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private gestion_cabinetDataSet gestion_cabinetDataSet;
        private System.Windows.Forms.BindingSource specialitesBindingSource;
        private gestion_cabinetDataSetTableAdapters.specialitesTableAdapter specialitesTableAdapter;
        private gestion_cabinetDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator specialitesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton specialitesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView specialitesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox id_specTextBox;
        private System.Windows.Forms.TextBox nom_specTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}