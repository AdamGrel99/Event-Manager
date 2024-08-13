using System.Windows.Forms;

namespace Administrator_Wydarzeń.View
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Zdarzenie = new System.Windows.Forms.GroupBox();
            this.deletebutton = new System.Windows.Forms.Button();
            this.priorityComboBox = new System.Windows.Forms.ComboBox();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.typeCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.dataGridViewEvents = new System.Windows.Forms.DataGridView();
            this.titleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriorityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.filterButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.filtercomboBox = new System.Windows.Forms.ComboBox();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.elementsFilterComboBox = new System.Windows.Forms.ComboBox();
            this.Zdarzenie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // Zdarzenie
            // 
            this.Zdarzenie.Controls.Add(this.deletebutton);
            this.Zdarzenie.Controls.Add(this.priorityComboBox);
            this.Zdarzenie.Controls.Add(this.priorityLabel);
            this.Zdarzenie.Controls.Add(this.typeCheckedListBox);
            this.Zdarzenie.Controls.Add(this.typeLabel);
            this.Zdarzenie.Controls.Add(this.descriptionRichTextBox);
            this.Zdarzenie.Controls.Add(this.dateLabel);
            this.Zdarzenie.Controls.Add(this.descriptionLabel);
            this.Zdarzenie.Controls.Add(this.titleLabel);
            this.Zdarzenie.Controls.Add(this.addButton);
            this.Zdarzenie.Controls.Add(this.dateTimePicker1);
            this.Zdarzenie.Controls.Add(this.titleBox);
            this.Zdarzenie.Location = new System.Drawing.Point(10, 20);
            this.Zdarzenie.Name = "Zdarzenie";
            this.Zdarzenie.Size = new System.Drawing.Size(356, 384);
            this.Zdarzenie.TabIndex = 0;
            this.Zdarzenie.TabStop = false;
            this.Zdarzenie.Text = "Zdarzenie";
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(220, 342);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(130, 36);
            this.deletebutton.TabIndex = 17;
            this.deletebutton.Text = "Usuń";
            this.deletebutton.UseVisualStyleBackColor = true;
            // 
            // priorityComboBox
            // 
            this.priorityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priorityComboBox.FormattingEnabled = true;
            this.priorityComboBox.Items.AddRange(new object[] {
            "wysoki",
            "średni",
            "niski"});
            this.priorityComboBox.Location = new System.Drawing.Point(129, 294);
            this.priorityComboBox.Name = "priorityComboBox";
            this.priorityComboBox.Size = new System.Drawing.Size(195, 24);
            this.priorityComboBox.TabIndex = 16;
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Location = new System.Drawing.Point(4, 294);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(51, 16);
            this.priorityLabel.TabIndex = 15;
            this.priorityLabel.Text = "Priority:";
            // 
            // typeCheckedListBox
            // 
            this.typeCheckedListBox.FormattingEnabled = true;
            this.typeCheckedListBox.Items.AddRange(new object[] {
            "rodzina",
            "praca",
            "rozrywka",
            "zdrowie",
            "sport"});
            this.typeCheckedListBox.Location = new System.Drawing.Point(129, 209);
            this.typeCheckedListBox.Name = "typeCheckedListBox";
            this.typeCheckedListBox.Size = new System.Drawing.Size(195, 72);
            this.typeCheckedListBox.TabIndex = 14;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(4, 209);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(34, 16);
            this.typeLabel.TabIndex = 13;
            this.typeLabel.Text = "Typ:";
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.Location = new System.Drawing.Point(129, 70);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(195, 96);
            this.descriptionRichTextBox.TabIndex = 12;
            this.descriptionRichTextBox.Text = "";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(4, 177);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(117, 16);
            this.dateLabel.TabIndex = 11;
            this.dateLabel.Text = "Data Wystąpienia:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(4, 70);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(38, 16);
            this.descriptionLabel.TabIndex = 10;
            this.descriptionLabel.Text = "Opis:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(4, 40);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(42, 16);
            this.titleLabel.TabIndex = 9;
            this.titleLabel.Text = "Tytuł:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(7, 342);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(125, 36);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Dodaj";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 175);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(195, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(129, 34);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(195, 22);
            this.titleBox.TabIndex = 0;
            // 
            // dataGridViewEvents
            // 
            this.dataGridViewEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleCol,
            this.descCol,
            this.dateCol,
            this.typeCol,
            this.PriorityCol});
            this.dataGridViewEvents.Location = new System.Drawing.Point(372, 90);
            this.dataGridViewEvents.MultiSelect = false;
            this.dataGridViewEvents.Name = "dataGridViewEvents";
            this.dataGridViewEvents.ReadOnly = true;
            this.dataGridViewEvents.RowHeadersVisible = false;
            this.dataGridViewEvents.RowHeadersWidth = 51;
            this.dataGridViewEvents.RowTemplate.Height = 24;
            this.dataGridViewEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEvents.Size = new System.Drawing.Size(553, 356);
            this.dataGridViewEvents.TabIndex = 1;
            // 
            // titleCol
            // 
            this.titleCol.DataPropertyName = "Title";
            this.titleCol.HeaderText = "Tytuł";
            this.titleCol.MinimumWidth = 6;
            this.titleCol.Name = "titleCol";
            this.titleCol.ReadOnly = true;
            this.titleCol.Width = 125;
            // 
            // descCol
            // 
            this.descCol.DataPropertyName = "Description";
            this.descCol.HeaderText = "Opis";
            this.descCol.MinimumWidth = 6;
            this.descCol.Name = "descCol";
            this.descCol.ReadOnly = true;
            this.descCol.Width = 125;
            // 
            // dateCol
            // 
            this.dateCol.DataPropertyName = "Date";
            this.dateCol.HeaderText = "Data Wystąpienia";
            this.dateCol.MinimumWidth = 6;
            this.dateCol.Name = "dateCol";
            this.dateCol.ReadOnly = true;
            this.dateCol.Width = 125;
            // 
            // typeCol
            // 
            this.typeCol.DataPropertyName = "Type";
            this.typeCol.HeaderText = "Typ";
            this.typeCol.MinimumWidth = 6;
            this.typeCol.Name = "typeCol";
            this.typeCol.ReadOnly = true;
            this.typeCol.Width = 125;
            // 
            // PriorityCol
            // 
            this.PriorityCol.DataPropertyName = "Priority";
            this.PriorityCol.HeaderText = "Priorytet";
            this.PriorityCol.MinimumWidth = 6;
            this.PriorityCol.Name = "PriorityCol";
            this.PriorityCol.ReadOnly = true;
            this.PriorityCol.Width = 125;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(17, 410);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(123, 36);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Zapisz";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(230, 410);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(130, 36);
            this.loadButton.TabIndex = 3;
            this.loadButton.Text = "Wczytaj";
            this.loadButton.UseVisualStyleBackColor = true;
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(372, 40);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(80, 36);
            this.filterButton.TabIndex = 18;
            this.filterButton.Text = "Filtruj";
            this.filterButton.UseVisualStyleBackColor = true;
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(739, 40);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(80, 36);
            this.sortButton.TabIndex = 19;
            this.sortButton.Text = "Sortuj";
            this.sortButton.UseVisualStyleBackColor = true;
            // 
            // filtercomboBox
            // 
            this.filtercomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtercomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filtercomboBox.FormattingEnabled = true;
            this.filtercomboBox.Items.AddRange(new object[] {
            "typ",
            "priorytet",
            "data",
            "------"});
            this.filtercomboBox.Location = new System.Drawing.Point(458, 45);
            this.filtercomboBox.Name = "filtercomboBox";
            this.filtercomboBox.Size = new System.Drawing.Size(116, 26);
            this.filtercomboBox.TabIndex = 20;
            // 
            // sortComboBox
            // 
            this.sortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "typ",
            "priorytet",
            "data",
            "------"});
            this.sortComboBox.Location = new System.Drawing.Point(825, 45);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(100, 26);
            this.sortComboBox.TabIndex = 21;
            // 
            // elementsFilterComboBox
            // 
            this.elementsFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.elementsFilterComboBox.Enabled = false;
            this.elementsFilterComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.elementsFilterComboBox.FormattingEnabled = true;
            this.elementsFilterComboBox.Items.AddRange(new object[] {
            "------"});
            this.elementsFilterComboBox.Location = new System.Drawing.Point(580, 45);
            this.elementsFilterComboBox.Name = "elementsFilterComboBox";
            this.elementsFilterComboBox.Size = new System.Drawing.Size(116, 26);
            this.elementsFilterComboBox.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 498);
            this.Controls.Add(this.elementsFilterComboBox);
            this.Controls.Add(this.sortComboBox);
            this.Controls.Add(this.filtercomboBox);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridViewEvents);
            this.Controls.Add(this.Zdarzenie);
            this.Name = "Form1";
            this.Text = "Administrator Wydarzeń";
            this.Zdarzenie.ResumeLayout(false);
            this.Zdarzenie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Zdarzenie;
        private System.Windows.Forms.DataGridView dataGridViewEvents;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.CheckedListBox typeCheckedListBox;
        private System.Windows.Forms.ComboBox priorityComboBox;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.ComboBox filtercomboBox;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn descCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriorityCol;
        private ComboBox elementsFilterComboBox;
    }
}

