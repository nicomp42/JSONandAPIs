/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */

using System;
using System.Windows.Forms;

namespace JSONandAPIs
{
    public partial class frmDemo : Form
    {
        public frmDemo()
        {
            InitializeComponent();
        }

        private void btnGSMNPAlerts_Click(object sender, EventArgs e)
        {
            APIs.GSMNPAlerts(txtAlerts);
        }

        private void txtDateTimePicked_DoubleClick(object sender, EventArgs e)
        {
            txtDateTimePicked.Text = DateTime.Now.ToString();
        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            lblSerializeInfo.Text = "Serializing...";
            try {
                String[] quality = { "organic", "free range", "pesticide-free" };
                Fruit fruit = new Fruit(txtName.Text,
                                    Convert.ToInt32(txtWeight.Text),
                                    Convert.ToDateTime(txtDateTimePicked.Text),
                                    Fruit.enumCondition.ripe,
                                    quality);
                JSONSerializeTools.Serialize(fruit, txtFileName.Text);
                lblSerializeInfo.Text = "Done";
            } catch (Exception ex) {
                lblSerializeInfo.Text = ex.Message;
            }
        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            Fruit fruit = (Fruit) JSONSerializeTools.Deserialize<Fruit>(txtDeserializeFileName.Text);
            lblDeserializeInfo.Text = fruit.ToString();
        }

        private void btnGSMNPInfo_Click(object sender, EventArgs e)
        {
            APIs.GSMNPInfo(txtInfo);
        }
    }
}
