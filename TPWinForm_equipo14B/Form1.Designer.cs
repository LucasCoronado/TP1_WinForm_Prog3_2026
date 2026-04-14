namespace TPWinForm_equipo14B
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbGestionArt = new Label();
            btnListArticulos = new Button();
            btnBusqArt = new Button();
            btnAgregarArt = new Button();
            btnModifArt = new Button();
            btnEliminarArt = new Button();
            btnDetalleArt = new Button();
            SuspendLayout();
            // 
            // lbGestionArt
            // 
            lbGestionArt.AutoSize = true;
            lbGestionArt.Location = new Point(339, 9);
            lbGestionArt.Name = "lbGestionArt";
            lbGestionArt.Size = new Size(111, 15);
            lbGestionArt.TabIndex = 0;
            lbGestionArt.Text = "Gestión de artículos";
            // 
            // btnListArticulos
            // 
            btnListArticulos.Location = new Point(159, 116);
            btnListArticulos.Name = "btnListArticulos";
            btnListArticulos.Size = new Size(110, 70);
            btnListArticulos.TabIndex = 1;
            btnListArticulos.Text = "Listado de artículos";
            btnListArticulos.UseVisualStyleBackColor = true;
            // 
            // btnBusqArt
            // 
            btnBusqArt.Location = new Point(356, 116);
            btnBusqArt.Name = "btnBusqArt";
            btnBusqArt.Size = new Size(110, 70);
            btnBusqArt.TabIndex = 2;
            btnBusqArt.Text = "Búsqueda de artículos";
            btnBusqArt.UseVisualStyleBackColor = true;
            // 
            // btnAgregarArt
            // 
            btnAgregarArt.Location = new Point(543, 116);
            btnAgregarArt.Name = "btnAgregarArt";
            btnAgregarArt.Size = new Size(110, 70);
            btnAgregarArt.TabIndex = 3;
            btnAgregarArt.Text = "Agregar artículo";
            btnAgregarArt.UseVisualStyleBackColor = true;
            btnAgregarArt.Click += btnAgregarArt_Click;
            // 
            // btnModifArt
            // 
            btnModifArt.Location = new Point(159, 246);
            btnModifArt.Name = "btnModifArt";
            btnModifArt.Size = new Size(110, 70);
            btnModifArt.TabIndex = 4;
            btnModifArt.Text = "Modificar artículo";
            btnModifArt.UseVisualStyleBackColor = true;
            // 
            // btnEliminarArt
            // 
            btnEliminarArt.Location = new Point(356, 246);
            btnEliminarArt.Name = "btnEliminarArt";
            btnEliminarArt.Size = new Size(110, 70);
            btnEliminarArt.TabIndex = 5;
            btnEliminarArt.Text = "Eliminar artículo";
            btnEliminarArt.UseVisualStyleBackColor = true;
            // 
            // btnDetalleArt
            // 
            btnDetalleArt.Location = new Point(543, 246);
            btnDetalleArt.Name = "btnDetalleArt";
            btnDetalleArt.Size = new Size(110, 70);
            btnDetalleArt.TabIndex = 6;
            btnDetalleArt.Text = "Detalle de artículo";
            btnDetalleArt.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDetalleArt);
            Controls.Add(btnEliminarArt);
            Controls.Add(btnModifArt);
            Controls.Add(btnAgregarArt);
            Controls.Add(btnBusqArt);
            Controls.Add(btnListArticulos);
            Controls.Add(lbGestionArt);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbGestionArt;
        private Button btnListArticulos;
        private Button btnBusqArt;
        private Button btnAgregarArt;
        private Button btnModifArt;
        private Button btnEliminarArt;
        private Button btnDetalleArt;
    }
}
