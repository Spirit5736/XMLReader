using System;
using System.Windows.Forms;
using System.Xml;


namespace XMLReader
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }        

        private void DownloadXMLButton_Click(object sender, EventArgs e)
        {
            FillTreeView();
        }

        #region Filling TreeView methods
        private void AddTreeNode(XmlNode xmlNode, TreeNode treeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList xNodeList;          
            if (xmlNode.HasChildNodes)
            {
                xNodeList = xmlNode.ChildNodes;
                for (int i = 0; i <= xNodeList.Count - 1; i++)                
                {
                    xNode = xmlNode.ChildNodes[i];
                    treeNode.Nodes.Add(new TreeNode(xNode.Name));
                    tNode = treeNode.Nodes[i];
                    AddTreeNode(xNode, tNode);
                }
            }
            else 
                treeNode.Text = xmlNode.OuterXml.Trim();
        }     
               
        private void FillTreeView()
        {
            try
            {
                //Изменение курсора на ожидание
                Cursor = Cursors.WaitCursor;
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(linkXmlTextBox.Text);
                TreeView.Nodes.Clear();
                TreeView.Nodes.Add(new TreeNode(xmlDoc.DocumentElement.Name));
                TreeNode tNode = new TreeNode();
                tNode = TreeView.Nodes[0];
                //Добавление узлов
                AddTreeNode(xmlDoc.DocumentElement, tNode);
                //Раскрытие всех узлов дерева
                TreeView.ExpandAll();
            }
            //Исключение при ошибке в Xml
            catch (XmlException xExc)           
            {
                MessageBox.Show(xExc.Message);
            }
            //Общее исключение
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Возвращает курсор в обычное состояние
                Cursor = Cursors.Default;
            }
        }
        #endregion
    }
}
