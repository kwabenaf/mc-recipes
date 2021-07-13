
namespace MCrecipes
{
    partial class Form1
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnFav = new System.Windows.Forms.Button();
            this.btnRecent = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.pnlDrag = new System.Windows.Forms.Panel();
            this.lblIng = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.lblItemIng = new System.Windows.Forms.Label();
            this.picItem = new System.Windows.Forms.PictureBox();
            this.lblItemname = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlDrag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(67)))), ((int)(((byte)(50)))));
            this.pnlSidebar.Controls.Add(this.pnlNav);
            this.pnlSidebar.Controls.Add(this.btnSettings);
            this.pnlSidebar.Controls.Add(this.btnFav);
            this.pnlSidebar.Controls.Add(this.btnRecent);
            this.pnlSidebar.Controls.Add(this.btnAll);
            this.pnlSidebar.Controls.Add(this.btnHome);
            this.pnlSidebar.Controls.Add(this.pnlLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(160, 429);
            this.pnlSidebar.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(213)))), ((int)(((byte)(178)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 130);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 2;
            // 
            // btnSettings
            // 
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(213)))), ((int)(((byte)(178)))));
            this.btnSettings.Location = new System.Drawing.Point(0, 386);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(160, 43);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.Leave += new System.EventHandler(this.btnSettings_Leave);
            // 
            // btnFav
            // 
            this.btnFav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFav.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFav.FlatAppearance.BorderSize = 0;
            this.btnFav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFav.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(213)))), ((int)(((byte)(178)))));
            this.btnFav.Location = new System.Drawing.Point(0, 154);
            this.btnFav.Name = "btnFav";
            this.btnFav.Size = new System.Drawing.Size(160, 43);
            this.btnFav.TabIndex = 1;
            this.btnFav.Text = "Favourites";
            this.btnFav.UseVisualStyleBackColor = true;
            this.btnFav.Click += new System.EventHandler(this.btnFav_Click);
            this.btnFav.Leave += new System.EventHandler(this.btnFav_Leave);
            // 
            // btnRecent
            // 
            this.btnRecent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecent.FlatAppearance.BorderSize = 0;
            this.btnRecent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecent.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(213)))), ((int)(((byte)(178)))));
            this.btnRecent.Location = new System.Drawing.Point(0, 111);
            this.btnRecent.Name = "btnRecent";
            this.btnRecent.Size = new System.Drawing.Size(160, 43);
            this.btnRecent.TabIndex = 1;
            this.btnRecent.Text = "Recents";
            this.btnRecent.UseVisualStyleBackColor = true;
            this.btnRecent.Click += new System.EventHandler(this.btnRecent_Click);
            this.btnRecent.Leave += new System.EventHandler(this.btnRecent_Leave);
            // 
            // btnAll
            // 
            this.btnAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAll.FlatAppearance.BorderSize = 0;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(213)))), ((int)(((byte)(178)))));
            this.btnAll.Location = new System.Drawing.Point(0, 68);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(160, 43);
            this.btnAll.TabIndex = 1;
            this.btnAll.Text = "All Items";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            this.btnAll.Leave += new System.EventHandler(this.btnAll_Leave);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(213)))), ((int)(((byte)(178)))));
            this.btnHome.Location = new System.Drawing.Point(0, 25);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(160, 43);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Search";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.Leave += new System.EventHandler(this.btnHome_Leave);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(160, 25);
            this.pnlLogo.TabIndex = 0;
            // 
            // pnlForm
            // 
            this.pnlForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlForm.Controls.Add(this.lblIng);
            this.pnlForm.Controls.Add(this.lblLogo);
            this.pnlForm.Controls.Add(this.lblName);
            this.pnlForm.Controls.Add(this.txtSearch);
            this.pnlForm.Controls.Add(this.lblError);
            this.pnlForm.Controls.Add(this.btnSearch);
            this.pnlForm.Controls.Add(this.lblItemIng);
            this.pnlForm.Controls.Add(this.picItem);
            this.pnlForm.Controls.Add(this.lblItemname);
            this.pnlForm.Controls.Add(this.pnlDrag);
            this.pnlForm.Location = new System.Drawing.Point(161, 0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(560, 429);
            this.pnlForm.TabIndex = 0;
            // 
            // pnlDrag
            // 
            this.pnlDrag.Controls.Add(this.btnClose);
            this.pnlDrag.Controls.Add(this.btnMin);
            this.pnlDrag.Location = new System.Drawing.Point(1, -1);
            this.pnlDrag.Name = "pnlDrag";
            this.pnlDrag.Size = new System.Drawing.Size(676, 22);
            this.pnlDrag.TabIndex = 11;
            this.pnlDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDrag_MouseDown);
            // 
            // lblIng
            // 
            this.lblIng.AutoSize = true;
            this.lblIng.Location = new System.Drawing.Point(148, 300);
            this.lblIng.Name = "lblIng";
            this.lblIng.Size = new System.Drawing.Size(59, 13);
            this.lblIng.TabIndex = 10;
            this.lblIng.Text = "Ingredients";
            this.lblIng.Visible = false;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(21)))));
            this.lblLogo.Location = new System.Drawing.Point(71, 18);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(232, 42);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "MC Recipes";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(148, 261);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name";
            this.lblName.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteCustomSource.AddRange(new string[] {
            "Chest",
            "Crafting Table",
            "Furnace",
            "Stick",
            "Torches",
            "Wood Planks",
            "Axes",
            "Bucket",
            "Carrot on a Stick",
            "Clock",
            "Compass",
            "Fishing Rod",
            "Flint and Steel",
            "Hoe",
            "Map",
            "Pickaxe",
            "Shears",
            "Shovel",
            "Arrows",
            "Bow",
            "Damaged Shield",
            "Patterned Shield",
            "Shield",
            "Spectral Arrow",
            "Sword",
            "Tipped Arrows",
            "Boots",
            "Chestplate",
            "Helmet",
            "Leggings",
            "Andesite",
            "Anvil",
            "Beacon",
            "Block of Coal",
            "Block of Quartz",
            "Block of Redstone",
            "Bone Block",
            "Bookshelf",
            "Brick Block",
            "Chiseled Sandstone",
            "Chiseled Stone Brick",
            "Clay Block",
            "Coarse Dirt",
            "Dark Prismarine",
            "Diorite",
            "End Stone Bricks",
            "Glowstone",
            "Granite",
            "Hay Bale"});
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(183)))), ((int)(((byte)(136)))));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.Location = new System.Drawing.Point(78, 81);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(225, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "Search...";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError.Location = new System.Drawing.Point(78, 108);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(113, 20);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "Error Message";
            this.lblError.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(522, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 25);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(321, 79);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseMnemonic = false;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Black;
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(485, 1);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(37, 25);
            this.btnMin.TabIndex = 3;
            this.btnMin.Text = "--";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // lblItemIng
            // 
            this.lblItemIng.AutoSize = true;
            this.lblItemIng.Location = new System.Drawing.Point(79, 300);
            this.lblItemIng.Name = "lblItemIng";
            this.lblItemIng.Size = new System.Drawing.Size(62, 13);
            this.lblItemIng.TabIndex = 5;
            this.lblItemIng.Text = "Ingredients:";
            this.lblItemIng.Visible = false;
            // 
            // picItem
            // 
            this.picItem.Image = global::MCrecipes.Properties.Resources.Empty_crafting_table;
            this.picItem.Location = new System.Drawing.Point(78, 140);
            this.picItem.Name = "picItem";
            this.picItem.Size = new System.Drawing.Size(201, 100);
            this.picItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItem.TabIndex = 4;
            this.picItem.TabStop = false;
            // 
            // lblItemname
            // 
            this.lblItemname.AutoSize = true;
            this.lblItemname.Location = new System.Drawing.Point(79, 261);
            this.lblItemname.Name = "lblItemname";
            this.lblItemname.Size = new System.Drawing.Size(38, 13);
            this.lblItemname.TabIndex = 5;
            this.lblItemname.Text = "Name:";
            this.lblItemname.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(106)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(722, 429);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.pnlDrag.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnFav;
        private System.Windows.Forms.Button btnRecent;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.PictureBox picItem;
        private System.Windows.Forms.Label lblItemname;
        private System.Windows.Forms.Label lblItemIng;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblIng;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlDrag;
        private System.Windows.Forms.Panel pnlForm;
    }
}

