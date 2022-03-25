namespace Estoque
{
	partial class FrmMain
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			this.TabMain = new MaterialSkin.Controls.MaterialTabControl();
			this.PageHome = new System.Windows.Forms.TabPage();
			this.PageProdutos = new System.Windows.Forms.TabPage();
			this.ImageList = new System.Windows.Forms.ImageList(this.components);
			this.TabMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// TabMain
			// 
			this.TabMain.Controls.Add(this.PageHome);
			this.TabMain.Controls.Add(this.PageProdutos);
			this.TabMain.Depth = 0;
			this.TabMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TabMain.ImageList = this.ImageList;
			this.TabMain.Location = new System.Drawing.Point(3, 64);
			this.TabMain.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabMain.Multiline = true;
			this.TabMain.Name = "TabMain";
			this.TabMain.SelectedIndex = 0;
			this.TabMain.Size = new System.Drawing.Size(990, 601);
			this.TabMain.TabIndex = 0;
			// 
			// PageHome
			// 
			this.PageHome.ImageKey = "home.png";
			this.PageHome.Location = new System.Drawing.Point(4, 39);
			this.PageHome.Name = "PageHome";
			this.PageHome.Padding = new System.Windows.Forms.Padding(3);
			this.PageHome.Size = new System.Drawing.Size(982, 558);
			this.PageHome.TabIndex = 0;
			this.PageHome.Text = "Home";
			this.PageHome.UseVisualStyleBackColor = true;
			// 
			// PageProdutos
			// 
			this.PageProdutos.BackColor = System.Drawing.SystemColors.Control;
			this.PageProdutos.ImageKey = "product.png";
			this.PageProdutos.Location = new System.Drawing.Point(4, 39);
			this.PageProdutos.Name = "PageProdutos";
			this.PageProdutos.Padding = new System.Windows.Forms.Padding(3);
			this.PageProdutos.Size = new System.Drawing.Size(982, 558);
			this.PageProdutos.TabIndex = 1;
			this.PageProdutos.Text = "Produtos";
			// 
			// ImageList
			// 
			this.ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
			this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.ImageList.Images.SetKeyName(0, "home.png");
			this.ImageList.Images.SetKeyName(1, "product.png");
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(996, 668);
			this.Controls.Add(this.TabMain);
			this.DrawerAutoShow = true;
			this.DrawerIndicatorWidth = 3;
			this.DrawerShowIconsWhenHidden = true;
			this.DrawerTabControl = this.TabMain;
			this.Name = "FrmMain";
			this.Text = "Estoque";
			this.Load += new System.EventHandler(this.FrmMain_Load);
			this.TabMain.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private MaterialSkin.Controls.MaterialTabControl TabMain;
		private TabPage PageHome;
		private TabPage PageProdutos;
		private ImageList ImageList;
	}
}