
namespace App_Catalogo_de_Comercio
{
    partial class frmPapelera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPapelera));
            this.dgvPapelera = new System.Windows.Forms.DataGridView();
            this.btnEliminarDB = new App_Catalogo_de_Comercio.Botones();
            this.btnRestaurar = new App_Catalogo_de_Comercio.Botones();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPapelera)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPapelera
            // 
            this.dgvPapelera.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPapelera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPapelera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPapelera.Location = new System.Drawing.Point(12, 12);
            this.dgvPapelera.Name = "dgvPapelera";
            this.dgvPapelera.Size = new System.Drawing.Size(546, 140);
            this.dgvPapelera.TabIndex = 0;
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
            this.btnEliminarDB.Location = new System.Drawing.Point(301, 171);
            this.btnEliminarDB.Name = "btnEliminarDB";
            this.btnEliminarDB.Size = new System.Drawing.Size(108, 40);
            this.btnEliminarDB.TabIndex = 2;
            this.btnEliminarDB.Text = "EliminarDB";
            this.btnEliminarDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarDB.TextColor = System.Drawing.Color.Black;
            this.btnEliminarDB.UseVisualStyleBackColor = false;
            this.btnEliminarDB.Click += new System.EventHandler(this.btnEliminarDB_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.BackColor = System.Drawing.Color.LightGreen;
            this.btnRestaurar.BackgroundColor = System.Drawing.Color.LightGreen;
            this.btnRestaurar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRestaurar.BorderRadius = 20;
            this.btnRestaurar.BorderSize = 0;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurar.ForeColor = System.Drawing.Color.Black;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestaurar.Location = new System.Drawing.Point(162, 171);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(108, 40);
            this.btnRestaurar.TabIndex = 1;
            this.btnRestaurar.Text = "Restaurar";
            this.btnRestaurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestaurar.TextColor = System.Drawing.Color.Black;
            this.btnRestaurar.UseVisualStyleBackColor = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // frmPapelera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(570, 224);
            this.Controls.Add(this.btnEliminarDB);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.dgvPapelera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPapelera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPapelera";
            this.Load += new System.EventHandler(this.frmPapelera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPapelera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPapelera;
        private Botones btnRestaurar;
        private Botones btnEliminarDB;
    }
}