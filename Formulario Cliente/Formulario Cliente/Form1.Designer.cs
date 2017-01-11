namespace Formulario_Cliente
{
    partial class Form1
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
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_Nome = new System.Windows.Forms.TextBox();
            this.txb_Telefone = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbtn_listar = new System.Windows.Forms.Button();
            this.list_Box_cliente = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbx_remove_id = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.txt_Nome_atualiza = new System.Windows.Forms.TextBox();
            this.txt_telefone_atualiza = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_atualiza = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(18, 146);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_adicionar.TabIndex = 0;
            this.btn_adicionar.Text = "adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.button_Adicionar);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefone";
            // 
            // txb_Nome
            // 
            this.txb_Nome.Location = new System.Drawing.Point(111, 23);
            this.txb_Nome.Name = "txb_Nome";
            this.txb_Nome.Size = new System.Drawing.Size(220, 20);
            this.txb_Nome.TabIndex = 3;
            // 
            // txb_Telefone
            // 
            this.txb_Telefone.Location = new System.Drawing.Point(111, 62);
            this.txb_Telefone.Name = "txb_Telefone";
            this.txb_Telefone.Size = new System.Drawing.Size(220, 20);
            this.txb_Telefone.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.txb_Nome);
            this.panel1.Controls.Add(this.txb_Telefone);
            this.panel1.Controls.Add(this.btn_adicionar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 186);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.lbtn_listar);
            this.panel2.Controls.Add(this.list_Box_cliente);
            this.panel2.Location = new System.Drawing.Point(376, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 186);
            this.panel2.TabIndex = 7;
            // 
            // lbtn_listar
            // 
            this.lbtn_listar.Location = new System.Drawing.Point(24, 146);
            this.lbtn_listar.Name = "lbtn_listar";
            this.lbtn_listar.Size = new System.Drawing.Size(75, 23);
            this.lbtn_listar.TabIndex = 1;
            this.lbtn_listar.Text = "listar";
            this.lbtn_listar.UseVisualStyleBackColor = true;
            this.lbtn_listar.Click += new System.EventHandler(this.lbtn_listar_Click);
            // 
            // list_Box_cliente
            // 
            this.list_Box_cliente.FormattingEnabled = true;
            this.list_Box_cliente.Location = new System.Drawing.Point(14, 14);
            this.list_Box_cliente.Name = "list_Box_cliente";
            this.list_Box_cliente.Size = new System.Drawing.Size(301, 108);
            this.list_Box_cliente.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.Controls.Add(this.cbx_remove_id);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btn_excluir);
            this.panel3.Location = new System.Drawing.Point(12, 217);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(346, 212);
            this.panel3.TabIndex = 9;
            // 
            // cbx_remove_id
            // 
            this.cbx_remove_id.FormattingEnabled = true;
            this.cbx_remove_id.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "36",
            "37",
            "38",
            "39",
            "40"});
            this.cbx_remove_id.Location = new System.Drawing.Point(30, 94);
            this.cbx_remove_id.Name = "cbx_remove_id";
            this.cbx_remove_id.Size = new System.Drawing.Size(121, 21);
            this.cbx_remove_id.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Selecione o id para ser excluido";
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(18, 176);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 0;
            this.btn_excluir.Text = "excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Info;
            this.panel4.Controls.Add(this.cbo_atualiza);
            this.panel4.Controls.Add(this.txt_Nome_atualiza);
            this.panel4.Controls.Add(this.txt_telefone_atualiza);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.btn_atualizar);
            this.panel4.Location = new System.Drawing.Point(376, 217);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(340, 212);
            this.panel4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Selecione o id para atualizar";
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Location = new System.Drawing.Point(24, 176);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_atualizar.TabIndex = 0;
            this.btn_atualizar.Text = "atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // txt_Nome_atualiza
            // 
            this.txt_Nome_atualiza.Location = new System.Drawing.Point(108, 100);
            this.txt_Nome_atualiza.Name = "txt_Nome_atualiza";
            this.txt_Nome_atualiza.Size = new System.Drawing.Size(220, 20);
            this.txt_Nome_atualiza.TabIndex = 7;
            // 
            // txt_telefone_atualiza
            // 
            this.txt_telefone_atualiza.Location = new System.Drawing.Point(108, 139);
            this.txt_telefone_atualiza.Name = "txt_telefone_atualiza";
            this.txt_telefone_atualiza.Size = new System.Drawing.Size(220, 20);
            this.txt_telefone_atualiza.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Telefone";
            // 
            // cbo_atualiza
            // 
            this.cbo_atualiza.FormattingEnabled = true;
            this.cbo_atualiza.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "36",
            "37",
            "38",
            "39",
            "40"});
            this.cbo_atualiza.Location = new System.Drawing.Point(38, 58);
            this.cbo_atualiza.Name = "cbo_atualiza";
            this.cbo_atualiza.Size = new System.Drawing.Size(121, 21);
            this.cbo_atualiza.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Cadastro de Cliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_Nome;
        private System.Windows.Forms.TextBox txb_Telefone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button lbtn_listar;
        private System.Windows.Forms.ListBox list_Box_cliente;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbx_remove_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.ComboBox cbo_atualiza;
        private System.Windows.Forms.TextBox txt_Nome_atualiza;
        private System.Windows.Forms.TextBox txt_telefone_atualiza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}