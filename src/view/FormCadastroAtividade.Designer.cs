namespace gerenciadorViagens_windowsForm_csharp.src.view
{
    partial class FormCadastroAtividade
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbx_date = new System.Windows.Forms.DateTimePicker();
            this.tbx_location = new System.Windows.Forms.TextBox();
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.finalDate = new System.Windows.Forms.Label();
            this.initialDate = new System.Windows.Forms.Label();
            this.destination = new System.Windows.Forms.Label();
            this.travelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_time = new System.Windows.Forms.TextBox();
            this.tbx_status = new System.Windows.Forms.ComboBox();
            this.description = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(490, 566);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 42);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.HandleCancelCreateActivitie);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(664, 566);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.HandleCreateActivitie);
            // 
            // tbx_date
            // 
            this.tbx_date.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_date.Location = new System.Drawing.Point(121, 316);
            this.tbx_date.Name = "tbx_date";
            this.tbx_date.Size = new System.Drawing.Size(424, 29);
            this.tbx_date.TabIndex = 4;
            // 
            // tbx_location
            // 
            this.tbx_location.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_location.Location = new System.Drawing.Point(121, 201);
            this.tbx_location.Multiline = true;
            this.tbx_location.Name = "tbx_location";
            this.tbx_location.Size = new System.Drawing.Size(424, 30);
            this.tbx_location.TabIndex = 2;
            // 
            // tbx_name
            // 
            this.tbx_name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_name.Location = new System.Drawing.Point(121, 144);
            this.tbx_name.Multiline = true;
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(424, 30);
            this.tbx_name.TabIndex = 1;
            // 
            // finalDate
            // 
            this.finalDate.AutoSize = true;
            this.finalDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalDate.Location = new System.Drawing.Point(32, 318);
            this.finalDate.Name = "finalDate";
            this.finalDate.Size = new System.Drawing.Size(42, 18);
            this.finalDate.TabIndex = 8;
            this.finalDate.Text = "Data";
            // 
            // initialDate
            // 
            this.initialDate.AutoSize = true;
            this.initialDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialDate.Location = new System.Drawing.Point(32, 260);
            this.initialDate.Name = "initialDate";
            this.initialDate.Size = new System.Drawing.Size(60, 18);
            this.initialDate.TabIndex = 9;
            this.initialDate.Text = "Horário";
            // 
            // destination
            // 
            this.destination.AutoSize = true;
            this.destination.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destination.Location = new System.Drawing.Point(32, 213);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(46, 18);
            this.destination.TabIndex = 10;
            this.destination.Text = "Local";
            // 
            // travelName
            // 
            this.travelName.AutoSize = true;
            this.travelName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.travelName.Location = new System.Drawing.Point(32, 156);
            this.travelName.Name = "travelName";
            this.travelName.Size = new System.Drawing.Size(50, 18);
            this.travelName.TabIndex = 5;
            this.travelName.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, -40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cadastrar Viagem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Criar Atividade";
            // 
            // tbx_time
            // 
            this.tbx_time.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_time.Location = new System.Drawing.Point(121, 257);
            this.tbx_time.Multiline = true;
            this.tbx_time.Name = "tbx_time";
            this.tbx_time.Size = new System.Drawing.Size(424, 30);
            this.tbx_time.TabIndex = 3;
            // 
            // tbx_status
            // 
            this.tbx_status.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_status.FormattingEnabled = true;
            this.tbx_status.Items.AddRange(new object[] {
            "Pendente",
            "Realizado",
            "Adiado"});
            this.tbx_status.Location = new System.Drawing.Point(121, 370);
            this.tbx_status.Name = "tbx_status";
            this.tbx_status.Size = new System.Drawing.Size(424, 26);
            this.tbx_status.TabIndex = 38;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(32, 373);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(52, 18);
            this.description.TabIndex = 37;
            this.description.Text = "Status";
            // 
            // FormCadastroAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 621);
            this.Controls.Add(this.tbx_status);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbx_date);
            this.Controls.Add(this.tbx_time);
            this.Controls.Add(this.tbx_location);
            this.Controls.Add(this.tbx_name);
            this.Controls.Add(this.finalDate);
            this.Controls.Add(this.initialDate);
            this.Controls.Add(this.destination);
            this.Controls.Add(this.travelName);
            this.Controls.Add(this.label1);
            this.Name = "FormCadastroAtividade";
            this.Text = "FormCadastroAtividade";
            this.Load += new System.EventHandler(this.FormCadastroAtividade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker tbx_date;
        private System.Windows.Forms.TextBox tbx_location;
        private System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.Label finalDate;
        private System.Windows.Forms.Label initialDate;
        private System.Windows.Forms.Label destination;
        private System.Windows.Forms.Label travelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_time;
        private System.Windows.Forms.ComboBox tbx_status;
        private System.Windows.Forms.Label description;
    }
}