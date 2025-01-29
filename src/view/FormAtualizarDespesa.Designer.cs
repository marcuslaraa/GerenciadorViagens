namespace gerenciadorViagens_windowsForm_csharp.src.view
{
    partial class FormAtualizarDespesa
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_description = new System.Windows.Forms.TextBox();
            this.tbx_value = new System.Windows.Forms.TextBox();
            this.initialDate = new System.Windows.Forms.Label();
            this.destination = new System.Windows.Forms.Label();
            this.travelName = new System.Windows.Forms.Label();
            this.tbx_category = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(490, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.HandleCancelCreateExpense);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(664, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.HandleUpdateExpense);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Atualizar Despesa";
            // 
            // tbx_description
            // 
            this.tbx_description.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_description.Location = new System.Drawing.Point(121, 257);
            this.tbx_description.Multiline = true;
            this.tbx_description.Name = "tbx_description";
            this.tbx_description.Size = new System.Drawing.Size(424, 30);
            this.tbx_description.TabIndex = 3;
            // 
            // tbx_value
            // 
            this.tbx_value.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_value.Location = new System.Drawing.Point(121, 201);
            this.tbx_value.Multiline = true;
            this.tbx_value.Name = "tbx_value";
            this.tbx_value.Size = new System.Drawing.Size(424, 30);
            this.tbx_value.TabIndex = 2;
            // 
            // initialDate
            // 
            this.initialDate.AutoSize = true;
            this.initialDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialDate.Location = new System.Drawing.Point(32, 260);
            this.initialDate.Name = "initialDate";
            this.initialDate.Size = new System.Drawing.Size(80, 18);
            this.initialDate.TabIndex = 34;
            this.initialDate.Text = "Descrição";
            // 
            // destination
            // 
            this.destination.AutoSize = true;
            this.destination.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destination.Location = new System.Drawing.Point(32, 208);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(44, 18);
            this.destination.TabIndex = 35;
            this.destination.Text = "Valor";
            // 
            // travelName
            // 
            this.travelName.AutoSize = true;
            this.travelName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.travelName.Location = new System.Drawing.Point(32, 150);
            this.travelName.Name = "travelName";
            this.travelName.Size = new System.Drawing.Size(78, 18);
            this.travelName.TabIndex = 36;
            this.travelName.Text = "Categoria";
            // 
            // tbx_category
            // 
            this.tbx_category.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_category.FormattingEnabled = true;
            this.tbx_category.Items.AddRange(new object[] {
            "Comida",
            "Turismo",
            "Praia",
            "Cultura",
            "Entretenimento"});
            this.tbx_category.Location = new System.Drawing.Point(121, 144);
            this.tbx_category.Name = "tbx_category";
            this.tbx_category.Size = new System.Drawing.Size(424, 30);
            this.tbx_category.TabIndex = 40;
            // 
            // FormAtualizarDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 461);
            this.Controls.Add(this.tbx_category);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_description);
            this.Controls.Add(this.tbx_value);
            this.Controls.Add(this.initialDate);
            this.Controls.Add(this.destination);
            this.Controls.Add(this.travelName);
            this.Name = "FormAtualizarDespesa";
            this.Text = "FormAtualizarDespesa";
            this.Load += new System.EventHandler(this.FormAtualizarDespesa_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressNumberExpense);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_description;
        private System.Windows.Forms.TextBox tbx_value;
        private System.Windows.Forms.Label initialDate;
        private System.Windows.Forms.Label destination;
        private System.Windows.Forms.Label travelName;
        private System.Windows.Forms.ComboBox tbx_category;
    }
}