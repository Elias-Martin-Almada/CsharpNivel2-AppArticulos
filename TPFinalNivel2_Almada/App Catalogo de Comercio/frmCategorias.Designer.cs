
namespace App_Catalogo_de_Comercio
{
    partial class frmCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategorias));
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAgregar = new System.Windows.Forms.TextBox();
            this.btnEliminarDB = new App_Catalogo_de_Comercio.Botones();
            this.btnAgregar = new App_Catalogo_de_Comercio.Botones();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategorias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(12, 12);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.Size = new System.Drawing.Size(340, 130);
            this.dgvCategorias.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nueva Categoria:";
            // 
            // txtAgregar
            // 
            this.txtAgregar.Location = new System.Drawing.Point(175, 161);
            this.txtAgregar.Name = "txtAgregar";
            this.txtAgregar.Size = new System.Drawing.Size(134, 20);
            this.txtAgregar.TabIndex = 4;
            // 
            // btnEliminarDB
            // 
            this.btnEliminarDB.BackColor = System.Drawing.Color.LightGreen;
            this.btnEliminarDB.BackgroundColor = System.Drawing.Color.LightGreen;
            this.btnEliminarDB.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminarDB.BorderRadius = 20;
            this.btnEliminarDB.BorderSize = 0;
            this.btnEliminarDB.FlatAppearance.BorderSize = 0;
            this.btnEliminarDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDB.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarDB.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarDB.Image")));
            this.btnEliminarDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarDB.Location = new System.Drawing.Point(201, 199);
            this.btnEliminarDB.Name = "btnEliminarDB";
            this.btnEliminarDB.Size = new System.Drawing.Size(108, 40);
            this.btnEliminarDB.TabIndex = 2;
            this.btnEliminarDB.Text = "EliminarDB";
            this.btnEliminarDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarDB.TextColor = System.Drawing.Color.Black;
            this.btnEliminarDB.UseVisualStyleBackColor = false;
            this.btnEliminarDB.Click += new System.EventHandler(this.btnEliminarDB_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LightGreen;
            this.btnAgregar.BackgroundColor = System.Drawing.Color.LightGreen;
            this.btnAgregar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregar.BorderRadius = 20;
            this.btnAgregar.BorderSize = 0;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(58, 199);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 40);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.TextColor = System.Drawing.Color.Black;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(364, 261);
            this.Controls.Add(this.txtAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarDB);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvCategorias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCategorias";
            this.Load += new System.EventHandler(this.frmCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategorias;
        private Botones btnAgregar;
        private Botones btnEliminarDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAgregar;
    }
}