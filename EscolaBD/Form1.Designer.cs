namespace EscolaBD
{
    partial class Form1
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
            nome_txt = new MaterialSkin.Controls.MaterialTextBox2();
            curso_txt = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            telefone_txt = new MaterialSkin.Controls.MaterialMaskedTextBox();
            nascimento_txt = new MaterialSkin.Controls.MaterialMaskedTextBox();
            alunosGrid = new DataGridView();
            delete_btn = new MaterialSkin.Controls.MaterialButton();
            alter_btn = new MaterialSkin.Controls.MaterialButton();
            add_btn = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)alunosGrid).BeginInit();
            SuspendLayout();
            // 
            // nome_txt
            // 
            nome_txt.AnimateReadOnly = false;
            nome_txt.BackgroundImageLayout = ImageLayout.None;
            nome_txt.CharacterCasing = CharacterCasing.Normal;
            nome_txt.Depth = 0;
            nome_txt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            nome_txt.HideSelection = true;
            nome_txt.LeadingIcon = null;
            nome_txt.Location = new Point(12, 48);
            nome_txt.MaxLength = 32767;
            nome_txt.MouseState = MaterialSkin.MouseState.OUT;
            nome_txt.Name = "nome_txt";
            nome_txt.PasswordChar = '\0';
            nome_txt.PrefixSuffixText = null;
            nome_txt.ReadOnly = false;
            nome_txt.RightToLeft = RightToLeft.No;
            nome_txt.SelectedText = "";
            nome_txt.SelectionLength = 0;
            nome_txt.SelectionStart = 0;
            nome_txt.ShortcutsEnabled = true;
            nome_txt.Size = new Size(198, 48);
            nome_txt.TabIndex = 0;
            nome_txt.TabStop = false;
            nome_txt.TextAlign = HorizontalAlignment.Left;
            nome_txt.TrailingIcon = null;
            nome_txt.UseSystemPasswordChar = false;
            // 
            // curso_txt
            // 
            curso_txt.AnimateReadOnly = false;
            curso_txt.BackgroundImageLayout = ImageLayout.None;
            curso_txt.CharacterCasing = CharacterCasing.Normal;
            curso_txt.Depth = 0;
            curso_txt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            curso_txt.HideSelection = true;
            curso_txt.LeadingIcon = null;
            curso_txt.Location = new Point(541, 48);
            curso_txt.MaxLength = 32767;
            curso_txt.MouseState = MaterialSkin.MouseState.OUT;
            curso_txt.Name = "curso_txt";
            curso_txt.PasswordChar = '\0';
            curso_txt.PrefixSuffixText = null;
            curso_txt.ReadOnly = false;
            curso_txt.RightToLeft = RightToLeft.No;
            curso_txt.SelectedText = "";
            curso_txt.SelectionLength = 0;
            curso_txt.SelectionStart = 0;
            curso_txt.ShortcutsEnabled = true;
            curso_txt.Size = new Size(198, 48);
            curso_txt.TabIndex = 0;
            curso_txt.TabStop = false;
            curso_txt.TextAlign = HorizontalAlignment.Left;
            curso_txt.TrailingIcon = null;
            curso_txt.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.FlatStyle = FlatStyle.System;
            materialLabel1.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel1.Location = new Point(12, 16);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.RightToLeft = RightToLeft.No;
            materialLabel1.Size = new Size(66, 29);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "Nome";
            materialLabel1.UseMnemonic = false;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.FlatStyle = FlatStyle.System;
            materialLabel2.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel2.Location = new Point(285, 16);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.RightToLeft = RightToLeft.No;
            materialLabel2.Size = new Size(131, 29);
            materialLabel2.TabIndex = 2;
            materialLabel2.Text = "Nascimento";
            materialLabel2.UseMnemonic = false;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.FlatStyle = FlatStyle.System;
            materialLabel3.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel3.Location = new Point(541, 16);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.RightToLeft = RightToLeft.No;
            materialLabel3.Size = new Size(64, 29);
            materialLabel3.TabIndex = 3;
            materialLabel3.Text = "Curso";
            materialLabel3.UseMnemonic = false;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.FlatStyle = FlatStyle.System;
            materialLabel4.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel4.Location = new Point(801, 16);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.RightToLeft = RightToLeft.No;
            materialLabel4.Size = new Size(95, 29);
            materialLabel4.TabIndex = 4;
            materialLabel4.Text = "Telefone";
            materialLabel4.UseMnemonic = false;
            // 
            // telefone_txt
            // 
            telefone_txt.AllowPromptAsInput = false;
            telefone_txt.AnimateReadOnly = false;
            telefone_txt.AsciiOnly = false;
            telefone_txt.BackgroundImageLayout = ImageLayout.None;
            telefone_txt.BeepOnError = false;
            telefone_txt.CutCopyMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            telefone_txt.Depth = 0;
            telefone_txt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            telefone_txt.HidePromptOnLeave = true;
            telefone_txt.HideSelection = true;
            telefone_txt.InsertKeyMode = InsertKeyMode.Overwrite;
            telefone_txt.LeadingIcon = null;
            telefone_txt.Location = new Point(801, 48);
            telefone_txt.Mask = "(00) 0000-0000";
            telefone_txt.MaxLength = 32767;
            telefone_txt.MouseState = MaterialSkin.MouseState.OUT;
            telefone_txt.Name = "telefone_txt";
            telefone_txt.PasswordChar = '\0';
            telefone_txt.PrefixSuffix = MaterialSkin.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
            telefone_txt.PrefixSuffixText = null;
            telefone_txt.PromptChar = '_';
            telefone_txt.ReadOnly = false;
            telefone_txt.RejectInputOnFirstFailure = false;
            telefone_txt.ResetOnPrompt = true;
            telefone_txt.ResetOnSpace = true;
            telefone_txt.RightToLeft = RightToLeft.No;
            telefone_txt.SelectedText = "";
            telefone_txt.SelectionLength = 0;
            telefone_txt.SelectionStart = 0;
            telefone_txt.ShortcutsEnabled = true;
            telefone_txt.Size = new Size(198, 48);
            telefone_txt.SkipLiterals = true;
            telefone_txt.TabIndex = 5;
            telefone_txt.TabStop = false;
            telefone_txt.Text = "__________";
            telefone_txt.TextAlign = HorizontalAlignment.Left;
            telefone_txt.TextMaskFormat = MaskFormat.IncludePrompt;
            telefone_txt.TrailingIcon = null;
            telefone_txt.UseSystemPasswordChar = false;
            telefone_txt.ValidatingType = null;
            // 
            // nascimento_txt
            // 
            nascimento_txt.AllowPromptAsInput = true;
            nascimento_txt.AnimateReadOnly = false;
            nascimento_txt.AsciiOnly = false;
            nascimento_txt.BackgroundImageLayout = ImageLayout.None;
            nascimento_txt.BeepOnError = false;
            nascimento_txt.CutCopyMaskFormat = MaskFormat.IncludePrompt;
            nascimento_txt.Depth = 0;
            nascimento_txt.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            nascimento_txt.HidePromptOnLeave = false;
            nascimento_txt.HideSelection = true;
            nascimento_txt.InsertKeyMode = InsertKeyMode.Overwrite;
            nascimento_txt.LeadingIcon = null;
            nascimento_txt.Location = new Point(285, 48);
            nascimento_txt.Mask = "00/00/0000";
            nascimento_txt.MaxLength = 32767;
            nascimento_txt.MouseState = MaterialSkin.MouseState.OUT;
            nascimento_txt.Name = "nascimento_txt";
            nascimento_txt.PasswordChar = '\0';
            nascimento_txt.PrefixSuffix = MaterialSkin.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
            nascimento_txt.PrefixSuffixText = null;
            nascimento_txt.PromptChar = '_';
            nascimento_txt.ReadOnly = false;
            nascimento_txt.RejectInputOnFirstFailure = false;
            nascimento_txt.ResetOnPrompt = true;
            nascimento_txt.ResetOnSpace = true;
            nascimento_txt.RightToLeft = RightToLeft.No;
            nascimento_txt.SelectedText = "";
            nascimento_txt.SelectionLength = 0;
            nascimento_txt.SelectionStart = 0;
            nascimento_txt.ShortcutsEnabled = true;
            nascimento_txt.Size = new Size(198, 48);
            nascimento_txt.SkipLiterals = true;
            nascimento_txt.TabIndex = 5;
            nascimento_txt.TabStop = false;
            nascimento_txt.Text = "  /  /";
            nascimento_txt.TextAlign = HorizontalAlignment.Left;
            nascimento_txt.TextMaskFormat = MaskFormat.IncludeLiterals;
            nascimento_txt.TrailingIcon = null;
            nascimento_txt.UseSystemPasswordChar = false;
            nascimento_txt.ValidatingType = null;
            // 
            // alunosGrid
            // 
            alunosGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            alunosGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            alunosGrid.BackgroundColor = Color.LightBlue;
            alunosGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            alunosGrid.Location = new Point(12, 262);
            alunosGrid.Name = "alunosGrid";
            alunosGrid.Size = new Size(987, 328);
            alunosGrid.TabIndex = 6;
            alunosGrid.CellClick += alunosGrid_RowEnter;
            // 
            // delete_btn
            // 
            delete_btn.AutoSize = false;
            delete_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            delete_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            delete_btn.Depth = 0;
            delete_btn.HighEmphasis = true;
            delete_btn.Icon = null;
            delete_btn.Location = new Point(787, 197);
            delete_btn.Margin = new Padding(4, 6, 4, 6);
            delete_btn.MouseState = MaterialSkin.MouseState.HOVER;
            delete_btn.Name = "delete_btn";
            delete_btn.NoAccentTextColor = Color.Empty;
            delete_btn.Size = new Size(158, 36);
            delete_btn.TabIndex = 7;
            delete_btn.Text = "APAGAR";
            delete_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            delete_btn.UseAccentColor = false;
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // alter_btn
            // 
            alter_btn.AutoSize = false;
            alter_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            alter_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            alter_btn.Depth = 0;
            alter_btn.HighEmphasis = true;
            alter_btn.Icon = null;
            alter_btn.Location = new Point(422, 197);
            alter_btn.Margin = new Padding(4, 6, 4, 6);
            alter_btn.MouseState = MaterialSkin.MouseState.HOVER;
            alter_btn.Name = "alter_btn";
            alter_btn.NoAccentTextColor = Color.Empty;
            alter_btn.Size = new Size(158, 36);
            alter_btn.TabIndex = 7;
            alter_btn.Text = "Alterar";
            alter_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            alter_btn.UseAccentColor = false;
            alter_btn.UseVisualStyleBackColor = true;
            alter_btn.Click += alter_btn_Click;
            // 
            // add_btn
            // 
            add_btn.AutoSize = false;
            add_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            add_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            add_btn.Depth = 0;
            add_btn.HighEmphasis = true;
            add_btn.Icon = null;
            add_btn.Location = new Point(52, 197);
            add_btn.Margin = new Padding(4, 6, 4, 6);
            add_btn.MouseState = MaterialSkin.MouseState.HOVER;
            add_btn.Name = "add_btn";
            add_btn.NoAccentTextColor = Color.Empty;
            add_btn.Size = new Size(158, 36);
            add_btn.TabIndex = 7;
            add_btn.Text = "Adicionar";
            add_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            add_btn.UseAccentColor = false;
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 602);
            Controls.Add(add_btn);
            Controls.Add(alter_btn);
            Controls.Add(delete_btn);
            Controls.Add(alunosGrid);
            Controls.Add(nascimento_txt);
            Controls.Add(telefone_txt);
            Controls.Add(materialLabel4);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(curso_txt);
            Controls.Add(nome_txt);
            Name = "Form1";
            Text = "Cadastro Escolar";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)alunosGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 nome_txt;
        private MaterialSkin.Controls.MaterialTextBox2 curso_txt;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialMaskedTextBox telefone_txt;
        private MaterialSkin.Controls.MaterialMaskedTextBox nascimento_txt;
        private DataGridView alunosGrid;
        private MaterialSkin.Controls.MaterialButton delete_btn;
        private MaterialSkin.Controls.MaterialButton alter_btn;
        private MaterialSkin.Controls.MaterialButton add_btn;
    }
}
