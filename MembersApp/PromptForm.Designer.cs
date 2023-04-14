namespace MembersApp
{
    partial class PromptForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            okButton = new Button();
            cancelButton = new Button();
            labelLabel = new Label();
            valueTextBox = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(okButton, 1, 2);
            tableLayoutPanel1.Controls.Add(cancelButton, 2, 2);
            tableLayoutPanel1.Controls.Add(labelLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(valueTextBox, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(8, 8);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0000076F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(599, 164);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // okButton
            // 
            okButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(363, 125);
            okButton.Margin = new Padding(2);
            okButton.Name = "okButton";
            okButton.Size = new Size(115, 36);
            okButton.TabIndex = 0;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(482, 125);
            cancelButton.Margin = new Padding(2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(115, 36);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // labelLabel
            // 
            labelLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelLabel.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(labelLabel, 3);
            labelLabel.Location = new Point(0, 36);
            labelLabel.Margin = new Padding(0);
            labelLabel.Name = "labelLabel";
            labelLabel.Size = new Size(599, 25);
            labelLabel.TabIndex = 2;
            labelLabel.Text = "label1";
            // 
            // valueTextBox
            // 
            valueTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(valueTextBox, 3);
            valueTextBox.HideSelection = false;
            valueTextBox.Location = new Point(2, 63);
            valueTextBox.Margin = new Padding(2);
            valueTextBox.Name = "valueTextBox";
            valueTextBox.Size = new Size(595, 31);
            valueTextBox.TabIndex = 1;
            // 
            // PromptForm
            // 
            AcceptButton = okButton;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(615, 180);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "PromptForm";
            Padding = new Padding(8);
            Text = "PromptForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button okButton;
        private Button cancelButton;
        private Label labelLabel;
        private TextBox valueTextBox;
    }
}