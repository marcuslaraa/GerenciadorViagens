namespace gerenciadorViagens_windowsForm_csharp.src.view
{
    partial class DetalhesDaViagem
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
            this.lb_nomeViagem = new System.Windows.Forms.Label();
            this.lb_dataIda = new System.Windows.Forms.Label();
            this.lb_dataVolta = new System.Windows.Forms.Label();
            this.lb_orcamento = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activitiesEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCadastrarViagem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_description = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_nomeViagem
            // 
            this.lb_nomeViagem.AutoSize = true;
            this.lb_nomeViagem.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nomeViagem.Location = new System.Drawing.Point(34, 31);
            this.lb_nomeViagem.Name = "lb_nomeViagem";
            this.lb_nomeViagem.Size = new System.Drawing.Size(461, 52);
            this.lb_nomeViagem.TabIndex = 0;
            this.lb_nomeViagem.Text = "Fernando de Noronha";
            this.lb_nomeViagem.UseWaitCursor = true;
            // 
            // lb_dataIda
            // 
            this.lb_dataIda.AutoSize = true;
            this.lb_dataIda.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dataIda.Location = new System.Drawing.Point(43, 91);
            this.lb_dataIda.Name = "lb_dataIda";
            this.lb_dataIda.Size = new System.Drawing.Size(97, 16);
            this.lb_dataIda.TabIndex = 1;
            this.lb_dataIda.Text = "Ida: 25/02/2025";
            // 
            // lb_dataVolta
            // 
            this.lb_dataVolta.AutoSize = true;
            this.lb_dataVolta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dataVolta.Location = new System.Drawing.Point(43, 114);
            this.lb_dataVolta.Name = "lb_dataVolta";
            this.lb_dataVolta.Size = new System.Drawing.Size(109, 16);
            this.lb_dataVolta.TabIndex = 1;
            this.lb_dataVolta.Text = "Volta: 03/03/2025";
            // 
            // lb_orcamento
            // 
            this.lb_orcamento.AutoSize = true;
            this.lb_orcamento.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_orcamento.Location = new System.Drawing.Point(848, 54);
            this.lb_orcamento.Name = "lb_orcamento";
            this.lb_orcamento.Size = new System.Drawing.Size(142, 29);
            this.lb_orcamento.TabIndex = 2;
            this.lb_orcamento.Text = "R$ 1.200,00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(850, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Orçamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Atividades";
            this.label1.UseWaitCursor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.location,
            this.time,
            this.date,
            this.status,
            this.activitiesEdit});
            this.dataGridView1.Location = new System.Drawing.Point(43, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(603, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // name
            // 
            this.name.HeaderText = "Nome";
            this.name.Name = "name";
            // 
            // location
            // 
            this.location.HeaderText = "Local";
            this.location.Name = "location";
            // 
            // time
            // 
            this.time.HeaderText = "Horário";
            this.time.Name = "time";
            // 
            // date
            // 
            this.date.HeaderText = "Data";
            this.date.Name = "date";
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // activitiesEdit
            // 
            this.activitiesEdit.HeaderText = "Editar";
            this.activitiesEdit.Name = "activitiesEdit";
            this.activitiesEdit.Width = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Despesas";
            this.label3.UseWaitCursor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.category,
            this.budget,
            this.description,
            this.expenseEdit});
            this.dataGridView2.Location = new System.Drawing.Point(43, 553);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(403, 150);
            this.dataGridView2.TabIndex = 5;
            // 
            // category
            // 
            this.category.HeaderText = "Categoria";
            this.category.Name = "category";
            // 
            // budget
            // 
            this.budget.HeaderText = "Valor";
            this.budget.Name = "budget";
            // 
            // description
            // 
            this.description.HeaderText = "Descrição";
            this.description.Name = "description";
            this.description.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // expenseEdit
            // 
            this.expenseEdit.HeaderText = "Editar";
            this.expenseEdit.Name = "expenseEdit";
            this.expenseEdit.Width = 60;
            // 
            // btnCadastrarViagem
            // 
            this.btnCadastrarViagem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrarViagem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarViagem.Location = new System.Drawing.Point(40, 426);
            this.btnCadastrarViagem.Name = "btnCadastrarViagem";
            this.btnCadastrarViagem.Size = new System.Drawing.Size(168, 42);
            this.btnCadastrarViagem.TabIndex = 7;
            this.btnCadastrarViagem.Text = "Criar atividade";
            this.btnCadastrarViagem.UseVisualStyleBackColor = false;
            this.btnCadastrarViagem.Click += new System.EventHandler(this.HandleOpenFormCreateActivitie);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(40, 709);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Adicionar despesa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.HandleOpenFormCreateExpense);
            // 
            // lb_description
            // 
            this.lb_description.AutoSize = true;
            this.lb_description.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_description.Location = new System.Drawing.Point(46, 153);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(72, 17);
            this.lb_description.TabIndex = 8;
            this.lb_description.Text = "descrição";
            // 
            // DetalhesDaViagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 798);
            this.Controls.Add(this.lb_description);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCadastrarViagem);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_orcamento);
            this.Controls.Add(this.lb_dataVolta);
            this.Controls.Add(this.lb_dataIda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_nomeViagem);
            this.Name = "DetalhesDaViagem";
            this.Text = "DetalhesDaViagem";
            this.Load += new System.EventHandler(this.DetalhesDaViagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nomeViagem;
        private System.Windows.Forms.Label lb_dataIda;
        private System.Windows.Forms.Label lb_dataVolta;
        private System.Windows.Forms.Label lb_orcamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewButtonColumn activitiesEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn budget;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewButtonColumn expenseEdit;
        private System.Windows.Forms.Button btnCadastrarViagem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_description;
    }
}