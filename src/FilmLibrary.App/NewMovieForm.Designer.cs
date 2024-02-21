namespace FilmLibrary.App
{
    partial class NewMovieForm
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
            txtIMDBSearch = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtReleaseDate = new TextBox();
            label3 = new Label();
            txtTitle = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtIMDBRating = new TextBox();
            label6 = new Label();
            txtGenre = new TextBox();
            label7 = new Label();
            txtDirector = new TextBox();
            label8 = new Label();
            txtActors = new TextBox();
            rtxtDescription = new RichTextBox();
            btnSave = new Button();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // txtIMDBSearch
            // 
            txtIMDBSearch.Location = new Point(12, 48);
            txtIMDBSearch.Name = "txtIMDBSearch";
            txtIMDBSearch.Size = new Size(406, 30);
            txtIMDBSearch.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(108, 23);
            label1.TabIndex = 1;
            label1.Text = "IMDB Search";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 382);
            label2.Name = "label2";
            label2.Size = new Size(106, 23);
            label2.TabIndex = 3;
            label2.Text = "Release date";
            // 
            // txtReleaseDate
            // 
            txtReleaseDate.Location = new Point(12, 420);
            txtReleaseDate.Name = "txtReleaseDate";
            txtReleaseDate.Size = new Size(406, 30);
            txtReleaseDate.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 96);
            label3.Name = "label3";
            label3.Size = new Size(42, 23);
            label3.TabIndex = 5;
            label3.Text = "Title";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(12, 134);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(406, 30);
            txtTitle.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 189);
            label4.Name = "label4";
            label4.Size = new Size(96, 23);
            label4.TabIndex = 7;
            label4.Text = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(424, 96);
            label5.Name = "label5";
            label5.Size = new Size(106, 23);
            label5.TabIndex = 9;
            label5.Text = "IMDB Rating";
            // 
            // txtIMDBRating
            // 
            txtIMDBRating.Location = new Point(424, 134);
            txtIMDBRating.Name = "txtIMDBRating";
            txtIMDBRating.Size = new Size(168, 30);
            txtIMDBRating.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 466);
            label6.Name = "label6";
            label6.Size = new Size(56, 23);
            label6.TabIndex = 11;
            label6.Text = "Genre";
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(12, 504);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(406, 30);
            txtGenre.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 556);
            label7.Name = "label7";
            label7.Size = new Size(71, 23);
            label7.TabIndex = 13;
            label7.Text = "Director";
            // 
            // txtDirector
            // 
            txtDirector.Location = new Point(12, 594);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(406, 30);
            txtDirector.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 646);
            label8.Name = "label8";
            label8.Size = new Size(58, 23);
            label8.TabIndex = 15;
            label8.Text = "Actors";
            // 
            // txtActors
            // 
            txtActors.Location = new Point(12, 684);
            txtActors.Name = "txtActors";
            txtActors.Size = new Size(406, 30);
            txtActors.TabIndex = 14;
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(12, 225);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(594, 134);
            rtxtDescription.TabIndex = 16;
            rtxtDescription.Text = "";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 733);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(105, 32);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(424, 46);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(105, 32);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // NewMovieForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 775);
            Controls.Add(btnSearch);
            Controls.Add(btnSave);
            Controls.Add(rtxtDescription);
            Controls.Add(label8);
            Controls.Add(txtActors);
            Controls.Add(label7);
            Controls.Add(txtDirector);
            Controls.Add(label6);
            Controls.Add(txtGenre);
            Controls.Add(label5);
            Controls.Add(txtIMDBRating);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtTitle);
            Controls.Add(label2);
            Controls.Add(txtReleaseDate);
            Controls.Add(label1);
            Controls.Add(txtIMDBSearch);
            Name = "NewMovieForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "NewMovieForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIMDBSearch;
        private Label label1;
        private Label label2;
        private TextBox txtReleaseDate;
        private Label label3;
        private TextBox txtTitle;
        private Label label4;
        private Label label5;
        private TextBox txtIMDBRating;
        private Label label6;
        private TextBox txtGenre;
        private Label label7;
        private TextBox txtDirector;
        private Label label8;
        private TextBox txtActors;
        private RichTextBox rtxtDescription;
        private Button btnSave;
        private Button btnSearch;
    }
}