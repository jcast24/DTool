namespace DTool;

public partial class Form1 : Form
{
    public void ShowDrives()
    {
        treeView1.BeginUpdate();
        string[] drives = Directory.GetLogicalDrives();
        foreach (string adrive in drives)
        {
            TreeNode tn = new TreeNode(adrive);
            treeView1.Nodes.Add(tn);
        }
        
        treeView1.EndUpdate();
    }
    
    public Form1()
    {
        InitializeComponent();
    }

    private void listView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }
}