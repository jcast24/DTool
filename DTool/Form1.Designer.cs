namespace DTool;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        treeView1 = new System.Windows.Forms.TreeView();
        listView1 = new System.Windows.Forms.ListView();
        columnHeader1 = new System.Windows.Forms.ColumnHeader();
        splitter1 = new System.Windows.Forms.Splitter();
        SuspendLayout();
        // 
        // treeView1
        // 
        treeView1.Dock = System.Windows.Forms.DockStyle.Left;
        treeView1.Location = new System.Drawing.Point(0, 0);
        treeView1.Name = "treeView1";
        treeView1.Size = new System.Drawing.Size(216, 450);
        treeView1.TabIndex = 0;
        // 
        // listView1
        // 
        listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1 });
        listView1.Dock = System.Windows.Forms.DockStyle.Fill;
        listView1.Location = new System.Drawing.Point(216, 0);
        listView1.Name = "listView1";
        listView1.Size = new System.Drawing.Size(584, 450);
        listView1.TabIndex = 1;
        listView1.UseCompatibleStateImageBehavior = false;
        listView1.View = System.Windows.Forms.View.Details;
        listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
        // 
        // columnHeader1
        // 
        columnHeader1.Name = "columnHeader1";
        columnHeader1.Text = "File Name";
        columnHeader1.Width = 200;
        // 
        // splitter1
        // 
        splitter1.Location = new System.Drawing.Point(216, 0);
        splitter1.Name = "splitter1";
        splitter1.Size = new System.Drawing.Size(6, 450);
        splitter1.TabIndex = 2;
        splitter1.TabStop = false;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(splitter1);
        Controls.Add(listView1);
        Controls.Add(treeView1);
        Text = "File Browser";
        Load += Form1_Load;
        ResumeLayout(false);
    }

    private System.Windows.Forms.ColumnHeader columnHeader1;

    private System.Windows.Forms.Splitter splitter1;

    private System.Windows.Forms.ListView listView1;

    private System.Windows.Forms.TreeView treeView1;

    #endregion
}