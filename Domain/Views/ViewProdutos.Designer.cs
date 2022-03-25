namespace Estoque.Domain.Views
{
	partial class ViewProdutos
	{
		/// <summary> 
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Designer de Componentes

		/// <summary> 
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.Panel Pn;
			MaterialSkin.Controls.MaterialCard CardFooter1;
			System.Windows.Forms.Panel Pn3;
			MaterialSkin.Controls.MaterialCard CardFooter2;
			this.BtCancelar = new MaterialSkin.Controls.MaterialButton();
			this.BtSalvar = new MaterialSkin.Controls.MaterialButton();
			this.BtAtualizar = new MaterialSkin.Controls.MaterialButton();
			this.BtNovo = new MaterialSkin.Controls.MaterialButton();
			this.TabMain = new MaterialSkin.Controls.MaterialTabControl();
			this.PageListProdutos = new System.Windows.Forms.TabPage();
			this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.TxBuscarProduto = new MaterialSkin.Controls.MaterialTextBox2();
			this.BtSearch = new MaterialSkin.Controls.MaterialButton();
			this.GridProdutos = new System.Windows.Forms.DataGridView();
			this.PageCadastroProdutos = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.PnPageCadRight = new System.Windows.Forms.Panel();
			this.TxPrecoVenda = new MaterialSkin.Controls.MaterialTextBox2();
			this.TxFornecedor = new MaterialSkin.Controls.MaterialTextBox2();
			this.TxDescricao = new MaterialSkin.Controls.MaterialTextBox2();
			this.BtBuscarFornecedor = new MaterialSkin.Controls.MaterialButton();
			this.PnPageCadLeft = new System.Windows.Forms.Panel();
			this.TxMargem = new MaterialSkin.Controls.MaterialTextBox2();
			this.TxEan = new MaterialSkin.Controls.MaterialTextBox2();
			this.TxPrecoCusto = new MaterialSkin.Controls.MaterialTextBox2();
			this.TxNomeProduto = new MaterialSkin.Controls.MaterialTextBox2();
			Pn = new System.Windows.Forms.Panel();
			CardFooter1 = new MaterialSkin.Controls.MaterialCard();
			Pn3 = new System.Windows.Forms.Panel();
			CardFooter2 = new MaterialSkin.Controls.MaterialCard();
			Pn.SuspendLayout();
			CardFooter1.SuspendLayout();
			Pn3.SuspendLayout();
			CardFooter2.SuspendLayout();
			this.TabMain.SuspendLayout();
			this.PageListProdutos.SuspendLayout();
			this.materialCard1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).BeginInit();
			this.PageCadastroProdutos.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.PnPageCadRight.SuspendLayout();
			this.PnPageCadLeft.SuspendLayout();
			this.SuspendLayout();
			// 
			// Pn
			// 
			Pn.BackColor = System.Drawing.Color.Transparent;
			Pn.Controls.Add(CardFooter1);
			Pn.Dock = System.Windows.Forms.DockStyle.Bottom;
			Pn.Location = new System.Drawing.Point(3, 460);
			Pn.Name = "Pn";
			Pn.Padding = new System.Windows.Forms.Padding(5);
			Pn.Size = new System.Drawing.Size(973, 67);
			Pn.TabIndex = 19;
			// 
			// CardFooter1
			// 
			CardFooter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			CardFooter1.Controls.Add(this.BtCancelar);
			CardFooter1.Controls.Add(this.BtSalvar);
			CardFooter1.Depth = 0;
			CardFooter1.Dock = System.Windows.Forms.DockStyle.Fill;
			CardFooter1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			CardFooter1.Location = new System.Drawing.Point(5, 5);
			CardFooter1.Margin = new System.Windows.Forms.Padding(14);
			CardFooter1.MouseState = MaterialSkin.MouseState.HOVER;
			CardFooter1.Name = "CardFooter1";
			CardFooter1.Padding = new System.Windows.Forms.Padding(14);
			CardFooter1.Size = new System.Drawing.Size(963, 57);
			CardFooter1.TabIndex = 0;
			// 
			// BtCancelar
			// 
			this.BtCancelar.AutoSize = false;
			this.BtCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BtCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.BtCancelar.Depth = 0;
			this.BtCancelar.HighEmphasis = true;
			this.BtCancelar.Icon = null;
			this.BtCancelar.Location = new System.Drawing.Point(28, 11);
			this.BtCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.BtCancelar.MouseState = MaterialSkin.MouseState.HOVER;
			this.BtCancelar.Name = "BtCancelar";
			this.BtCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
			this.BtCancelar.Size = new System.Drawing.Size(413, 36);
			this.BtCancelar.TabIndex = 1;
			this.BtCancelar.Text = "Cancelar";
			this.BtCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.BtCancelar.UseAccentColor = false;
			this.BtCancelar.UseVisualStyleBackColor = true;
			this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
			// 
			// BtSalvar
			// 
			this.BtSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtSalvar.AutoSize = false;
			this.BtSalvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BtSalvar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.BtSalvar.Depth = 0;
			this.BtSalvar.HighEmphasis = true;
			this.BtSalvar.Icon = null;
			this.BtSalvar.Location = new System.Drawing.Point(532, 11);
			this.BtSalvar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.BtSalvar.MouseState = MaterialSkin.MouseState.HOVER;
			this.BtSalvar.Name = "BtSalvar";
			this.BtSalvar.NoAccentTextColor = System.Drawing.Color.Empty;
			this.BtSalvar.Size = new System.Drawing.Size(413, 36);
			this.BtSalvar.TabIndex = 0;
			this.BtSalvar.Text = "Salvar";
			this.BtSalvar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.BtSalvar.UseAccentColor = false;
			this.BtSalvar.UseVisualStyleBackColor = true;
			this.BtSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
			// 
			// Pn3
			// 
			Pn3.BackColor = System.Drawing.SystemColors.Control;
			Pn3.Controls.Add(CardFooter2);
			Pn3.Dock = System.Windows.Forms.DockStyle.Bottom;
			Pn3.Location = new System.Drawing.Point(3, 460);
			Pn3.Name = "Pn3";
			Pn3.Padding = new System.Windows.Forms.Padding(5);
			Pn3.Size = new System.Drawing.Size(973, 67);
			Pn3.TabIndex = 11;
			// 
			// CardFooter2
			// 
			CardFooter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			CardFooter2.Controls.Add(this.BtAtualizar);
			CardFooter2.Controls.Add(this.BtNovo);
			CardFooter2.Depth = 0;
			CardFooter2.Dock = System.Windows.Forms.DockStyle.Fill;
			CardFooter2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			CardFooter2.Location = new System.Drawing.Point(5, 5);
			CardFooter2.Margin = new System.Windows.Forms.Padding(14);
			CardFooter2.MouseState = MaterialSkin.MouseState.HOVER;
			CardFooter2.Name = "CardFooter2";
			CardFooter2.Padding = new System.Windows.Forms.Padding(14);
			CardFooter2.Size = new System.Drawing.Size(963, 57);
			CardFooter2.TabIndex = 0;
			// 
			// BtAtualizar
			// 
			this.BtAtualizar.AutoSize = false;
			this.BtAtualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BtAtualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.BtAtualizar.Depth = 0;
			this.BtAtualizar.HighEmphasis = true;
			this.BtAtualizar.Icon = null;
			this.BtAtualizar.Location = new System.Drawing.Point(28, 11);
			this.BtAtualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.BtAtualizar.MouseState = MaterialSkin.MouseState.HOVER;
			this.BtAtualizar.Name = "BtAtualizar";
			this.BtAtualizar.NoAccentTextColor = System.Drawing.Color.Empty;
			this.BtAtualizar.Size = new System.Drawing.Size(413, 36);
			this.BtAtualizar.TabIndex = 1;
			this.BtAtualizar.Text = "Atualizar";
			this.BtAtualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.BtAtualizar.UseAccentColor = false;
			this.BtAtualizar.UseVisualStyleBackColor = true;
			this.BtAtualizar.Click += new System.EventHandler(this.BtAtualizar_Click);
			// 
			// BtNovo
			// 
			this.BtNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtNovo.AutoSize = false;
			this.BtNovo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BtNovo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.BtNovo.Depth = 0;
			this.BtNovo.HighEmphasis = true;
			this.BtNovo.Icon = null;
			this.BtNovo.Location = new System.Drawing.Point(532, 11);
			this.BtNovo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.BtNovo.MouseState = MaterialSkin.MouseState.HOVER;
			this.BtNovo.Name = "BtNovo";
			this.BtNovo.NoAccentTextColor = System.Drawing.Color.Empty;
			this.BtNovo.Size = new System.Drawing.Size(413, 36);
			this.BtNovo.TabIndex = 0;
			this.BtNovo.Text = "Novo";
			this.BtNovo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.BtNovo.UseAccentColor = false;
			this.BtNovo.UseVisualStyleBackColor = true;
			this.BtNovo.Click += new System.EventHandler(this.BtNovo_Click);
			// 
			// TabMain
			// 
			this.TabMain.Controls.Add(this.PageListProdutos);
			this.TabMain.Controls.Add(this.PageCadastroProdutos);
			this.TabMain.Depth = 0;
			this.TabMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TabMain.Location = new System.Drawing.Point(0, 0);
			this.TabMain.MouseState = MaterialSkin.MouseState.HOVER;
			this.TabMain.Multiline = true;
			this.TabMain.Name = "TabMain";
			this.TabMain.SelectedIndex = 0;
			this.TabMain.Size = new System.Drawing.Size(987, 558);
			this.TabMain.TabIndex = 0;
			// 
			// PageListProdutos
			// 
			this.PageListProdutos.BackColor = System.Drawing.SystemColors.Control;
			this.PageListProdutos.Controls.Add(this.materialCard1);
			this.PageListProdutos.Controls.Add(this.GridProdutos);
			this.PageListProdutos.Controls.Add(Pn3);
			this.PageListProdutos.Location = new System.Drawing.Point(4, 24);
			this.PageListProdutos.Name = "PageListProdutos";
			this.PageListProdutos.Padding = new System.Windows.Forms.Padding(3);
			this.PageListProdutos.Size = new System.Drawing.Size(979, 530);
			this.PageListProdutos.TabIndex = 0;
			this.PageListProdutos.Text = "PageListProdutos";
			// 
			// materialCard1
			// 
			this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.materialCard1.Controls.Add(this.tableLayoutPanel2);
			this.materialCard1.Depth = 0;
			this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialCard1.Location = new System.Drawing.Point(8, 13);
			this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
			this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialCard1.Name = "materialCard1";
			this.materialCard1.Padding = new System.Windows.Forms.Padding(3);
			this.materialCard1.Size = new System.Drawing.Size(963, 64);
			this.materialCard1.TabIndex = 13;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.16043F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.839572F));
			this.tableLayoutPanel2.Controls.Add(this.TxBuscarProduto, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.BtSearch, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(957, 58);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// TxBuscarProduto
			// 
			this.TxBuscarProduto.AnimateReadOnly = false;
			this.TxBuscarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.TxBuscarProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.TxBuscarProduto.Depth = 0;
			this.TxBuscarProduto.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxBuscarProduto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.TxBuscarProduto.HideSelection = true;
			this.TxBuscarProduto.Hint = "Buscar produto";
			this.TxBuscarProduto.LeadingIcon = null;
			this.TxBuscarProduto.Location = new System.Drawing.Point(8, 3);
			this.TxBuscarProduto.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
			this.TxBuscarProduto.MaxLength = 32767;
			this.TxBuscarProduto.MouseState = MaterialSkin.MouseState.OUT;
			this.TxBuscarProduto.Name = "TxBuscarProduto";
			this.TxBuscarProduto.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
			this.TxBuscarProduto.PasswordChar = '\0';
			this.TxBuscarProduto.PrefixSuffixText = null;
			this.TxBuscarProduto.ReadOnly = false;
			this.TxBuscarProduto.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.TxBuscarProduto.SelectedText = "";
			this.TxBuscarProduto.SelectionLength = 0;
			this.TxBuscarProduto.SelectionStart = 0;
			this.TxBuscarProduto.ShortcutsEnabled = true;
			this.TxBuscarProduto.Size = new System.Drawing.Size(851, 48);
			this.TxBuscarProduto.TabIndex = 2;
			this.TxBuscarProduto.TabStop = false;
			this.TxBuscarProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.TxBuscarProduto.TrailingIcon = null;
			this.TxBuscarProduto.UseSystemPasswordChar = false;
			// 
			// BtSearch
			// 
			this.BtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtSearch.AutoSize = false;
			this.BtSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BtSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.BtSearch.Depth = 0;
			this.BtSearch.HighEmphasis = true;
			this.BtSearch.Icon = global::Estoque.Resource.search;
			this.BtSearch.Location = new System.Drawing.Point(878, 15);
			this.BtSearch.Margin = new System.Windows.Forms.Padding(10, 15, 35, 10);
			this.BtSearch.MouseState = MaterialSkin.MouseState.HOVER;
			this.BtSearch.Name = "BtSearch";
			this.BtSearch.NoAccentTextColor = System.Drawing.Color.Empty;
			this.BtSearch.Size = new System.Drawing.Size(44, 33);
			this.BtSearch.TabIndex = 3;
			this.BtSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.BtSearch.UseAccentColor = false;
			this.BtSearch.UseVisualStyleBackColor = true;
			// 
			// GridProdutos
			// 
			this.GridProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GridProdutos.Location = new System.Drawing.Point(8, 86);
			this.GridProdutos.Name = "GridProdutos";
			this.GridProdutos.RowTemplate.Height = 25;
			this.GridProdutos.Size = new System.Drawing.Size(963, 362);
			this.GridProdutos.TabIndex = 12;
			this.GridProdutos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProdutos_RowEnter);
			// 
			// PageCadastroProdutos
			// 
			this.PageCadastroProdutos.BackColor = System.Drawing.SystemColors.Control;
			this.PageCadastroProdutos.Controls.Add(this.tableLayoutPanel1);
			this.PageCadastroProdutos.Controls.Add(Pn);
			this.PageCadastroProdutos.Location = new System.Drawing.Point(4, 24);
			this.PageCadastroProdutos.Name = "PageCadastroProdutos";
			this.PageCadastroProdutos.Padding = new System.Windows.Forms.Padding(3);
			this.PageCadastroProdutos.Size = new System.Drawing.Size(979, 530);
			this.PageCadastroProdutos.TabIndex = 1;
			this.PageCadastroProdutos.Text = "PageCadastroProdutos";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.PnPageCadRight, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.PnPageCadLeft, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 21);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(963, 335);
			this.tableLayoutPanel1.TabIndex = 24;
			// 
			// PnPageCadRight
			// 
			this.PnPageCadRight.Controls.Add(this.TxPrecoVenda);
			this.PnPageCadRight.Controls.Add(this.TxFornecedor);
			this.PnPageCadRight.Controls.Add(this.TxDescricao);
			this.PnPageCadRight.Controls.Add(this.BtBuscarFornecedor);
			this.PnPageCadRight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PnPageCadRight.Location = new System.Drawing.Point(484, 3);
			this.PnPageCadRight.Name = "PnPageCadRight";
			this.PnPageCadRight.Size = new System.Drawing.Size(476, 329);
			this.PnPageCadRight.TabIndex = 1;
			// 
			// TxPrecoVenda
			// 
			this.TxPrecoVenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TxPrecoVenda.AnimateReadOnly = false;
			this.TxPrecoVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.TxPrecoVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.TxPrecoVenda.Depth = 0;
			this.TxPrecoVenda.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.TxPrecoVenda.HideSelection = true;
			this.TxPrecoVenda.Hint = "Preço de venda";
			this.TxPrecoVenda.LeadingIcon = null;
			this.TxPrecoVenda.Location = new System.Drawing.Point(19, 172);
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
			this.TxPrecoVenda.Size = new System.Drawing.Size(434, 48);
			this.TxPrecoVenda.TabIndex = 18;
			this.TxPrecoVenda.TabStop = false;
			this.TxPrecoVenda.Text = "0,00";
			this.TxPrecoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.TxPrecoVenda.TrailingIcon = null;
			this.TxPrecoVenda.UseSystemPasswordChar = false;
			// 
			// TxFornecedor
			// 
			this.TxFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TxFornecedor.AnimateReadOnly = false;
			this.TxFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.TxFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.TxFornecedor.Depth = 0;
			this.TxFornecedor.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.TxFornecedor.HideSelection = true;
			this.TxFornecedor.Hint = "Fornecedor";
			this.TxFornecedor.LeadingIcon = null;
			this.TxFornecedor.Location = new System.Drawing.Point(19, 96);
			this.TxFornecedor.MaxLength = 32767;
			this.TxFornecedor.MouseState = MaterialSkin.MouseState.OUT;
			this.TxFornecedor.Name = "TxFornecedor";
			this.TxFornecedor.PasswordChar = '\0';
			this.TxFornecedor.PrefixSuffixText = null;
			this.TxFornecedor.ReadOnly = false;
			this.TxFornecedor.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.TxFornecedor.SelectedText = "";
			this.TxFornecedor.SelectionLength = 0;
			this.TxFornecedor.SelectionStart = 0;
			this.TxFornecedor.ShortcutsEnabled = true;
			this.TxFornecedor.Size = new System.Drawing.Size(368, 48);
			this.TxFornecedor.TabIndex = 23;
			this.TxFornecedor.TabStop = false;
			this.TxFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.TxFornecedor.TrailingIcon = null;
			this.TxFornecedor.UseSystemPasswordChar = false;
			// 
			// TxDescricao
			// 
			this.TxDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TxDescricao.AnimateReadOnly = false;
			this.TxDescricao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.TxDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.TxDescricao.Depth = 0;
			this.TxDescricao.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.TxDescricao.HideSelection = true;
			this.TxDescricao.Hint = "Descrição";
			this.TxDescricao.LeadingIcon = null;
			this.TxDescricao.Location = new System.Drawing.Point(19, 21);
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
			this.TxDescricao.Size = new System.Drawing.Size(434, 48);
			this.TxDescricao.TabIndex = 16;
			this.TxDescricao.TabStop = false;
			this.TxDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.TxDescricao.TrailingIcon = null;
			this.TxDescricao.UseSystemPasswordChar = false;
			// 
			// BtBuscarFornecedor
			// 
			this.BtBuscarFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtBuscarFornecedor.AutoSize = false;
			this.BtBuscarFornecedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BtBuscarFornecedor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.BtBuscarFornecedor.Depth = 0;
			this.BtBuscarFornecedor.HighEmphasis = true;
			this.BtBuscarFornecedor.Icon = global::Estoque.Resource.search;
			this.BtBuscarFornecedor.Location = new System.Drawing.Point(409, 108);
			this.BtBuscarFornecedor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.BtBuscarFornecedor.MouseState = MaterialSkin.MouseState.HOVER;
			this.BtBuscarFornecedor.Name = "BtBuscarFornecedor";
			this.BtBuscarFornecedor.NoAccentTextColor = System.Drawing.Color.Empty;
			this.BtBuscarFornecedor.Size = new System.Drawing.Size(44, 36);
			this.BtBuscarFornecedor.TabIndex = 22;
			this.BtBuscarFornecedor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.BtBuscarFornecedor.UseAccentColor = false;
			this.BtBuscarFornecedor.UseVisualStyleBackColor = true;
			// 
			// PnPageCadLeft
			// 
			this.PnPageCadLeft.Controls.Add(this.TxMargem);
			this.PnPageCadLeft.Controls.Add(this.TxEan);
			this.PnPageCadLeft.Controls.Add(this.TxPrecoCusto);
			this.PnPageCadLeft.Controls.Add(this.TxNomeProduto);
			this.PnPageCadLeft.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PnPageCadLeft.Location = new System.Drawing.Point(3, 3);
			this.PnPageCadLeft.Name = "PnPageCadLeft";
			this.PnPageCadLeft.Size = new System.Drawing.Size(475, 329);
			this.PnPageCadLeft.TabIndex = 0;
			// 
			// TxMargem
			// 
			this.TxMargem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TxMargem.AnimateReadOnly = false;
			this.TxMargem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.TxMargem.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.TxMargem.Depth = 0;
			this.TxMargem.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.TxMargem.HideSelection = true;
			this.TxMargem.Hint = "Margem";
			this.TxMargem.LeadingIcon = null;
			this.TxMargem.Location = new System.Drawing.Point(248, 172);
			this.TxMargem.MaxLength = 32767;
			this.TxMargem.MouseState = MaterialSkin.MouseState.OUT;
			this.TxMargem.Name = "TxMargem";
			this.TxMargem.PasswordChar = '\0';
			this.TxMargem.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
			this.TxMargem.PrefixSuffixText = "%";
			this.TxMargem.ReadOnly = false;
			this.TxMargem.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.TxMargem.SelectedText = "";
			this.TxMargem.SelectionLength = 0;
			this.TxMargem.SelectionStart = 0;
			this.TxMargem.ShortcutsEnabled = true;
			this.TxMargem.Size = new System.Drawing.Size(205, 48);
			this.TxMargem.TabIndex = 27;
			this.TxMargem.TabStop = false;
			this.TxMargem.Text = "0";
			this.TxMargem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.TxMargem.TrailingIcon = null;
			this.TxMargem.UseSystemPasswordChar = false;
			this.TxMargem.TextChanged += new System.EventHandler(this.TxMargem_TextChanged);
			// 
			// TxEan
			// 
			this.TxEan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TxEan.AnimateReadOnly = false;
			this.TxEan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.TxEan.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.TxEan.Depth = 0;
			this.TxEan.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.TxEan.HideSelection = true;
			this.TxEan.Hint = "EAN";
			this.TxEan.LeadingIcon = null;
			this.TxEan.Location = new System.Drawing.Point(25, 96);
			this.TxEan.MaxLength = 32767;
			this.TxEan.MouseState = MaterialSkin.MouseState.OUT;
			this.TxEan.Name = "TxEan";
			this.TxEan.PasswordChar = '\0';
			this.TxEan.PrefixSuffixText = null;
			this.TxEan.ReadOnly = false;
			this.TxEan.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.TxEan.SelectedText = "";
			this.TxEan.SelectionLength = 0;
			this.TxEan.SelectionStart = 0;
			this.TxEan.ShortcutsEnabled = true;
			this.TxEan.Size = new System.Drawing.Size(428, 48);
			this.TxEan.TabIndex = 26;
			this.TxEan.TabStop = false;
			this.TxEan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.TxEan.TrailingIcon = null;
			this.TxEan.UseSystemPasswordChar = false;
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
			this.TxPrecoCusto.Location = new System.Drawing.Point(25, 172);
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
			this.TxPrecoCusto.Size = new System.Drawing.Size(205, 48);
			this.TxPrecoCusto.TabIndex = 25;
			this.TxPrecoCusto.TabStop = false;
			this.TxPrecoCusto.Text = "0,00";
			this.TxPrecoCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.TxPrecoCusto.TrailingIcon = null;
			this.TxPrecoCusto.UseSystemPasswordChar = false;
			this.TxPrecoCusto.TextChanged += new System.EventHandler(this.TxPrecoCusto_TextChanged);
			// 
			// TxNomeProduto
			// 
			this.TxNomeProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TxNomeProduto.AnimateReadOnly = false;
			this.TxNomeProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.TxNomeProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.TxNomeProduto.Depth = 0;
			this.TxNomeProduto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.TxNomeProduto.HideSelection = true;
			this.TxNomeProduto.Hint = "Nome";
			this.TxNomeProduto.LeadingIcon = null;
			this.TxNomeProduto.Location = new System.Drawing.Point(25, 21);
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
			this.TxNomeProduto.Size = new System.Drawing.Size(428, 48);
			this.TxNomeProduto.TabIndex = 24;
			this.TxNomeProduto.TabStop = false;
			this.TxNomeProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.TxNomeProduto.TrailingIcon = null;
			this.TxNomeProduto.UseSystemPasswordChar = false;
			// 
			// ViewProdutos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.TabMain);
			this.Name = "ViewProdutos";
			this.Size = new System.Drawing.Size(987, 558);
			this.Load += new System.EventHandler(this.ViewProdutos_Load);
			Pn.ResumeLayout(false);
			CardFooter1.ResumeLayout(false);
			Pn3.ResumeLayout(false);
			CardFooter2.ResumeLayout(false);
			this.TabMain.ResumeLayout(false);
			this.PageListProdutos.ResumeLayout(false);
			this.materialCard1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).EndInit();
			this.PageCadastroProdutos.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.PnPageCadRight.ResumeLayout(false);
			this.PnPageCadLeft.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private TabPage PageListProdutos;
		private TabPage PageCadastroProdutos;
		private MaterialSkin.Controls.MaterialTabControl TabMain;
		private MaterialSkin.Controls.MaterialTextBox2 TxFornecedor;
		private MaterialSkin.Controls.MaterialButton BtBuscarFornecedor;
		private MaterialSkin.Controls.MaterialButton BtCancelar;
		private MaterialSkin.Controls.MaterialButton BtSalvar;
		private MaterialSkin.Controls.MaterialTextBox2 TxPrecoVenda;
		private MaterialSkin.Controls.MaterialTextBox2 TxDescricao;
		private DataGridView GridProdutos;
		private MaterialSkin.Controls.MaterialButton BtAtualizar;
		private MaterialSkin.Controls.MaterialButton BtNovo;
		private TableLayoutPanel tableLayoutPanel1;
		private Panel PnPageCadRight;
		private Panel PnPageCadLeft;
		private MaterialSkin.Controls.MaterialTextBox2 TxEan;
		private MaterialSkin.Controls.MaterialTextBox2 TxPrecoCusto;
		private MaterialSkin.Controls.MaterialTextBox2 TxNomeProduto;
		private MaterialSkin.Controls.MaterialTextBox2 TxMargem;
		private MaterialSkin.Controls.MaterialCard materialCard1;
		private TableLayoutPanel tableLayoutPanel2;
		private MaterialSkin.Controls.MaterialTextBox2 TxBuscarProduto;
		private MaterialSkin.Controls.MaterialButton BtSearch;
	}
}
