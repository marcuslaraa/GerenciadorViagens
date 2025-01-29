namespace gerenciadorViagens_windowsForm_csharp.src.view
{
    partial class ListagemViagens
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCadastrarViagem = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.travelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initialDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finmalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editTravel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.details = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem vindo ao Gerenciamento de Viagens";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.travelName,
            this.destination,
            this.initialDate,
            this.finmalDate,
            this.budget,
            this.description,
            this.editTravel,
            this.delete,
            this.details});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(39, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(933, 253);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnCadastrarViagem
            // 
            this.btnCadastrarViagem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrarViagem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarViagem.Location = new System.Drawing.Point(843, 617);
            this.btnCadastrarViagem.Name = "btnCadastrarViagem";
            this.btnCadastrarViagem.Size = new System.Drawing.Size(168, 42);
            this.btnCadastrarViagem.TabIndex = 5;
            this.btnCadastrarViagem.Text = "Cadastrar Viagem";
            this.btnCadastrarViagem.UseVisualStyleBackColor = false;
            this.btnCadastrarViagem.Click += new System.EventHandler(this.HandleFormCreateTravel);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id.ToolTipText = "teste";
            this.id.Width = 50;
            // 
            // travelName
            // 
            this.travelName.HeaderText = "Nome da Viagem";
            this.travelName.Name = "travelName";
            this.travelName.Width = 120;
            // 
            // destination
            // 
            this.destination.HeaderText = "Destino";
            this.destination.Name = "destination";
            // 
            // initialDate
            // 
            this.initialDate.HeaderText = "Data de Início";
            this.initialDate.Name = "initialDate";
            // 
            // finmalDate
            // 
            this.finmalDate.HeaderText = "Data Final";
            this.finmalDate.Name = "finmalDate";
            // 
            // budget
            // 
            this.budget.HeaderText = "Orçamento";
            this.budget.Name = "budget";
            // 
            // description
            // 
            this.description.HeaderText = "Descrição";
            this.description.Name = "description";
            this.description.Width = 150;
            // 
            // editTravel
            // 
            this.editTravel.HeaderText = "Acões";
            this.editTravel.Name = "editTravel";
            this.editTravel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editTravel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.editTravel.Text = "Editar";
            this.editTravel.Width = 50;
            // 
            // delete
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            this.delete.DefaultCellStyle = dataGridViewCellStyle1;
            this.delete.HeaderText = "";
            this.delete.Name = "delete";
            this.delete.Width = 50;
            // 
            // details
            // 
            this.details.HeaderText = "Detalhes";
            this.details.Name = "details";
            this.details.Width = 70;
            // 
            // ListagemViagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 671);
            this.Controls.Add(this.btnCadastrarViagem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "ListagemViagens";
            this.Text = "ListagemViagens";
            this.Load += new System.EventHandler(this.ListagemViagens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCadastrarViagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn travelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn initialDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn finmalDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn budget;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewButtonColumn editTravel;
        private System.Windows.Forms.DataGridViewTextBoxColumn delete;
        private System.Windows.Forms.DataGridViewButtonColumn details;
    }
}