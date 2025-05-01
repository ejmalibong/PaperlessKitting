
namespace PaperlessKitting
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnDor = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblLine = new System.Windows.Forms.Label();
            this.btnDorLev = new System.Windows.Forms.Button();
            this.btnDummySeal = new System.Windows.Forms.Button();
            this.btnJointedWire = new System.Windows.Forms.Button();
            this.btnLooseParts = new System.Windows.Forms.Button();
            this.btnWireTaping = new System.Windows.Forms.Button();
            this.btnWireTapingPrep = new System.Windows.Forms.Button();
            this.btnCotSlit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDor
            // 
            this.btnDor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDor.Location = new System.Drawing.Point(13, 124);
            this.btnDor.Name = "btnDor";
            this.btnDor.Size = new System.Drawing.Size(350, 84);
            this.btnDor.TabIndex = 0;
            this.btnDor.Text = "1\r\nDaily Operation Report";
            this.btnDor.UseVisualStyleBackColor = true;
            this.btnDor.Click += new System.EventHandler(this.btnDor_Click);
            // 
            // lblDate
            // 
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(12, 6);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(98, 45);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.CustomFormat = "MMMM/dd/yyyy";
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(109, 6);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(340, 45);
            this.dtpDate.TabIndex = 3;
            this.dtpDate.Value = new System.DateTime(2025, 2, 12, 23, 55, 33, 0);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(13, 482);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(705, 60);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close Application";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblLine
            // 
            this.lblLine.BackColor = System.Drawing.SystemColors.Info;
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine.ForeColor = System.Drawing.Color.Black;
            this.lblLine.Location = new System.Drawing.Point(13, 58);
            this.lblLine.Margin = new System.Windows.Forms.Padding(3);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(704, 60);
            this.lblLine.TabIndex = 5;
            this.lblLine.Text = "Username";
            this.lblLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDorLev
            // 
            this.btnDorLev.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDorLev.Location = new System.Drawing.Point(12, 214);
            this.btnDorLev.Name = "btnDorLev";
            this.btnDorLev.Size = new System.Drawing.Size(350, 84);
            this.btnDorLev.TabIndex = 6;
            this.btnDorLev.Text = "2\r\nDOR Levercon";
            this.btnDorLev.UseVisualStyleBackColor = true;
            this.btnDorLev.Click += new System.EventHandler(this.btnSampling_Click);
            // 
            // btnDummySeal
            // 
            this.btnDummySeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDummySeal.Location = new System.Drawing.Point(13, 304);
            this.btnDummySeal.Name = "btnDummySeal";
            this.btnDummySeal.Size = new System.Drawing.Size(350, 84);
            this.btnDummySeal.TabIndex = 7;
            this.btnDummySeal.Text = "3\r\nDummy Seal / Clip Clamp";
            this.btnDummySeal.UseVisualStyleBackColor = true;
            this.btnDummySeal.Click += new System.EventHandler(this.btnDummySeal_Click);
            // 
            // btnJointedWire
            // 
            this.btnJointedWire.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJointedWire.Location = new System.Drawing.Point(13, 394);
            this.btnJointedWire.Name = "btnJointedWire";
            this.btnJointedWire.Size = new System.Drawing.Size(350, 84);
            this.btnJointedWire.TabIndex = 8;
            this.btnJointedWire.Text = "4\r\nJointed Wire";
            this.btnJointedWire.UseVisualStyleBackColor = true;
            this.btnJointedWire.Click += new System.EventHandler(this.btnJointedWire_Click);
            // 
            // btnLooseParts
            // 
            this.btnLooseParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLooseParts.Location = new System.Drawing.Point(368, 394);
            this.btnLooseParts.Name = "btnLooseParts";
            this.btnLooseParts.Size = new System.Drawing.Size(350, 84);
            this.btnLooseParts.TabIndex = 12;
            this.btnLooseParts.Text = "8\r\nLoose Parts";
            this.btnLooseParts.UseVisualStyleBackColor = true;
            this.btnLooseParts.Click += new System.EventHandler(this.btnLooseParts_Click);
            // 
            // btnWireTaping
            // 
            this.btnWireTaping.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWireTaping.Location = new System.Drawing.Point(370, 214);
            this.btnWireTaping.Name = "btnWireTaping";
            this.btnWireTaping.Size = new System.Drawing.Size(350, 84);
            this.btnWireTaping.TabIndex = 11;
            this.btnWireTaping.Text = "6\r\nWire Taping";
            this.btnWireTaping.UseVisualStyleBackColor = true;
            this.btnWireTaping.Click += new System.EventHandler(this.btnWireTaping_Click);
            // 
            // btnWireTapingPrep
            // 
            this.btnWireTapingPrep.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWireTapingPrep.Location = new System.Drawing.Point(369, 124);
            this.btnWireTapingPrep.Name = "btnWireTapingPrep";
            this.btnWireTapingPrep.Size = new System.Drawing.Size(350, 84);
            this.btnWireTapingPrep.TabIndex = 10;
            this.btnWireTapingPrep.Text = "5\r\nWire Taping - Parts Prep";
            this.btnWireTapingPrep.UseVisualStyleBackColor = true;
            this.btnWireTapingPrep.Click += new System.EventHandler(this.btnWireTapingPrep_Click);
            // 
            // btnCotSlit
            // 
            this.btnCotSlit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotSlit.Location = new System.Drawing.Point(369, 304);
            this.btnCotSlit.Name = "btnCotSlit";
            this.btnCotSlit.Size = new System.Drawing.Size(350, 84);
            this.btnCotSlit.TabIndex = 9;
            this.btnCotSlit.Text = "7\r\nCot With Slit";
            this.btnCotSlit.UseVisualStyleBackColor = true;
            this.btnCotSlit.Click += new System.EventHandler(this.btnCotSlit_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(457, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 45);
            this.label1.TabIndex = 13;
            this.label1.Text = "Shift";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(734, 548);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnLooseParts);
            this.Controls.Add(this.btnWireTaping);
            this.Controls.Add(this.btnWireTapingPrep);
            this.Controls.Add(this.btnCotSlit);
            this.Controls.Add(this.btnJointedWire);
            this.Controls.Add(this.btnDummySeal);
            this.Controls.Add(this.btnDorLev);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnDor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paperless Kitting";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDor;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Button btnDorLev;
        private System.Windows.Forms.Button btnDummySeal;
        private System.Windows.Forms.Button btnJointedWire;
        private System.Windows.Forms.Button btnLooseParts;
        private System.Windows.Forms.Button btnWireTaping;
        private System.Windows.Forms.Button btnWireTapingPrep;
        private System.Windows.Forms.Button btnCotSlit;
        private System.Windows.Forms.Label label1;
    }
}

