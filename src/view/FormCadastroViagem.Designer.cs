namespace gerenciadorViagens_windowsForm_csharp
{
    partial class FormCadastroViagem
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.travelName = new System.Windows.Forms.Label();
            this.destination = new System.Windows.Forms.Label();
            this.initialDate = new System.Windows.Forms.Label();
            this.finalDate = new System.Windows.Forms.Label();
            this.budget = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.tbx_travelName = new System.Windows.Forms.TextBox();
            this.tbx_destination = new System.Windows.Forms.TextBox();
            this.tbx_budget = new System.Windows.Forms.TextBox();
            this.tbx_description = new System.Windows.Forms.TextBox();
            this.tbx_initialDate = new System.Windows.Forms.DateTimePicker();
            this.tbx_finalDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Viagem";
            // 
            // travelName
            // 
            this.travelName.AutoSize = true;
            this.travelName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.travelName.Location = new System.Drawing.Point(32, 155);
            this.travelName.Name = "travelName";
            this.travelName.Size = new System.Drawing.Size(131, 18);
            this.travelName.TabIndex = 1;
            this.travelName.Text = "Nome da Viagem";
            // 
            // destination
            // 
            this.destination.AutoSize = true;
            this.destination.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destination.Location = new System.Drawing.Point(32, 212);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(62, 18);
            this.destination.TabIndex = 1;
            this.destination.Text = "Destino";
            // 
            // initialDate
            // 
            this.initialDate.AutoSize = true;
            this.initialDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialDate.Location = new System.Drawing.Point(32, 259);
            this.initialDate.Name = "initialDate";
            this.initialDate.Size = new System.Drawing.Size(104, 18);
            this.initialDate.TabIndex = 1;
            this.initialDate.Text = "Data de início";
            // 
            // finalDate
            // 
            this.finalDate.AutoSize = true;
            this.finalDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalDate.Location = new System.Drawing.Point(32, 317);
            this.finalDate.Name = "finalDate";
            this.finalDate.Size = new System.Drawing.Size(74, 18);
            this.finalDate.TabIndex = 1;
            this.finalDate.Text = "Data final";
            // 
            // budget
            // 
            this.budget.AutoSize = true;
            this.budget.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budget.Location = new System.Drawing.Point(32, 383);
            this.budget.Name = "budget";
            this.budget.Size = new System.Drawing.Size(85, 18);
            this.budget.TabIndex = 1;
            this.budget.Text = "Orçamento";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(32, 437);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(80, 18);
            this.description.TabIndex = 1;
            this.description.Text = "Descrição";
            // 
            // tbx_travelName
            // 
            this.tbx_travelName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_travelName.Location = new System.Drawing.Point(177, 143);
            this.tbx_travelName.Multiline = true;
            this.tbx_travelName.Name = "tbx_travelName";
            this.tbx_travelName.Size = new System.Drawing.Size(424, 30);
            this.tbx_travelName.TabIndex = 2;
            // 
            // tbx_destination
            // 
            this.tbx_destination.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_destination.Location = new System.Drawing.Point(177, 200);
            this.tbx_destination.Multiline = true;
            this.tbx_destination.Name = "tbx_destination";
            this.tbx_destination.Size = new System.Drawing.Size(424, 30);
            this.tbx_destination.TabIndex = 2;
            // 
            // tbx_budget
            // 
            this.tbx_budget.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_budget.Location = new System.Drawing.Point(177, 371);
            this.tbx_budget.Multiline = true;
            this.tbx_budget.Name = "tbx_budget";
            this.tbx_budget.Size = new System.Drawing.Size(424, 30);
            this.tbx_budget.TabIndex = 2;
            // 
            // tbx_description
            // 
            this.tbx_description.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_description.Location = new System.Drawing.Point(177, 425);
            this.tbx_description.Multiline = true;
            this.tbx_description.Name = "tbx_description";
            this.tbx_description.Size = new System.Drawing.Size(424, 30);
            this.tbx_description.TabIndex = 2;
            // 
            // tbx_initialDate
            // 
            this.tbx_initialDate.CalendarFont = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_initialDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_initialDate.Location = new System.Drawing.Point(177, 257);
            this.tbx_initialDate.Name = "tbx_initialDate";
            this.tbx_initialDate.Size = new System.Drawing.Size(424, 29);
            this.tbx_initialDate.TabIndex = 3;
            // 
            // tbx_finalDate
            // 
            this.tbx_finalDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_finalDate.Location = new System.Drawing.Point(177, 315);
            this.tbx_finalDate.Name = "tbx_finalDate";
            this.tbx_finalDate.Size = new System.Drawing.Size(424, 29);
            this.tbx_finalDate.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(640, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.handleCreateTravelAsync);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(466, 549);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.HandleCancelCreateTravel);
            // 
            // FormCadastroViagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 621);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbx_finalDate);
            this.Controls.Add(this.tbx_initialDate);
            this.Controls.Add(this.tbx_description);
            this.Controls.Add(this.tbx_budget);
            this.Controls.Add(this.tbx_destination);
            this.Controls.Add(this.tbx_travelName);
            this.Controls.Add(this.description);
            this.Controls.Add(this.budget);
            this.Controls.Add(this.finalDate);
            this.Controls.Add(this.initialDate);
            this.Controls.Add(this.destination);
            this.Controls.Add(this.travelName);
            this.Controls.Add(this.label1);
            this.Name = "FormCadastroViagem";
            this.Text = "FormCadastroViagem";
            this.Load += new System.EventHandler(this.FormCadastroViagem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label travelName;
        private System.Windows.Forms.Label destination;
        private System.Windows.Forms.Label initialDate;
        private System.Windows.Forms.Label finalDate;
        private System.Windows.Forms.Label budget;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.TextBox tbx_travelName;
        private System.Windows.Forms.TextBox tbx_destination;
        private System.Windows.Forms.TextBox tbx_budget;
        private System.Windows.Forms.TextBox tbx_description;
        private System.Windows.Forms.DateTimePicker tbx_initialDate;
        private System.Windows.Forms.DateTimePicker tbx_finalDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

