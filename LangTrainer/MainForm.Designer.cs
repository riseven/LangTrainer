namespace LangTrainer
{
    partial class MainForm
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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.configTabPage = new System.Windows.Forms.TabPage();
            this.textProcessingGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.processTextButton = new System.Windows.Forms.Button();
            this.dictionaryTabPage = new System.Windows.Forms.TabPage();
            this.dictionaryDataGridView = new System.Windows.Forms.DataGridView();
            this.IndexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrequencyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccumulatedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textProcessorWorker = new System.ComponentModel.BackgroundWorker();
            this.processProgressBar = new System.Windows.Forms.ProgressBar();
            this.mainTabControl.SuspendLayout();
            this.configTabPage.SuspendLayout();
            this.textProcessingGroupBox.SuspendLayout();
            this.dictionaryTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.configTabPage);
            this.mainTabControl.Controls.Add(this.dictionaryTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(784, 562);
            this.mainTabControl.TabIndex = 1;
            // 
            // configTabPage
            // 
            this.configTabPage.Controls.Add(this.textProcessingGroupBox);
            this.configTabPage.Location = new System.Drawing.Point(4, 33);
            this.configTabPage.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.configTabPage.Name = "configTabPage";
            this.configTabPage.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.configTabPage.Size = new System.Drawing.Size(776, 525);
            this.configTabPage.TabIndex = 0;
            this.configTabPage.Text = "Configuration";
            this.configTabPage.UseVisualStyleBackColor = true;
            // 
            // textProcessingGroupBox
            // 
            this.textProcessingGroupBox.Controls.Add(this.processProgressBar);
            this.textProcessingGroupBox.Controls.Add(this.textBox1);
            this.textProcessingGroupBox.Controls.Add(this.processTextButton);
            this.textProcessingGroupBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textProcessingGroupBox.Location = new System.Drawing.Point(238, 152);
            this.textProcessingGroupBox.Name = "textProcessingGroupBox";
            this.textProcessingGroupBox.Size = new System.Drawing.Size(245, 172);
            this.textProcessingGroupBox.TabIndex = 0;
            this.textProcessingGroupBox.TabStop = false;
            this.textProcessingGroupBox.Text = "Text processing";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(6, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 65);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Rebuild the dictionary by processing all text files found in the texts subfolder." +
                "";
            // 
            // processTextButton
            // 
            this.processTextButton.Location = new System.Drawing.Point(139, 136);
            this.processTextButton.Name = "processTextButton";
            this.processTextButton.Size = new System.Drawing.Size(100, 30);
            this.processTextButton.TabIndex = 0;
            this.processTextButton.Text = "Process";
            this.processTextButton.UseVisualStyleBackColor = true;
            this.processTextButton.Click += new System.EventHandler(this.processTextButton_Click);
            // 
            // dictionaryTabPage
            // 
            this.dictionaryTabPage.Controls.Add(this.dictionaryDataGridView);
            this.dictionaryTabPage.Location = new System.Drawing.Point(4, 33);
            this.dictionaryTabPage.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dictionaryTabPage.Name = "dictionaryTabPage";
            this.dictionaryTabPage.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dictionaryTabPage.Size = new System.Drawing.Size(776, 525);
            this.dictionaryTabPage.TabIndex = 1;
            this.dictionaryTabPage.Text = "Dictionary";
            this.dictionaryTabPage.UseVisualStyleBackColor = true;
            // 
            // dictionaryDataGridView
            // 
            this.dictionaryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dictionaryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IndexColumn,
            this.WordColumn,
            this.FrequencyColumn,
            this.AccumulatedColumn});
            this.dictionaryDataGridView.Location = new System.Drawing.Point(9, 8);
            this.dictionaryDataGridView.Name = "dictionaryDataGridView";
            this.dictionaryDataGridView.Size = new System.Drawing.Size(758, 509);
            this.dictionaryDataGridView.TabIndex = 0;
            // 
            // IndexColumn
            // 
            this.IndexColumn.HeaderText = "Index";
            this.IndexColumn.Name = "IndexColumn";
            this.IndexColumn.ReadOnly = true;
            // 
            // WordColumn
            // 
            this.WordColumn.HeaderText = "Word";
            this.WordColumn.Name = "WordColumn";
            this.WordColumn.ReadOnly = true;
            // 
            // FrequencyColumn
            // 
            this.FrequencyColumn.HeaderText = "Frequency (PPM)";
            this.FrequencyColumn.Name = "FrequencyColumn";
            this.FrequencyColumn.ReadOnly = true;
            this.FrequencyColumn.Width = 300;
            // 
            // AccumulatedColumn
            // 
            this.AccumulatedColumn.HeaderText = "Accumulated";
            this.AccumulatedColumn.Name = "AccumulatedColumn";
            this.AccumulatedColumn.ReadOnly = true;
            // 
            // textProcessorWorker
            // 
            this.textProcessorWorker.WorkerReportsProgress = true;
            this.textProcessorWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.textProcessorWorker_DoWork);
            this.textProcessorWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.textProcessorWorker_ProgressChanged);
            this.textProcessorWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.textProcessorWorker_RunWorkerCompleted);
            // 
            // processProgressBar
            // 
            this.processProgressBar.Location = new System.Drawing.Point(6, 107);
            this.processProgressBar.Name = "processProgressBar";
            this.processProgressBar.Size = new System.Drawing.Size(233, 23);
            this.processProgressBar.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.mainTabControl);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "MainForm";
            this.Text = "Languague Trainer";
            this.mainTabControl.ResumeLayout(false);
            this.configTabPage.ResumeLayout(false);
            this.textProcessingGroupBox.ResumeLayout(false);
            this.textProcessingGroupBox.PerformLayout();
            this.dictionaryTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage configTabPage;
        private System.Windows.Forms.TabPage dictionaryTabPage;
        private System.Windows.Forms.GroupBox textProcessingGroupBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button processTextButton;
        private System.Windows.Forms.DataGridView dictionaryDataGridView;
        private System.ComponentModel.BackgroundWorker textProcessorWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndexColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WordColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrequencyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccumulatedColumn;
        private System.Windows.Forms.ProgressBar processProgressBar;
    }
}

