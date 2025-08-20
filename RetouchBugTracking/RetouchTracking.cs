using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            cb_fault.ValueMember = "Id";
            cb_fault.DisplayMember = "errorDescription";
            cb_fault.DataSource = dm.getRetouchingMistakes();

            cb_personelRecord.ValueMember = "Kimlik";
            cb_personelRecord.DisplayMember = "defination";
            cb_personelRecord.DataSource = dm.getPersonalRecord();

            cb_productCode.ValueMember = "Kimlik";
            cb_productCode.DisplayMember = "defination";
            cb_productCode.DataSource = dm.getCodeList();
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
                    retouchTransactionDateFinish = Convert.ToDateTime(dtp_bringFinish.Value.ToShortDateString()),
                    retouchFault = cb_fault.Text,
                    personalID = cb_personelRecord.Text,
                    productTime = Convert.ToDateTime(dtp_productionDate.Value.ToShortDateString()),
                    productTimeFinish = Convert.ToDateTime(dtp_productionDateFinish.Value.ToShortDateString()),
                    definition = cb_productCode.Text
                },
                cbx_fault.Checked,
                cbx_personal.Checked,
                cbx_productCode.Checked,
                cbx_productionDate.Checked,
                cbx_bring.Checked,
                cbx_productionDateFinish.Checked,
                cbx_bringFnish.Checked);

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