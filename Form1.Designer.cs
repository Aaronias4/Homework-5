namespace MilburyLab2
{
    partial class FrmLab2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLab2));
            this.grpMultiplier = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblMult = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.txtMultiplier = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.grpInformation = new System.Windows.Forms.GroupBox();
            this.btnData = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPic = new System.Windows.Forms.Button();
            this.lblHobby = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pbMountain = new System.Windows.Forms.PictureBox();
            this.grpMultiplier.SuspendLayout();
            this.grpInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMountain)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMultiplier
            // 
            this.grpMultiplier.Controls.Add(this.btnReset);
            this.grpMultiplier.Controls.Add(this.btnCalculate);
            this.grpMultiplier.Controls.Add(this.lblResult);
            this.grpMultiplier.Controls.Add(this.lblAnswer);
            this.grpMultiplier.Controls.Add(this.lblMult);
            this.grpMultiplier.Controls.Add(this.lblNum);
            this.grpMultiplier.Controls.Add(this.txtMultiplier);
            this.grpMultiplier.Controls.Add(this.txtNumber);
            this.grpMultiplier.Location = new System.Drawing.Point(12, 11);
            this.grpMultiplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMultiplier.Name = "grpMultiplier";
            this.grpMultiplier.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMultiplier.Size = new System.Drawing.Size(247, 296);
            this.grpMultiplier.TabIndex = 2;
            this.grpMultiplier.TabStop = false;
            this.grpMultiplier.Text = "Multiplier";
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(142, 234);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(83, 48);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(25, 234);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(84, 48);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(91, 178);
            this.lblResult.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(124, 24);
            this.lblResult.TabIndex = 2;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(9, 182);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(67, 19);
            this.lblAnswer.TabIndex = 0;
            this.lblAnswer.Text = "Answer.";
            // 
            // lblMult
            // 
            this.lblMult.AutoSize = true;
            this.lblMult.Location = new System.Drawing.Point(9, 117);
            this.lblMult.Name = "lblMult";
            this.lblMult.Size = new System.Drawing.Size(77, 19);
            this.lblMult.TabIndex = 1;
            this.lblMult.Text = "Multiplier.";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(9, 54);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(70, 19);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Number.";
            // 
            // txtMultiplier
            // 
            this.txtMultiplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMultiplier.Location = new System.Drawing.Point(91, 115);
            this.txtMultiplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMultiplier.Name = "txtMultiplier";
            this.txtMultiplier.Size = new System.Drawing.Size(124, 26);
            this.txtMultiplier.TabIndex = 1;
            // 
            // txtNumber
            // 
            this.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumber.Location = new System.Drawing.Point(91, 54);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(124, 26);
            this.txtNumber.TabIndex = 0;
            // 
            // grpInformation
            // 
            this.grpInformation.Controls.Add(this.btnData);
            this.grpInformation.Controls.Add(this.btnHide);
            this.grpInformation.Controls.Add(this.btnExit);
            this.grpInformation.Controls.Add(this.btnPic);
            this.grpInformation.Controls.Add(this.lblHobby);
            this.grpInformation.Controls.Add(this.lblDescription);
            this.grpInformation.Controls.Add(this.pbMountain);
            this.grpInformation.Location = new System.Drawing.Point(281, 11);
            this.grpInformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpInformation.Name = "grpInformation";
            this.grpInformation.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpInformation.Size = new System.Drawing.Size(422, 296);
            this.grpInformation.TabIndex = 3;
            this.grpInformation.TabStop = false;
            this.grpInformation.Text = "Information";
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(119, 234);
            this.btnData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(80, 48);
            this.btnData.TabIndex = 1;
            this.btnData.Text = "&Data";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(214, 234);
            this.btnHide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(80, 48);
            this.btnHide.TabIndex = 2;
            this.btnHide.Text = "&Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(311, 234);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 48);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPic
            // 
            this.btnPic.Location = new System.Drawing.Point(24, 234);
            this.btnPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(80, 48);
            this.btnPic.TabIndex = 0;
            this.btnPic.Text = "&Picture";
            this.btnPic.UseVisualStyleBackColor = true;
            this.btnPic.Click += new System.EventHandler(this.btnPic_Click);
            // 
            // lblHobby
            // 
            this.lblHobby.AutoSize = true;
            this.lblHobby.Location = new System.Drawing.Point(129, 13);
            this.lblHobby.Name = "lblHobby";
            this.lblHobby.Size = new System.Drawing.Size(165, 19);
            this.lblHobby.TabIndex = 5;
            this.lblHobby.Text = "My topic is my hobby";
            // 
            // lblDescription
            // 
            this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescription.Location = new System.Drawing.Point(24, 34);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(367, 196);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = resources.GetString("lblDescription.Text");
            this.lblDescription.Visible = false;
            // 
            // pbMountain
            // 
            this.pbMountain.Image = ((System.Drawing.Image)(resources.GetObject("pbMountain.Image")));
            this.pbMountain.Location = new System.Drawing.Point(24, 34);
            this.pbMountain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMountain.Name = "pbMountain";
            this.pbMountain.Size = new System.Drawing.Size(367, 196);
            this.pbMountain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMountain.TabIndex = 0;
            this.pbMountain.TabStop = false;
            this.pbMountain.Visible = false;
            // 
            // FrmLab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 331);
            this.Controls.Add(this.grpMultiplier);
            this.Controls.Add(this.grpInformation);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmLab2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 2 by Aaron Milbury";
            this.grpMultiplier.ResumeLayout(false);
            this.grpMultiplier.PerformLayout();
            this.grpInformation.ResumeLayout(false);
            this.grpInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMountain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMultiplier;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblMult;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txtMultiplier;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.GroupBox grpInformation;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPic;
        private System.Windows.Forms.Label lblHobby;
        private System.Windows.Forms.PictureBox pbMountain;
        private System.Windows.Forms.Label lblDescription;
    }
}

