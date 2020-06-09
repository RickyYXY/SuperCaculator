using DerivIntegForm;
using MatrixCalculateForm;
using PaintForm;
using StandardCalculateForm;
using System;
using System.Windows.Forms;

namespace MainForm
{
    public partial class MainForm : Form
    {
        StandardCalculat standardForm = new StandardCalculat();
        FunctionPaintForm paintForm = new FunctionPaintForm();
        DIForm diForm = new DIForm();
        MainMatrixForm matrixForm = new MainMatrixForm();
        EquationsSolvingModule.MainForm solveEquForm=new EquationsSolvingModule.MainForm();

        public MainForm()
        {
            InitializeComponent();
            treeView1.ExpandAll();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            ShowForm(standardForm);
        }

        public void ShowForm(Form form1)
        {

            this.panelChild.Controls.Clear();

            form1.TopLevel = false;

            form1.FormBorderStyle = FormBorderStyle.None;

            form1.Dock = DockStyle.Fill;

            form1.Parent = this.panelChild;

            this.panelChild.Controls.Add(form1);

            form1.Show();

        }

        private void MenuClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent!=null)
            {
                switch (e.Node.Name)
                {
                    case "painting":
                        ShowForm(paintForm);
                            break;
                    case "DI":
                        ShowForm(diForm);
                        break;
                    case "matrix":
                        ShowForm(matrixForm);
                        break;
                    case "solveEquation":
                        ShowForm(solveEquForm);
                        break;

                    default:
                        ShowForm(standardForm);
                        break;

                }
            }
        }
    }
}
