namespace StudiHelper.UI
{
  partial class InfoForm
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
      this.close = new System.Windows.Forms.Button();
      this.titel = new System.Windows.Forms.Label();
      this.infoField = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // close
      // 
      this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.close.Location = new System.Drawing.Point(298, 256);
      this.close.Name = "close";
      this.close.Size = new System.Drawing.Size(75, 23);
      this.close.TabIndex = 0;
      this.close.Text = "Schließen";
      this.close.UseVisualStyleBackColor = true;
      this.close.Click += new System.EventHandler(this.close_Click);
      // 
      // titel
      // 
      this.titel.AutoSize = true;
      this.titel.Location = new System.Drawing.Point(12, 9);
      this.titel.Name = "titel";
      this.titel.Size = new System.Drawing.Size(27, 13);
      this.titel.TabIndex = 1;
      this.titel.Text = "Titel";
      // 
      // infoField
      // 
      this.infoField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.infoField.BackColor = System.Drawing.SystemColors.Info;
      this.infoField.Location = new System.Drawing.Point(15, 25);
      this.infoField.Multiline = true;
      this.infoField.Name = "infoField";
      this.infoField.ReadOnly = true;
      this.infoField.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.infoField.Size = new System.Drawing.Size(358, 225);
      this.infoField.TabIndex = 2;
      // 
      // InfoForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(385, 291);
      this.ControlBox = false;
      this.Controls.Add(this.infoField);
      this.Controls.Add(this.titel);
      this.Controls.Add(this.close);
      this.Name = "InfoForm";
      this.Text = "Info";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button close;
    private System.Windows.Forms.Label titel;
    private System.Windows.Forms.TextBox infoField;
  }
}