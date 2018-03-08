namespace TaskList
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.taskTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.headerLabelTime = new System.Windows.Forms.Label();
            this.headerLabelEditor = new System.Windows.Forms.Label();
            this.headerLabelDestroyer = new System.Windows.Forms.Label();
            this.headerLabelName = new System.Windows.Forms.Label();
            this.taskGeneratorButton = new System.Windows.Forms.Button();
            this.taskTablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(489, 23);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 19);
            this.nameTextBox.TabIndex = 2;
            // 
            // timeTextBox
            // 
            this.timeTextBox.Location = new System.Drawing.Point(489, 66);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(100, 19);
            this.timeTextBox.TabIndex = 3;
            // 
            // taskTablePanel
            // 
            this.taskTablePanel.AutoScroll = true;
            this.taskTablePanel.AutoSize = true;
            this.taskTablePanel.ColumnCount = 4;
            this.taskTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.09119F));
            this.taskTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.09119F));
            this.taskTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.90881F));
            this.taskTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.90881F));
            this.taskTablePanel.Controls.Add(this.headerLabelTime, 1, 0);
            this.taskTablePanel.Controls.Add(this.headerLabelEditor, 2, 0);
            this.taskTablePanel.Controls.Add(this.headerLabelDestroyer, 3, 0);
            this.taskTablePanel.Controls.Add(this.headerLabelName, 0, 0);
            this.taskTablePanel.Location = new System.Drawing.Point(24, 23);
            this.taskTablePanel.Name = "taskTablePanel";
            this.taskTablePanel.RowCount = 1;
            this.taskTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.taskTablePanel.Size = new System.Drawing.Size(380, 90);
            this.taskTablePanel.TabIndex = 4;
            // 
            // headerLabelTime
            // 
            this.headerLabelTime.AutoSize = true;
            this.headerLabelTime.Location = new System.Drawing.Point(128, 0);
            this.headerLabelTime.Name = "headerLabelTime";
            this.headerLabelTime.Size = new System.Drawing.Size(29, 12);
            this.headerLabelTime.TabIndex = 5;
            this.headerLabelTime.Text = "期限";
            // 
            // headerLabelEditor
            // 
            this.headerLabelEditor.AutoSize = true;
            this.headerLabelEditor.Location = new System.Drawing.Point(253, 0);
            this.headerLabelEditor.Name = "headerLabelEditor";
            this.headerLabelEditor.Size = new System.Drawing.Size(56, 12);
            this.headerLabelEditor.TabIndex = 6;
            this.headerLabelEditor.Text = "編集ボタン";
            // 
            // headerLabelDestroyer
            // 
            this.headerLabelDestroyer.AutoSize = true;
            this.headerLabelDestroyer.Location = new System.Drawing.Point(317, 0);
            this.headerLabelDestroyer.Name = "headerLabelDestroyer";
            this.headerLabelDestroyer.Size = new System.Drawing.Size(56, 12);
            this.headerLabelDestroyer.TabIndex = 7;
            this.headerLabelDestroyer.Text = "削除ボタン";
            // 
            // headerLabelName
            // 
            this.headerLabelName.AutoSize = true;
            this.headerLabelName.Location = new System.Drawing.Point(3, 0);
            this.headerLabelName.Name = "headerLabelName";
            this.headerLabelName.Size = new System.Drawing.Size(29, 12);
            this.headerLabelName.TabIndex = 0;
            this.headerLabelName.Text = "名前";
            // 
            // taskGeneratorButton
            // 
            this.taskGeneratorButton.Location = new System.Drawing.Point(489, 132);
            this.taskGeneratorButton.Name = "taskGeneratorButton";
            this.taskGeneratorButton.Size = new System.Drawing.Size(100, 40);
            this.taskGeneratorButton.TabIndex = 5;
            this.taskGeneratorButton.Text = "Generate Task";
            this.taskGeneratorButton.UseVisualStyleBackColor = true;
            this.taskGeneratorButton.Click += new System.EventHandler(this.taskGeneratorButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 370);
            this.Controls.Add(this.taskGeneratorButton);
            this.Controls.Add(this.taskTablePanel);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.taskTablePanel.ResumeLayout(false);
            this.taskTablePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TableLayoutPanel taskTablePanel;
        private System.Windows.Forms.Label headerLabelTime;
        private System.Windows.Forms.Label headerLabelName;
        private System.Windows.Forms.Label headerLabelEditor;
        private System.Windows.Forms.Label headerLabelDestroyer;
        private System.Windows.Forms.Button taskGeneratorButton;
    }
}

