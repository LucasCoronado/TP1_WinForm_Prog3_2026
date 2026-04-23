namespace TPWinForm_equipo14B
{
    partial class frmEliminarArticulos
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
            dgvArticulos = new DataGridView();
            btnEliminar = new Button();
            lbEliminar = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).BeginInit();
            SuspendLayout();
            // 
            // dgvArticulos
            // 
            dgvArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticulos.Location = new Point(12, 12);
            dgvArticulos.Name = "dgvArticulos";
            dgvArticulos.Size = new Size(954, 270);
            dgvArticulos.TabIndex = 0;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = Properties.Resources.eliminar_producto;
            btnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEliminar.Location = new Point(469, 335);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(81, 81);
            btnEliminar.TabIndex = 1;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lbEliminar
            // 
            lbEliminar.AutoSize = true;
            lbEliminar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEliminar.Location = new Point(469, 307);
            lbEliminar.Name = "lbEliminar";
            lbEliminar.Size = new Size(81, 25);
            lbEliminar.TabIndex = 2;
            lbEliminar.Text = "Eliminar";
            // 
            // frmEliminarArticulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 450);
            Controls.Add(lbEliminar);
            Controls.Add(btnEliminar);
            Controls.Add(dgvArticulos);
            Name = "frmEliminarArticulos";
            Text = "frmEliminarArticulos";
            Load += frmEliminarArticulos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvArticulos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvArticulos;
        private Button btnEliminar;
        private Label lbEliminar;
    }

}