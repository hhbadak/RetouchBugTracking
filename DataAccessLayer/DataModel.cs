using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;

        public DataModel()
        {
            con = new SqlConnection(ConnectionStrings.ConStr);
            cmd = con.CreateCommand();
        }

        public List<RetouchTracking> logEntryListBySelectedDate(RetouchTracking src)
        {
            List<RetouchTracking> rt = new List<RetouchTracking>();
            try
            {
                cmd.CommandText = "SELECT rt.ID, rt.Barkod, kl.tanim, rh.HataTanim, rt.IslemTarih, p.KullaniciAd, dsl.tanim, u.DokumTarih FROM RotusTakip AS rt\r\nJOIN UT_D_Urunler AS u ON rt.Barkod = u.BarkodNo\r\nJOIN RotusHatalari AS rh ON rh.Id = rt.RotusHata_ID\r\nJOIN ES_Personeller AS p ON p.PersonelId = rt.PersonelSicil_ID\r\nJOIN dokum_sicil_liste AS dsl ON dsl.Kimlik = u.DokumcuId\r\nJOIN kod_liste AS kl ON kl.Kimlik = u.TezgahKalipId\r\nJOIN UT_D_Tezgahlar as t ON t.Id = u.TezgahId WHERE rt.IslemTarih = @selectedDate";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@selectedDate", src.retouchTransactionDate);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    RetouchTracking model = new RetouchTracking()
                    {
                        RetouchTrackingID = reader.GetInt32(0),
                        barcode = reader.GetString(1),
                        definition = reader.GetString(2),
                        fault = reader.GetString(3),
                        retouchTransactionDate = reader.GetDateTime(4),
                        username = reader.GetString(5),
                        personalID = reader.GetString(6),
                        productTransactionDate = reader.GetDateTime(7)
                    };
                    rt.Add(model);
                }
                return rt;
            }
            catch
            {
                return null;
            }
            finally { con.Close(); }
        }

        public List<RetouchTracking> logEntryListProductionDate(RetouchTracking src, bool fault, bool personalRecord, bool productCode, bool productDate, bool controlDate, bool productDateFinish, bool controlDateFinish)
        {
            List<RetouchTracking> rt = new List<RetouchTracking>();
            try
            {
                cmd.CommandText = queryText(fault, personalRecord, productCode, productDate, controlDate, productDateFinish, controlDateFinish);
                cmd.Parameters.Clear();
                if (fault)
                    cmd.Parameters.AddWithValue("@RotusHata", src.retouchFault);
                if (controlDate)
                    cmd.Parameters.AddWithValue("@Islemtarih", src.retouchTransactionDate);
                if (personalRecord)
                    cmd.Parameters.AddWithValue("@PersonelSicil", src.personalID);
                if (productDate)
                    cmd.Parameters.AddWithValue("@productDate", src.productTime);
                if (productCode)
                    cmd.Parameters.AddWithValue("@productCode", src.definition);
                if (productDateFinish)
                    cmd.Parameters.AddWithValue("@productDateFinish", src.productTimeFinish);
                if (controlDateFinish)
                    cmd.Parameters.AddWithValue("@controlDateFinish", src.retouchTransactionDateFinish);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    RetouchTracking model = new RetouchTracking()
                    {
                        RetouchTrackingID = reader.GetInt32(0),
                        barcode = reader.GetString(1),
                        definition = reader.GetString(2),
                        fault = reader.GetString(3),
                        retouchTransactionDate = reader.GetDateTime(4),
                        username = reader.GetString(5),
                        personalID = reader.GetString(6),
                        productTransactionDate = reader.GetDateTime(7)
                    };
                    rt.Add(model);
                }
                return rt;
            }
            catch
            {
                return null;
            }
            finally { con.Close(); }
        }

        public bool retouchFaultAdd(RetouchTracking model)
        {
            try
            {
                cmd.CommandText = "INSERT INTO RotusTakip(Barkod, RotusHata_ID, IslemTarih, PersonelSicil_ID) VALUES (@barcode, @retouchFaultID, @transactionDate, @personalRecord)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@barcode", model.barcode);
                cmd.Parameters.AddWithValue("@retouchFaultID", model.retouchFaultID);
                cmd.Parameters.AddWithValue("@transactionDate", model.retouchTransactionDate);
                cmd.Parameters.AddWithValue("@personalRecord", model.personnelRegisterID);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally { con.Close(); }
        }

        public List<RetouchingMistakes> getRetouchingMistakes()
        {
            List<RetouchingMistakes> fault = new List<RetouchingMistakes>();
            try
            {
                cmd.CommandText = "SELECT Id, HataTanim FROM RotusHatalari";
                cmd.Parameters.Clear();
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    RetouchingMistakes model = new RetouchingMistakes();
                    model.ID = Convert.ToInt16(reader["Id"]);
                    model.errorDescription = reader.GetString(1);
                    fault.Add(model);
                }
                return fault;
            }
            catch
            {
                return null;
            }
            finally { con.Close(); }
        }

        public List<PersonalRecord> getPersonalRecord()
        {
            List<PersonalRecord> personalRecords = new List<PersonalRecord>();
            try
            {
                cmd.CommandText = "SELECT Kimlik, Tanim FROM dokum_sicil_liste";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    PersonalRecord model = new PersonalRecord();
                    model.ID = Convert.ToInt32(reader["Kimlik"]);
                    model.defination = reader.GetString(1);
                    personalRecords.Add(model);
                }
                return personalRecords;
            }
            catch
            {
                return null;
            }
            finally { con.Close(); }
        }

        public List<CodeList> getCodeList()
        {
            List<CodeList> listCode = new List<CodeList>();
            try
            {
                cmd.CommandText = "SELECT Kimlik, Tanim FROM kod_liste";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    CodeList model = new CodeList();
                    model.ID = Convert.ToInt32(reader["Kimlik"]);
                    model.defination = reader.GetString(1);
                    listCode.Add(model);
                }
                return listCode;
            }
            catch
            {
                return null;
            }
            finally { con.Close(); }
        }

        public Staff getPersonal(int id)
        {
            try
            {
                Staff model = new Staff();
                cmd.CommandText = "SELECT PersonelId, PersonelAdSoyad\r\n, BirimId, KullaniciAd, Sifre, Yetki FROM ES_Personeller WHERE PersonelId = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                if (con.State != System.Data.ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    model.ID = Convert.ToInt32(reader["PersonelId"]);
                    model.nameSurname = reader.GetString(1);
                    model.departmentID = Convert.ToInt16(reader["BirimId"]);
                    model.username = reader.GetString(3);
                    model.password = reader.GetString(4);
                    model.authorization = Convert.ToInt16(reader["Yetki"]);
                }
                return model;
            }
            catch
            {
                return null;
            }
            finally { con.Close(); }
        }

        public Staff personalLogin(string username, string password)
        {
            Staff model = new Staff();
            try
            {
                cmd.CommandText = "SELECT PersonelId FROM ES_Personeller WHERE KullaniciAd = @uName AND Sifre = @password";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@uName", username);
                cmd.Parameters.AddWithValue("@password", password);
                con.Open();
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                if (id > 0)
                {
                    model = getPersonal(id);
                }
                return model;
            }
            catch
            {
                return null;
            }
            finally { con.Close(); }
        }

        public bool isThereBarcode(string barcode)
        {
            try
            {
                cmd.CommandText = "SELECT Barkod FROM RotusTakip WHERE Barkod = @barcode";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@barcode", barcode);
                con.Open();
                barcode = cmd.ExecuteScalar().ToString();
                return true;
            }
            catch
            {
                return false;
            }
            finally { con.Close(); }
        }

        public bool deleteFault(int id)
        {
            try
            {
                cmd.CommandText = "DELETE FROM RotusTakip WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally { con.Close(); }
        }

        public string queryText(bool fault, bool personalRecord, bool productCode, bool productDate, bool controlDate, bool productDateFinish, bool controlDateFinish)
        {
            try
            {
                string query = "SELECT rt.ID, rt.Barkod, kl.tanim, rh.HataTanim, rt.IslemTarih, p.KullaniciAd, dsl.tanim, u.DokumTarih FROM RotusTakip AS rt\r\nJOIN UT_D_Urunler AS u ON rt.Barkod = u.BarkodNo\r\nJOIN RotusHatalari AS rh ON rh.Id = rt.RotusHata_ID\r\nJOIN ES_Personeller AS p ON p.PersonelId = rt.PersonelSicil_ID\r\nJOIN dokum_sicil_liste AS dsl ON dsl.Kimlik = u.DokumcuId\r\nJOIN kod_liste AS kl ON kl.Kimlik = u.TezgahKalipId\r\nJOIN UT_D_Tezgahlar as t ON t.Id = u.TezgahId WHERE 1=1 ";

                string parameterFault = " rh.HataTanim=@RotusHata ";
                string parameterControlDate = " rt.IslemTarih>=@Islemtarih ";
                string parameterControlDateFinish = " rt.IslemTarih<=@controlDateFinish ";
                string parameterPersonalRecord = " dsl.tanim=@PersonelSicil ";
                string parameterProductDate = " u.DokumTarih>=@productDate ";
                string parameterProductDateFinish = " u.DokumTarih<=@productDateFinish ";
                string parameterProductCode = " kl.tanim=@productCode ";

                string and = "AND ";

                string mainQuery = query;
                if (fault)
                {
                    mainQuery = mainQuery + and + parameterFault;
                }
                if (personalRecord)
                {
                    mainQuery = mainQuery + and + parameterPersonalRecord;
                }
                if (productCode)
                {
                    mainQuery = mainQuery + and + parameterProductCode;
                }
                if (productDate)
                {
                    mainQuery = mainQuery + and + parameterProductDate;
                }
                if (controlDate)
                {
                    mainQuery = mainQuery + and + parameterControlDate;
                }
                if (productDateFinish)
                {
                    mainQuery = mainQuery + and + parameterProductDateFinish;
                }
                if (controlDateFinish)
                {
                    mainQuery = mainQuery + and + parameterControlDateFinish;
                }
                return mainQuery;
            }
            finally
            {
                con.Close();
            }
        }
    }
}