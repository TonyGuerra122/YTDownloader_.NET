namespace YTDownloader {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            treeView1 = new TreeView();
            listView1 = new ListView();
            button1 = new Button();
            path = new TextBox();
            url = new TextBox();
            download_button = new Button();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 12);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(247, 246);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 275);
            listView1.Name = "listView1";
            listView1.Size = new Size(247, 134);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(631, 95);
            button1.Name = "button1";
            button1.Size = new Size(80, 23);
            button1.TabIndex = 2;
            button1.Text = "Browser";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // path
            // 
            path.Location = new Point(417, 95);
            path.Name = "path";
            path.PlaceholderText = "Caminho pra pasta de download";
            path.Size = new Size(208, 23);
            path.TabIndex = 3;
            // 
            // url
            // 
            url.Location = new Point(417, 184);
            url.Name = "url";
            url.PlaceholderText = "Insira a URL";
            url.Size = new Size(208, 23);
            url.TabIndex = 4;
            // 
            // download_button
            // 
            download_button.Location = new Point(631, 183);
            download_button.Name = "download_button";
            download_button.Size = new Size(75, 23);
            download_button.TabIndex = 5;
            download_button.Text = "Baixar";
            download_button.UseVisualStyleBackColor = true;
            download_button.Click += download_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(800, 450);
            Controls.Add(download_button);
            Controls.Add(url);
            Controls.Add(path);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(treeView1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private ListView listView1;
        private Button button1;
        private TextBox path;
        private TextBox url;
        private Button download_button;
    }
}