namespace databaseCreate
{
    partial class MyClient
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
            this.components = new System.ComponentModel.Container();
            this._sendButton = new System.Windows.Forms.Button();
            this._labelAdress = new System.Windows.Forms.Label();
            this._adressTextBox = new System.Windows.Forms.TextBox();
            this._labelTypeEvent = new System.Windows.Forms.Label();
            this._listTypeEvent = new System.Windows.Forms.ComboBox();
            this._bsTypeEvent = new System.Windows.Forms.BindingSource(this.components);
            this._labelLevel = new System.Windows.Forms.Label();
            this._listLevel = new System.Windows.Forms.ComboBox();
            this._bsLevelImportance = new System.Windows.Forms.BindingSource(this.components);
            this._message = new System.Windows.Forms.Label();
            this._textBoxMessage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._bsTypeEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bsLevelImportance)).BeginInit();
            this.SuspendLayout();
            // 
            // _sendButton
            // 
            this._sendButton.Location = new System.Drawing.Point(97, 228);
            this._sendButton.Name = "_sendButton";
            this._sendButton.Size = new System.Drawing.Size(75, 23);
            this._sendButton.TabIndex = 0;
            this._sendButton.Text = "Send";
            this._sendButton.UseVisualStyleBackColor = true;
            this._sendButton.Click += new System.EventHandler(this._sendButton_Click);
            // 
            // _labelAdress
            // 
            this._labelAdress.AutoSize = true;
            this._labelAdress.Location = new System.Drawing.Point(12, 21);
            this._labelAdress.Name = "_labelAdress";
            this._labelAdress.Size = new System.Drawing.Size(69, 13);
            this._labelAdress.TabIndex = 1;
            this._labelAdress.Text = "Adress WCF:";
            // 
            // _adressTextBox
            // 
            this._adressTextBox.Location = new System.Drawing.Point(106, 18);
            this._adressTextBox.Name = "_adressTextBox";
            this._adressTextBox.Size = new System.Drawing.Size(169, 20);
            this._adressTextBox.TabIndex = 2;
            // 
            // _labelTypeEvent
            // 
            this._labelTypeEvent.AutoSize = true;
            this._labelTypeEvent.Location = new System.Drawing.Point(12, 56);
            this._labelTypeEvent.Name = "_labelTypeEvent";
            this._labelTypeEvent.Size = new System.Drawing.Size(65, 13);
            this._labelTypeEvent.TabIndex = 3;
            this._labelTypeEvent.Text = "Type Event:";
            // 
            // _listTypeEvent
            // 
            this._listTypeEvent.DataSource = this._bsTypeEvent;
            this._listTypeEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._listTypeEvent.FormattingEnabled = true;
            this._listTypeEvent.Location = new System.Drawing.Point(106, 53);
            this._listTypeEvent.Name = "_listTypeEvent";
            this._listTypeEvent.Size = new System.Drawing.Size(169, 21);
            this._listTypeEvent.TabIndex = 4;
            // 
            // _labelLevel
            // 
            this._labelLevel.AutoSize = true;
            this._labelLevel.Location = new System.Drawing.Point(12, 85);
            this._labelLevel.Name = "_labelLevel";
            this._labelLevel.Size = new System.Drawing.Size(92, 13);
            this._labelLevel.TabIndex = 5;
            this._labelLevel.Text = "Level Importance:";
            // 
            // _listLevel
            // 
            this._listLevel.DataSource = this._bsLevelImportance;
            this._listLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._listLevel.FormattingEnabled = true;
            this._listLevel.Location = new System.Drawing.Point(106, 82);
            this._listLevel.Name = "_listLevel";
            this._listLevel.Size = new System.Drawing.Size(169, 21);
            this._listLevel.TabIndex = 6;
            // 
            // _message
            // 
            this._message.AutoSize = true;
            this._message.Location = new System.Drawing.Point(12, 115);
            this._message.Name = "_message";
            this._message.Size = new System.Drawing.Size(53, 13);
            this._message.TabIndex = 7;
            this._message.Text = "Message:";
            // 
            // _textBoxMessage
            // 
            this._textBoxMessage.Location = new System.Drawing.Point(106, 115);
            this._textBoxMessage.Multiline = true;
            this._textBoxMessage.Name = "_textBoxMessage";
            this._textBoxMessage.Size = new System.Drawing.Size(169, 83);
            this._textBoxMessage.TabIndex = 8;
            // 
            // MyClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 273);
            this.Controls.Add(this._textBoxMessage);
            this.Controls.Add(this._message);
            this.Controls.Add(this._listLevel);
            this.Controls.Add(this._labelLevel);
            this.Controls.Add(this._listTypeEvent);
            this.Controls.Add(this._labelTypeEvent);
            this.Controls.Add(this._adressTextBox);
            this.Controls.Add(this._labelAdress);
            this.Controls.Add(this._sendButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MyClient";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WCFClient";
            this.Load += new System.EventHandler(this.MyClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this._bsTypeEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bsLevelImportance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _sendButton;
        private System.Windows.Forms.Label _labelAdress;
        private System.Windows.Forms.TextBox _adressTextBox;
        private System.Windows.Forms.Label _labelTypeEvent;
        private System.Windows.Forms.ComboBox _listTypeEvent;
        private System.Windows.Forms.Label _labelLevel;
        private System.Windows.Forms.ComboBox _listLevel;
        private System.Windows.Forms.Label _message;
        private System.Windows.Forms.TextBox _textBoxMessage;
        private System.Windows.Forms.BindingSource _bsTypeEvent;
        private System.Windows.Forms.BindingSource _bsLevelImportance;
    }
}

