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

        public List<RetouchTracking> logEntryList()
        {
            List<RetouchTracking> rt = new List<RetouchTracking>();
            try
            {
                cmd.CommandText = "SELECT rt.ID, rt.Barkod, rh.HataTanim, rt.IslemTarih, p.KullaniciAd, dsl.ad_soyad, u.DokumTarih FROM RotusTakip AS rt \r\nJOIN UT_D_Urunler AS u ON rt.Barkod = u.BarkodNo\r\nJOIN RotusHatalari AS rh ON rh.Id = rt.RotusHata_ID\r\nJOIN ES_Personeller AS p ON p.PersonelId = rt.PersonelSicil_ID\r\nJOIN dokum_sicil_liste AS dsl ON dsl.Kimlik = u.DokumcuId\r\nJOIN UT_D_Tezgahlar as t ON t.Id = u.TezgahId WHERE rt.IslemTarih = convert(date,getdate(),4)";
                cmd.Parameters.Clear();
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    RetouchTracking model = new RetouchTracking()
                    {
                        RetouchTrackingID = reader.GetInt32(0),
                        barcode = reader.GetString(1),
                        fault = reader.GetString(2),
                        retouchTransactionDate = reader.GetDateTime(3),
                        username = reader.GetString(4),
                        nameSurname = reader.GetString(5),
                        productTransactionDate = reader.GetDateTime(6)
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

        public Staff getPersonal(int id)
        {
            try
            {
                Staff model = new Staff();
                cmd.CommandText = "SELECT PersonelId, PersonelAdSoyad\r\n, BirimId, KullaniciAd, Sifre, Yetki FROM ES_Personeller WHERE PersonelId = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                if (con.State !=System.Data.ConnectionState.Open)
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
    }
}
