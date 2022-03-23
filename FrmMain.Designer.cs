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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.Grid = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.Pn = new System.Windows.Forms.Panel();
			this.BtAtualizar = new MaterialSkin.Controls.MaterialButton();
			this.BtInserir = new MaterialSkin.Controls.MaterialButton();
			this.TxPrecoVenda = new MaterialSkin.Controls.MaterialTextBox2();
			this.TxPrecoCusto = new MaterialSkin.Controls.MaterialTextBox2();
			this.TxDescricao = new MaterialSkin.Controls.MaterialTextBox2();
			this.TxNomeProduto = new MaterialSkin.Controls.MaterialTextBox2();
			this.ImageList = new System.Windows.Forms.ImageList(this.components);
			this.TabMain.SuspendLayout();
			this.PageProdutos.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
			this.panel1.SuspendLayout();
			this.Pn.SuspendLayout();
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
			this.PageProdutos.Controls.Add(this.tableLayoutPanel1);
			this.PageProdutos.ImageKey = "product.png";
			this.PageProdutos.Location = new System.Drawing.Point(4, 39);
			this.PageProdutos.Name = "PageProdutos";
			this.PageProdutos.Padding = new System.Windows.Forms.Padding(3);
			this.PageProdutos.Size = new System.Drawing.Size(982, 558);
			this.PageProdutos.TabIndex = 1;
			this.PageProdutos.Text = "Produtos";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.Grid, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.26087F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.73913F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(976, 552);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// Grid
			// 
			this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Grid.Location = new System.Drawing.Point(3, 297);
			this.Grid.Name = "Grid";
			this.Grid.RowTemplate.Height = 25;
			this.Grid.Size = new System.Drawing.Size(970, 252);
			this.Grid.TabIndex = 1;
			this.Grid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_RowEnter);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.Pn);
			this.panel1.Controls.Add(this.TxPrecoVenda);
			this.panel1.Controls.Add(this.TxPrecoCusto);
			this.panel1.Controls.Add(this.TxDescricao);
			this.panel1.Controls.Add(this.TxNomeProduto);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(970, 288);
			this.panel1.TabIndex = 2;
			// 
			// Pn
			// 
			this.Pn.Controls.Add(this.BtAtualizar);
			this.Pn.Controls.Add(this.BtInserir);
			this.Pn.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Pn.Location = new System.Drawing.Point(0, 240);
			this.Pn.Name = "Pn";
			this.Pn.Size = new System.Drawing.Size(970, 48);
			this.Pn.TabIndex = 9;
			// 
			// BtAtualizar
			// 
			this.BtAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtAtualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BtAtualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.BtAtualizar.Depth = 0;
			this.BtAtualizar.HighEmphasis = true;
			this.BtAtualizar.Icon = null;
			this.BtAtualizar.Location = new System.Drawing.Point(774, 6);
			this.BtAtualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.BtAtualizar.MouseState = MaterialSkin.MouseState.HOVER;
			this.BtAtualizar.Name = "BtAtualizar";
			this.BtAtualizar.NoAccentTextColor = System.Drawing.Color.Empty;
			this.BtAtualizar.Size = new System.Drawing.Size(99, 36);
			this.BtAtualizar.TabIndex = 10;
			this.BtAtualizar.Text = "Atualizar";
			this.BtAtualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.BtAtualizar.UseAccentColor = false;
			this.BtAtualizar.UseVisualStyleBackColor = true;
			this.BtAtualizar.Click += new System.EventHandler(this.BtAtualizar_Click);
			// 
			// BtInserir
			// 
			this.BtInserir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtInserir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BtInserir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.BtInserir.Depth = 0;
			this.BtInserir.HighEmphasis = true;
			this.BtInserir.Icon = null;
			this.BtInserir.Location = new System.Drawing.Point(890, 6);
			this.BtInserir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.BtInserir.MouseState = MaterialSkin.MouseState.HOVER;
			this.BtInserir.Name = "BtInserir";
			this.BtInserir.NoAccentTextColor = System.Drawing.Color.Empty;
			this.BtInserir.Size = new System.Drawing.Size(76, 36);
			this.BtInserir.TabIndex = 9;
			this.BtInserir.Text = "Inserir";
			this.BtInserir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.BtInserir.UseAccentColor = false;
			this.BtInserir.UseVisualStyleBackColor = true;
			this.BtInserir.Click += new System.EventHandler(this.BtInserir_Click);
			// 
			// TxPrecoVenda
			// 
			this.TxPrecoVenda.AnimateReadOnly = false;
			this.TxPrecoVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.TxPrecoVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.TxPrecoVenda.Depth = 0;
			this.TxPrecoVenda.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.TxPrecoVenda.HideSelection = true;
			this.TxPrecoVenda.Hint = "Preço de venda";
			this.TxPrecoVenda.LeadingIcon = null;
			this.TxPrecoVenda.Location = new System.Drawing.Point(343, 100);
			this.TxPrecoVenda.MaxLength = 32767;
			this.TxPrecoVenda.MouseState = MaterialSkin.MouseState.OUT;
			this.TxPrecoVenda.Name = "TxPrecoVenda";
			this.TxPrecoVenda.PasswordChar = '\0';
			this.TxPrecoVenda.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
			this.TxPrecoVenda.PrefixSuffixText = "R$";
			this.TxPrecoVenda.ReadOnly = false;
			this.TxPrecoVenda.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.TxPrecoVenda.SelectedText = "";
			this.TxPrecoVenda.SelectionLength = 0;
			this.TxPrecoVenda.SelectionStart = 0;
			this.TxPrecoVenda.ShortcutsEnabled = true;
			this.TxPrecoVenda.Size = new System.Drawing.Size(289, 48);
			this.TxPrecoVenda.TabIndex = 6;
			this.TxPrecoVenda.TabStop = false;
			this.TxPrecoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.TxPrecoVenda.TrailingIcon = null;
			this.TxPrecoVenda.UseSystemPasswordChar = false;
			// 
			// TxPrecoCusto
			// 
			this.TxPrecoCusto.AnimateReadOnly = false;
			this.TxPrecoCusto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.TxPrecoCusto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.TxPrecoCusto.Depth = 0;
			this.TxPrecoCusto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.TxPrecoCusto.HideSelection = true;
			this.TxPrecoCusto.Hint = "Preço de custo";
			this.TxPrecoCusto.LeadingIcon = null;
			this.TxPrecoCusto.Location = new System.Drawing.Point(17, 100);
			this.TxPrecoCusto.MaxLength = 32767;
			this.TxPrecoCusto.MouseState = MaterialSkin.MouseState.OUT;
			this.TxPrecoCusto.Name = "TxPrecoCusto";
			this.TxPrecoCusto.PasswordChar = '\0';
			this.TxPrecoCusto.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
			this.TxPrecoCusto.PrefixSuffixText = "R$";
			this.TxPrecoCusto.ReadOnly = false;
			this.TxPrecoCusto.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.TxPrecoCusto.SelectedText = "";
			this.TxPrecoCusto.SelectionLength = 0;
			this.TxPrecoCusto.SelectionStart = 0;
			this.TxPrecoCusto.ShortcutsEnabled = true;
			this.TxPrecoCusto.Size = new System.Drawing.Size(289, 48);
			this.TxPrecoCusto.TabIndex = 5;
			this.TxPrecoCusto.TabStop = false;
			this.TxPrecoCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.TxPrecoCusto.TrailingIcon = null;
			this.TxPrecoCusto.UseSystemPasswordChar = false;
			// 
			// TxDescricao
			// 
			this.TxDescricao.AnimateReadOnly = false;
			this.TxDescricao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.TxDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.TxDescricao.Depth = 0;
			this.TxDescricao.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.TxDescricao.HideSelection = true;
			this.TxDescricao.Hint = "Descrição";
			this.TxDescricao.LeadingIcon = null;
			this.TxDescricao.Location = new System.Drawing.Point(343, 23);
			this.TxDescricao.MaxLength = 32767;
			this.TxDescricao.MouseState = MaterialSkin.MouseState.OUT;
			this.TxDescricao.Name = "TxDescricao";
			this.TxDescricao.PasswordChar = '\0';
			this.TxDescricao.PrefixSuffixText = null;
			this.TxDescricao.ReadOnly = false;
			this.TxDescricao.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.TxDescricao.SelectedText = "";
			this.TxDescricao.SelectionLength = 0;
			this.TxDescricao.SelectionStart = 0;
			this.TxDescricao.ShortcutsEnabled = true;
			this.TxDescricao.Size = new System.Drawing.Size(289, 48);
			this.TxDescricao.TabIndex = 4;
			this.TxDescricao.TabStop = false;
			this.TxDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.TxDescricao.TrailingIcon = null;
			this.TxDescricao.UseSystemPasswordChar = false;
			// 
			// TxNomeProduto
			// 
			this.TxNomeProduto.AnimateReadOnly = false;
			this.TxNomeProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.TxNomeProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.TxNomeProduto.Depth = 0;
			this.TxNomeProduto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.TxNomeProduto.HideSelection = true;
			this.TxNomeProduto.Hint = "Nome do produto";
			this.TxNomeProduto.LeadingIcon = null;
			this.TxNomeProduto.Location = new System.Drawing.Point(17, 23);
			this.TxNomeProduto.MaxLength = 32767;
			this.TxNomeProduto.MouseState = MaterialSkin.MouseState.OUT;
			this.TxNomeProduto.Name = "TxNomeProduto";
			this.TxNomeProduto.PasswordChar = '\0';
			this.TxNomeProduto.PrefixSuffixText = null;
			this.TxNomeProduto.ReadOnly = false;
			this.TxNomeProduto.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.TxNomeProduto.SelectedText = "";
			this.TxNomeProduto.SelectionLength = 0;
			this.TxNomeProduto.SelectionStart = 0;
			this.TxNomeProduto.ShortcutsEnabled = true;
			this.TxNomeProduto.Size = new System.Drawing.Size(289, 48);
			this.TxNomeProduto.TabIndex = 3;
			this.TxNomeProduto.TabStop = false;
			this.TxNomeProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.TxNomeProduto.TrailingIcon = null;
			this.TxNomeProduto.UseSystemPasswordChar = false;
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
			this.PageProdutos.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
			this.panel1.ResumeLayout(false);
			this.Pn.ResumeLayout(false);
			this.Pn.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private MaterialSkin.Controls.MaterialTabControl TabMain;
		private TabPage PageHome;
		private TabPage PageProdutos;
		private ImageList ImageList;
		private TableLayoutPanel tableLayoutPanel1;
		private DataGridView Grid;
		private Panel panel1;
		private MaterialSkin.Controls.MaterialTextBox2 TxNomeProduto;
		private MaterialSkin.Controls.MaterialTextBox2 TxPrecoCusto;
		private MaterialSkin.Controls.MaterialTextBox2 TxDescricao;
		private MaterialSkin.Controls.MaterialTextBox2 TxPrecoVenda;
		private Panel Pn;
		private MaterialSkin.Controls.MaterialButton BtAtualizar;
		private MaterialSkin.Controls.MaterialButton BtInserir;
	}
}