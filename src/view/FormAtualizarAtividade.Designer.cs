namespace gerenciadorViagens_windowsForm_csharp.src.view
{
    partial class FormAtualizarAtividade
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
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbx_date = new System.Windows.Forms.DateTimePicker();
            this.tbx_status = new System.Windows.Forms.TextBox();
            this.tbx_time = new System.Windows.Forms.TextBox();
            this.tbx_location = new System.Windows.Forms.TextBox();
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.Label();
            this.finalDate = new System.Windows.Forms.Label();
            this.initialDate = new System.Windows.Forms.Label();
            this.destination = new System.Windows.Forms.Label();
            this.travelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 32);
            this.label2.TabIndex = 35;
            this.label2.Text = "Atualizar Atividade";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(490, 566);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 42);
            this.button2.TabIndex = 33;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.HandleCancelForm);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(664, 566);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 42);
            this.button1.TabIndex = 34;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.HandleUpdateActivitieAsync);
            // 
            // tbx_date
            // 
            this.tbx_date.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_date.Location = new System.Drawing.Point(121, 316);
            this.tbx_date.Name = "tbx_date";
            this.tbx_date.Size = new System.Drawing.Size(424, 29);
            this.tbx_date.TabIndex = 32;
            // 
            // tbx_status
            // 
            this.tbx_status.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_status.Location = new System.Drawing.Point(121, 372);
            this.tbx_status.Multiline = true;
            this.tbx_status.Name = "tbx_status";
            this.tbx_status.Size = new System.Drawing.Size(424, 30);
            this.tbx_status.TabIndex = 27;
            // 
            // tbx_time
            // 
            this.tbx_time.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_time.Location = new System.Drawing.Point(121, 257);
            this.tbx_time.Multiline = true;
            this.tbx_time.Name = "tbx_time";
            this.tbx_time.Size = new System.Drawing.Size(424, 30);
            this.tbx_time.TabIndex = 29;
            // 
            // tbx_location
            // 
            this.tbx_location.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_location.Location = new System.Drawing.Point(121, 201);
            this.tbx_location.Multiline = true;
            this.tbx_location.Name = "tbx_location";
            this.tbx_location.Size = new System.Drawing.Size(424, 30);
            this.tbx_location.TabIndex = 30;
            // 
            // tbx_name
            // 
            this.tbx_name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_name.Location = new System.Drawing.Point(121, 144);
            this.tbx_name.Multiline = true;
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(424, 30);
            this.tbx_name.TabIndex = 31;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(32, 384);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(52, 18);
            this.description.TabIndex = 21;
            this.description.Text = "Status";
            // 
            // finalDate
            // 
            this.finalDate.AutoSize = true;
            this.finalDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalDate.Location = new System.Drawing.Point(32, 318);
            this.finalDate.Name = "finalDate";
            this.finalDate.Size = new System.Drawing.Size(42, 18);
            this.finalDate.TabIndex = 23;
            this.finalDate.Text = "Data";
            // 
            // initialDate
            // 
            this.initialDate.AutoSize = true;
            this.initialDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialDate.Location = new System.Drawing.Point(32, 260);
            this.initialDate.Name = "initialDate";
            this.initialDate.Size = new System.Drawing.Size(60, 18);
            this.initialDate.TabIndex = 24;
            this.initialDate.Text = "Horário";
            // 
            // destination
            // 
            this.destination.AutoSize = true;
            this.destination.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destination.Location = new System.Drawing.Point(32, 213);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(46, 18);
            this.destination.TabIndex = 25;
            this.destination.Text = "Local";
            // 
            // travelName
            // 
            this.travelName.AutoSize = true;
            this.travelName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.travelName.Location = new System.Drawing.Point(32, 156);
            this.travelName.Name = "travelName";
            this.travelName.Size = new System.Drawing.Size(50, 18);
            this.travelName.TabIndex = 26;
            this.travelName.Text = "Nome";
            // 
            // FormAtualizarAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 621);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbx_date);
            this.Controls.Add(this.tbx_status);
            this.Controls.Add(this.tbx_time);
            this.Controls.Add(this.tbx_location);
            this.Controls.Add(this.tbx_name);
            this.Controls.Add(this.description);
            this.Controls.Add(this.finalDate);
            this.Controls.Add(this.initialDate);
            this.Controls.Add(this.destination);
            this.Controls.Add(this.travelName);
            this.Name = "FormAtualizarAtividade";
            this.Text = "FormAtualizarAtividade";
            this.Load += new System.EventHandler(this.FormAtualizarAtividade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker tbx_date;
        private System.Windows.Forms.TextBox tbx_status;
        private System.Windows.Forms.TextBox tbx_time;
        private System.Windows.Forms.TextBox tbx_location;
        private System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label finalDate;
        private System.Windows.Forms.Label initialDate;
        private System.Windows.Forms.Label destination;
        private System.Windows.Forms.Label travelName;
    }
}