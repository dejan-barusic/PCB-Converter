namespace PCBConverter {
    partial class UI {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.ui_splitContainer = new System.Windows.Forms.SplitContainer();
            this.ui_toolPanel = new System.Windows.Forms.Panel();
            this.ui_openButton = new System.Windows.Forms.Button();
            this.ui_saveButton = new System.Windows.Forms.Button();
            this.ui_toolTable = new System.Windows.Forms.TableLayoutPanel();
            this.ui_nonexposedColorButton = new System.Windows.Forms.Button();
            this.ui_boardHeightText = new System.Windows.Forms.Label();
            this.ui_boardWidthText = new System.Windows.Forms.Label();
            this.ui_boardWidthInput = new System.Windows.Forms.NumericUpDown();
            this.ui_boardHeightInput = new System.Windows.Forms.NumericUpDown();
            this.ui_stepHorizontalInput = new System.Windows.Forms.NumericUpDown();
            this.ui_stepHorizontalText = new System.Windows.Forms.Label();
            this.ui_stepVerticalInput = new System.Windows.Forms.NumericUpDown();
            this.ui_stepVerticalText = new System.Windows.Forms.Label();
            this.ui_dpiInput = new System.Windows.Forms.NumericUpDown();
            this.ui_dpiText = new System.Windows.Forms.Label();
            this.ui_useDPIcheckbox = new System.Windows.Forms.CheckBox();
            this.ui_tileHorizontalInput = new System.Windows.Forms.NumericUpDown();
            this.ui_tileHorizontalText = new System.Windows.Forms.Label();
            this.ui_tileVerticalInput = new System.Windows.Forms.NumericUpDown();
            this.ui_tileVerticalText = new System.Windows.Forms.Label();
            this.ui_tileBorderInput = new System.Windows.Forms.NumericUpDown();
            this.ui_tileBorderText = new System.Windows.Forms.Label();
            this.ui_inverseProcessCheckbox = new System.Windows.Forms.CheckBox();
            this.ui_exposedColorButton = new System.Windows.Forms.Button();
            this.ui_exposedColorText = new System.Windows.Forms.Label();
            this.ui_nonexposedColorText = new System.Windows.Forms.Label();
            this.ui_inputBitmapInfo = new System.Windows.Forms.Label();
            this.ui_inputBitmap = new System.Windows.Forms.PictureBox();
            this.ui_workBitmapLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.ui_workBitmap = new System.Windows.Forms.PictureBox();
            this.ui_workBitmapInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ui_splitContainer)).BeginInit();
            this.ui_splitContainer.Panel1.SuspendLayout();
            this.ui_splitContainer.Panel2.SuspendLayout();
            this.ui_splitContainer.SuspendLayout();
            this.ui_toolPanel.SuspendLayout();
            this.ui_toolTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ui_boardWidthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ui_boardHeightInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ui_stepHorizontalInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ui_stepVerticalInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ui_dpiInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ui_tileHorizontalInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ui_tileVerticalInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ui_tileBorderInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ui_inputBitmap)).BeginInit();
            this.ui_workBitmapLayoutTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ui_workBitmap)).BeginInit();
            this.SuspendLayout();
            // 
            // ui_splitContainer
            // 
            this.ui_splitContainer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ui_splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ui_splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.ui_splitContainer.Location = new System.Drawing.Point(0, 0);
            this.ui_splitContainer.Name = "ui_splitContainer";
            // 
            // ui_splitContainer.Panel1
            // 
            this.ui_splitContainer.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ui_splitContainer.Panel1.Controls.Add(this.ui_toolPanel);
            // 
            // ui_splitContainer.Panel2
            // 
            this.ui_splitContainer.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ui_splitContainer.Panel2.Controls.Add(this.ui_workBitmapLayoutTable);
            this.ui_splitContainer.Size = new System.Drawing.Size(1008, 760);
            this.ui_splitContainer.SplitterDistance = 240;
            this.ui_splitContainer.TabIndex = 0;
            // 
            // ui_toolPanel
            // 
            this.ui_toolPanel.AutoScroll = true;
            this.ui_toolPanel.AutoScrollMargin = new System.Drawing.Size(2, 2);
            this.ui_toolPanel.Controls.Add(this.ui_openButton);
            this.ui_toolPanel.Controls.Add(this.ui_saveButton);
            this.ui_toolPanel.Controls.Add(this.ui_toolTable);
            this.ui_toolPanel.Controls.Add(this.ui_inputBitmapInfo);
            this.ui_toolPanel.Controls.Add(this.ui_inputBitmap);
            this.ui_toolPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_toolPanel.Location = new System.Drawing.Point(0, 0);
            this.ui_toolPanel.Name = "ui_toolPanel";
            this.ui_toolPanel.Padding = new System.Windows.Forms.Padding(10);
            this.ui_toolPanel.Size = new System.Drawing.Size(238, 758);
            this.ui_toolPanel.TabIndex = 0;
            // 
            // ui_openButton
            // 
            this.ui_openButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ui_openButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ui_openButton.Location = new System.Drawing.Point(10, 688);
            this.ui_openButton.MaximumSize = new System.Drawing.Size(200, 30);
            this.ui_openButton.Name = "ui_openButton";
            this.ui_openButton.Size = new System.Drawing.Size(200, 30);
            this.ui_openButton.TabIndex = 19;
            this.ui_openButton.Text = "Open";
            this.ui_openButton.UseVisualStyleBackColor = true;
            this.ui_openButton.Click += new System.EventHandler(this.ui_openButton_Click);
            // 
            // ui_saveButton
            // 
            this.ui_saveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ui_saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ui_saveButton.Location = new System.Drawing.Point(10, 718);
            this.ui_saveButton.MaximumSize = new System.Drawing.Size(200, 30);
            this.ui_saveButton.Name = "ui_saveButton";
            this.ui_saveButton.Size = new System.Drawing.Size(200, 30);
            this.ui_saveButton.TabIndex = 18;
            this.ui_saveButton.Text = "Save";
            this.ui_saveButton.UseVisualStyleBackColor = true;
            this.ui_saveButton.Click += new System.EventHandler(this.ui_saveButton_Click);
            // 
            // ui_toolTable
            // 
            this.ui_toolTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ui_toolTable.ColumnCount = 2;
            this.ui_toolTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ui_toolTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ui_toolTable.Controls.Add(this.ui_nonexposedColorButton, 0, 15);
            this.ui_toolTable.Controls.Add(this.ui_boardHeightText, 1, 1);
            this.ui_toolTable.Controls.Add(this.ui_boardWidthText, 1, 0);
            this.ui_toolTable.Controls.Add(this.ui_boardWidthInput, 0, 0);
            this.ui_toolTable.Controls.Add(this.ui_boardHeightInput, 0, 1);
            this.ui_toolTable.Controls.Add(this.ui_stepHorizontalInput, 0, 3);
            this.ui_toolTable.Controls.Add(this.ui_stepHorizontalText, 1, 3);
            this.ui_toolTable.Controls.Add(this.ui_stepVerticalInput, 0, 4);
            this.ui_toolTable.Controls.Add(this.ui_stepVerticalText, 1, 4);
            this.ui_toolTable.Controls.Add(this.ui_dpiInput, 0, 6);
            this.ui_toolTable.Controls.Add(this.ui_dpiText, 1, 6);
            this.ui_toolTable.Controls.Add(this.ui_useDPIcheckbox, 0, 7);
            this.ui_toolTable.Controls.Add(this.ui_tileHorizontalInput, 0, 9);
            this.ui_toolTable.Controls.Add(this.ui_tileHorizontalText, 1, 9);
            this.ui_toolTable.Controls.Add(this.ui_tileVerticalInput, 0, 10);
            this.ui_toolTable.Controls.Add(this.ui_tileVerticalText, 1, 10);
            this.ui_toolTable.Controls.Add(this.ui_tileBorderInput, 0, 11);
            this.ui_toolTable.Controls.Add(this.ui_tileBorderText, 1, 11);
            this.ui_toolTable.Controls.Add(this.ui_inverseProcessCheckbox, 0, 16);
            this.ui_toolTable.Controls.Add(this.ui_exposedColorButton, 0, 14);
            this.ui_toolTable.Controls.Add(this.ui_exposedColorText, 1, 14);
            this.ui_toolTable.Controls.Add(this.ui_nonexposedColorText, 1, 15);
            this.ui_toolTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.ui_toolTable.Location = new System.Drawing.Point(10, 273);
            this.ui_toolTable.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.ui_toolTable.Name = "ui_toolTable";
            this.ui_toolTable.RowCount = 17;
            this.ui_toolTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ui_toolTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ui_toolTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.ui_toolTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ui_toolTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ui_toolTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.ui_toolTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ui_toolTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ui_toolTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.ui_toolTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ui_toolTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ui_toolTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ui_toolTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.ui_toolTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ui_toolTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ui_toolTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ui_toolTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ui_toolTable.Size = new System.Drawing.Size(218, 402);
            this.ui_toolTable.TabIndex = 16;
            // 
            // ui_nonexposedColorButton
            // 
            this.ui_nonexposedColorButton.BackColor = System.Drawing.Color.DimGray;
            this.ui_nonexposedColorButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ui_nonexposedColorButton.Location = new System.Drawing.Point(15, 337);
            this.ui_nonexposedColorButton.Margin = new System.Windows.Forms.Padding(15, 1, 3, 3);
            this.ui_nonexposedColorButton.Name = "ui_nonexposedColorButton";
            this.ui_nonexposedColorButton.Size = new System.Drawing.Size(60, 25);
            this.ui_nonexposedColorButton.TabIndex = 30;
            this.ui_nonexposedColorButton.UseVisualStyleBackColor = false;
            this.ui_nonexposedColorButton.Click += new System.EventHandler(this.ui_nonexposedColorButton_Click);
            // 
            // ui_boardHeightText
            // 
            this.ui_boardHeightText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ui_boardHeightText.AutoSize = true;
            this.ui_boardHeightText.CausesValidation = false;
            this.ui_boardHeightText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ui_boardHeightText.Location = new System.Drawing.Point(81, 36);
            this.ui_boardHeightText.Margin = new System.Windows.Forms.Padding(0);
            this.ui_boardHeightText.Name = "ui_boardHeightText";
            this.ui_boardHeightText.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ui_boardHeightText.Size = new System.Drawing.Size(94, 17);
            this.ui_boardHeightText.TabIndex = 14;
            this.ui_boardHeightText.Text = "Board height";
            // 
            // ui_boardWidthText
            // 
            this.ui_boardWidthText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ui_boardWidthText.AutoSize = true;
            this.ui_boardWidthText.CausesValidation = false;
            this.ui_boardWidthText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ui_boardWidthText.Location = new System.Drawing.Point(81, 6);
            this.ui_boardWidthText.Margin = new System.Windows.Forms.Padding(0);
            this.ui_boardWidthText.Name = "ui_boardWidthText";
            this.ui_boardWidthText.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ui_boardWidthText.Size = new System.Drawing.Size(87, 17);
            this.ui_boardWidthText.TabIndex = 13;
            this.ui_boardWidthText.Text = "Board width";
            // 
            // ui_boardWidthInput
            // 
            this.ui_boardWidthInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ui_boardWidthInput.DecimalPlaces = 2;
            this.ui_boardWidthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ui_boardWidthInput.Location = new System.Drawing.Point(3, 3);
            this.ui_boardWidthInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ui_boardWidthInput.Name = "ui_boardWidthInput";
            this.ui_boardWidthInput.Size = new System.Drawing.Size(75, 24);
            this.ui_boardWidthInput.TabIndex = 11;
            this.ui_boardWidthInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ui_boardWidthInput.Value = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
            this.ui_boardWidthInput.ValueChanged += new System.EventHandler(this.ui_boardWidthInput_ValueChanged);
            // 
            // ui_boardHeightInput
            // 
            this.ui_boardHeightInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ui_boardHeightInput.DecimalPlaces = 2;
            this.ui_boardHeightInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ui_boardHeightInput.Location = new System.Drawing.Point(3, 33);
            this.ui_boardHeightInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ui_boardHeightInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ui_boardHeightInput.Name = "ui_boardHeightInput";
            this.ui_boardHeightInput.Size = new System.Drawing.Size(75, 24);
            this.ui_boardHeightInput.TabIndex = 12;
            this.ui_boardHeightInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ui_boardHeightInput.Value = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
            this.ui_boardHeightInput.ValueChanged += new System.EventHandler(this.ui_boardHeightInput_ValueChanged);
            // 
            // ui_stepHorizontalInput
            // 
            this.ui_stepHorizontalInput.DecimalPlaces = 5;
            this.ui_stepHorizontalInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ui_stepHorizontalInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.ui_stepHorizontalInput.Location = new System.Drawing.Point(3, 73);
            this.ui_stepHorizontalInput.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ui_stepHorizontalInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.ui_stepHorizontalInput.Name = "ui_stepHorizontalInput";
            this.ui_stepHorizontalInput.Size = new System.Drawing.Size(75, 24);
            this.ui_stepHorizontalInput.TabIndex = 15;
            this.ui_stepHorizontalInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ui_stepHorizontalInput.Value = new decimal(new int[] {
            8467,
            0,
            0,
            327680});
            this.ui_stepHorizontalInput.ValueChanged += new System.EventHandler(this.ui_stepHorizontalInput_ValueChanged);
            // 
            // ui_stepHorizontalText
            // 
            this.ui_stepHorizontalText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ui_stepHorizontalText.AutoSize = true;
            this.ui_stepHorizontalText.CausesValidation = false;
            this.ui_stepHorizontalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ui_stepHorizontalText.Location = new System.Drawing.Point(81, 76);
            this.ui_stepHorizontalText.Margin = new System.Windows.Forms.Padding(0);
            this.ui_stepHorizontalText.Name = "ui_stepHorizontalText";
            this.ui_stepHorizontalText.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ui_stepHorizontalText.Size = new System.Drawing.Size(108, 17);
            this.ui_stepHorizontalText.TabIndex = 16;
            this.ui_stepHorizontalText.Text = "Horizontal step";
            // 
            // ui_stepVerticalInput
            // 
            this.ui_stepVerticalInput.DecimalPlaces = 5;
            this.ui_stepVerticalInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ui_stepVerticalInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.ui_stepVerticalInput.Location = new System.Drawing.Point(3, 103);
            this.ui_stepVerticalInput.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ui_stepVerticalInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.ui_stepVerticalInput.Name = "ui_stepVerticalInput";
            this.ui_stepVerticalInput.Size = new System.Drawing.Size(75, 24);
            this.ui_stepVerticalInput.TabIndex = 17;
            this.ui_stepVerticalInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ui_stepVerticalInput.Value = new decimal(new int[] {
            8467,
            0,
            0,
            327680});
            this.ui_stepVerticalInput.ValueChanged += new System.EventHandler(this.ui_stepVerticalInput_ValueChanged);
            // 
            // ui_stepVerticalText
            // 
            this.ui_stepVerticalText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ui_stepVerticalText.AutoSize = true;
            this.ui_stepVerticalText.CausesValidation = false;
            this.ui_stepVerticalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ui_stepVerticalText.Location = new System.Drawing.Point(81, 106);
            this.ui_stepVerticalText.Margin = new System.Windows.Forms.Padding(0);
            this.ui_stepVerticalText.Name = "ui_stepVerticalText";
            this.ui_stepVerticalText.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ui_stepVerticalText.Size = new System.Drawing.Size(91, 17);
            this.ui_stepVerticalText.TabIndex = 18;
            this.ui_stepVerticalText.Text = "Vertical step";
            // 
            // ui_dpiInput
            // 
            this.ui_dpiInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ui_dpiInput.Location = new System.Drawing.Point(3, 143);
            this.ui_dpiInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ui_dpiInput.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ui_dpiInput.Name = "ui_dpiInput";
            this.ui_dpiInput.Size = new System.Drawing.Size(75, 24);
            this.ui_dpiInput.TabIndex = 19;
            this.ui_dpiInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ui_dpiInput.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.ui_dpiInput.ValueChanged += new System.EventHandler(this.ui_dpiInput_ValueChanged);
            // 
            // ui_dpiText
            // 
            this.ui_dpiText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ui_dpiText.AutoSize = true;
            this.ui_dpiText.CausesValidation = false;
            this.ui_dpiText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ui_dpiText.Location = new System.Drawing.Point(81, 146);
            this.ui_dpiText.Margin = new System.Windows.Forms.Padding(0);
            this.ui_dpiText.Name = "ui_dpiText";
            this.ui_dpiText.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ui_dpiText.Size = new System.Drawing.Size(112, 17);
            this.ui_dpiText.TabIndex = 20;
            this.ui_dpiText.Text = "Input image DPI";
            // 
            // ui_useDPIcheckbox
            // 
            this.ui_useDPIcheckbox.AutoSize = true;
            this.ui_toolTable.SetColumnSpan(this.ui_useDPIcheckbox, 2);
            this.ui_useDPIcheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ui_useDPIcheckbox.Location = new System.Drawing.Point(3, 173);
            this.ui_useDPIcheckbox.Name = "ui_useDPIcheckbox";
            this.ui_useDPIcheckbox.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.ui_useDPIcheckbox.Size = new System.Drawing.Size(215, 21);
            this.ui_useDPIcheckbox.TabIndex = 21;
            this.ui_useDPIcheckbox.Text = "Calculate board size from DPI";
            this.ui_useDPIcheckbox.UseVisualStyleBackColor = true;
            this.ui_useDPIcheckbox.CheckedChanged += new System.EventHandler(this.ui_useDPIcheckbox_CheckedChanged);
            // 
            // ui_tileHorizontalInput
            // 
            this.ui_tileHorizontalInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ui_tileHorizontalInput.Location = new System.Drawing.Point(3, 210);
            this.ui_tileHorizontalInput.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.ui_tileHorizontalInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ui_tileHorizontalInput.Name = "ui_tileHorizontalInput";
            this.ui_tileHorizontalInput.Size = new System.Drawing.Size(75, 24);
            this.ui_tileHorizontalInput.TabIndex = 22;
            this.ui_tileHorizontalInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ui_tileHorizontalInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ui_tileHorizontalInput.ValueChanged += new System.EventHandler(this.ui_tileHorizontalInput_ValueChanged);
            // 
            // ui_tileHorizontalText
            // 
            this.ui_tileHorizontalText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ui_tileHorizontalText.AutoSize = true;
            this.ui_tileHorizontalText.CausesValidation = false;
            this.ui_tileHorizontalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ui_tileHorizontalText.Location = new System.Drawing.Point(81, 213);
            this.ui_tileHorizontalText.Margin = new System.Windows.Forms.Padding(0);
            this.ui_tileHorizontalText.Name = "ui_tileHorizontalText";
            this.ui_tileHorizontalText.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ui_tileHorizontalText.Size = new System.Drawing.Size(106, 17);
            this.ui_tileHorizontalText.TabIndex = 23;
            this.ui_tileHorizontalText.Text = "Horizontal tiles";
            // 
            // ui_tileVerticalInput
            // 
            this.ui_tileVerticalInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ui_tileVerticalInput.Location = new System.Drawing.Point(3, 240);
            this.ui_tileVerticalInput.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.ui_tileVerticalInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ui_tileVerticalInput.Name = "ui_tileVerticalInput";
            this.ui_tileVerticalInput.Size = new System.Drawing.Size(75, 24);
            this.ui_tileVerticalInput.TabIndex = 24;
            this.ui_tileVerticalInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ui_tileVerticalInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ui_tileVerticalInput.ValueChanged += new System.EventHandler(this.ui_tileVerticalInput_ValueChanged);
            // 
            // ui_tileVerticalText
            // 
            this.ui_tileVerticalText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ui_tileVerticalText.AutoSize = true;
            this.ui_tileVerticalText.CausesValidation = false;
            this.ui_tileVerticalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ui_tileVerticalText.Location = new System.Drawing.Point(81, 243);
            this.ui_tileVerticalText.Margin = new System.Windows.Forms.Padding(0);
            this.ui_tileVerticalText.Name = "ui_tileVerticalText";
            this.ui_tileVerticalText.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ui_tileVerticalText.Size = new System.Drawing.Size(89, 17);
            this.ui_tileVerticalText.TabIndex = 25;
            this.ui_tileVerticalText.Text = "Vertical tiles";
            // 
            // ui_tileBorderInput
            // 
            this.ui_tileBorderInput.DecimalPlaces = 1;
            this.ui_tileBorderInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ui_tileBorderInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ui_tileBorderInput.Location = new System.Drawing.Point(3, 270);
            this.ui_tileBorderInput.Name = "ui_tileBorderInput";
            this.ui_tileBorderInput.Size = new System.Drawing.Size(75, 24);
            this.ui_tileBorderInput.TabIndex = 26;
            this.ui_tileBorderInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ui_tileBorderInput.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.ui_tileBorderInput.ValueChanged += new System.EventHandler(this.ui_tileBorderInput_ValueChanged);
            // 
            // ui_tileBorderText
            // 
            this.ui_tileBorderText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ui_tileBorderText.AutoSize = true;
            this.ui_tileBorderText.CausesValidation = false;
            this.ui_tileBorderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ui_tileBorderText.Location = new System.Drawing.Point(81, 273);
            this.ui_tileBorderText.Margin = new System.Windows.Forms.Padding(0);
            this.ui_tileBorderText.Name = "ui_tileBorderText";
            this.ui_tileBorderText.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ui_tileBorderText.Size = new System.Drawing.Size(56, 17);
            this.ui_tileBorderText.TabIndex = 27;
            this.ui_tileBorderText.Text = "Border";
            // 
            // ui_inverseProcessCheckbox
            // 
            this.ui_inverseProcessCheckbox.AutoSize = true;
            this.ui_toolTable.SetColumnSpan(this.ui_inverseProcessCheckbox, 2);
            this.ui_inverseProcessCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ui_inverseProcessCheckbox.Location = new System.Drawing.Point(3, 368);
            this.ui_inverseProcessCheckbox.Name = "ui_inverseProcessCheckbox";
            this.ui_inverseProcessCheckbox.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.ui_inverseProcessCheckbox.Size = new System.Drawing.Size(142, 21);
            this.ui_inverseProcessCheckbox.TabIndex = 28;
            this.ui_inverseProcessCheckbox.Text = "Inverse process";
            this.ui_inverseProcessCheckbox.UseVisualStyleBackColor = true;
            this.ui_inverseProcessCheckbox.CheckedChanged += new System.EventHandler(this.ui_inverseProcessCheckbox_CheckedChanged);
            // 
            // ui_exposedColorButton
            // 
            this.ui_exposedColorButton.BackColor = System.Drawing.Color.Chartreuse;
            this.ui_exposedColorButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ui_exposedColorButton.Location = new System.Drawing.Point(15, 310);
            this.ui_exposedColorButton.Margin = new System.Windows.Forms.Padding(15, 3, 3, 1);
            this.ui_exposedColorButton.Name = "ui_exposedColorButton";
            this.ui_exposedColorButton.Size = new System.Drawing.Size(60, 25);
            this.ui_exposedColorButton.TabIndex = 29;
            this.ui_exposedColorButton.UseVisualStyleBackColor = false;
            this.ui_exposedColorButton.Click += new System.EventHandler(this.ui_exposedColorButton_Click);
            // 
            // ui_exposedColorText
            // 
            this.ui_exposedColorText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ui_exposedColorText.AutoSize = true;
            this.ui_exposedColorText.CausesValidation = false;
            this.ui_exposedColorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ui_exposedColorText.Location = new System.Drawing.Point(81, 313);
            this.ui_exposedColorText.Margin = new System.Windows.Forms.Padding(0);
            this.ui_exposedColorText.Name = "ui_exposedColorText";
            this.ui_exposedColorText.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ui_exposedColorText.Size = new System.Drawing.Size(102, 17);
            this.ui_exposedColorText.TabIndex = 31;
            this.ui_exposedColorText.Text = "Exposed color";
            // 
            // ui_nonexposedColorText
            // 
            this.ui_nonexposedColorText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ui_nonexposedColorText.AutoSize = true;
            this.ui_nonexposedColorText.CausesValidation = false;
            this.ui_nonexposedColorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ui_nonexposedColorText.Location = new System.Drawing.Point(81, 342);
            this.ui_nonexposedColorText.Margin = new System.Windows.Forms.Padding(0);
            this.ui_nonexposedColorText.Name = "ui_nonexposedColorText";
            this.ui_nonexposedColorText.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ui_nonexposedColorText.Size = new System.Drawing.Size(127, 17);
            this.ui_nonexposedColorText.TabIndex = 32;
            this.ui_nonexposedColorText.Text = "Nonexposed color";
            // 
            // ui_inputBitmapInfo
            // 
            this.ui_inputBitmapInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.ui_inputBitmapInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ui_inputBitmapInfo.Location = new System.Drawing.Point(10, 210);
            this.ui_inputBitmapInfo.Margin = new System.Windows.Forms.Padding(0);
            this.ui_inputBitmapInfo.Name = "ui_inputBitmapInfo";
            this.ui_inputBitmapInfo.Padding = new System.Windows.Forms.Padding(3);
            this.ui_inputBitmapInfo.Size = new System.Drawing.Size(218, 63);
            this.ui_inputBitmapInfo.TabIndex = 2;
            this.ui_inputBitmapInfo.Text = "Input image info";
            this.ui_inputBitmapInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ui_inputBitmap
            // 
            this.ui_inputBitmap.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ui_inputBitmap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ui_inputBitmap.Dock = System.Windows.Forms.DockStyle.Top;
            this.ui_inputBitmap.Location = new System.Drawing.Point(10, 10);
            this.ui_inputBitmap.Margin = new System.Windows.Forms.Padding(0);
            this.ui_inputBitmap.Name = "ui_inputBitmap";
            this.ui_inputBitmap.Size = new System.Drawing.Size(218, 200);
            this.ui_inputBitmap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ui_inputBitmap.TabIndex = 1;
            this.ui_inputBitmap.TabStop = false;
            this.ui_inputBitmap.WaitOnLoad = true;
            // 
            // ui_workBitmapLayoutTable
            // 
            this.ui_workBitmapLayoutTable.AutoSize = true;
            this.ui_workBitmapLayoutTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ui_workBitmapLayoutTable.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ui_workBitmapLayoutTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ui_workBitmapLayoutTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.ui_workBitmapLayoutTable.ColumnCount = 1;
            this.ui_workBitmapLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ui_workBitmapLayoutTable.Controls.Add(this.ui_workBitmap, 0, 0);
            this.ui_workBitmapLayoutTable.Controls.Add(this.ui_workBitmapInfo, 0, 1);
            this.ui_workBitmapLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_workBitmapLayoutTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.ui_workBitmapLayoutTable.Location = new System.Drawing.Point(0, 0);
            this.ui_workBitmapLayoutTable.Name = "ui_workBitmapLayoutTable";
            this.ui_workBitmapLayoutTable.RowCount = 2;
            this.ui_workBitmapLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ui_workBitmapLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.ui_workBitmapLayoutTable.Size = new System.Drawing.Size(762, 758);
            this.ui_workBitmapLayoutTable.TabIndex = 0;
            // 
            // ui_workBitmap
            // 
            this.ui_workBitmap.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ui_workBitmap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ui_workBitmap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_workBitmap.Location = new System.Drawing.Point(9, 9);
            this.ui_workBitmap.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.ui_workBitmap.Name = "ui_workBitmap";
            this.ui_workBitmap.Size = new System.Drawing.Size(744, 722);
            this.ui_workBitmap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ui_workBitmap.TabIndex = 2;
            this.ui_workBitmap.TabStop = false;
            // 
            // ui_workBitmapInfo
            // 
            this.ui_workBitmapInfo.AutoSize = true;
            this.ui_workBitmapInfo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ui_workBitmapInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_workBitmapInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ui_workBitmapInfo.Location = new System.Drawing.Point(1, 732);
            this.ui_workBitmapInfo.Margin = new System.Windows.Forms.Padding(0);
            this.ui_workBitmapInfo.Name = "ui_workBitmapInfo";
            this.ui_workBitmapInfo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ui_workBitmapInfo.Size = new System.Drawing.Size(760, 25);
            this.ui_workBitmapInfo.TabIndex = 0;
            this.ui_workBitmapInfo.Text = "Work bitmap info";
            this.ui_workBitmapInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 760);
            this.Controls.Add(this.ui_splitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UI";
            this.Text = "PCB Converter 0.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ui_FormClosing);
            this.ui_splitContainer.Panel1.ResumeLayout(false);
            this.ui_splitContainer.Panel2.ResumeLayout(false);
            this.ui_splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ui_splitContainer)).EndInit();
            this.ui_splitContainer.ResumeLayout(false);
            this.ui_toolPanel.ResumeLayout(false);
            this.ui_toolTable.ResumeLayout(false);
            this.ui_toolTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ui_boardWidthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ui_boardHeightInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ui_stepHorizontalInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ui_stepVerticalInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ui_dpiInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ui_tileHorizontalInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ui_tileVerticalInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ui_tileBorderInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ui_inputBitmap)).EndInit();
            this.ui_workBitmapLayoutTable.ResumeLayout(false);
            this.ui_workBitmapLayoutTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ui_workBitmap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer ui_splitContainer;
        private System.Windows.Forms.Panel ui_toolPanel;
        private System.Windows.Forms.Label ui_inputBitmapInfo;
        private System.Windows.Forms.TableLayoutPanel ui_toolTable;
        private System.Windows.Forms.Label ui_boardWidthText;
        private System.Windows.Forms.NumericUpDown ui_boardWidthInput;
        private System.Windows.Forms.NumericUpDown ui_boardHeightInput;
        private System.Windows.Forms.Label ui_boardHeightText;
        private System.Windows.Forms.NumericUpDown ui_stepHorizontalInput;
        private System.Windows.Forms.Label ui_stepHorizontalText;
        private System.Windows.Forms.NumericUpDown ui_stepVerticalInput;
        private System.Windows.Forms.Label ui_stepVerticalText;
        private System.Windows.Forms.NumericUpDown ui_dpiInput;
        private System.Windows.Forms.Label ui_dpiText;
        private System.Windows.Forms.CheckBox ui_useDPIcheckbox;
        private System.Windows.Forms.NumericUpDown ui_tileHorizontalInput;
        private System.Windows.Forms.Label ui_tileHorizontalText;
        private System.Windows.Forms.NumericUpDown ui_tileVerticalInput;
        private System.Windows.Forms.Label ui_tileVerticalText;
        private System.Windows.Forms.NumericUpDown ui_tileBorderInput;
        private System.Windows.Forms.Label ui_tileBorderText;
        private System.Windows.Forms.Button ui_nonexposedColorButton;
        private System.Windows.Forms.CheckBox ui_inverseProcessCheckbox;
        private System.Windows.Forms.Button ui_exposedColorButton;
        private System.Windows.Forms.Label ui_exposedColorText;
        private System.Windows.Forms.Label ui_nonexposedColorText;
        private System.Windows.Forms.TableLayoutPanel ui_workBitmapLayoutTable;
        private System.Windows.Forms.Label ui_workBitmapInfo;
        private System.Windows.Forms.Button ui_saveButton;
        private System.Windows.Forms.Button ui_openButton;
        protected System.Windows.Forms.PictureBox ui_inputBitmap;
        private System.Windows.Forms.PictureBox ui_workBitmap;
    }
}