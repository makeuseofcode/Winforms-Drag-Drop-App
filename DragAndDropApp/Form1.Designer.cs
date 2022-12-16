
namespace DragAndDropApp
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
            this.dragDropPanel = new System.Windows.Forms.Panel();
            this.uploadedFilesList = new System.Windows.Forms.ListBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.dragDropPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dragDropPanel
            // 
            this.dragDropPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dragDropPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dragDropPanel.Controls.Add(this.uploadedFilesList);
            this.dragDropPanel.Location = new System.Drawing.Point(139, 136);
            this.dragDropPanel.Name = "dragDropPanel";
            this.dragDropPanel.Size = new System.Drawing.Size(600, 400);
            this.dragDropPanel.TabIndex = 0;
            this.dragDropPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDropPanel_DragDrop);
            this.dragDropPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragDropPanel_DragEnter);
            // 
            // uploadedFilesList
            // 
            this.uploadedFilesList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.uploadedFilesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uploadedFilesList.FormattingEnabled = true;
            this.uploadedFilesList.ItemHeight = 41;
            this.uploadedFilesList.Location = new System.Drawing.Point(51, 44);
            this.uploadedFilesList.Name = "uploadedFilesList";
            this.uploadedFilesList.Size = new System.Drawing.Size(500, 287);
            this.uploadedFilesList.TabIndex = 0;
            this.uploadedFilesList.Visible = false;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(546, 589);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(188, 58);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 894);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.dragDropPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.dragDropPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dragDropPanel;
        private System.Windows.Forms.ListBox uploadedFilesList;
        private System.Windows.Forms.Button clearButton;
    }
}

