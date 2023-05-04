using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetouchBugTracking
{
    public partial class RetouchTracking : Form
    {
        DataModel dm = new DataModel();
        int retouchFaultID = 0;
        public RetouchTracking()
        {
            InitializeComponent();
        }
        int personelId = 0;
        private void RetouchTracking_Load(object sender, EventArgs e)
        {

            LoginPage frm = new LoginPage();
            frm.ShowDialog();
            Staff model = Helpers.isLogin;
            toolStripStatusLabel1.Text = model.nameSurname;
            personelId = model.ID;
            loadGrid();

            cb_faultList.ValueMember = "Id";
            cb_faultList.DisplayMember = "errorDescription";
            cb_faultList.DataSource = dm.getRetouchingMistakes();
        }

        private void loadGrid()
        {
            dgv_list.DataSource = dm.logEntryList();
            var rt = dm.logEntryList().OrderByDescending(r => r.RetouchTrackingID).ToList();
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Barkod No");
            dt.Columns.Add("Hata Tanımı");
            dt.Columns.Add("Rötuş Hata Giriş");
            dt.Columns.Add("Kullanıcı Adı");
            dt.Columns.Add("Dökümcü Ad Soyad");
            dt.Columns.Add("Döküm Tarihi");

            for (int i = 0; i < rt.Count; i++)
            {
                DataRow r = dt.NewRow();

                r["ID"] = rt[i].RetouchTrackingID;
                r["Barkod No"] = rt[i].barcode;
                r["Hata Tanımı"] = rt[i].fault;
                r["Rötuş Hata Giriş"] = rt[i].retouchTransactionDate.ToShortDateString();
                r["Kullanıcı Adı"] = rt[i].username;
                r["Dökümcü Ad Soyad"] = rt[i].nameSurname;
                r["Döküm Tarihi"] = rt[i].productTransactionDate;

                dt.Rows.Add(r);
            }
            dgv_list.DataSource = dt;
        }

        private void tb_barcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tb_barcode.Text.Length == 10)
                {
                    if (dm.isThereBarcode(tb_barcode.Text) != true)
                    {
                        dm.retouchFaultAdd(new DataAccessLayer.RetouchTracking
                        {
                            barcode = tb_barcode.Text,
                            retouchFaultID = Convert.ToInt16(cb_faultList.SelectedValue),
                            retouchTransactionDate = DateTime.Now,
                            personnelRegisterID = Convert.ToInt16(personelId)
                        });
                        tb_barcode.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Barkod Kayıtlı");
                    }
                }
                else
                {
                    MessageBox.Show("Geçerli Barkod Numarası Giriniz");
                }
            }
            loadGrid();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            dm.deleteFault(retouchFaultID);
            loadGrid();
        }

        private void dgv_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            retouchFaultID = Convert.ToInt32(dgv_list.CurrentRow.Cells["ID"].Value);
        }
    }
}
