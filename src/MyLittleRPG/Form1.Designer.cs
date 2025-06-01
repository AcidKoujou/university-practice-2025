
namespace MyLittleRPG
{
    partial class MyLittleRPG
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
            this.btnTrade = new System.Windows.Forms.Button();

            this.lblStaticInfo1 = new System.Windows.Forms.Label();
            this.lblStaticInfo2 = new System.Windows.Forms.Label();
            this.lblStaticInfo3 = new System.Windows.Forms.Label();
            this.lblStaticInfo4 = new System.Windows.Forms.Label();
            this.lblHitPoints = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblExperience = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblControl = new System.Windows.Forms.Label();
            this.cboWeapons = new System.Windows.Forms.ComboBox();
            this.cboPotions = new System.Windows.Forms.ComboBox();
            this.btnUseWeapon = new System.Windows.Forms.Button();
            this.btnUsePotion = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.rtbLocation = new System.Windows.Forms.RichTextBox();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.dgvQuests = new System.Windows.Forms.DataGridView();
            this.pctPlayer = new System.Windows.Forms.PictureBox();
            this.pctWeapon = new System.Windows.Forms.PictureBox();
            this.pctHealing = new System.Windows.Forms.PictureBox();
            this.pctCreature = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctWeapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctHealing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCreature)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStaticInfo1
            // 
            this.lblStaticInfo1.AutoSize = true;
            this.lblStaticInfo1.Location = new System.Drawing.Point(18, 20);
            this.lblStaticInfo1.Name = "lblStaticInfo1";
            this.lblStaticInfo1.Size = new System.Drawing.Size(72, 17);
            this.lblStaticInfo1.TabIndex = 0;
            this.lblStaticInfo1.Text = "Hit Points:";
            // 
            // lblStaticInfo2
            // 
            this.lblStaticInfo2.AutoSize = true;
            this.lblStaticInfo2.Location = new System.Drawing.Point(18, 46);
            this.lblStaticInfo2.Name = "lblStaticInfo2";
            this.lblStaticInfo2.Size = new System.Drawing.Size(42, 17);
            this.lblStaticInfo2.TabIndex = 1;
            this.lblStaticInfo2.Text = "Gold:";
            // 
            // lblStaticInfo3
            // 
            this.lblStaticInfo3.AutoSize = true;
            this.lblStaticInfo3.Location = new System.Drawing.Point(18, 74);
            this.lblStaticInfo3.Name = "lblStaticInfo3";
            this.lblStaticInfo3.Size = new System.Drawing.Size(82, 17);
            this.lblStaticInfo3.TabIndex = 2;
            this.lblStaticInfo3.Text = "Experience:";
            // 
            // lblStaticInfo4
            // 
            this.lblStaticInfo4.AutoSize = true;
            this.lblStaticInfo4.Location = new System.Drawing.Point(18, 100);
            this.lblStaticInfo4.Name = "lblStaticInfo4";
            this.lblStaticInfo4.Size = new System.Drawing.Size(46, 17);
            this.lblStaticInfo4.TabIndex = 3;
            this.lblStaticInfo4.Text = "Level:";
            // 
            // lblHitPoints
            // 
            this.lblHitPoints.AutoSize = true;
            this.lblHitPoints.Location = new System.Drawing.Point(110, 19);
            this.lblHitPoints.Name = "lblHitPoints";
            this.lblHitPoints.Size = new System.Drawing.Size(0, 17);
            this.lblHitPoints.TabIndex = 4;
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(110, 45);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(0, 17);
            this.lblGold.TabIndex = 5;
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.Location = new System.Drawing.Point(110, 73);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(0, 17);
            this.lblExperience.TabIndex = 6;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(110, 99);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(0, 17);
            this.lblLevel.TabIndex = 7;
            // 
            // lblControl
            // 
            this.lblControl.AutoSize = true;
            this.lblControl.Location = new System.Drawing.Point(617, 531);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(89, 17);
            this.lblControl.TabIndex = 8;
            this.lblControl.Text = "Select action";
            // 
            // cboWeapons
            // 
            this.cboWeapons.FormattingEnabled = true;
            this.cboWeapons.Location = new System.Drawing.Point(369, 559);
            this.cboWeapons.Name = "cboWeapons";
            this.cboWeapons.Size = new System.Drawing.Size(121, 24);
            this.cboWeapons.TabIndex = 9;
            // 
            // cboPotions
            // 
            this.cboPotions.FormattingEnabled = true;
            this.cboPotions.Location = new System.Drawing.Point(369, 593);
            this.cboPotions.Name = "cboPotions";
            this.cboPotions.Size = new System.Drawing.Size(121, 24);
            this.cboPotions.TabIndex = 10;
            // 
            // btnUseWeapon
            // 
            this.btnUseWeapon.Location = new System.Drawing.Point(620, 559);
            this.btnUseWeapon.Name = "btnUseWeapon";
            this.btnUseWeapon.Size = new System.Drawing.Size(75, 23);
            this.btnUseWeapon.TabIndex = 11;
            this.btnUseWeapon.Text = "Use";
            this.btnUseWeapon.UseVisualStyleBackColor = true;
            this.btnUseWeapon.Click += new System.EventHandler(this.btnUseWeapon_Click);
            // 
            // btnUsePotion
            // 
            this.btnUsePotion.Location = new System.Drawing.Point(620, 593);
            this.btnUsePotion.Name = "btnUsePotion";
            this.btnUsePotion.Size = new System.Drawing.Size(75, 23);
            this.btnUsePotion.TabIndex = 12;
            this.btnUsePotion.Text = "Use";
            this.btnUsePotion.UseVisualStyleBackColor = true;
            this.btnUsePotion.Click += new System.EventHandler(this.btnUsePotion_Click);
            // 
            // btnEast
            // 
            this.btnEast.Location = new System.Drawing.Point(573, 457);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(75, 23);
            this.btnEast.TabIndex = 13;
            this.btnEast.Text = "East";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.btnEast_Click);
            // 
            // btnNorth
            // 
            this.btnNorth.Location = new System.Drawing.Point(493, 433);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(75, 23);
            this.btnNorth.TabIndex = 14;
            this.btnNorth.Text = "North";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
            // 
            // btnWest
            // 
            this.btnWest.Location = new System.Drawing.Point(412, 457);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(75, 23);
            this.btnWest.TabIndex = 15;
            this.btnWest.Text = "West";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.btnWest_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.Location = new System.Drawing.Point(493, 487);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(75, 23);
            this.btnSouth.TabIndex = 16;
            this.btnSouth.Text = "South";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click);
            // 
            // rtbLocation
            // 
            this.rtbLocation.Location = new System.Drawing.Point(347, 19);
            this.rtbLocation.Name = "rtbLocation";
            this.rtbLocation.ReadOnly = true;
            this.rtbLocation.Size = new System.Drawing.Size(360, 105);
            this.rtbLocation.TabIndex = 17;
            this.rtbLocation.Text = "";
            // 
            // rtbMessages
            // 
            this.rtbMessages.Location = new System.Drawing.Point(347, 130);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.Size = new System.Drawing.Size(360, 286);
            this.rtbMessages.TabIndex = 18;
            this.rtbMessages.Text = "";
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AllowUserToResizeRows = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInventory.Enabled = false;
            this.dgvInventory.Location = new System.Drawing.Point(16, 130);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.RowHeadersWidth = 51;
            this.dgvInventory.RowTemplate.Height = 24;
            this.dgvInventory.Size = new System.Drawing.Size(312, 309);
            this.dgvInventory.TabIndex = 19;
            // 
            // dgvQuests
            // 
            this.dgvQuests.AllowUserToAddRows = false;
            this.dgvQuests.AllowUserToDeleteRows = false;
            this.dgvQuests.AllowUserToResizeColumns = false;
            this.dgvQuests.AllowUserToResizeRows = false;
            this.dgvQuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvQuests.Enabled = false;
            this.dgvQuests.Location = new System.Drawing.Point(16, 446);
            this.dgvQuests.MultiSelect = false;
            this.dgvQuests.Name = "dgvQuests";
            this.dgvQuests.ReadOnly = true;
            this.dgvQuests.RowHeadersVisible = false;
            this.dgvQuests.RowHeadersWidth = 51;
            this.dgvQuests.RowTemplate.Height = 24;
            this.dgvQuests.Size = new System.Drawing.Size(312, 189);
            this.dgvQuests.TabIndex = 20;
            // 
            // pctPlayer
            // 
            this.pctPlayer.Location = new System.Drawing.Point(199, 5);
            this.pctPlayer.Name = "pctPlayer";
            this.pctPlayer.Size = new System.Drawing.Size(129, 119);
            this.pctPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctPlayer.TabIndex = 21;
            this.pctPlayer.TabStop = false;
            // 
            // pctWeapon
            // 
            this.pctWeapon.Location = new System.Drawing.Point(764, 487);
            this.pctWeapon.Name = "pctWeapon";
            this.pctWeapon.Size = new System.Drawing.Size(146, 137);
            this.pctWeapon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctWeapon.TabIndex = 22;
            this.pctWeapon.TabStop = false;
            // 
            // pctHealing
            // 
            this.pctHealing.Location = new System.Drawing.Point(955, 487);
            this.pctHealing.Name = "pctHealing";
            this.pctHealing.Size = new System.Drawing.Size(146, 137);
            this.pctHealing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctHealing.TabIndex = 23;
            this.pctHealing.TabStop = false;
            // 
            // pctCreature
            // 
            this.pctCreature.Location = new System.Drawing.Point(728, 20);
            this.pctCreature.Name = "pctCreature";
            this.pctCreature.Size = new System.Drawing.Size(373, 396);
            this.pctCreature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctCreature.TabIndex = 24;
            this.pctCreature.TabStop = false;
            //
            // btnTrade
            //
            this.btnTrade.Location = new System.Drawing.Point(493, 620);
            this.btnTrade.Name = "btnTrade";
            this.btnTrade.Size = new System.Drawing.Size(75, 23);
            this.btnTrade.TabIndex = 21;
            this.btnTrade.Text = "Trade";
            this.btnTrade.UseVisualStyleBackColor = true;
            this.btnTrade.Click += new System.EventHandler(this.btnTrade_Click);
            // 
            // MyLittleRPG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 645);
            this.Controls.Add(this.pctCreature);
            this.Controls.Add(this.pctHealing);
            this.Controls.Add(this.pctWeapon);
            this.Controls.Add(this.pctPlayer);
            this.Controls.Add(this.dgvQuests);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.rtbLocation);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnUsePotion);
            this.Controls.Add(this.btnUseWeapon);
            this.Controls.Add(this.cboPotions);
            this.Controls.Add(this.cboWeapons);
            this.Controls.Add(this.lblControl);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblExperience);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblHitPoints);
            this.Controls.Add(this.lblStaticInfo4);
            this.Controls.Add(this.lblStaticInfo3);
            this.Controls.Add(this.lblStaticInfo2);
            this.Controls.Add(this.lblStaticInfo1);
            this.Controls.Add(this.btnTrade);
            this.Name = "MyLittleRPG";
            this.Text = "MyLittleRPG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MyLittleRPG_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctWeapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctHealing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCreature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStaticInfo1;
        private System.Windows.Forms.Label lblStaticInfo2;
        private System.Windows.Forms.Label lblStaticInfo3;
        private System.Windows.Forms.Label lblStaticInfo4;
        private System.Windows.Forms.Label lblHitPoints;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblControl;
        private System.Windows.Forms.ComboBox cboWeapons;
        private System.Windows.Forms.ComboBox cboPotions;
        private System.Windows.Forms.Button btnUseWeapon;
        private System.Windows.Forms.Button btnUsePotion;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.RichTextBox rtbLocation;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.DataGridView dgvQuests;
        private System.Windows.Forms.PictureBox pctPlayer;
        private System.Windows.Forms.PictureBox pctWeapon;
        private System.Windows.Forms.PictureBox pctHealing;
        private System.Windows.Forms.PictureBox pctCreature;
        private System.Windows.Forms.Button btnTrade;
    }
}

