namespace FilmLibrary.App
{
    partial class IndexForm
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
            ListViewItem listViewItem6 = new ListViewItem("Title");
            ListViewItem listViewItem7 = new ListViewItem("Rating");
            ListViewItem listViewItem8 = new ListViewItem("Description");
            ListViewItem listViewItem9 = new ListViewItem("Director");
            ListViewItem listViewItem10 = new ListViewItem("Release date");
            txtSearch = new TextBox();
            btnClear = new Button();
            lvFilmList = new ListView();
            btnNew = new Button();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(24, 21);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(473, 30);
            txtSearch.TabIndex = 0;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(519, 21);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(105, 32);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lvFilmList
            // 
            lvFilmList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvFilmList.GridLines = true;
            lvFilmList.Items.AddRange(new ListViewItem[] { listViewItem6, listViewItem7, listViewItem8, listViewItem9, listViewItem10 });
            lvFilmList.Location = new Point(24, 80);
            lvFilmList.Name = "lvFilmList";
            lvFilmList.Size = new Size(1190, 784);
            lvFilmList.TabIndex = 2;
            lvFilmList.UseCompatibleStateImageBehavior = false;
            lvFilmList.View = View.Details;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnNew.Location = new Point(1109, 17);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(105, 32);
            btnNew.TabIndex = 3;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // IndexForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 890);
            Controls.Add(btnNew);
            Controls.Add(lvFilmList);
            Controls.Add(btnClear);
            Controls.Add(txtSearch);
            Name = "IndexForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Film Library | ver 1.0";
            Load += IndexForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Button btnClear;
        private ListView lvFilmList;
        private Button btnNew;
    }
}