
namespace App_Catalogo_de_Comercio
{
    partial class frmMarcas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarcas));
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new App_Catalogo_de_Comercio.Botones();
            this.btnEliminarDB = new App_Catalogo_de_Comercio.Botones();
            this.txtAgregar = new System.Windows.Forms.TextBox();
            this.lblMarcas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarcas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Location = new System.Drawing.Point(12, 12);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.Size = new System.Drawing.Size(340, 130);
            this.dgvMarcas.TabIndex = 0;
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
            this.btnAgregar.Location = new System.Drawing.Point(69, 197);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 40);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.TextColor = System.Drawing.Color.Black;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            this.btnEliminarDB.Location = new System.Drawing.Point(203, 197);
            this.btnEliminarDB.Name = "btnEliminarDB";
            this.btnEliminarDB.Size = new System.Drawing.Size(108, 40);
            this.btnEliminarDB.TabIndex = 2;
            this.btnEliminarDB.Text = "EliminarDB";
            this.btnEliminarDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarDB.TextColor = System.Drawing.Color.Black;
            this.btnEliminarDB.UseVisualStyleBackColor = false;
            this.btnEliminarDB.Click += new System.EventHandler(this.btnEliminarDB_Click);
            // 
            // txtAgregar
            // 
            this.txtAgregar.Location = new System.Drawing.Point(164, 163);
            this.txtAgregar.Name = "txtAgregar";
            this.txtAgregar.Size = new System.Drawing.Size(134, 20);
            this.txtAgregar.TabIndex = 3;
            // 
            // lblMarcas
            // 
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcas.ForeColor = System.Drawing.Color.White;
            this.lblMarcas.Location = new System.Drawing.Point(66, 163);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Size = new System.Drawing.Size(92, 17);
            this.lblMarcas.TabIndex = 4;
            this.lblMarcas.Text = "Nueva Marca:";
            // 
            // frmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(364, 261);
            this.Controls.Add(this.lblMarcas);
            this.Controls.Add(this.txtAgregar);
            this.Controls.Add(this.btnEliminarDB);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvMarcas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMarcas";
            this.Load += new System.EventHandler(this.frmMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarcas;
        private Botones btnAgregar;
        private Botones btnEliminarDB;
        private System.Windows.Forms.TextBox txtAgregar;
        private System.Windows.Forms.Label lblMarcas;
    }
}