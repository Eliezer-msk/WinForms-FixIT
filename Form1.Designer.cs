namespace WindowsFormsAppFixIT
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.paramètresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catégorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMatos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPrix = new System.Windows.Forms.TextBox();
            this.dateTimePickerInter = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paramètresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(753, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // paramètresToolStripMenuItem
            // 
            this.paramètresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produitToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.catégorieToolStripMenuItem});
            this.paramètresToolStripMenuItem.Name = "paramètresToolStripMenuItem";
            this.paramètresToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.paramètresToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.paramètresToolStripMenuItem.Text = "Paramètres";
            // 
            // produitToolStripMenuItem
            // 
            this.produitToolStripMenuItem.Name = "produitToolStripMenuItem";
            this.produitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.produitToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.produitToolStripMenuItem.Text = "Produit ... ";
            this.produitToolStripMenuItem.Click += new System.EventHandler(this.produitToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.clientToolStripMenuItem.Text = "Client ...";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // catégorieToolStripMenuItem
            // 
            this.catégorieToolStripMenuItem.Name = "catégorieToolStripMenuItem";
            this.catégorieToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.catégorieToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.catégorieToolStripMenuItem.Text = "Catégorie ...";
            this.catégorieToolStripMenuItem.Click += new System.EventHandler(this.catégorieToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonValider);
            this.groupBox1.Controls.Add(this.textBoxComment);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxMatos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxPrix);
            this.groupBox1.Controls.Add(this.dateTimePickerInter);
            this.groupBox1.Location = new System.Drawing.Point(19, 129);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(712, 305);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Créer une intervention";
            // 
            // buttonValider
            // 
            this.buttonValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValider.Location = new System.Drawing.Point(496, 186);
            this.buttonValider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(194, 86);
            this.buttonValider.TabIndex = 6;
            this.buttonValider.Text = "Créer";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // textBoxComment
            // 
            this.textBoxComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxComment.Location = new System.Drawing.Point(29, 186);
            this.textBoxComment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(446, 87);
            this.textBoxComment.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Matériel";
            // 
            // comboBoxMatos
            // 
            this.comboBoxMatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMatos.FormattingEnabled = true;
            this.comboBoxMatos.Location = new System.Drawing.Point(154, 133);
            this.comboBoxMatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxMatos.Name = "comboBoxMatos";
            this.comboBoxMatos.Size = new System.Drawing.Size(198, 33);
            this.comboBoxMatos.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prix";
            // 
            // textBoxPrix
            // 
            this.textBoxPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrix.Location = new System.Drawing.Point(154, 84);
            this.textBoxPrix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPrix.Name = "textBoxPrix";
            this.textBoxPrix.Size = new System.Drawing.Size(198, 32);
            this.textBoxPrix.TabIndex = 1;
            // 
            // dateTimePickerInter
            // 
            this.dateTimePickerInter.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerInter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInter.Location = new System.Drawing.Point(29, 29);
            this.dateTimePickerInter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerInter.Name = "dateTimePickerInter";
            this.dateTimePickerInter.Size = new System.Drawing.Size(322, 37);
            this.dateTimePickerInter.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 455);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FixIT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paramètresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catégorieToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerInter;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPrix;
    }
}

