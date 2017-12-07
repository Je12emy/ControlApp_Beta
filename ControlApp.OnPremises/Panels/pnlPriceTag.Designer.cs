﻿namespace ControlApp.OnPremises.Panels
{
    partial class pnlPriceTag
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCreate = new MetroFramework.Controls.MetroTile();
            this.txtRetrieveByName = new MetroFramework.Controls.MetroTextBox();
            this.lblRetrieve = new MetroFramework.Controls.MetroLabel();
            this.dgvPriceTag = new MetroFramework.Controls.MetroGrid();
            this.ID_PRICE_TAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIP_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new MetroFramework.Controls.MetroTile();
            this.txtPriceTag = new MetroFramework.Controls.MetroTextBox();
            this.mtlblPriceTag = new MetroFramework.Controls.MetroLabel();
            this.txtDescripPrice = new MetroFramework.Controls.MetroTextBox();
            this.mtlblDescrip = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriceTag)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.ActiveControl = null;
            this.btnCreate.Location = new System.Drawing.Point(94, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(83, 60);
            this.btnCreate.TabIndex = 40;
            this.btnCreate.Text = "Agregar";
            this.btnCreate.UseSelectable = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtRetrieveByName
            // 
            // 
            // 
            // 
            this.txtRetrieveByName.CustomButton.Image = null;
            this.txtRetrieveByName.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txtRetrieveByName.CustomButton.Name = "";
            this.txtRetrieveByName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRetrieveByName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRetrieveByName.CustomButton.TabIndex = 1;
            this.txtRetrieveByName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRetrieveByName.CustomButton.UseSelectable = true;
            this.txtRetrieveByName.CustomButton.Visible = false;
            this.txtRetrieveByName.Lines = new string[0];
            this.txtRetrieveByName.Location = new System.Drawing.Point(517, 69);
            this.txtRetrieveByName.MaxLength = 32767;
            this.txtRetrieveByName.Name = "txtRetrieveByName";
            this.txtRetrieveByName.PasswordChar = '\0';
            this.txtRetrieveByName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRetrieveByName.SelectedText = "";
            this.txtRetrieveByName.SelectionLength = 0;
            this.txtRetrieveByName.SelectionStart = 0;
            this.txtRetrieveByName.ShortcutsEnabled = true;
            this.txtRetrieveByName.Size = new System.Drawing.Size(135, 23);
            this.txtRetrieveByName.TabIndex = 33;
            this.txtRetrieveByName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtRetrieveByName.UseSelectable = true;
            this.txtRetrieveByName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRetrieveByName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtRetrieveByName.TextChanged += new System.EventHandler(this.txtRetrieveByName_TextChanged);
            // 
            // lblRetrieve
            // 
            this.lblRetrieve.AutoSize = true;
            this.lblRetrieve.Location = new System.Drawing.Point(464, 73);
            this.lblRetrieve.Name = "lblRetrieve";
            this.lblRetrieve.Size = new System.Drawing.Size(47, 19);
            this.lblRetrieve.TabIndex = 37;
            this.lblRetrieve.Text = "Buscar";
            this.lblRetrieve.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dgvPriceTag
            // 
            this.dgvPriceTag.AllowUserToAddRows = false;
            this.dgvPriceTag.AllowUserToDeleteRows = false;
            this.dgvPriceTag.AllowUserToResizeRows = false;
            this.dgvPriceTag.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvPriceTag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPriceTag.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPriceTag.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPriceTag.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPriceTag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPriceTag.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PRICE_TAG,
            this.DESCRIP_PRICE,
            this.TOTAL_PRICE});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPriceTag.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPriceTag.EnableHeadersVisualStyles = false;
            this.dgvPriceTag.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPriceTag.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvPriceTag.Location = new System.Drawing.Point(12, 127);
            this.dgvPriceTag.Name = "dgvPriceTag";
            this.dgvPriceTag.ReadOnly = true;
            this.dgvPriceTag.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPriceTag.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPriceTag.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPriceTag.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPriceTag.Size = new System.Drawing.Size(658, 332);
            this.dgvPriceTag.TabIndex = 36;
            this.dgvPriceTag.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvPriceTag.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPriceTag_CellClick);
            // 
            // ID_PRICE_TAG
            // 
            this.ID_PRICE_TAG.FillWeight = 70F;
            this.ID_PRICE_TAG.HeaderText = "ID";
            this.ID_PRICE_TAG.Name = "ID_PRICE_TAG";
            this.ID_PRICE_TAG.ReadOnly = true;
            this.ID_PRICE_TAG.Visible = false;
            this.ID_PRICE_TAG.Width = 50;
            // 
            // DESCRIP_PRICE
            // 
            this.DESCRIP_PRICE.HeaderText = "Descripción";
            this.DESCRIP_PRICE.Name = "DESCRIP_PRICE";
            this.DESCRIP_PRICE.ReadOnly = true;
            // 
            // TOTAL_PRICE
            // 
            this.TOTAL_PRICE.HeaderText = "Precio";
            this.TOTAL_PRICE.Name = "TOTAL_PRICE";
            this.TOTAL_PRICE.ReadOnly = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.ActiveControl = null;
            this.btnUpdate.Location = new System.Drawing.Point(183, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 60);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtPriceTag
            // 
            // 
            // 
            // 
            this.txtPriceTag.CustomButton.Image = null;
            this.txtPriceTag.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.txtPriceTag.CustomButton.Name = "";
            this.txtPriceTag.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPriceTag.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPriceTag.CustomButton.TabIndex = 1;
            this.txtPriceTag.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPriceTag.CustomButton.UseSelectable = true;
            this.txtPriceTag.CustomButton.Visible = false;
            this.txtPriceTag.Lines = new string[0];
            this.txtPriceTag.Location = new System.Drawing.Point(94, 98);
            this.txtPriceTag.MaxLength = 32767;
            this.txtPriceTag.Name = "txtPriceTag";
            this.txtPriceTag.PasswordChar = '\0';
            this.txtPriceTag.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPriceTag.SelectedText = "";
            this.txtPriceTag.SelectionLength = 0;
            this.txtPriceTag.SelectionStart = 0;
            this.txtPriceTag.ShortcutsEnabled = true;
            this.txtPriceTag.Size = new System.Drawing.Size(83, 23);
            this.txtPriceTag.TabIndex = 32;
            this.txtPriceTag.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPriceTag.UseSelectable = true;
            this.txtPriceTag.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPriceTag.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPriceTag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriceTag_KeyPress);
            // 
            // mtlblPriceTag
            // 
            this.mtlblPriceTag.AutoSize = true;
            this.mtlblPriceTag.Location = new System.Drawing.Point(42, 102);
            this.mtlblPriceTag.Name = "mtlblPriceTag";
            this.mtlblPriceTag.Size = new System.Drawing.Size(46, 19);
            this.mtlblPriceTag.TabIndex = 35;
            this.mtlblPriceTag.Text = "Precio";
            this.mtlblPriceTag.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtDescripPrice
            // 
            // 
            // 
            // 
            this.txtDescripPrice.CustomButton.Image = null;
            this.txtDescripPrice.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.txtDescripPrice.CustomButton.Name = "";
            this.txtDescripPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDescripPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescripPrice.CustomButton.TabIndex = 1;
            this.txtDescripPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescripPrice.CustomButton.UseSelectable = true;
            this.txtDescripPrice.CustomButton.Visible = false;
            this.txtDescripPrice.Lines = new string[0];
            this.txtDescripPrice.Location = new System.Drawing.Point(94, 69);
            this.txtDescripPrice.MaxLength = 32767;
            this.txtDescripPrice.Name = "txtDescripPrice";
            this.txtDescripPrice.PasswordChar = '\0';
            this.txtDescripPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescripPrice.SelectedText = "";
            this.txtDescripPrice.SelectionLength = 0;
            this.txtDescripPrice.SelectionStart = 0;
            this.txtDescripPrice.ShortcutsEnabled = true;
            this.txtDescripPrice.Size = new System.Drawing.Size(172, 23);
            this.txtDescripPrice.TabIndex = 41;
            this.txtDescripPrice.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtDescripPrice.UseSelectable = true;
            this.txtDescripPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescripPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtlblDescrip
            // 
            this.mtlblDescrip.AutoSize = true;
            this.mtlblDescrip.Location = new System.Drawing.Point(12, 73);
            this.mtlblDescrip.Name = "mtlblDescrip";
            this.mtlblDescrip.Size = new System.Drawing.Size(76, 19);
            this.mtlblDescrip.TabIndex = 42;
            this.mtlblDescrip.Text = "Descripción";
            this.mtlblDescrip.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pnlPriceTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtlblDescrip);
            this.Controls.Add(this.txtDescripPrice);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtRetrieveByName);
            this.Controls.Add(this.lblRetrieve);
            this.Controls.Add(this.dgvPriceTag);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtPriceTag);
            this.Controls.Add(this.mtlblPriceTag);
            this.Name = "pnlPriceTag";
            this.Size = new System.Drawing.Size(697, 574);
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.pnlPriceTag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriceTag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnCreate;
        private MetroFramework.Controls.MetroTextBox txtRetrieveByName;
        private MetroFramework.Controls.MetroLabel lblRetrieve;
        private MetroFramework.Controls.MetroGrid dgvPriceTag;
        private MetroFramework.Controls.MetroTile btnUpdate;
        private MetroFramework.Controls.MetroTextBox txtPriceTag;
        private MetroFramework.Controls.MetroLabel mtlblPriceTag;
        private MetroFramework.Controls.MetroTextBox txtDescripPrice;
        private MetroFramework.Controls.MetroLabel mtlblDescrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRICE_TAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIP_PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_PRICE;
    }
}
