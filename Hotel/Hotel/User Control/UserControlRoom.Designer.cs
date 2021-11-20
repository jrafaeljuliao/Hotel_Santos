
namespace Hotel.User_Control
{
    partial class UserControlRoom
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlRoom = new System.Windows.Forms.TabControl();
            this.TabPageAddRoom = new System.Windows.Forms.TabPage();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxPhoneNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSearchRoom = new System.Windows.Forms.TabPage();
            this.textBoxSearchRoomNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPageUpdateAndDeleteRoom = new System.Windows.Forms.TabPage();
            this.radioButtonNo1 = new System.Windows.Forms.RadioButton();
            this.radioButtonYes1 = new System.Windows.Forms.RadioButton();
            this.comboBoxType1 = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxPhoneNo1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridViewRoom = new System.Windows.Forms.DataGridView();
            this.Room_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room_Free = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlRoom.SuspendLayout();
            this.TabPageAddRoom.SuspendLayout();
            this.tabPageSearchRoom.SuspendLayout();
            this.tabPageUpdateAndDeleteRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlRoom
            // 
            this.tabControlRoom.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlRoom.Controls.Add(this.TabPageAddRoom);
            this.tabControlRoom.Controls.Add(this.tabPageSearchRoom);
            this.tabControlRoom.Controls.Add(this.tabPageUpdateAndDeleteRoom);
            this.tabControlRoom.Location = new System.Drawing.Point(36, 14);
            this.tabControlRoom.Name = "tabControlRoom";
            this.tabControlRoom.SelectedIndex = 0;
            this.tabControlRoom.Size = new System.Drawing.Size(1031, 417);
            this.tabControlRoom.TabIndex = 0;
            // 
            // TabPageAddRoom
            // 
            this.TabPageAddRoom.Controls.Add(this.radioButtonNo);
            this.TabPageAddRoom.Controls.Add(this.radioButtonYes);
            this.TabPageAddRoom.Controls.Add(this.comboBoxType);
            this.TabPageAddRoom.Controls.Add(this.buttonAdd);
            this.TabPageAddRoom.Controls.Add(this.textBoxPhoneNo);
            this.TabPageAddRoom.Controls.Add(this.label3);
            this.TabPageAddRoom.Controls.Add(this.label4);
            this.TabPageAddRoom.Controls.Add(this.label2);
            this.TabPageAddRoom.Controls.Add(this.label1);
            this.TabPageAddRoom.Location = new System.Drawing.Point(4, 4);
            this.TabPageAddRoom.Name = "TabPageAddRoom";
            this.TabPageAddRoom.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageAddRoom.Size = new System.Drawing.Size(1023, 388);
            this.TabPageAddRoom.TabIndex = 0;
            this.TabPageAddRoom.Text = "Adicionar Quarto:";
            this.TabPageAddRoom.UseVisualStyleBackColor = true;
            this.TabPageAddRoom.Click += new System.EventHandler(this.tabPage1_Click);
            this.TabPageAddRoom.Leave += new System.EventHandler(this.TabPageAddRoom_Leave);
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(266, 209);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(52, 20);
            this.radioButtonNo.TabIndex = 4;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "Não";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Location = new System.Drawing.Point(266, 183);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(49, 20);
            this.radioButtonYes.TabIndex = 3;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Sim";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Casal",
            "Familia",
            "Presidencial",
            "Solteiro",
            "Suite"});
            this.comboBoxType.Location = new System.Drawing.Point(177, 130);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(264, 24);
            this.comboBoxType.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(177, 259);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(106, 40);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Adicionar";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxPhoneNo
            // 
            this.textBoxPhoneNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPhoneNo.Location = new System.Drawing.Point(512, 132);
            this.textBoxPhoneNo.Name = "textBoxPhoneNo";
            this.textBoxPhoneNo.Size = new System.Drawing.Size(260, 22);
            this.textBoxPhoneNo.TabIndex = 2;
            this.textBoxPhoneNo.TextChanged += new System.EventHandler(this.textBoxPhoneNo_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(509, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefone No.:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(174, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Disponível:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adicionar Quarto:";
            // 
            // tabPageSearchRoom
            // 
            this.tabPageSearchRoom.Controls.Add(this.dataGridViewRoom);
            this.tabPageSearchRoom.Controls.Add(this.textBoxSearchRoomNo);
            this.tabPageSearchRoom.Controls.Add(this.label5);
            this.tabPageSearchRoom.Controls.Add(this.label6);
            this.tabPageSearchRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchRoom.Name = "tabPageSearchRoom";
            this.tabPageSearchRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchRoom.Size = new System.Drawing.Size(1023, 388);
            this.tabPageSearchRoom.TabIndex = 1;
            this.tabPageSearchRoom.Text = "Procurar Quartos:";
            this.tabPageSearchRoom.UseVisualStyleBackColor = true;
            this.tabPageSearchRoom.Enter += new System.EventHandler(this.tabPageSearchRoom_Enter);
            this.tabPageSearchRoom.Leave += new System.EventHandler(this.tabPageSearchRoom_Leave);
            // 
            // textBoxSearchRoomNo
            // 
            this.textBoxSearchRoomNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearchRoomNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearchRoomNo.Location = new System.Drawing.Point(186, 68);
            this.textBoxSearchRoomNo.Name = "textBoxSearchRoomNo";
            this.textBoxSearchRoomNo.Size = new System.Drawing.Size(260, 22);
            this.textBoxSearchRoomNo.TabIndex = 2;
            this.textBoxSearchRoomNo.TextChanged += new System.EventHandler(this.textBoxSearchRoomNo_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(183, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nº Quarto:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Procurar Quarto:";
            // 
            // tabPageUpdateAndDeleteRoom
            // 
            this.tabPageUpdateAndDeleteRoom.Controls.Add(this.radioButtonNo1);
            this.tabPageUpdateAndDeleteRoom.Controls.Add(this.radioButtonYes1);
            this.tabPageUpdateAndDeleteRoom.Controls.Add(this.comboBoxType1);
            this.tabPageUpdateAndDeleteRoom.Controls.Add(this.buttonDelete);
            this.tabPageUpdateAndDeleteRoom.Controls.Add(this.buttonUpdate);
            this.tabPageUpdateAndDeleteRoom.Controls.Add(this.textBoxPhoneNo1);
            this.tabPageUpdateAndDeleteRoom.Controls.Add(this.label7);
            this.tabPageUpdateAndDeleteRoom.Controls.Add(this.label8);
            this.tabPageUpdateAndDeleteRoom.Controls.Add(this.label9);
            this.tabPageUpdateAndDeleteRoom.Controls.Add(this.label10);
            this.tabPageUpdateAndDeleteRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateAndDeleteRoom.Name = "tabPageUpdateAndDeleteRoom";
            this.tabPageUpdateAndDeleteRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateAndDeleteRoom.Size = new System.Drawing.Size(1023, 388);
            this.tabPageUpdateAndDeleteRoom.TabIndex = 2;
            this.tabPageUpdateAndDeleteRoom.Text = "Atualizar e Deletar Quartos:";
            this.tabPageUpdateAndDeleteRoom.UseVisualStyleBackColor = true;
            // 
            // radioButtonNo1
            // 
            this.radioButtonNo1.AutoSize = true;
            this.radioButtonNo1.Location = new System.Drawing.Point(266, 209);
            this.radioButtonNo1.Name = "radioButtonNo1";
            this.radioButtonNo1.Size = new System.Drawing.Size(52, 20);
            this.radioButtonNo1.TabIndex = 4;
            this.radioButtonNo1.TabStop = true;
            this.radioButtonNo1.Text = "Não";
            this.radioButtonNo1.UseVisualStyleBackColor = true;
            // 
            // radioButtonYes1
            // 
            this.radioButtonYes1.AutoSize = true;
            this.radioButtonYes1.Location = new System.Drawing.Point(266, 183);
            this.radioButtonYes1.Name = "radioButtonYes1";
            this.radioButtonYes1.Size = new System.Drawing.Size(49, 20);
            this.radioButtonYes1.TabIndex = 3;
            this.radioButtonYes1.TabStop = true;
            this.radioButtonYes1.Text = "Sim";
            this.radioButtonYes1.UseVisualStyleBackColor = true;
            // 
            // comboBoxType1
            // 
            this.comboBoxType1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxType1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType1.FormattingEnabled = true;
            this.comboBoxType1.Items.AddRange(new object[] {
            "Casal",
            "Familia",
            "Presidencial",
            "Solteiro",
            "Suite"});
            this.comboBoxType1.Location = new System.Drawing.Point(177, 130);
            this.comboBoxType1.Name = "comboBoxType1";
            this.comboBoxType1.Size = new System.Drawing.Size(264, 24);
            this.comboBoxType1.TabIndex = 1;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(73)))), ((int)(((byte)(67)))));
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(289, 259);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(106, 40);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Deletar";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(177, 259);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(106, 40);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Atualizar";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxPhoneNo1
            // 
            this.textBoxPhoneNo1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPhoneNo1.Location = new System.Drawing.Point(512, 132);
            this.textBoxPhoneNo1.Name = "textBoxPhoneNo1";
            this.textBoxPhoneNo1.Size = new System.Drawing.Size(260, 22);
            this.textBoxPhoneNo1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(509, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Telefone No.:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(174, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Disponível:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(174, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tipo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(212, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Atualizar e Deletar Quartos";
            // 
            // dataGridViewRoom
            // 
            this.dataGridViewRoom.AllowUserToAddRows = false;
            this.dataGridViewRoom.AllowUserToDeleteRows = false;
            this.dataGridViewRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Room_Number,
            this.Room_Type,
            this.Room_Phone,
            this.Room_Free});
            this.dataGridViewRoom.Location = new System.Drawing.Point(31, 120);
            this.dataGridViewRoom.Name = "dataGridViewRoom";
            this.dataGridViewRoom.ReadOnly = true;
            this.dataGridViewRoom.Size = new System.Drawing.Size(962, 227);
            this.dataGridViewRoom.TabIndex = 0;
            this.dataGridViewRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoom_CellClick);
            // 
            // Room_Number
            // 
            this.Room_Number.DataPropertyName = "Room_Number";
            this.Room_Number.HeaderText = "No.";
            this.Room_Number.Name = "Room_Number";
            this.Room_Number.ReadOnly = true;
            // 
            // Room_Type
            // 
            this.Room_Type.DataPropertyName = "Room_Type";
            this.Room_Type.HeaderText = "Tipo";
            this.Room_Type.Name = "Room_Type";
            this.Room_Type.ReadOnly = true;
            // 
            // Room_Phone
            // 
            this.Room_Phone.DataPropertyName = "Room_Phone";
            this.Room_Phone.HeaderText = "Telefone";
            this.Room_Phone.Name = "Room_Phone";
            this.Room_Phone.ReadOnly = true;
            // 
            // Room_Free
            // 
            this.Room_Free.DataPropertyName = "Room_Free";
            this.Room_Free.HeaderText = "Disponível";
            this.Room_Free.Name = "Room_Free";
            this.Room_Free.ReadOnly = true;
            // 
            // UserControlRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlRoom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlRoom";
            this.Size = new System.Drawing.Size(1102, 462);
            this.Load += new System.EventHandler(this.UserControlRoom_Load);
            this.tabControlRoom.ResumeLayout(false);
            this.TabPageAddRoom.ResumeLayout(false);
            this.TabPageAddRoom.PerformLayout();
            this.tabPageSearchRoom.ResumeLayout(false);
            this.tabPageSearchRoom.PerformLayout();
            this.tabPageUpdateAndDeleteRoom.ResumeLayout(false);
            this.tabPageUpdateAndDeleteRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlRoom;
        private System.Windows.Forms.TabPage TabPageAddRoom;
        private System.Windows.Forms.TabPage tabPageSearchRoom;
        private System.Windows.Forms.TabPage tabPageUpdateAndDeleteRoom;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxPhoneNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearchRoomNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButtonNo1;
        private System.Windows.Forms.RadioButton radioButtonYes1;
        private System.Windows.Forms.ComboBox comboBoxType1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxPhoneNo1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridViewRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room_Free;
    }
}
