namespace Formularios
{
    partial class FormPedidos
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
            this.btn_Atender = new System.Windows.Forms.Button();
            this.rtb_Entregados = new System.Windows.Forms.RichTextBox();
            this.rtb_Pendientes = new System.Windows.Forms.RichTextBox();
            this.btn_Parar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_PedidoNuevo = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Atender
            // 
            this.btn_Atender.Location = new System.Drawing.Point(72, 346);
            this.btn_Atender.Name = "btn_Atender";
            this.btn_Atender.Size = new System.Drawing.Size(75, 44);
            this.btn_Atender.TabIndex = 0;
            this.btn_Atender.Text = "Comenzar a atender";
            this.btn_Atender.UseVisualStyleBackColor = true;
            this.btn_Atender.Click += new System.EventHandler(this.btn_Atender_Click);
            // 
            // rtb_Entregados
            // 
            this.rtb_Entregados.Location = new System.Drawing.Point(419, 110);
            this.rtb_Entregados.Name = "rtb_Entregados";
            this.rtb_Entregados.ReadOnly = true;
            this.rtb_Entregados.Size = new System.Drawing.Size(281, 218);
            this.rtb_Entregados.TabIndex = 2;
            this.rtb_Entregados.Text = "";
            // 
            // rtb_Pendientes
            // 
            this.rtb_Pendientes.Location = new System.Drawing.Point(72, 110);
            this.rtb_Pendientes.Name = "rtb_Pendientes";
            this.rtb_Pendientes.ReadOnly = true;
            this.rtb_Pendientes.Size = new System.Drawing.Size(281, 218);
            this.rtb_Pendientes.TabIndex = 3;
            this.rtb_Pendientes.Text = "";
            // 
            // btn_Parar
            // 
            this.btn_Parar.Location = new System.Drawing.Point(153, 346);
            this.btn_Parar.Name = "btn_Parar";
            this.btn_Parar.Size = new System.Drawing.Size(75, 44);
            this.btn_Parar.TabIndex = 4;
            this.btn_Parar.Text = "Frenar atencion";
            this.btn_Parar.UseVisualStyleBackColor = true;
            this.btn_Parar.Click += new System.EventHandler(this.btn_Parar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pendientes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(419, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Entregados";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(628, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pedidos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_PedidoNuevo
            // 
            this.btn_PedidoNuevo.Location = new System.Drawing.Point(72, 398);
            this.btn_PedidoNuevo.Name = "btn_PedidoNuevo";
            this.btn_PedidoNuevo.Size = new System.Drawing.Size(156, 23);
            this.btn_PedidoNuevo.TabIndex = 8;
            this.btn_PedidoNuevo.Text = "Generar pedido";
            this.btn_PedidoNuevo.UseVisualStyleBackColor = true;
            this.btn_PedidoNuevo.Click += new System.EventHandler(this.btn_PedidoNuevo_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(713, 407);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 9;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(800, 433);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_PedidoNuevo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Parar);
            this.Controls.Add(this.rtb_Pendientes);
            this.Controls.Add(this.rtb_Entregados);
            this.Controls.Add(this.btn_Atender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPedidos";
            this.Text = "Estado de los pedidos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPedidos_FormClosing);
            this.Load += new System.EventHandler(this.FormPedidos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Atender;
        private System.Windows.Forms.RichTextBox rtb_Entregados;
        private System.Windows.Forms.RichTextBox rtb_Pendientes;
        private System.Windows.Forms.Button btn_Parar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_PedidoNuevo;
        private System.Windows.Forms.Button btn_Salir;
    }
}

