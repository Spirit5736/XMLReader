
namespace XMLReader
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TreeView = new System.Windows.Forms.TreeView();
            this.write_inn = new System.Windows.Forms.Label();
            this.downloadXMLButton = new System.Windows.Forms.Button();
            this.linkXmlTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TreeView
            // 
            this.TreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TreeView.Location = new System.Drawing.Point(36, 98);
            this.TreeView.Name = "TreeView";
            this.TreeView.Size = new System.Drawing.Size(654, 370);
            this.TreeView.TabIndex = 0;
            // 
            // write_inn
            // 
            this.write_inn.AutoSize = true;
            this.write_inn.Location = new System.Drawing.Point(33, 27);
            this.write_inn.Name = "write_inn";
            this.write_inn.Size = new System.Drawing.Size(161, 13);
            this.write_inn.TabIndex = 1;
            this.write_inn.Text = "Введите ссылку на XML файл ";
            // 
            // downloadXMLButton
            // 
            this.downloadXMLButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadXMLButton.Location = new System.Drawing.Point(615, 59);
            this.downloadXMLButton.Name = "downloadXMLButton";
            this.downloadXMLButton.Size = new System.Drawing.Size(75, 23);
            this.downloadXMLButton.TabIndex = 2;
            this.downloadXMLButton.Text = "Загрузить";
            this.downloadXMLButton.UseVisualStyleBackColor = true;
            this.downloadXMLButton.Click += new System.EventHandler(this.DownloadXMLButton_Click);
            // 
            // linkXmlTextBox
            // 
            this.linkXmlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkXmlTextBox.Location = new System.Drawing.Point(36, 59);
            this.linkXmlTextBox.Name = "linkXmlTextBox";
            this.linkXmlTextBox.Size = new System.Drawing.Size(573, 20);
            this.linkXmlTextBox.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 491);
            this.Controls.Add(this.linkXmlTextBox);
            this.Controls.Add(this.downloadXMLButton);
            this.Controls.Add(this.write_inn);
            this.Controls.Add(this.TreeView);
            this.MinimumSize = new System.Drawing.Size(750, 530);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XMLReader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView TreeView;
        private System.Windows.Forms.Label write_inn;
        private System.Windows.Forms.Button downloadXMLButton;
        private System.Windows.Forms.TextBox linkXmlTextBox;
    }
}

