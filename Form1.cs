using YTDownloader.classes;
namespace YTDownloader {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            PopulateTreeView();

            treeView1.Visible = false;
            listView1.Visible = false;
        }

        private void PopulateTreeView() {
            string[] drives = Directory.GetLogicalDrives();

            foreach (string drive in drives) {

                TreeNode driveNode = new TreeNode(drive);
                treeView1.Nodes.Add(driveNode);
                PopulateDriveNode(driveNode);
            }
        }

        private void PopulateDriveNode(TreeNode driveNode) {
            string drivePath = driveNode.Text;
            try {
                string[] directories = Directory.GetDirectories(drivePath);
                foreach (string directory in directories) {
                    TreeNode directoryNode = new TreeNode(Path.GetFileName(directory));
                    driveNode.Nodes.Add(directoryNode);
                }
            }
            catch (UnauthorizedAccessException) {
                MessageBox.Show("Ocorreu um erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) {
            listView1.Items.Clear();
            if (e.Node is null) {
                return;
            }
            string selectedPath = e.Node.FullPath;

            try {
                string[] directories = Directory.GetDirectories(selectedPath);
                foreach (string directory in directories) {
                    ListViewItem item = new ListViewItem(Path.GetFileName(directory));
                    item.SubItems.Add("Folder");
                    listView1.Items.Add(item);
                }
                string[] files = Directory.GetFiles(selectedPath);
                foreach (string file in files) {
                    ListViewItem item = new ListViewItem(Path.GetFileName(file));
                    item.SubItems.Add("file");
                    listView1.Items.Add(item);
                }
            }
            catch (UnauthorizedAccessException) {
                MessageBox.Show("Ocorreu um Erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e) {

            treeView1.Visible = true;
            listView1.Visible = true;

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) {
            if (listView1.SelectedItems.Count > 0) {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string selectedFileName = selectedItem.Text;

                if (treeView1.SelectedNode != null) {
                    string selectedFolderPath = treeView1.SelectedNode.FullPath;
                    string selectedFilePath = Path.Combine(selectedFolderPath, selectedFileName);
                    // Agora você tem o caminho completo do item selecionado no ListView
                    // Faça o que precisar com esse caminho

                    path.Text = selectedFilePath;
                }
            }
        }

        private async void download_button_Click(object sender, EventArgs e) {
            if(url == null) {
                MessageBox.Show("Preencha a URL", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

          

            await Downloader.Download(url.Text, path.Text);

        }
    }
}