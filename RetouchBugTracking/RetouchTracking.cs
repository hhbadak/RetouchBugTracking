using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
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
        int personelId = 0;
        public RetouchTracking()
        {
            InitializeComponent();
        }

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

            cb_productCode.ValueMember = "Kimlik";
            cb_productCode.DisplayMember = "productDescription";

        }

        private void loadGrid()
        {
            var result = dm.logEntryListBySelectedDate(
                new DataAccessLayer.RetouchTracking
                {
                    retouchTransactionDate = Convert.ToDateTime(dtp_bring.Value.ToShortDateString())
                });

            dgv_list.DataSource = result;
            var rt = result.OrderByDescending(r => r.RetouchTrackingID).ToList();
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Barkod No");
            dt.Columns.Add("Kod Tanım");
            dt.Columns.Add("Hata Tanımı");
            dt.Columns.Add("Rötuş Hata Giriş");
            dt.Columns.Add("Kullanıcı Adı");
            dt.Columns.Add("Dökümcü Sicil No");
            dt.Columns.Add("Döküm Tarihi");

            for (int i = 0; i < rt.Count; i++)
            {
                DataRow r = dt.NewRow();

                r["ID"] = rt[i].RetouchTrackingID;
                r["Barkod No"] = rt[i].barcode;
                r["Kod Tanım"] = rt[i].definition;
                r["Hata Tanımı"] = rt[i].fault;
                r["Rötuş Hata Giriş"] = rt[i].retouchTransactionDate.ToShortDateString();
                r["Kullanıcı Adı"] = rt[i].username;
                r["Dökümcü Sicil No"] = rt[i].personalID;
                r["Döküm Tarihi"] = rt[i].productTransactionDate.ToShortDateString();

                dt.Rows.Add(r);
            }
            dgv_list.DataSource = dt;

            label4.Text = "Bakılan Ürün sayısı: " + dgv_list.RowCount.ToString();
        } 
        private void loadGridByFilter()
        {
            var result = dm.logEntryListProductionDate(
                new DataAccessLayer.RetouchTracking
                {
                    retouchTransactionDate = Convert.ToDateTime(dtp_bring.Value.ToShortDateString()),
                    retouchFault = cb_fault.Text,
                    personalID = cb_personelRecord.Text,
                    productTime = Convert.ToDateTime(dtp_productionDate.Value.ToShortDateString()),
                    definition = cb_productCode.Text,
                },
                cbx_fault.Checked, cbx_personal.Checked, cbx_productCode.Checked, cbx_productionDate.Checked, cbx_bring.Checked); ;

            dgv_list.DataSource = result;
            var rt = result.OrderByDescending(r => r.RetouchTrackingID).ToList();
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Barkod No");
            dt.Columns.Add("Kod Tanım");
            dt.Columns.Add("Hata Tanımı");
            dt.Columns.Add("Rötuş Hata Giriş");
            dt.Columns.Add("Kullanıcı Adı");
            dt.Columns.Add("Dökümcü Sicil No");
            dt.Columns.Add("Döküm Tarihi");

            for (int i = 0; i < rt.Count; i++)
            {
                DataRow r = dt.NewRow();

                r["ID"] = rt[i].RetouchTrackingID;
                r["Barkod No"] = rt[i].barcode;
                r["Kod Tanım"] = rt[i].definition;
                r["Hata Tanımı"] = rt[i].fault;
                r["Rötuş Hata Giriş"] = rt[i].retouchTransactionDate.ToShortDateString();
                r["Kullanıcı Adı"] = rt[i].username;
                r["Dökümcü Sicil No"] = rt[i].personalID;
                r["Döküm Tarihi"] = rt[i].productTransactionDate.ToShortDateString();

                dt.Rows.Add(r);
            }
            dgv_list.DataSource = dt;

            label4.Text = "Bakılan Ürün sayısı: " + dgv_list.RowCount.ToString();
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

        private void btn_bring_Click(object sender, EventArgs e)
        {

            loadGridByFilter();
        }

        private void btn_productionDate_Click(object sender, EventArgs e)
        {
        }

        private void btn_fault_Click(object sender, EventArgs e)
        {

        }

        private void btn_personelRecord_Click(object sender, EventArgs e)
        {

        }
    }
}
