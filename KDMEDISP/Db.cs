using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDMEDISP
{
  
        public  class Db 
        {
            util imsg = new util();




            public void Tr_ComputeTotal()
            {
                string dbname = "KDMEDISP";
                SQLiteConnection conn = new SQLiteConnection();
                AppMessage imsg = new AppMessage();
                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd;
                string QCreate = " CREATE TRIGGER  IF NOT EXISTS calcTotal AFTER INSERT  ON tblcart FOR EACH ROW"
                              + " BEGIN UPDATE tblcart  SET total = (qty * price)-discount;  END; ";

                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = QCreate;
                sqlite_cmd.ExecuteNonQuery();
                conn.Close();

            }
            public void Tr_ComputeTotalafterUpdate()
            {
                string dbname = "KDMEDISP";
                SQLiteConnection conn = new SQLiteConnection();
                AppMessage imsg = new AppMessage();
                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd;
                string QCreate = " CREATE TRIGGER  IF NOT EXISTS UpdateTotal AFTER UPDATE  ON tblcart FOR EACH ROW"
                              + " BEGIN UPDATE tblcart  SET total = (qty * price)-discount;  END; ";

                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = QCreate;
                sqlite_cmd.ExecuteNonQuery();
                conn.Close();

            }
            public void createSuppliers()
            {
                string dbname = "KDMEDISP";
                string tablename = "tblSuppliers";
                SQLiteConnection conn = new SQLiteConnection();
                AppMessage imsg = new AppMessage();
                if (File.Exists(dbname))
                {
                    return;
                }
                else
                {
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    string QCreate = " CREATE TABLE IF NOT EXISTS `" + tablename + "` ( 	`id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, `supplier` TEXT,    `phone` TEXT,`email` TEXT,`address` TEXT  );";
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = QCreate;
                    sqlite_cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        public void createDefaultDrug()
        {
            string dbname = "KDMEDISP";
            string tablename = "tblDefaultDrugList";
            SQLiteConnection conn = new SQLiteConnection();
            AppMessage imsg = new AppMessage();
            if (File.Exists(dbname))
            {
                return;
            }
            else
            {
                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd;
                string QCreate = " CREATE TABLE IF NOT EXISTS `" + tablename + "` ( 	`id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, `Generic` TEXT,   `Strength` TEXT, `dclass` TEXT );";

                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = QCreate;
                sqlite_cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public void CreatePrescription()
        {
            string dbname = "KDMEDISP";
            string tablename = "tblPrescriptions";
            SQLiteConnection conn = new SQLiteConnection();
            AppMessage imsg = new AppMessage();
            if (File.Exists(dbname))
            {
                return;
            }
            else
            {
                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd;
                string QCreate = " CREATE TABLE IF NOT EXISTS `" + tablename + "` ( 	`id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, `PrescriptionID` TEXT, `prescriberID` TEXT,   `medication` TEXT, `PatientID` TEXT,     `sig` TEXT,`dispense` TEXT,`refill` TEXT,`daw` TEXT ,`status` TEXT    DEFAULT pending  NOT NULL,`presDate` TEXT    );";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = QCreate;
                sqlite_cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public void createBarCode()
            {
                string dbname = "KDMEDISP";
                string tablename = "tblbarcodes";
                SQLiteConnection conn = new SQLiteConnection();
                AppMessage imsg = new AppMessage();
                if (File.Exists(dbname))
                {
                    return;
                }
                else
                {
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    string QCreate = " CREATE TABLE IF NOT EXISTS `" + tablename + "` ( 	`id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, `pbcode` TEXT,    `pdesc` TEXT );";
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = QCreate;
                    sqlite_cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        public void CreateActivate()
        {
            string dbname = "KDMEDISP";
            string tablename = "tblActivate";
            SQLiteConnection conn = new SQLiteConnection();
            AppMessage imsg = new AppMessage();
            if (File.Exists(dbname))
            {
                return;
            }
            else
            {
                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd;
                string QCreate = " CREATE TABLE IF NOT EXISTS `" + tablename + "` ( 	`id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, `activate` INTEGER );";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = QCreate;
                sqlite_cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public bool InsertBarcode(string barcode, string desc)
            {
                bool Stats = false;

                try
                {

                    string dbname = "KDMEDISP";
                    string tablename = "tblbarcodes";
                    SQLiteConnection conn = new SQLiteConnection();
                    AppMessage imsg = new AppMessage();

                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    string QCreate = " INSERT INTO `" + tablename + "` ( pbcode,pdesc ) VALUES(@pbcode,@pdesc);";
                    sqlite_cmd = conn.CreateCommand();

                    sqlite_cmd.CommandText = QCreate;
                    sqlite_cmd.Parameters.AddWithValue("@pbcode", barcode);
                    sqlite_cmd.Parameters.AddWithValue("@pdesc", desc);
                    sqlite_cmd.ExecuteNonQuery();
                    conn.Close();
                    Stats = true;
                }
                catch (Exception)
                {
                    Stats = false;

                }
                return Stats;
            }
        public bool InsertNonActivate()
        {
            bool Stats = false;

            try
            {
                string dbname = "KDMEDISP";
                string tablename = "tblActivate";
                SQLiteConnection conn = new SQLiteConnection();
                AppMessage imsg = new AppMessage();

                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd;
                string QCreate = " INSERT INTO `" + tablename + "` ( activate) VALUES(0);";
                sqlite_cmd = conn.CreateCommand();

                sqlite_cmd.CommandText = QCreate;
                sqlite_cmd.ExecuteNonQuery();
                conn.Close();
                Stats = true;
            }
            catch (Exception)
            {
                Stats = false;

            }
            return Stats;
        }
        public bool InsertTrialCount()
        {
            bool Stats = false;

            try
            {

                string dbname = "KDMEDISP";
                string tablename = "tblCount";
                SQLiteConnection conn = new SQLiteConnection();
                AppMessage imsg = new AppMessage();

                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd;
                string QCreate = " INSERT INTO `" + tablename + "` ( count) VALUES(60);";
                sqlite_cmd = conn.CreateCommand();

                sqlite_cmd.CommandText = QCreate;
                sqlite_cmd.ExecuteNonQuery();
                conn.Close();
                Stats = true;
            }
            catch (Exception)
            {
                Stats = false;

            }
            return Stats;
        }
        public bool UpdateActivate()
        {
            bool Stats = false;

            try
            {

                string dbname = "KDMEDISP";
                string tablename = "tblActivate";
                SQLiteConnection conn = new SQLiteConnection();
                AppMessage imsg = new AppMessage();

                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd;
                string QCreate = " update tblActivate  SET activate =1 where id=1;";
                sqlite_cmd = conn.CreateCommand();
                 
                sqlite_cmd.CommandText = QCreate;
                sqlite_cmd.ExecuteNonQuery();
                conn.Close();
                Stats = true;
            }
            catch (Exception)
            {
                Stats = false;

            }
            return Stats;
        }
        public void CreateCounter()
            {
                string dbname = "KDMEDISP";
                string tablename = "tblCount";
                SQLiteConnection conn = new SQLiteConnection();
                AppMessage imsg = new AppMessage();
                try
                {
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    string QCreate = " CREATE TABLE IF NOT EXISTS `" + tablename + "` ( 	`id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,    `count` INTEGER );";
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = QCreate;
                    sqlite_cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception)
                {
                 
                }

            }
        public void CreateFirst()
        {
            string dbname = "KDMEDISP";
            string tablename = "tblFirstInstall";
            SQLiteConnection conn = new SQLiteConnection();
            AppMessage imsg = new AppMessage();
            try
            {
                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd;
                string QCreate = " CREATE TABLE IF NOT EXISTS `" + tablename + "` ( 	`id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,    `install` INTEGER );";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = QCreate;
                sqlite_cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {

            }

        }
        public void CreateInitConfig()
            {
                string dbname = "KDMEDISP";
                string tablename = "InitConfigStats";
                SQLiteConnection conn = new SQLiteConnection();
                AppMessage imsg = new AppMessage();
                try
                {
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    string QCreate = " CREATE TABLE IF NOT EXISTS `" + tablename + "` ( 	`id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,    `InitConfigStats` INTEGER );";
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = QCreate;
                    sqlite_cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception)
                {

                }

            }
            public void CreateDefPrinter()
            {
                string dbname = "KDMEDISP";
                string tablename = "tblDefPrinter";
                SQLiteConnection conn = new SQLiteConnection();

                AppMessage imsg = new AppMessage();
                try
                {
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    string QCreate = " CREATE TABLE IF NOT EXISTS `" + tablename + "` ( 	`id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,    `DefPrinter` TEXT );";
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = QCreate;
                    sqlite_cmd.ExecuteNonQuery();  //   returns 0 if successfully

                    conn.Close();


                }
                catch (Exception)
                {

                }

            }
            public void CreateErrorModeConfig()
            {
                string dbname = "KDMEDISP";
                string tablename = "tblErrorMode";
                SQLiteConnection conn = new SQLiteConnection();
                AppMessage imsg = new AppMessage();
                try
                {
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    string QCreate = " CREATE TABLE IF NOT EXISTS `" + tablename + "` ( 	`id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,    `ErrorMode` INTEGER );";
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = QCreate;
                    sqlite_cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception)
                {

                }

            }
            public bool InsertSingle(string tablename, string tableCol, object ColValue)
            {
                string dbname = "KDMEDISP";
                SQLiteConnection conn = new SQLiteConnection();
                bool stats = false;
                try
                {
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    string QInsert = "INSERT INTO `" + tablename + "` (" + tableCol + ") VALUES(@colVal) ";
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.Parameters.AddWithValue("@colVal", ColValue);
                    sqlite_cmd.CommandText = QInsert;
                    if (sqlite_cmd.ExecuteNonQuery() != 0)
                    {
                        stats = true;
                    }

                    conn.Close();
                }
                catch (Exception)
                {

                }
                return stats;
            }
            public bool UpdateSingleData(string dbname, string tablename, string tableCol, object ColValue, int id = 1)
            {
                SQLiteConnection conn = new SQLiteConnection();
                bool stats = false;
                try
                {
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    string QInsert = "UPDATE  `" + tablename + "` SET " + tableCol + "= @colVal  where id=@id;";
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.Parameters.AddWithValue("@colVal", ColValue);
                    sqlite_cmd.Parameters.AddWithValue("@id", id);
                    sqlite_cmd.CommandText = QInsert;
                    if (sqlite_cmd.ExecuteNonQuery() != 0)
                    {
                        stats = true;
                    }

                    conn.Close();
                }
                catch (Exception)
                {

                }
                return stats;
            }
            public void CreatePatients()
            {
                string dbname = "KDMEDISP";
                string tablename = "tblpatients";
                SQLiteConnection conn = new SQLiteConnection();
                AppMessage imsg = new AppMessage();
                if (File.Exists(dbname))
                {
                    return;
                }
                else
                {
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    string QCreate = " CREATE TABLE IF NOT EXISTS `" + tablename + "` ( 	`id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, `patientID` TEXT, `title` TEXT,  `sex` TEXT,   `dob` TEXT, `firstname` TEXT, `lastName` TEXT,`othername` TEXT, `Email` TEXT, `Phone` TEXT, `Address` TEXT,`nextofKin` TEXT,`nextofKinPhone` TEXT,`organisation` TEXT,`Allergies` TEXT,`MedicalNotes` TEXT,`regdate` TEXT,`imgUrl` TEXT );";
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = QCreate;
                    sqlite_cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            public void CreatePrescribers()
            {
                string dbname = "KDMEDISP";
                string tablename = "tblprescribers";
                SQLiteConnection conn = new SQLiteConnection();
                AppMessage imsg = new AppMessage();
                if (File.Exists(dbname))
                {
                    return;
                }
                else
                {
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    string QCreate = " CREATE TABLE IF NOT EXISTS `" + tablename + "` ( 	`id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, `title` TEXT,  `sex` TEXT,   `dob` TEXT, `firstname` TEXT, `lastName` TEXT,`othername` TEXT, `Email` TEXT, `Phone` TEXT, `StaffID` TEXT,`Address` TEXT,`imgUrl` TEXT );";
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = QCreate;
                    sqlite_cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            public void CreateDrugs()
            {
                string dbname = "KDMEDISP";
                string tablename = "tblDrugs";
                SQLiteConnection conn = new SQLiteConnection();
                AppMessage imsg = new AppMessage();
                if (File.Exists(dbname))
                {
                    return;
                }
                else
                {
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    string QCreate = " CREATE TABLE IF NOT EXISTS `" + tablename + "` ( 	`id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, `Nprimary` TEXT,  `Generic` TEXT,   `Strength` TEXT, `Units` TEXT, `class` TEXT,`Manufacturer` TEXT, `Pcode` TEXT, `barcode` TEXT, `storageLoc` TEXT,`qty` INTEGER,`reorderqty` INTEGER ,`ExpiryDate` TEXT,`Supplier` TEXT,`Package` TEXT,`price` DOUBLE,`additionalinfo` TEXT );";
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = QCreate;
                    sqlite_cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            public void createProd()
            {
                string dbname = "KDMEDISP";
                string tablename = "tblproduct";
                SQLiteConnection conn = new SQLiteConnection();
                AppMessage imsg = new AppMessage();
                if (File.Exists(dbname))
                {
                    return;
                }
                else
                {
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    string QCreate = " CREATE TABLE IF NOT EXISTS `" + tablename + "` ( 	`id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, `pcode` TEXT,  `pbcode` TEXT,   `pdesc` TEXT, `bid` INTEGER, `cid` INTEGER, `price` DECIMAL, `qty` INTEGER, `reorderqty` INTEGER,`EstoreID` INTEGER,`imgUrl` TEXT );";
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = QCreate;
                    sqlite_cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            public void CreateCart()
            {
                string dbname = "KDMEDISP";
                string tablename = "tblcart";
                SQLiteConnection conn = new SQLiteConnection();
                AppMessage imsg = new AppMessage();
                if (File.Exists(dbname))
                {
                    return;
                }
                else
                {
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    string QCreate = " CREATE TABLE IF NOT EXISTS `" + tablename + "` (`id` INTEGER NOT NULL   PRIMARY KEY AUTOINCREMENT, "
                    + "`transno` TEXT, `pcode` TEXT, `price` DECIMAL, `qty`    INTEGER,"
                    + " `discount` DECIMAL,`total` DECIMAL,`sdate`DATE,`status` TEXT    DEFAULT pending  NOT NULL,  `adminID` INTEGER NOT NULL  );";
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = QCreate;
                    sqlite_cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            public void CreateStockIn()
            {
                string dbname = "KDMEDISP";
                string tablename = "tblstockin";
                SQLiteConnection conn = new SQLiteConnection();
                AppMessage imsg = new AppMessage();
                if (File.Exists(dbname))
                {
                    return;
                }
                else
                {
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    string QCreate = " CREATE TABLE IF NOT EXISTS `" + tablename + "` ( 	`id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,    `refno` TEXT,    `pcode` TEXT,    `qty` TEXT,  `sdate` DATETIME,    `stockinby` TEXT, `status` TEXT  NOT NULL  DEFAULT 'Pending');";
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = QCreate;
                    sqlite_cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            public void CreateDiscTrack()
            {
                string dbname = "KDMEDISP";
                string tablename = "tblDiscTrack";
                SQLiteConnection conn = new SQLiteConnection();
                AppMessage imsg = new AppMessage();
                if (File.Exists(dbname))
                {
                    return;
                }
                else
                {
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    string QCreate = " CREATE TABLE IF NOT EXISTS `" + tablename + "` ( 	`id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,    `discTrack` DECIMAL);";
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = QCreate;
                    sqlite_cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            public void createCat()
            {
                string dbname = "KDMEDISP";
                string tablename = "tblcategory";
                SQLiteConnection conn = new SQLiteConnection();
                AppMessage imsg = new AppMessage();
                if (File.Exists(dbname))
                {
                    return;
                }
                else
                {
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    string QCreate = " CREATE TABLE IF NOT EXISTS `" + tablename + "` ( 	`id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,    `category` TEXT );";
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = QCreate;
                    sqlite_cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            public void CreateManufacturers()
            {
                string dbname = "KDMEDISP";
                string tablename = "tblmanufacturers";
                SQLiteConnection conn = new SQLiteConnection();
                AppMessage imsg = new AppMessage();

                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd;
                string QCreate = " CREATE TABLE IF NOT EXISTS `" + tablename + "` ( 	`id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,    `manufacturer` TEXT );";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = QCreate;
                sqlite_cmd.ExecuteNonQuery();
                conn.Close();

            }
            public void CreateProdImg()
            {
                string dbname = "KDMEDISP";
                string tablename = "tblprodimg";
                SQLiteConnection conn = new SQLiteConnection();
                AppMessage imsg = new AppMessage();

                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd;
                string QCreate = " CREATE TABLE IF NOT EXISTS `" + tablename + "` ( 	`id`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,    `pcode` TEXT );";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = QCreate;
                sqlite_cmd.ExecuteNonQuery();
                conn.Close();

            }
            // check that a table exists
            public bool IsTableExist(string dbname, string tableName)
            {
                //try
                //{
                SQLiteConnection conn = new SQLiteConnection();

                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd;
                string tableExist = " SELECT * FROM sqlite_master WHERE type = 'table' AND name=@tableName  ;";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.Parameters.AddWithValue("@tableName", tableName);
                sqlite_cmd.CommandText = tableExist;

                Int64 count = Convert.ToInt64(sqlite_cmd.ExecuteScalar());  // checke record exist before inserting new records
                if (count > 0)
                {
                    imsg.info("Table Exist ");
                    sqlite_cmd.Dispose();
                }
                conn.Close();

                return true;
                //}
                //catch (Exception)
                //{

                //    return false; ;
                //}
            }
            // delete users
            public bool DeleteUser(string dbname, string tablename, string username)
            {
                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    // Console.WriteLine(dbname);
                    AppMessage imsg = new AppMessage();

                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    string DelRec = " Delete FROM `" + tablename + "`  	 WHERE username=@username  ;";
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.Parameters.AddWithValue("@username", username);
                    sqlite_cmd.CommandText = DelRec;
                    sqlite_cmd.ExecuteNonQuery();
                    conn.Close();

                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }
            public bool DelBarcode(string pbcode)
            {
                try
                {
                    string dbname = "KDMEDISP";
                    string tablename = "tblbarcodes";
                    SQLiteConnection conn = new SQLiteConnection();
                    // Console.WriteLine(dbname);

                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    string DelRec = " Delete FROM `" + tablename + "`  	 WHERE pbcode=@pbcode  ;";
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.Parameters.AddWithValue("@pbcode", pbcode);
                    sqlite_cmd.CommandText = DelRec;
                    sqlite_cmd.ExecuteNonQuery();
                    conn.Close();
                    imsg.info("Delete Successful");
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }
            public bool DelItemFromCart(string id, bool report = true)
            {
                try
                {
                    string dbname = "KDMEDISP";
                    string tablename = "tblCart";
                    SQLiteConnection conn = new SQLiteConnection();
                    // Console.WriteLine(dbname);

                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    string DelRec = " Delete FROM `" + tablename + "`  	 WHERE id=@id  ;";
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.Parameters.AddWithValue("@id", id);
                    sqlite_cmd.CommandText = DelRec;
                    sqlite_cmd.ExecuteNonQuery();
                    conn.Close();
                    if (report)
                    {
                        imsg.info("Delete Successful");

                    }
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }
            public bool DelProd(string pcode)
            {
                try
                {
                    string dbname = "KDMEDISP";
                    string tablename = "tblproduct";
                    SQLiteConnection conn = new SQLiteConnection();
                    // Console.WriteLine(dbname);

                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    string DelRec = " Delete FROM `" + tablename + "`  	 WHERE pcode=@pcode  ;";
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.Parameters.AddWithValue("@pcode", pcode);
                    sqlite_cmd.CommandText = DelRec;
                    sqlite_cmd.ExecuteNonQuery();
                    conn.Close();
                    imsg.info("Delete Successful");
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }

            public bool DelStock(string stockID)
            {
                try
                {
                    string dbname = "KDMEDISP";
                    string tablename = "tblstockin";
                    SQLiteConnection conn = new SQLiteConnection();
                    // Console.WriteLine(dbname);

                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    string DelRec = " Delete FROM `" + tablename + "`  	 WHERE id=@stockID  ;";
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.Parameters.AddWithValue("@stockID", stockID);
                    sqlite_cmd.CommandText = DelRec;
                    sqlite_cmd.ExecuteNonQuery();
                    conn.Close();
                    imsg.info("Delete Successful");
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }

            // Delete Datagrid record
            public bool DeleteAdmin(string dbname, string tablename, int recordID)
            {
                try
                {
                    SQLiteConnection conn = new SQLiteConnection();

                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    string DelRec = " Delete FROM `" + tablename + "`  	 WHERE id=@id  ;";
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.Parameters.AddWithValue("@id", recordID);
                    sqlite_cmd.CommandText = DelRec;
                    sqlite_cmd.ExecuteNonQuery();
                    conn.Close();

                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }
            public bool UpdateManufactuerer(string manufacturer, string id)
            {
                bool status = false;
                string dbname;

                dbname = "KDMEDISP";
                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    //Console.WriteLine();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    sqlite_cmd = conn.CreateCommand();
                    string update = "UPDATE tblManufacturers SET [manufacturer]=@manufacturer WHERE id= @id";


                    sqlite_cmd.Parameters.AddWithValue("@manufacturer", manufacturer);

                    sqlite_cmd.Parameters.AddWithValue("@id", id);


                    // conn.Open();
                    sqlite_cmd.CommandText = update;


                    sqlite_cmd.ExecuteNonQuery();

                    conn.Close();
                    status = true;
                }
                catch (Exception)
                {

                    status = false;
                }
                return status;
            }
            public bool UpdateSupplier(string supplier, string email, string phone, string address, string id)
            {
                bool status = false;
                string dbname;

                dbname = "KDMEDISP";
                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    //Console.WriteLine();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    sqlite_cmd = conn.CreateCommand();
                    string update = "UPDATE tblsuppliers SET [supplier]=@supplier,[phone]=@phone,[email]=@email,[address]=@address WHERE id= @id";


                    sqlite_cmd.Parameters.AddWithValue("@supplier", supplier);
                    sqlite_cmd.Parameters.AddWithValue("@phone", phone);
                    sqlite_cmd.Parameters.AddWithValue("@email", email);
                    sqlite_cmd.Parameters.AddWithValue("@address", address);

                    sqlite_cmd.Parameters.AddWithValue("@id", id);


                    // conn.Open();
                    sqlite_cmd.CommandText = update;


                    sqlite_cmd.ExecuteNonQuery();

                    conn.Close();
                    status = true;
                }
                catch (Exception)
                {

                    status = false;
                }
                return status;
            }
            public bool insertManufacturer(string manufacturer)
            {
                bool status = false;
                string dbname = "KDMEDISP";
                string tablename = "tblmanufacturers";
                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    //Console.WriteLine();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    sqlite_cmd = conn.CreateCommand();
                    string insmanufacturerRec = "INSERT INTO '" + tablename + "'  (manufacturer) VALUES (@manufacturer);";
                    string recExist = "SELECT * FROM '" + tablename + "'  WHERE manufacturer=@manufacturer;";



                    sqlite_cmd.Parameters.AddWithValue("@manufacturer", manufacturer);
                    sqlite_cmd.CommandText = recExist;

                    Int64 count =
                        Convert.ToInt64(sqlite_cmd.ExecuteScalar());  // checke record exist before inserting new records
                    if (count > 0)
                    {
                        imsg.info("Record already exist", "Add manufacturer");
                        sqlite_cmd.Dispose();
                    }
                    else
                    {
                        // conn.Open();
                        sqlite_cmd.CommandText = insmanufacturerRec;
                        // frmmanufacturerList.


                    }


                    sqlite_cmd.ExecuteNonQuery();

                    conn.Close();
                    status = true;
                }
                catch (Exception)
                {

                    status = false;
                }
                return status;
            }

            public bool insertSupplier(string supplierName, string phone, string email, string address)
            {
                bool status = false;
                string dbname = "KDMEDISP";
                string tablename = "tblSuppliers";
                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    closeConn(conn);
                    //Console.WriteLine();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    sqlite_cmd = conn.CreateCommand();
                    string insmanufacturerRec = "INSERT INTO '" + tablename + "'  (supplier,phone,email,address) VALUES (@supplier,@phone,@email,@address);";
                    string recExist = "SELECT * FROM '" + tablename + "'  WHERE supplier=@supplier;";

                    sqlite_cmd.Parameters.AddWithValue("@supplier", supplierName);
                    sqlite_cmd.Parameters.AddWithValue("@phone", phone);
                    sqlite_cmd.Parameters.AddWithValue("@email", email);
                    sqlite_cmd.Parameters.AddWithValue("@address", address);
                    sqlite_cmd.CommandText = recExist;

                    Int64 count =
                        Convert.ToInt64(sqlite_cmd.ExecuteScalar());  // checke record exist before inserting new records
                    if (count > 0)
                    {
                        imsg.info("Record already exist", "Add Supplier");
                        sqlite_cmd.Dispose();
                    }
                    else
                    {

                        sqlite_cmd.CommandText = insmanufacturerRec;
                        // frmmanufacturerList.


                    }


                    sqlite_cmd.ExecuteNonQuery();

                    conn.Close();
                    status = true;
                }
                catch (Exception)
                {

                    status = false;
                }
                return status;
            }
            public bool InsertProduct(string pcode, string pbcode, string pdesc, int bid, int cid, double price, int qty, int reorderQty, int EstoreID = -1, string ImgUrl = "")
            {
                bool status = false;
                string dbname = "KDMEDISP";
                string tablename = "tblproduct";
                //try
                //{
                SQLiteConnection conn = new SQLiteConnection();
                //Console.WriteLine();
                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();
                string insmanufacturerRec = "INSERT INTO '" + tablename + "'  (pcode,pbcode, pdesc, bid, cid, price, qty,reorderqty,estoreID,imgUrl) VALUES (@pcode, @pbcode,@pdesc, @bid, @cid, @price, @qty,@reorderqty,@EstoreID,@imgUrl);";
                string recExist = "SELECT * FROM '" + tablename + "'  WHERE pcode=@pcode AND  pdesc= @pdesc AND bid=@bid AND cid=@cid AND price=@price AND qty=@qty;";

                sqlite_cmd.Parameters.AddWithValue("@pcode", pcode);
                sqlite_cmd.Parameters.AddWithValue("@pdesc", pdesc);
                sqlite_cmd.Parameters.AddWithValue("@bid", bid);
                sqlite_cmd.Parameters.AddWithValue("@cid", cid);
                sqlite_cmd.Parameters.AddWithValue("@price", price);
                sqlite_cmd.Parameters.AddWithValue("@qty", qty);
                sqlite_cmd.Parameters.AddWithValue("@reorderqty", reorderQty);
                sqlite_cmd.Parameters.AddWithValue("@pbcode", pbcode);
                sqlite_cmd.Parameters.AddWithValue("@EstoreID", EstoreID);
                sqlite_cmd.Parameters.AddWithValue("@imgUrl", ImgUrl);
                sqlite_cmd.CommandText = recExist;

                Int64 count =
                    Convert.ToInt64(sqlite_cmd.ExecuteScalar());  // checke record exist before inserting new records
                if (count > 0)
                {
                    imsg.info("Record already exist", "Add Product");
                    sqlite_cmd.Dispose();
                    status = false;
                }
                else
                {
                    // conn.Open();
                    sqlite_cmd.CommandText = insmanufacturerRec;
                    status = true;
                    // frmmanufacturerList.


                }


                sqlite_cmd.ExecuteNonQuery();

                conn.Close();
                status = true;
                //}
                //catch (Exception)
                //{

                //    status = false;
                //}
                return status;
            }


            public bool InsertPatient(string patientID, string title, string sex, string dob, string firstname, string lastname, string othername,
                string Email, string phone, string address, string nextofKin,
                string nextofKinPhone, string organisation, string allergies, string medicalNotes, string regdate, string ImgUrl = "")
            {
                bool status = false;
                string dbname = "KDMEDISP";
                string tablename = "tblPatients";
                //try
                //{
                SQLiteConnection conn = new SQLiteConnection();
                Console.WriteLine();
                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();
                string insmanufacturerRec = "INSERT INTO '" + tablename + "'  (patientID,title,sex, dob, firstname, lastname,othername,email, phone,address,nextofKin,nextofKinPhone,organisation,Allergies,MedicalNotes,regdate,imgUrl) VALUES (@patientID,@title,@sex, @dob, @firstname, @lastname,@othername,@email, @phone,@address,@nextofkin,@nextofKinPhone,@organisation,@Allergies,@MedicalNotes,@regdate,@imgUrl);";
                string recExist = "SELECT * FROM '" + tablename + "'  WHERE sex=@sex AND  firstname= @firstname AND lastname=@lastname AND othername=@othername AND patientID=@patientID AND dob=@dob;";
                sqlite_cmd.Parameters.AddWithValue("@patientID", patientID);
                sqlite_cmd.Parameters.AddWithValue("@title", title);
                sqlite_cmd.Parameters.AddWithValue("@sex", sex);
                sqlite_cmd.Parameters.AddWithValue("@dob", dob);
                sqlite_cmd.Parameters.AddWithValue("@firstname", firstname);
                sqlite_cmd.Parameters.AddWithValue("@lastname", lastname);
                sqlite_cmd.Parameters.AddWithValue("@othername", othername);
                sqlite_cmd.Parameters.AddWithValue("@email", Email);
                sqlite_cmd.Parameters.AddWithValue("@phone", phone);
                sqlite_cmd.Parameters.AddWithValue("@address", address);
                sqlite_cmd.Parameters.AddWithValue("@nextofKin", nextofKin);
                sqlite_cmd.Parameters.AddWithValue("@nextofKinPhone", nextofKinPhone);
                sqlite_cmd.Parameters.AddWithValue("@organisation", organisation);
                sqlite_cmd.Parameters.AddWithValue("@allergies", allergies);
                sqlite_cmd.Parameters.AddWithValue("@medicalnotes", medicalNotes);
                sqlite_cmd.Parameters.AddWithValue("@regdate", regdate);
                sqlite_cmd.Parameters.AddWithValue("@imgUrl", ImgUrl);
                sqlite_cmd.CommandText = recExist;
                closeConn(conn);
                conn.Open();

                Int64 count =
                        Convert.ToInt64(sqlite_cmd.ExecuteScalar());  // checke record exist before inserting new records
                if (count > 0)
                {
                    imsg.info("Record already exist", "Add Product");
                    sqlite_cmd.Dispose();
                    conn.Close();

                    status = false;
                }
                else
                {
                    sqlite_cmd.CommandText = insmanufacturerRec;

                    sqlite_cmd.ExecuteNonQuery();

                    conn.Close();
                    status = true;

                }



                status = true;
                //}
                //catch (Exception)
                //{

                //    status = false;
                //}
                return status;
            }
            public bool InsertDrugs(string primary, string Generic, string strength, string units, string Dclass, string Manufac,
               string pcode, string barcode, string storageLoc, int entryStock,
               int reorderqty, string ExpiryDate, string Supplier, string Package, Double price, string additionalInfo)
            {
                bool status = false;
                string dbname = "KDMEDISP";
                string tablename = "tblDrugs";
            try
            {
                SQLiteConnection conn = new SQLiteConnection();
                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();
                string insmanufacturerRec = "INSERT INTO '" + tablename + "'  (Nprimary,generic,strength, units, class, Manufacturer,pcode, barcode,storageLoc,qty,reorderqty,expirydate,supplier,package,price,additionalinfo) VALUES" +
                "                                           (@primary,@generic,@strength,@units,@Dclass,@Manufac,@pcode,@barcode,@storageLoc,@qty,@reorderqty,@expirydate,@supplier,@package,@price,@additionalinfo);";
            Console.WriteLine(insmanufacturerRec);
            string recExist = "SELECT * FROM '" + tablename + "' WHERE   Nprimary= @primary AND barcode=@barcode;";
                sqlite_cmd.Parameters.AddWithValue("@primary", primary);
                sqlite_cmd.Parameters.AddWithValue("@generic", Generic);
                sqlite_cmd.Parameters.AddWithValue("@strength", strength);
                sqlite_cmd.Parameters.AddWithValue("@units", units);
                sqlite_cmd.Parameters.AddWithValue("@Dclass", Dclass);
                sqlite_cmd.Parameters.AddWithValue("@Manufac", Manufac);
                sqlite_cmd.Parameters.AddWithValue("@pcode", pcode);
                sqlite_cmd.Parameters.AddWithValue("@barcode", barcode);
                sqlite_cmd.Parameters.AddWithValue("@storageLoc", storageLoc);
                sqlite_cmd.Parameters.AddWithValue("@qty", entryStock);
                sqlite_cmd.Parameters.AddWithValue("@reorderqty", reorderqty);
                sqlite_cmd.Parameters.AddWithValue("@expirydate", ExpiryDate);
                sqlite_cmd.Parameters.AddWithValue("@supplier", Supplier);
                sqlite_cmd.Parameters.AddWithValue("@package", Package);
                sqlite_cmd.Parameters.AddWithValue("@price", price);
                sqlite_cmd.Parameters.AddWithValue("@additionalinfo", additionalInfo);
                sqlite_cmd.CommandText = recExist;
                closeConn(conn);
                conn.Open();
            //Console.WriteLine(sqlite_cmd.ExecuteScalar());
                Int64 count =
                        Convert.ToInt64(sqlite_cmd.ExecuteScalar());  // checke record exist before inserting new records
                if (count > 0)
                {
                    imsg.info("Record already exist", "Add Drugs");
                    sqlite_cmd.Dispose();
                    conn.Close();

                    status = false;
                }
                else
                {
                    sqlite_cmd.CommandText = insmanufacturerRec;

                    sqlite_cmd.ExecuteNonQuery();

                    conn.Close();
                    status = true;

                }



                status = true;
            }
            catch (Exception)
            {

                status = false;
            }
            return status;
            }
        public bool UpdateDrugs(int id, string primary, string Generic, string strength, string units, string Dclass, string Manufac,
             string pcode, string barcode, string storageLoc, int entryStock,
             int reorderqty, string ExpiryDate, string Supplier, string Package, Double price, string additionalInfo)
        {
            bool status = false;
            string dbname = "KDMEDISP";
            string tablename = "tblDrugs";
            try
            {
                SQLiteConnection conn = new SQLiteConnection();
                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();
                string update = "UPDATE '" + tablename + "' SET [Nprimary]=@primary, [generic] =@generic, [strength]=@strength, [units]=@units,[class]=@Dclass," +
                        "[Manufacturer]=@Manufac,  [pcode]=@pcode,  [barcode]=@barcode,  [storageLoc]=@storageLoc,  [qty]=@qty, [reorderqty]=@reorderqty ,       "
                       + "[expirydate]=@expirydate,  [supplier]=@supplier,  [package]=@package,  [price]=@price,  [additionalinfo]=@additionalinfo       "
              + "WHERE id= @id";
                string recExist = "SELECT * FROM '" + tablename + "' WHERE   Nprimary= @primary AND barcode=@barcode;";
                sqlite_cmd.Parameters.AddWithValue("@id", id);
                sqlite_cmd.Parameters.AddWithValue("@primary", primary);
                sqlite_cmd.Parameters.AddWithValue("@generic", Generic);
                sqlite_cmd.Parameters.AddWithValue("@strength", strength);
                sqlite_cmd.Parameters.AddWithValue("@units", units);
                sqlite_cmd.Parameters.AddWithValue("@Dclass", Dclass);
                sqlite_cmd.Parameters.AddWithValue("@Manufac", Manufac);
                sqlite_cmd.Parameters.AddWithValue("@pcode", pcode);
                sqlite_cmd.Parameters.AddWithValue("@barcode", barcode);
                sqlite_cmd.Parameters.AddWithValue("@storageLoc", storageLoc);
                sqlite_cmd.Parameters.AddWithValue("@qty", entryStock);
                sqlite_cmd.Parameters.AddWithValue("@reorderqty", reorderqty);
                sqlite_cmd.Parameters.AddWithValue("@expirydate", ExpiryDate);
                sqlite_cmd.Parameters.AddWithValue("@supplier", Supplier);
                sqlite_cmd.Parameters.AddWithValue("@package", Package);
                sqlite_cmd.Parameters.AddWithValue("@price", price);
                sqlite_cmd.Parameters.AddWithValue("@additionalinfo", additionalInfo);
                sqlite_cmd.CommandText = recExist;
                closeConn(conn);
                conn.Open();
                sqlite_cmd.CommandText = update;



                sqlite_cmd.ExecuteNonQuery();

                conn.Close();
                status = true;
            



                status = true;
        }
            catch (Exception)
            {

                status = false;
            }
            return status;
        }

        public bool InsertPrescriber(string title, string sex, string dob, string firstname, string lastname, string othername, string Email, string phone, string staffID, string address, string ImgUrl = "")
            {
                bool status = false;
                string dbname = "KDMEDISP";
                string tablename = "tblprescribers";
                //try
                //{
                SQLiteConnection conn = new SQLiteConnection();
                Console.WriteLine();
                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();
                string insmanufacturerRec = "INSERT INTO '" + tablename + "'  (title,sex, dob, firstname, lastname,othername,email, phone,staffid,address,imgUrl) VALUES (@title, @sex,@dob, @firstname, @lastname,@othername, @email, @phone,@staffid,@address,@imgUrl);";
                string recExist = "SELECT * FROM '" + tablename + "'  WHERE sex=@sex AND  firstname= @firstname AND lastname=@lastname AND othername=@othername AND staffid=@staffid AND dob=@dob;";
                sqlite_cmd.Parameters.AddWithValue("@title", title);
                sqlite_cmd.Parameters.AddWithValue("@sex", sex);
                sqlite_cmd.Parameters.AddWithValue("@dob", dob);
                sqlite_cmd.Parameters.AddWithValue("@firstname", firstname);
                sqlite_cmd.Parameters.AddWithValue("@lastname", lastname);
                sqlite_cmd.Parameters.AddWithValue("@othername", othername);
                sqlite_cmd.Parameters.AddWithValue("@email", Email);
                sqlite_cmd.Parameters.AddWithValue("@phone", phone);
                sqlite_cmd.Parameters.AddWithValue("@staffid", staffID);
                sqlite_cmd.Parameters.AddWithValue("@address", address);
                sqlite_cmd.Parameters.AddWithValue("@imgUrl", ImgUrl);
                sqlite_cmd.CommandText = recExist;
                closeConn(conn);
                conn.Open();

                Int64 count =
                        Convert.ToInt64(sqlite_cmd.ExecuteScalar());  // checke record exist before inserting new records
                if (count > 0)
                {
                    imsg.info("Record already exist", "Add Product");
                    sqlite_cmd.Dispose();
                    conn.Close();

                    status = false;
                }
                else
                {
                    sqlite_cmd.CommandText = insmanufacturerRec;
                    status = true;


                }


                sqlite_cmd.ExecuteNonQuery();

                conn.Close();
                status = true;
                //}
                //catch (Exception)
                //{

                //    status = false;
                //}
                return status;
            }
            public string GetSingleData(string dbname, string tablename, object param, object selID = null)
            {
                string val = "";

                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.Parameters.AddWithValue("@selID", selID);
                    string SelectQuery = "SELECT " + param + " FROM " + tablename + " ";
                    if (selID != null)
                    {
                        SelectQuery += " WHERE id=@selID";
                    }
                    sqlite_cmd.CommandText = SelectQuery;
                    Console.WriteLine(SelectQuery);
                    if (sqlite_cmd.ExecuteScalar() == null)
                    {
                        val = "";
                    }
                    else
                    {
                        val = sqlite_cmd.ExecuteScalar().ToString();
                    }


                    conn.Close();






                }
                catch (Exception)
                {

                }
                return val;

            }
        public int checkActivateExist()
        {
            int val = -1;

            try
            {
                SQLiteConnection conn = new SQLiteConnection();
                conn = CreateConnection("KDMEDISP");
                SQLiteCommand sqlite_cmd = conn.CreateCommand();
                string SelectQuery = "SELECT id from tblactivate where id=1 ";
                sqlite_cmd.CommandText = SelectQuery;
                Console.WriteLine(SelectQuery);
                if (sqlite_cmd.ExecuteScalar() == null)
                {
                    return -1;
                }
                else
                {
                    val = Convert.ToInt32(sqlite_cmd.ExecuteScalar().ToString());
                }


                conn.Close();






            }
            catch (Exception)
            {

            }
            return val;

        }
        public int checkCountExist()
        {
            int val = -1;

            try
            {
                SQLiteConnection conn = new SQLiteConnection();
                conn = CreateConnection("KDMEDISP");
                SQLiteCommand sqlite_cmd = conn.CreateCommand();
                string SelectQuery = "SELECT id from tblCount where id=1 ";
                sqlite_cmd.CommandText = SelectQuery;
                Console.WriteLine(SelectQuery);
                if (sqlite_cmd.ExecuteScalar() == null)
                {
                    return -1;
                }
                else
                {
                    val = Convert.ToInt32(sqlite_cmd.ExecuteScalar().ToString());
                }


                conn.Close();






            }
            catch (Exception)
            {

            }
            return val;

        }
        public int GetIDForEstoreID(int EstoreID)
            {
                int val = -1;

                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    conn = CreateConnection("KDMEDISP");
                    SQLiteCommand sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.Parameters.AddWithValue("@EstoreID", EstoreID);
                    string SelectQuery = "SELECT id from tblproduct where EstoreID=@EstoreID ";
                    sqlite_cmd.CommandText = SelectQuery;
                    Console.WriteLine(SelectQuery);
                    if (sqlite_cmd.ExecuteScalar() == null)
                    {
                        return -1;
                    }
                    else
                    {
                        val = Convert.ToInt32(sqlite_cmd.ExecuteScalar().ToString());
                    }


                    conn.Close();






                }
                catch (Exception)
                {

                }
                return val;

            }
            public bool CheckPCodeExist(string pcode)
            {
                bool exist = false;

                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    conn = CreateConnection("KDMEDISP");
                    SQLiteCommand sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.Parameters.AddWithValue("@pcode", pcode);
                    string SelectQuery = "SELECT pcode from tblproduct where pcode=@pcode ";
                    sqlite_cmd.CommandText = SelectQuery;
                    Console.WriteLine(SelectQuery);
                    if (sqlite_cmd.ExecuteScalar() == null)
                    {
                        conn.Close();
                        return false;
                    }
                    else
                    {
                        conn.Close();
                        return true;
                    }
                }
                catch (Exception)
                {

                }
                return exist;

            }
            public bool getPrescriberID(string staffID)
            {
                string val = null;
                DataSet dset = new DataSet();
                DataTable dt = new DataTable();
                DataTable retTable = new DataTable();
                string tablename = "tblprescribers";
                string dbname = "KDMEDISP";
                bool stats = false;
                //try
                //{
                SQLiteConnection conn = new SQLiteConnection();
                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.Parameters.AddWithValue("@staffID", staffID);
                sqlite_cmd.CommandText = "SELECT count(*) FROM tblPrescribers where staffID=@staffID";

                int idexist = Convert.ToInt32(sqlite_cmd.ExecuteScalar());

                if (idexist > 0)
                {
                    stats = true;
                }
                else
                {
                    //Username doesn't exist.
                    stats = false;

                }

                conn.Close();






                //}
                //catch (Exception)
                //{

                //}

                return stats;

            }

            public bool getPatientID(string patientID)
            {
                string val = null;
                DataSet dset = new DataSet();
                DataTable dt = new DataTable();
                DataTable retTable = new DataTable();
                string dbname = "KDMEDISP";
                bool stats = false;
                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.Parameters.AddWithValue("@patientID", patientID);
                    sqlite_cmd.CommandText = "SELECT count(*) FROM tblpatients where patientID=@patientID";

                    int idexist = Convert.ToInt32(sqlite_cmd.ExecuteScalar());

                    if (idexist > 0)
                    {
                        stats = true;
                    }
                    else
                    {
                        //Username doesn't exist.
                        stats = false;

                    }

                    conn.Close();






                }
                catch (Exception)
                {

                }

                return stats;

            }
        public bool getDrugPcode(string pcode)
        {
            string val = null;
            DataSet dset = new DataSet();
            DataTable dt = new DataTable();
            DataTable retTable = new DataTable();
            string dbname = "KDMEDISP";
            bool stats = false;
            try
            {
                SQLiteConnection conn = new SQLiteConnection();
                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.Parameters.AddWithValue("@pcode", pcode);
                sqlite_cmd.CommandText = "SELECT count(*) FROM tblDrugs where pcode=@pcode";

                int idexist = Convert.ToInt32(sqlite_cmd.ExecuteScalar());

                if (idexist > 0)
                {
                    stats = true;
                }
                else
                {
                    //Username doesn't exist.
                    stats = false;

                }

                conn.Close();






            }
            catch (Exception)
            {

            }

            return stats;

        }
        public bool getStockRefExist(string refno)
        {
            string val = null;
            DataSet dset = new DataSet();
            DataTable dt = new DataTable();
            DataTable retTable = new DataTable();
            string dbname = "KDMEDISP";
            bool stats = false;
            try
            {
                SQLiteConnection conn = new SQLiteConnection();
                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.Parameters.AddWithValue("@refno", refno);
                sqlite_cmd.CommandText = "SELECT count(*) FROM tblstockin where refno=@refno";

                int idexist = Convert.ToInt32(sqlite_cmd.ExecuteScalar());

                if (idexist > 0)
                {
                    stats = true;
                }
                else
                {
                    //Username doesn't exist.
                    stats = false;

                }

                conn.Close();






            }
            catch (Exception)
            {

            }

            return stats;

        }
        public int getIDfromPatientID(string patientID)
            {
                string val = null;
                DataSet dset = new DataSet();
                DataTable dt = new DataTable();
                DataTable retTable = new DataTable();
                int idexist = 0;
                string dbname = "KDMEDISP";
                bool stats = false;
                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.Parameters.AddWithValue("@patientID", patientID);
                    sqlite_cmd.CommandText = "SELECT id FROM tblpatients where patientID=@patientID";

                    idexist = Convert.ToInt32(sqlite_cmd.ExecuteScalar());

                    if (idexist > 0)
                    {
                        stats = true;
                    }
                    else
                    {
                        //Username doesn't exist.
                        stats = false;

                    }

                    conn.Close();






                }
                catch (Exception)
                {

                }

                return idexist;

            }
            public int getIDfromStaffID(string staffID)
            {
                string val = null;
                DataSet dset = new DataSet();
                DataTable dt = new DataTable();
                DataTable retTable = new DataTable();
                int idexist = 0;
                string dbname = "KDMEDISP";
                bool stats = false;
                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.Parameters.AddWithValue("@staffID", staffID);
                    sqlite_cmd.CommandText = "SELECT id FROM tblprescribers where staffID=@staffID";

                    idexist = Convert.ToInt32(sqlite_cmd.ExecuteScalar());

                    if (idexist > 0)
                    {
                        stats = true;
                    }
                    else
                    {
                        //Username doesn't exist.
                        stats = false;

                    }

                    conn.Close();






                }
                catch (Exception)
                {

                }

                return idexist;

            }
            public bool SingleCheckExist(string dbname, string tablename, object param, int selID = 1)
            {
                string val = null;
                DataSet dset = new DataSet();
                DataTable dt = new DataTable();
                DataTable retTable = new DataTable();

                bool stats = false;
                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.Parameters.AddWithValue("@selID", selID);
                    sqlite_cmd.CommandText = "SELECT * FROM " + tablename + " where id=@selID";

                    Int64 count = Convert.ToInt64(sqlite_cmd.ExecuteScalar());  // checked record exist 
                    if (count > 0)
                    {
                        stats = true;
                    }


                    conn.Close();






                }
                catch (Exception)
                {

                }

                return stats;

            }
            public string getBid(string manufacturer)
            {
                string dbname = "KDMEDISP";
                string tablename = "tblManufacturers";
                string bid = null;
                DataSet dset = new DataSet();
                DataTable dt = new DataTable();
                DataTable retTable = new DataTable();

                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = "SELECT id FROM " + tablename + " where manufacturer like @manufacturer";
                    sqlite_cmd.Parameters.AddWithValue("@manufacturer", manufacturer);

                    bid = sqlite_cmd.ExecuteScalar().ToString();


                    conn.Close();






                }
                catch (Exception)
                {

                }

                return bid;

            }
        public int getActivateStatus()
        {
            string dbname = "KDMEDISP";
            string tablename = "tblActivate";
            int bid = 0;
            DataSet dset = new DataSet();
            DataTable dt = new DataTable();
            DataTable retTable = new DataTable();

            try
            {
                SQLiteConnection conn = new SQLiteConnection();
                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT activate FROM " + tablename + " where id=1";

                bid = Convert.ToInt16(sqlite_cmd.ExecuteScalar().ToString());


                conn.Close();






            }
            catch (Exception)
            {

            }

            return bid;

        }
        public int getlastID(string tablename)
            {
                string dbname = "KDMEDISP";
                int bid = 0;
                DataSet dset = new DataSet();
                DataTable dt = new DataTable();
                DataTable retTable = new DataTable();

                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = "SELECT id FROM " + tablename + " Order by ID DESC limit 1";

                    bid = Convert.ToInt32(sqlite_cmd.ExecuteScalar());


                    conn.Close();






                }
                catch (Exception)
                {

                }

                return bid;

            }
            public bool DefaultPrinterExist()
            {
                string dbname = "KDMEDISP";
                string tablename = "tblDefPrinter";
                DataTable dt = new DataTable();
                DataTable retTable = new DataTable();
                bool status = false;
                string SavedprinterName = "0";
                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = "SELECT * FROM " + tablename + " where id =1";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_cmd);
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        status = true;
                    }


                    conn.Close();






                }
                catch (Exception)
                {

                }

                return status;

            }
            public string getSaveDefPrinter()
            {
                string dbname = "KDMEDISP";
                string tablename = "tblDefPrinter";
                DataTable dt = new DataTable();
                DataTable retTable = new DataTable();
                string DefPrinterName = "";
                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = "SELECT * FROM " + tablename + " where id =1";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_cmd);
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        DefPrinterName = dt.Rows[0]["DefPrinter"].ToString();
                    }
                    else
                    {
                        DefPrinterName = "No Printer Set!";
                    }

                    conn.Close();






                }
                catch (Exception)
                {

                }

                return DefPrinterName;

            }
            public string getCid(string category)
            {
                string dbname = "KDMEDISP";
                string tablename = "tblcategory";
                bool stats = false;
                string cid = null;
                DataSet dset = new DataSet();
                DataTable dt = new DataTable();
                DataTable retTable = new DataTable();

                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = "SELECT id FROM " + tablename + " where category like @category";
                    sqlite_cmd.Parameters.AddWithValue("@category", category);

                    cid = sqlite_cmd.ExecuteScalar().ToString();


                    conn.Close();






                }
                catch (Exception)
                {

                }

                return cid;

            }


        public int getCount()
        {
            string dbname = "KDMEDISP";
            string tablename = "tblCount";
            bool stats = false;
            int cid = 0;
            DataSet dset = new DataSet();
            DataTable dt = new DataTable();
            DataTable retTable = new DataTable();

            try
            {
                SQLiteConnection conn = new SQLiteConnection();
                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT count FROM " + tablename + " where id=1";

                cid =Convert.ToInt16(sqlite_cmd.ExecuteScalar().ToString());


                conn.Close();






            }
            catch (Exception)
            {

            }

            return cid;

        }
        public object returnStockProduct(string pcode = " ", string dbname = "KDMEDISP")
            {
                bool stats = false;
                DataSet dset = new DataSet();
                DataTable dt = new DataTable();
                DataTable retTable = new DataTable();

                try
                {

                    SQLiteConnection conn = new SQLiteConnection();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = "select * from tblproduct where LOWER(pcode) like '%" + pcode + "%' ";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_cmd);

                    da.Fill(dt);

                    conn.Close();



                    if (dt.Rows.Count == 0)
                    {
                        retTable.Columns.Add("Records");
                        retTable.Rows.Add("No record Found");
                    }
                    else
                    {
                        retTable = dt;
                    }


                }
                catch (Exception)
                {

                }


                return retTable;

            }

            public object returnTransno(string sdate, string dbname = "KDMEDISP")
            {
                bool stats = false;
                DataSet dset = new DataSet();
                DataTable dt = new DataTable();
                DataTable retTable = new DataTable();

                try
                {

                    SQLiteConnection conn = new SQLiteConnection();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = "SELECT transno  from tblcart where transno like '" + sdate + "%'   order by id DESC LIMIT 1";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_cmd);

                    da.Fill(dt);

                    conn.Close();




                    retTable = dt;



                }
                catch (Exception)
                {

                }
                return retTable;
            }
        public object returnPresID(string sdate, string dbname = "KDMEDISP")
        {
            bool stats = false;
            DataSet dset = new DataSet();
            DataTable dt = new DataTable();
            DataTable retTable = new DataTable();

            try
            {

                SQLiteConnection conn = new SQLiteConnection();
                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT prescriptionID  from tblprescriptions where prescriptionID like 'DISP/" + sdate + "%'   order by id DESC LIMIT 1";
                SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_cmd);

                da.Fill(dt);

                conn.Close();




                retTable = dt;



            }
            catch (Exception)
            {

            }
            return retTable;
        }
        public object ReturnPrescriptionCart(string prescriptionID = " ", string dbname = "KDMEDISP")
        {
            bool stats = false;
            DataSet dset = new DataSet();
            DataTable dt = new DataTable();
            DataTable retTable = new DataTable();

            try
            {

                SQLiteConnection conn = new SQLiteConnection();
                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = "select * from tblPrescriptions where prescriptionID like @prescriptionID;";
                sqlite_cmd.Parameters.AddWithValue("@prescriptionID", prescriptionID);
                SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_cmd);

                da.Fill(dt);

                conn.Close();



                if (dt.Rows.Count == 0)
                {
                    retTable = null;
                }
                else
                {
                    retTable = dt;
                }


            }
            catch (Exception)
            {

            }

            return retTable;

        }
        public object ReturnPendingCart(string transno = " ", string dbname = "KDMEDISP")
            {
                bool stats = false;
                DataSet dset = new DataSet();
                DataTable dt = new DataTable();
                DataTable retTable = new DataTable();

                try
                {

                    SQLiteConnection conn = new SQLiteConnection();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = "select c.id, c.pcode,  p.nprimary, c.price, c.qty, c.discount, c.total from tblcart AS c inner join tblDrugs AS  p on c.pcode=p.pcode where transno like @transno;";
                    sqlite_cmd.Parameters.AddWithValue("@transno", transno);
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_cmd);

                    da.Fill(dt);

                    conn.Close();



                    if (dt.Rows.Count == 0)
                    {
                        retTable = null;
                    }
                    else
                    {
                        retTable = dt;
                    }


                }
                catch (Exception)
                {

                }

                return retTable;

            }
            public object returnProduct(int reorderMode, string pdesc = " ", string dbname = "KDMEDISP")
            {
                bool stats = false;
                DataSet dset = new DataSet();
                DataTable dt = new DataTable();
                DataTable retTable = new DataTable();

                try
                {

                    SQLiteConnection conn = new SQLiteConnection();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd = conn.CreateCommand();
                    string Query = "select p.pcode, p.pbcode, p.nprimary, b.manufacturer, c.category, p.price,p.qty,p.reorderqty, p.imgurl,p.estoreID from tblproducts as p inner join tblManufacturers  as  b" +
                        " on b.id=p.bid inner join tblcategory" +
                        " as c on c.id=p.cid where LOWER(p.pdesc) like '%" + pdesc + "%' ";
                    if (reorderMode == 1)
                    {
                        Query += "  order  by qty ASC";
                    }
                    else if (reorderMode == 0)
                    {
                        Query += "  order  by qty DESC";

                    }
                    else if (reorderMode == 2)
                    {
                        Query += "  order  by pdesc";

                    }

                    sqlite_cmd.CommandText = Query;
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_cmd);

                    da.Fill(dt);

                    conn.Close();



                    if (dt.Rows.Count == 0)
                    {
                        retTable.Columns.Add("Records");
                        retTable.Rows.Add("No record Found");
                    }
                    else
                    {
                        retTable = dt;
                    }

                    stats = true;

                }
                catch (Exception)
                {

                    stats = false;
                }

                return retTable;

            }
            public object returnDsReceipt(string transno, string dbname = "KDMEDISP")
            {
                bool stats = false;
                DataTable dt = new DataTable();
                DataTable retTable = new DataTable();

                try
                {

                    SQLiteConnection conn = new SQLiteConnection();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd = conn.CreateCommand();
                    string Query = "select c.id , c.transno, c.pcode,c.price,c.qty,c.discount,c.total,c.sdate,c.status,"
                        + "p.pdesc from tblCart as c inner join tblproduct as p on p.pcode=c.pcode where transno like '%" + transno + "%' ";


                    sqlite_cmd.CommandText = Query;
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_cmd);

                    da.Fill(dt);

                    conn.Close();



                    if (dt.Rows.Count == 0)
                    {
                        retTable.Columns.Add("Records");
                        retTable.Rows.Add("No record Found");
                    }
                    else
                    {
                        retTable = dt;
                    }

                    stats = true;

                }
                catch (Exception)
                {

                    stats = false;
                }

                return retTable;

            }
            public object returnBarcodeProduct(string search = " ", string dbname = "KDMEDISP")
            {
                bool stats = false;
                DataSet dset = new DataSet();
                DataTable dt = new DataTable();
                DataTable retTable = new DataTable();

                try
                {

                    SQLiteConnection conn = new SQLiteConnection();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = "SELECT * from tbldrugs where LOWER(barcode) like '" + search.ToLower() + "' ";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_cmd);

                    da.Fill(dt);

                    conn.Close();




                    retTable = dt;



                }
                catch (Exception)
                {

                }

                return retTable;

            }

            public object returnViewStockinHistory(DateTime start, DateTime end, string dbname = "KDMEDISP")
            {
                bool stats = false;
                DataSet dset = new DataSet();
                DataTable dt = new DataTable();
                DataTable retTable = new DataTable();
                start = DateTime.Parse(start.ToShortDateString());
                end = DateTime.Parse(end.ToShortDateString());
                try
                {

                    SQLiteConnection conn = new SQLiteConnection();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = "SELECT * FROM vStockin WHERE  DATE(sdate) BETWEEN @start AND @end "
                    + " AND status LIKE 'done' ";
                    sqlite_cmd.Parameters.AddWithValue("@start", start);
                    sqlite_cmd.Parameters.AddWithValue("@end", end);
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_cmd);
                    da.Fill(dt);




                    if (dt.Rows.Count == 0)
                    {
                        retTable.Columns.Add("Records");
                        retTable.Rows.Add("No record Found");
                    }
                    else
                    {
                        retTable = dt;
                    }

                    stats = true;

                }
                catch (Exception)
                {

                }

                return retTable;

            }
            public object returnViewStockin(string refno, string dbname = "KDMEDISP")
            {
                bool stats = false;
                DataSet dset = new DataSet();
                DataTable dt = new DataTable();
                DataTable retTable = new DataTable();

                try
                {

                    SQLiteConnection conn = new SQLiteConnection();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = "select * FROM vStockin where refno like @refno AND status like 'pending' ";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_cmd);
                    sqlite_cmd.Parameters.AddWithValue("@refno", refno);
                    da.Fill(dt);

                    conn.Close();



                    if (dt.Rows.Count == 0)
                    {
                        retTable.Columns.Add("Records");
                        retTable.Rows.Add("No record Found");
                    }
                    else
                    {
                        retTable = dt;
                    }

                    stats = true;

                }
                catch (Exception)
                {

                    stats = false;
                }

                return retTable;

            }
            public object CreateViewStockIn(string dbname = "KDMEDISP")
            {
                bool stats = false;
                DataSet dset = new DataSet();
                DataTable dt = new DataTable();
                DataTable retTable = new DataTable();

                try
                {

                    SQLiteConnection conn = new SQLiteConnection();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = "CREATE VIEW  IF NOT EXISTS vStockin AS SELECT tblstockin.id,tblstockin.refno,  tblstockin.pcode,tbldrugs.nprimary,"
                                            + "tblstockin.qty,tblstockin.sdate,tblstockin.stockinby, tblstockin.status"
                               + " FROM tbldrugs   INNER JOIN  tblstockin ON tbldrugs.pcode = tblstockin.pcode; ";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_cmd);

                    da.Fill(dt);

                    conn.Close();



                    if (dt.Rows.Count == 0)
                    {
                        retTable.Columns.Add("Records");
                        retTable.Rows.Add("No record Found");
                    }
                    else
                    {
                        retTable = dt;
                    }

                    stats = true;

                }
                catch (Exception)
                {

                    stats = false;
                }

                return retTable;

            }
            public object CreateTopSellingView(string dbname = "KDMEDISP")
            {
                bool stats = false;
                DataSet dset = new DataSet();
                DataTable dt = new DataTable();
                DataTable retTable = new DataTable();

                try
                {

                    SQLiteConnection conn = new SQLiteConnection();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = "CREATE VIEW  IF NOT EXISTS vTopSelling AS SELECT tblcart.pcode, tblcart.qty,tblproduct.pdesc, "
                    + " tblcart.sdate,tblcart.status FROM tblcart   INNER JOIN  tblproduct ON tblcart.pcode = tblproduct.pcode ";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_cmd);

                    da.Fill(dt);

                    conn.Close();



                    if (dt.Rows.Count == 0)
                    {
                        retTable.Columns.Add("Records");
                        retTable.Rows.Add("No record Found");
                    }
                    else
                    {
                        retTable = dt;
                    }

                    stats = true;

                }
                catch (Exception)
                {

                    stats = false;
                }

                return retTable;

            }
            public object returnStock(string search = " ", string dbname = "KDMEDISP")
            {
                bool stats = false;
                DataSet dset = new DataSet();
                DataTable dt = new DataTable();
                DataTable retTable = new DataTable();

                //try
                //{

                    SQLiteConnection conn = new SQLiteConnection();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = "select * from tbldrugs where Lower(nprimary) like '%" + search + "%' order by nprimary";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_cmd);

                    da.Fill(dt);

                    conn.Close();



                    if (dt.Rows.Count == 0)
                    {
                        retTable.Columns.Add("Records");
                        retTable.Rows.Add("No record Found");
                    }
                    else
                    {
                        retTable = dt;
                    }

                    stats = true;

                //}
                //catch (Exception)
                //{

                //    stats = false;
                //}

                return retTable;

            }

            public object returnPatients(string dbname, string tablename)
            {
                bool stats = false;
                DataSet dset = new DataSet();
                DataTable dt = new DataTable();
                DataTable retTable = new DataTable();

                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = "SELECT * FROM " + tablename + " order by id;";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_cmd);


                    da.Fill(dt);

                    conn.Close();



                    if (dt.Rows.Count == 0)
                    {
                        retTable.Columns.Add("Records");
                        retTable.Rows.Add("No record Found");
                    }
                    else
                    {
                        retTable = dt;
                    }

                    stats = true;

                }
                catch (Exception)
                {

                    stats = false;
                }

                return retTable;

            }

            public object returnManufacturers(string dbname, string tablename)
            {
                bool stats = false;
                DataSet dset = new DataSet();
                DataTable dt = new DataTable();
                DataTable retTable = new DataTable();

                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = "SELECT * FROM " + tablename + " order by id;";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_cmd);


                    da.Fill(dt);

                    conn.Close();



                    if (dt.Rows.Count == 0)
                    {
                        retTable.Columns.Add("Records");
                        retTable.Rows.Add("No record Found");
                    }
                    else
                    {
                        retTable = dt;
                    }

                    stats = true;

                }
                catch (Exception)
                {

                    stats = false;
                }

                return retTable;

            }
            public object returnSuppliers(string dbname, string tablename)
            {
                bool stats = false;
                DataSet dset = new DataSet();
                DataTable dt = new DataTable();
                DataTable retTable = new DataTable();

                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = "SELECT * FROM " + tablename + " order by id;";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_cmd);


                    da.Fill(dt);

                    conn.Close();



                    if (dt.Rows.Count == 0)
                    {
                        retTable.Columns.Add("Records");
                        retTable.Rows.Add("No record Found");
                    }
                    else
                    {
                        retTable = dt;
                    }

                    stats = true;

                }
                catch (Exception)
                {

                    stats = false;
                }

                return retTable;

            }

        public object returnDrugs(string dbname, string tablename)
        {
            bool stats = false;
            DataSet dset = new DataSet();
            DataTable dt = new DataTable();
            DataTable retTable = new DataTable();

            try
            {
                SQLiteConnection conn = new SQLiteConnection();
                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM " + tablename + " order by id;";
                SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_cmd);


                da.Fill(dt);

                conn.Close();



                if (dt.Rows.Count == 0)
                {
                    retTable.Columns.Add("Records");
                    retTable.Rows.Add("No record Found");
                }
                else
                {
                    retTable = dt;
                }

                stats = true;

            }
            catch (Exception)
            {

                stats = false;
            }

            return retTable;

        }

        public object returnDefaultDrugs(string dbname, string tablename,string searchQuery=" ")
        {
            bool stats = false;
            DataSet dset = new DataSet();
            DataTable dt = new DataTable();
            DataTable retTable = new DataTable();

            try
            {
                SQLiteConnection conn = new SQLiteConnection();
                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd = conn.CreateCommand();
            
                    sqlite_cmd.CommandText = "SELECT * FROM " + tablename + " WHERE  LOWER(generic) like '%" + searchQuery.ToLower() + "%' ";

                
                SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_cmd);


                da.Fill(dt);

                conn.Close();



                if (dt.Rows.Count == 0)
                {
                    retTable.Columns.Add("Records");
                    retTable.Rows.Add("No record Found");
                }
                else
                {
                    retTable = dt;
                }

                stats = true;

            }
            catch (Exception)
            {

                stats = false;
            }

            return retTable;

        }
        public object returnDrugsfromPcode(string pcode)
        {
            bool stats = false;
            DataSet dset = new DataSet();
            DataTable dt = new DataTable();
            DataTable retTable = new DataTable();
            string dbname = "KDMEDISP";
            try
            {
                SQLiteConnection conn = new SQLiteConnection();
                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.Parameters.AddWithValue("@pcode", pcode);
                sqlite_cmd.CommandText = "SELECT * FROM  tbldrugs  where pcode=@pcode order by id;";
                SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_cmd);


                da.Fill(dt);

                conn.Close();



                if (dt.Rows.Count == 0)
                {
                    retTable.Columns.Add("Records");
                    retTable.Rows.Add("No record Found");
                }
                else
                {
                    retTable = dt;
                }

                stats = true;

            }
            catch (Exception)
            {

                stats = false;
            }

            return retTable;

        }
        public object returnPrescribers(string dbname, string tablename)
            {
                bool stats = false;
                DataSet dset = new DataSet();
                DataTable dt = new DataTable();
                DataTable retTable = new DataTable();

                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = "SELECT * FROM " + tablename + " order by id;";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_cmd);


                    da.Fill(dt);

                    conn.Close();



                    if (dt.Rows.Count == 0)
                    {
                        retTable.Columns.Add("Records");
                        retTable.Rows.Add("No record Found");
                    }
                    else
                    {
                        retTable = dt;
                    }

                    stats = true;

                }
                catch (Exception)
                {

                    stats = false;
                }

                return retTable;

            }
            public object returnPrescriberfromStaffID(string staffID)
            {
                string dbname = "KDMEDISP", tablename = "tblprescribers";
                bool stats = false;
                DataSet dset = new DataSet();
                DataTable dt = new DataTable();
                DataTable retTable = new DataTable();

                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.Parameters.AddWithValue("@staffID", staffID);
                    sqlite_cmd.CommandText = "SELECT * FROM " + tablename + " where staffID =@staffID;";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_cmd);


                    da.Fill(dt);

                    conn.Close();



                    if (dt.Rows.Count == 0)
                    {
                        return null;
                    }
                    else
                    {
                        retTable = dt;
                    }

                    stats = true;

                }
                catch (Exception)
                {

                    stats = false;
                }

                return retTable;

            }
        public object returnPrescriberfromtblID(string id)
        {
            string dbname = "KDMEDISP", tablename = "tblprescribers";
            bool stats = false;
            DataSet dset = new DataSet();
            DataTable dt = new DataTable();
            DataTable retTable = new DataTable();

            try
            {
                SQLiteConnection conn = new SQLiteConnection();
                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.Parameters.AddWithValue("@id", id);
                sqlite_cmd.CommandText = "SELECT * FROM " + tablename + " where id =@id;";
                SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_cmd);


                da.Fill(dt);

                conn.Close();



                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                else
                {
                    retTable = dt;
                }

                stats = true;

            }
            catch (Exception)
            {

                stats = false;
            }

            return retTable;

        }
        public object returnPatientfromID(string patientID)
            {
                string dbname = "KDMEDISP", tablename = "tblpatients";
                bool stats = false;
                DataSet dset = new DataSet();
                DataTable dt = new DataTable();
                DataTable retTable = new DataTable();

                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.Parameters.AddWithValue("@patientID", patientID);
                    sqlite_cmd.CommandText = "SELECT * FROM " + tablename + " where patientID =@patientID;";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_cmd);


                    da.Fill(dt);

                    conn.Close();



                    if (dt.Rows.Count == 0)
                    {
                        return null;
                    }
                    else
                    {
                        retTable = dt;
                    }

                    stats = true;

                }
                catch (Exception)
                {

                    stats = false;
                }

                return retTable;

            }
        public object returnPatientfromtblID(string id)
        {
            string dbname = "KDMEDISP", tablename = "tblpatients";
            bool stats = false;
            DataSet dset = new DataSet();
            DataTable dt = new DataTable();
            DataTable retTable = new DataTable();

            try
            {
                SQLiteConnection conn = new SQLiteConnection();
                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.Parameters.AddWithValue("@id", id);
                sqlite_cmd.CommandText = "SELECT * FROM " + tablename + " where id =@id;";
                SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_cmd);


                da.Fill(dt);

                conn.Close();



                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                else
                {
                    retTable = dt;
                }

                stats = true;

            }
            catch (Exception)
            {

                stats = false;
            }

            return retTable;

        }
        public bool CheckBarCodeExist(string pbcode)
            {
                string dbname = "KDMEDISP";
                string tablename = "tblbarcodes";
                bool stats = false;
                DataSet dset = new DataSet();
                DataTable dt = new DataTable();
                DataTable retTable = new DataTable();

                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = "SELECT pbcode FROM " + tablename + " where pbcode=@pbcode;";
                    sqlite_cmd.Parameters.AddWithValue("@pbcode", pbcode);
                    if (sqlite_cmd.ExecuteScalar() == null)
                    {
                        stats = false;
                    }
                    else
                    {
                        stats = true;
                    }

                    conn.Close();




                }
                catch (Exception)
                {

                }

                return stats;

            }
            public object returnCategory(string dbname, string tablename)
            {
                bool stats = false;
                DataSet dset = new DataSet();
                DataTable dt = new DataTable();
                DataTable retTable = new DataTable();

                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = "SELECT * FROM " + tablename + " order by category;";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_cmd);


                    da.Fill(dt);

                    conn.Close();



                    if (dt.Rows.Count == 0)
                    {
                        retTable.Columns.Add("Records");
                        retTable.Rows.Add("No record Found");
                    }
                    else
                    {
                        retTable = dt;
                    }

                    stats = true;

                }
                catch (Exception)
                {

                    stats = false;
                }

                return retTable;

            }
            public object returnSoldItems(DateTime startdate, DateTime enddate, string dbname, string tablename)
            {
                DataSet dset = new DataSet();
                DataTable dt = new DataTable();
                DataTable retTable = new DataTable();

                //try
                //{
                    SQLiteConnection conn = new SQLiteConnection();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = "SELECT c.id, c.sdate, c.transno, c.pcode, p.nprimary, c.price , c.qty, c.discount,  c.total from tblcart  as c inner join tbldrugs as p on  c.pcode=p.pcode where c.status  like  'sold' and DATE(c.sdate) ";
                    sqlite_cmd.Parameters.AddWithValue("@start", startdate);
                    sqlite_cmd.Parameters.AddWithValue("@end", enddate);
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_cmd);


                    da.Fill(dt);

                    conn.Close();



                    if (dt.Rows.Count == 0)
                    {
                retTable = null;
                    }
                    else
                    {
                        retTable = dt;
                    }


                //}
                //catch (Exception)
                //{

                //}

                return retTable;

            }
            public object ReturnCashierPerf(DateTime startdate, DateTime enddate)
            {
                DataSet dset = new DataSet();
                DataTable dt = new DataTable();
                DataTable retTable = new DataTable();
                string dbname, tablename;
                dbname = "KDMEDISP";
                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = "select SUM (c.qty)  as qty,  a.username,  c.total from tblcart as c inner join adminlogin as a where c.adminID=a.id AND sdate >= @start   and sdate<= @end Group by c.adminID  order by  qty desc";
                    sqlite_cmd.Parameters.AddWithValue("@start", startdate.ToString());
                    sqlite_cmd.Parameters.AddWithValue("@end", enddate.ToString());
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_cmd);

                    da.Fill(dt);

                    conn.Close();



                    if (dt.Rows.Count == 0)
                    {
                        retTable = null;
                    }
                    else
                    {
                        retTable = dt;
                    }


                }
                catch (Exception)
                {

                }

                return retTable;

            }
            public object returnTopSelling(DateTime startdate, DateTime enddate)
            {
                DataSet dset = new DataSet();
                DataTable dt = new DataTable();
                DataTable retTable = new DataTable();
                string dbname, tablename;
                dbname = "KDMEDISP";
                tablename = "vTopSelling";
                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = "SELECT pcode, pdesc, qty from vTopSelling  WHERE sdate >= @start   and sdate<= @end order by  qty desc";
                    sqlite_cmd.Parameters.AddWithValue("@start", startdate.ToString());
                    sqlite_cmd.Parameters.AddWithValue("@end", enddate.ToString());
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_cmd);

                    da.Fill(dt);

                    conn.Close();



                    if (dt.Rows.Count == 0)
                    {
                        retTable.Columns.Add("Records");
                        retTable.Rows.Add("No record Found");
                    }
                    else
                    {
                        retTable = dt;
                    }


                }
                catch (Exception)
                {

                }

                return retTable;

            }
            public object returnBarcode(string SearchDesc)
            {
                string dbname = "KDMEDISP";
                string tablename = "tblbarcodes";
                bool stats = false;
                DataSet dset = new DataSet();
                DataTable dt = new DataTable();
                DataTable retTable = new DataTable();

                //try
                //{
                SQLiteConnection conn = new SQLiteConnection();
                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * from tblbarcodes where LOWER(pdesc) like '%" + SearchDesc.ToLower() + "%' ";
                SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_cmd);


                da.Fill(dt);

                conn.Close();



                if (dt.Rows.Count == 0)
                {
                    retTable.Columns.Add("Records");
                    retTable.Rows.Add("No record Found");
                }
                else
                {
                    retTable = dt;
                }


                //}
                //catch (exception)
                //{

                //}

                return retTable;

            }
            public bool InsertCategory(string Cat)
            {
                bool status = false;
                string dbname = "KDMEDISP";
                string tablename = "tblcategory";
                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    //Console.WriteLine();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    sqlite_cmd = conn.CreateCommand();
                    string insCateRec = "INSERT INTO '" + tablename + "'  (category) VALUES (@category);";
                    string recExist = "SELECT * FROM '" + tablename + "'  WHERE category    =@category;";



                    sqlite_cmd.Parameters.AddWithValue("@category", Cat);
                    sqlite_cmd.CommandText = recExist;

                    Int64 count =
                        Convert.ToInt64(sqlite_cmd.ExecuteScalar());  // checke record exist before inserting new records
                    if (count > 0)
                    {
                        imsg.info("Record already exist ", "Add Category");
                        sqlite_cmd.Dispose();
                    }
                    else
                    {
                        // conn.Open();
                        sqlite_cmd.CommandText = insCateRec;
                        // frmmanufacturerList.


                    }


                    sqlite_cmd.ExecuteNonQuery();

                    conn.Close();
                    status = true;
                }
                catch (Exception)
                {

                    status = false;
                }
                return status;
            }

        public bool InsertDefaultDrugs(string Generic, string Strength, string dclass)
        {
            bool status = false;
            string dbname = "KDMEDISP";
            string tablename = "tblDefaultDrugList";
            //try
            //{
                SQLiteConnection conn = new SQLiteConnection();
                //Console.WriteLine();
                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();
                string insCateRec = "INSERT INTO '" + tablename + "'  (Generic, Strength,dclass) VALUES (@Generic, @Strength , @dclass);";
                string recExist = "SELECT * FROM '" + tablename + "'  WHERE generic    =@generic AND  Strength=@Strength AND dclass=@dclass;";
                sqlite_cmd.Parameters.AddWithValue("@Generic", Generic);
                sqlite_cmd.Parameters.AddWithValue("@Strength", Strength);
                sqlite_cmd.Parameters.AddWithValue("@dclass", dclass);
                sqlite_cmd.CommandText = recExist;

                Int64 count =
                    Convert.ToInt64(sqlite_cmd.ExecuteScalar());  // checke record exist before inserting new records
                if (count > 0)
                {
                    sqlite_cmd.Dispose();
                }
                else
                {
                    // conn.Open();
                    sqlite_cmd.CommandText = insCateRec;
                    // frmmanufacturerList.


                }


                sqlite_cmd.ExecuteNonQuery();

                conn.Close();
                status = true;
            //}
            //catch (Exception)
            //{

            //    status = false;
            //}
            return status;
        }
        public bool InsertNewPrescription(string prescriptionID, string prescriberID,string medication,string patientID,
            string sig, string dispense, string refill, string daw, string presDate)
        {
            string dbname = "KDMEDISP";
            string tablename = "tblPrescriptions";
            bool status = false;
            try
            {
                SQLiteConnection conn = new SQLiteConnection();
                //Console.WriteLine();
                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();
                string insCateRec = "INSERT INTO '" + tablename + "'  (prescriptionID,prescriberID, medication,patientID,sig,dispense," +
                    "refill,daw,presdate) VALUES (@prescriptionID,@prescriberID,@medication,@patientID,@sig,@dispense,@refill,@daw,@presDate);";
                string recExist = "SELECT * FROM '" + tablename + "'  WHERE prescriptionID    =@prescriptionID  AND medication=@medication and patientID=@patientID and dispense=@dispense and refill=@refill and daw=@daw ";



                sqlite_cmd.Parameters.AddWithValue("@prescriptionID", prescriptionID);
                sqlite_cmd.Parameters.AddWithValue("@prescriberID", prescriberID);
                sqlite_cmd.Parameters.AddWithValue("@medication", medication);
                sqlite_cmd.Parameters.AddWithValue("@patientID", patientID);
                sqlite_cmd.Parameters.AddWithValue("@sig", sig);
                sqlite_cmd.Parameters.AddWithValue("@dispense", dispense);
                sqlite_cmd.Parameters.AddWithValue("@daw", daw);
                sqlite_cmd.Parameters.AddWithValue("@refill", refill);
                sqlite_cmd.Parameters.AddWithValue("@presDate", presDate);
                sqlite_cmd.CommandText = recExist;

                Int64 count =
                    Convert.ToInt64(sqlite_cmd.ExecuteScalar());  // checke record exist before inserting new records
                if (count > 0)
                {
                    imsg.info("Record already exist ", " New Medication");
                    sqlite_cmd.Dispose();
                }
                else
                {
                    // conn.Open();
                    sqlite_cmd.CommandText = insCateRec;
                    // frmmanufacturerList.


                }


                sqlite_cmd.ExecuteNonQuery();

                conn.Close();
                status = true;
            }
            catch (Exception)
            {

                status = false;
            }
            return status;
        }
        public bool InsertUpdatePrescription(string prescriptionID,  string medication,
           string sig, string dispense, string refill, string daw)
        {
            string dbname = "KDMEDISP";
            string tablename = "tblPrescriptions";
            bool status = false;
            try
            {
                SQLiteConnection conn = new SQLiteConnection();
                //Console.WriteLine();
                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();
                string update = "UPDATE '" + tablename + "'  SET  [medication] =@medication, [sig]=@sig,[dispense] =@dispense," +
                    "[refill]=@refill,[daw]=@daw  WHERE prescriptionID=@prescriptionID   ";



                sqlite_cmd.Parameters.AddWithValue("@prescriptionID", prescriptionID);
                sqlite_cmd.Parameters.AddWithValue("@medication", medication);
                sqlite_cmd.Parameters.AddWithValue("@sig", sig);
                sqlite_cmd.Parameters.AddWithValue("@dispense", dispense);
                sqlite_cmd.Parameters.AddWithValue("@daw", daw);
                sqlite_cmd.Parameters.AddWithValue("@refill", refill);
                sqlite_cmd.CommandText = update;


                sqlite_cmd.ExecuteNonQuery();

                conn.Close();
                status = true;
            }
            catch (Exception)
            {

                status = false;
            }
            return status;
        
    }

        public bool InsertStock(string refno, string pcode, DateTime sdate, string stockinby)
            {
                bool status = false;
                string dbname = "KDMEDISP";
                string tablename = "tblstockin";
                try
                {
                    int qty = 0;
                    SQLiteConnection conn = new SQLiteConnection();
                    //Console.WriteLine();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    sqlite_cmd = conn.CreateCommand();
                    string insCateRec = "INSERT INTO '" + tablename + "'  (refno,pcode,qty,sdate,stockinby,status) VALUES(@refno,@pcode,@qty,@sdate,@stockinby,'pending');";
                    string recExist = "SELECT * FROM '" + tablename + "'  WHERE pcode    =@pcode and refno=@refno;";



                    sqlite_cmd.Parameters.AddWithValue("@refno", refno);
                    sqlite_cmd.Parameters.AddWithValue("@pcode", pcode);
                    sqlite_cmd.Parameters.AddWithValue("@sdate", DateTime.Parse(sdate.ToShortDateString()));
                    sqlite_cmd.Parameters.AddWithValue("@stockinby", stockinby);
                    sqlite_cmd.Parameters.AddWithValue("@qty", qty);
                    sqlite_cmd.CommandText = recExist;

                    Int64 count =
                        Convert.ToInt64(sqlite_cmd.ExecuteScalar());  // checke record exist before inserting new records
                    if (count > 0)
                    {
                        imsg.info("Record already exist ", "Add Category");
                        sqlite_cmd.Dispose();
                    }
                    else
                    {
                        // conn.Open();
                        sqlite_cmd.CommandText = insCateRec;
                        // frmmanufacturerList.


                    }


                    sqlite_cmd.ExecuteNonQuery();

                    conn.Close();
                    status = true;
                }
                catch (Exception)
                {

                    status = false;
                }
                return status;
            }

            public bool InsertCart(string transno, string pcode, Double price, int qty, double discount, DateTime sdate, int adminID)
            {
                bool status = false;
                string dbname = "KDMEDISP";
                string tablename = "tblcart";
                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    //Console.WriteLine();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    sqlite_cmd = conn.CreateCommand();
                    string insCart = "INSERT INTO '" + tablename + "'  (transno,pcode,price,qty,discount,sdate,adminID) VALUES(@transno,@pcode,@price,@qty,@discount, @sdate,@adminID);";
                    string recExist = "SELECT * FROM '" + tablename + "'  WHERE pcode    =@pcode and transno=@transno;";



                    sqlite_cmd.Parameters.AddWithValue("@transno", transno);
                    sqlite_cmd.Parameters.AddWithValue("@pcode", pcode);
                    sqlite_cmd.Parameters.AddWithValue("@price", price);
                    sqlite_cmd.Parameters.AddWithValue("@qty", qty);
                    sqlite_cmd.Parameters.AddWithValue("@discount", discount);
                    sqlite_cmd.Parameters.AddWithValue("@sdate", sdate.ToShortDateString());
                    sqlite_cmd.Parameters.AddWithValue("@adminID", adminID);
                    sqlite_cmd.CommandText = recExist;

                    Int64 count =
                        Convert.ToInt64(sqlite_cmd.ExecuteScalar());  // checke record exist before inserting new records
                    if (count > 0)
                    {
                        imsg.info("Record already exist ", "Add Category");
                        sqlite_cmd.Dispose();
                    }
                    else
                    {
                        // conn.Open();
                        sqlite_cmd.CommandText = insCart;
                        // frmmanufacturerList.


                    }


                    sqlite_cmd.ExecuteNonQuery();

                    conn.Close();
                    status = true;
                }
                catch (Exception)
                {

                    status = false;
                }
                return status;
            }
            public bool UpdateProductQtyFromCart(string pcode, int qty)
            {
                bool status = false;
                string dbname = "KDMEDISP";

                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    //Console.WriteLine();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    sqlite_cmd = conn.CreateCommand();
                    string update = "UPDATE tbldrugs SET  [qty]=qty- @qty "
              + "WHERE pcode like @pcode";


                    sqlite_cmd.Parameters.AddWithValue("@pcode", pcode);
                    sqlite_cmd.Parameters.AddWithValue("@qty", qty);

                    // conn.Open();
                    sqlite_cmd.CommandText = update;


                    sqlite_cmd.ExecuteNonQuery();

                    conn.Close();
                    status = true;
                }
                catch (Exception)
                {

                    status = false;
                }
                return status;
            }
        public bool UpdateCount()
        {
            bool status = false;
            string dbname = "KDMEDISP";

            try
            {
                SQLiteConnection conn = new SQLiteConnection();
                //Console.WriteLine();
                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();
                string update = "UPDATE tblcount SET  [count]=count- 1 "
          + " WHERE id =1";


            

                // conn.Open();
                sqlite_cmd.CommandText = update;


                sqlite_cmd.ExecuteNonQuery();

                conn.Close();
                status = true;
            }
            catch (Exception)
            {

                status = false;
            }
            return status;
        }
        public bool UpdateProductQty(string pcode, int qty)
            {
                bool status = false;
                string dbname = "KDMEDISP";

                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    //Console.WriteLine();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    sqlite_cmd = conn.CreateCommand();
                    string update = "UPDATE tbldrugs SET  [qty]=qty+ @qty "
              + "WHERE pcode like @pcode";


                    sqlite_cmd.Parameters.AddWithValue("@pcode", pcode);
                    sqlite_cmd.Parameters.AddWithValue("@qty", qty);

                    // conn.Open();
                    sqlite_cmd.CommandText = update;


                    sqlite_cmd.ExecuteNonQuery();

                    conn.Close();
                    status = true;
                }
                catch (Exception)
                {

                    status = false;
                }
                return status;
            }

            public bool UpdateStock(string id, int qty)
            {
                bool status = false;
                string dbname = "KDMEDISP";

                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    //Console.WriteLine();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    sqlite_cmd = conn.CreateCommand();
                    string update = "UPDATE tblstockin SET  [qty]=qty + @qty,status='Done' "
              + "WHERE id like @id";


                    sqlite_cmd.Parameters.AddWithValue("@id", id);
                    sqlite_cmd.Parameters.AddWithValue("@qty", qty);

                    // conn.Open();
                    sqlite_cmd.CommandText = update;


                    sqlite_cmd.ExecuteNonQuery();

                    conn.Close();
                    status = true;
                }
                catch (Exception)
                {

                    status = false;
                }
                return status;
            }
            public bool UpdateAdmin(string id, string username, string password)
            {
                bool status = false;
                string dbname = "KDMEDISP";

                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    //Console.WriteLine();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    sqlite_cmd = conn.CreateCommand();
                    string update = "UPDATE adminLogin SET  [username]=@username, password=@password "
              + "WHERE id = @id";


                    sqlite_cmd.Parameters.AddWithValue("@id", id);
                    sqlite_cmd.Parameters.AddWithValue("@username", username);
                    sqlite_cmd.Parameters.AddWithValue("@password", password);

                    // conn.Open();
                    sqlite_cmd.CommandText = update;


                    sqlite_cmd.ExecuteNonQuery();

                    conn.Close();
                    status = true;
                }
                catch (Exception)
                {

                    status = false;
                }
                return status;
            }
            public bool UpdateProduct(string pcode, string pbcode, string pdesc, int bid, int cid, double price, int qty, int reorderQty, int EstoreID = -1, string imgUrl = "")
            {
                bool status = false;
                string dbname = "KDMEDISP";

                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    //Console.WriteLine();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    sqlite_cmd = conn.CreateCommand();
                    string update = "UPDATE tblproduct SET [pdesc]=@pdesc, [pbcode]=@pbcode, [bid] =@bid, [cid]=@cid, [estoreID]=@EstoreID,[imgurl]=@ImgUrl,[qty]=@qty,  [price]=@price "
              + "WHERE pcode= @pcode";


                    sqlite_cmd.Parameters.AddWithValue("@pdesc", pdesc);
                    sqlite_cmd.Parameters.AddWithValue("@bid", bid);
                    sqlite_cmd.Parameters.AddWithValue("@cid", cid);
                    sqlite_cmd.Parameters.AddWithValue("@price", price);
                    sqlite_cmd.Parameters.AddWithValue("@pcode", pcode);
                    sqlite_cmd.Parameters.AddWithValue("@pbcode", pbcode);
                    sqlite_cmd.Parameters.AddWithValue("@qty", qty);
                    sqlite_cmd.Parameters.AddWithValue("@reorder", reorderQty);
                    sqlite_cmd.Parameters.AddWithValue("@EstoreID", EstoreID);
                    sqlite_cmd.Parameters.AddWithValue("@imgUrl", imgUrl);

                    // conn.Open();
                    sqlite_cmd.CommandText = update;


                    sqlite_cmd.ExecuteNonQuery();

                    conn.Close();
                    status = true;
                }
                catch (Exception)
                {

                    status = false;
                }
                return status;
            }

            public bool UpdatePatient(int id, string patientID, string title, string sex, string dob, string firstname, string lastname, string othername,
           string Email, string phone, string address, string nextofKin,
           string nextofKinPhone, string organisation, string allergies, string medicalNotes, string ImgUrl = "")
            {
                bool status = false;
                string dbname = "KDMEDISP";

                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    //Console.WriteLine();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    sqlite_cmd = conn.CreateCommand();
                    string update = "UPDATE tblpatients SET [patientID]=@patientID, [title]=@title, [sex] =@sex, [dob]=@dob, [firstname]=@firstname,[lastname]=@lastname," +
                        "[othername]=@othername,  [email]=@email,  [phone]=@phone,  [address]=@address,  [nextofkin]=@nextofkin, " +
                        " [nextofkinphone]=@nextofkinphone ,  [organisation]=@organisation,  [allergies]=@allergies,  [medicalnotes]=@medicalnotes,  [imgUrl]=@imgURl        "
              + "WHERE id= @id";


                    sqlite_cmd.Parameters.AddWithValue("@id", id);
                    sqlite_cmd.Parameters.AddWithValue("@patientID", patientID);
                    sqlite_cmd.Parameters.AddWithValue("@title", title);
                    sqlite_cmd.Parameters.AddWithValue("@sex", sex);
                    sqlite_cmd.Parameters.AddWithValue("@dob", dob);
                    sqlite_cmd.Parameters.AddWithValue("@firstname", firstname);
                    sqlite_cmd.Parameters.AddWithValue("@lastname", lastname);
                    sqlite_cmd.Parameters.AddWithValue("@othername", othername);
                    sqlite_cmd.Parameters.AddWithValue("@email", Email);
                    sqlite_cmd.Parameters.AddWithValue("@phone", phone);
                    sqlite_cmd.Parameters.AddWithValue("@address", address);
                    sqlite_cmd.Parameters.AddWithValue("@nextofKin", nextofKin);
                    sqlite_cmd.Parameters.AddWithValue("@nextofKinPhone", nextofKinPhone);
                    sqlite_cmd.Parameters.AddWithValue("@organisation", organisation);
                    sqlite_cmd.Parameters.AddWithValue("@allergies", allergies);
                    sqlite_cmd.Parameters.AddWithValue("@medicalnotes", medicalNotes);
                    sqlite_cmd.Parameters.AddWithValue("@imgUrl", ImgUrl);

                    // conn.Open();
                    sqlite_cmd.CommandText = update;


                    sqlite_cmd.ExecuteNonQuery();

                    conn.Close();
                    status = true;
                }
                catch (Exception)
                {

                    status = false;
                }
                return status;
            }

            public bool UpdatePrescriber(int id, string title, string sex, string dob, string firstname, string lastname, string othername, string Email, string phone, string staffID, string address, string ImgUrl = "")

            {
                bool status = false;
                string dbname = "KDMEDISP";

                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    //Console.WriteLine();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    sqlite_cmd = conn.CreateCommand();
                    string update = "UPDATE tblprescribers SET [title]=@title, [sex] =@sex, [dob]=@dob, [firstname]=@firstname,[lastname]=@lastname," +
                        "[othername]=@othername,  [email]=@email,  [phone]=@phone,  [address]=@address,  [staffid]=@staffid, [imgUrl]=@imgURl        "
              + "WHERE id= @id";


                    sqlite_cmd.Parameters.AddWithValue("@id", id);
                    sqlite_cmd.Parameters.AddWithValue("@title", title);
                    sqlite_cmd.Parameters.AddWithValue("@sex", sex);
                    sqlite_cmd.Parameters.AddWithValue("@dob", dob);
                    sqlite_cmd.Parameters.AddWithValue("@firstname", firstname);
                    sqlite_cmd.Parameters.AddWithValue("@lastname", lastname);
                    sqlite_cmd.Parameters.AddWithValue("@othername", othername);
                    sqlite_cmd.Parameters.AddWithValue("@email", Email);
                    sqlite_cmd.Parameters.AddWithValue("@phone", phone);
                    sqlite_cmd.Parameters.AddWithValue("@staffid", staffID);
                    sqlite_cmd.Parameters.AddWithValue("@address", address);
                    sqlite_cmd.Parameters.AddWithValue("@imgUrl", ImgUrl);

                    // conn.Open();
                    sqlite_cmd.CommandText = update;



                    sqlite_cmd.ExecuteNonQuery();

                    conn.Close();
                    status = true;
                }
                catch (Exception)
                {

                    status = false;
                }
                return status;
            }
            #region CreateConnection
            public SQLiteConnection CreateConnection(string Dbname)
            {

                string folder = "/KDMEDISP/";
                string appData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                string dbFolder = appData + folder;
                //  Console.WriteLine(dbFolder + Dbname + ".db");
                bool exists = Directory.Exists(dbFolder);
                if (!exists)
                {
                    //  //Console.WriteLine("not exist");
                    System.IO.Directory.CreateDirectory(dbFolder);
                }

                SQLiteConnection sqlite_conn;
                // Create a new database connection:
                sqlite_conn = new SQLiteConnection("Data Source=" + dbFolder + Dbname + ".db;" + " Version = 3; New = True; Compress = True; ");
                // Open the connection:
                try
                {
                    sqlite_conn.Open();
                }
                catch (Exception )
                {


                }
                return sqlite_conn;
            }

            #endregion





           

            public object getSingleAdmin(string dbname, string tablename, string username)
            {
                DataSet dset = new DataSet();
                DataTable dt = new DataTable();
                DataTable retTable = new DataTable();
                TaskReport ts = new TaskReport();

                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = "SELECT id, password FROM " + tablename + " Where username=@username; ";
                    sqlite_cmd.Parameters.AddWithValue("@username", username.ToLower());
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_cmd);


                    da.Fill(dt);

                    conn.Close();



                    if (dt.Rows.Count == 0)
                    {
                        retTable = null;
                    }
                    else
                    {
                        foreach (DataRow item in dt.Rows)
                        {
                            ts.textData1 = item["password"].ToString();
                            ts.numData = Convert.ToInt32(item["id"].ToString());

                        }
                    }


                }
                catch (Exception)
                {

                }

                return ts;
            }

            public object viewAdmin(string dbname, string tablename)
            {
                DataSet dset = new DataSet();
                DataTable dt = new DataTable();
                DataTable retTable = new DataTable();

                try
                {
                    SQLiteConnection conn = new SQLiteConnection();
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = "SELECT Username FROM " + tablename + " ";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_cmd);


                    da.Fill(dt);

                    conn.Close();



                    if (dt.Rows.Count == 0)
                    {
                        retTable.Columns.Add("Records");
                        retTable.Rows.Add("No record Found");
                    }
                    else
                    {
                        retTable = dt;
                    }


                }
                catch (Exception)
                {

                }

                return retTable;
            }


            //

        

            public byte[] imageToByteArray(System.Drawing.Image imageIn)
            {
                MemoryStream ms = new MemoryStream();
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }

            public Image byteArrayToImage(byte[] byteArrayIn)
            {
                MemoryStream ms = new MemoryStream(byteArrayIn);
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }







            public void createAdmins(string dbname = "KDMEDISP")


            {
                string tablename = "AdminLogin";
                SQLiteConnection conn = new SQLiteConnection();
                AppMessage imsg = new AppMessage();
                if (File.Exists(dbname))
                {
                    return;
                }
                else
                {
                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    string createLogin = "CREATE TABLE  IF NOT EXISTS  '" + tablename + "'  (id INTEGER PRIMARY KEY AUTOINCREMENT,   username VARCHAR(20),  password VARCHAR(20) , email VARCHAR(20), privilege INTEGER(2))";
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = createLogin;
                    sqlite_cmd.ExecuteNonQuery();


                }

            }
            public bool InsertAdmin(string username, string password, string email, int privilege, string dbname = "KDMEDISP")


            {
                bool stats = false;
                string tablename = "AdminLogin";
                SQLiteConnection conn = new SQLiteConnection();

                try
                {

                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;

                    string insAdmin = "INSERT INTO '" + tablename + "'  (username, password, email, privilege ) VALUES (@username, @password, @email, @privilege);";
                    string chkUser = "Select * FROM '" + tablename + "'  Where username=@username;";
                    string chkSuperUser = "Select * FROM '" + tablename + "'  Where privilege=0 ;";
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.Parameters.AddWithValue("@username", username);
                    sqlite_cmd.Parameters.AddWithValue("@password", password);
                    sqlite_cmd.Parameters.AddWithValue("@email", email);
                    sqlite_cmd.Parameters.AddWithValue("@privilege", privilege);

                    sqlite_cmd.CommandText = chkSuperUser;
                    if (privilege == 0)
                    {
                        Int64 count = Convert.ToInt64(sqlite_cmd.ExecuteScalar());  // checke record exist before inserting new records
                        if (count > 0)
                        {
                            imsg.info("Super Admin already exist");
                            sqlite_cmd.Dispose();
                        }
                        else
                        {
                            sqlite_cmd.CommandText = insAdmin;

                            sqlite_cmd.ExecuteNonQuery();
                            stats = true;
                        }
                    }
                    if (privilege == 1)
                    {

                        sqlite_cmd.CommandText = chkUser;

                        Int64 count2 = Convert.ToInt64(sqlite_cmd.ExecuteScalar());  // checke record exist before inserting new records
                        if (count2 > 0)
                        {
                            imsg.info("User already exist");
                            sqlite_cmd.Dispose();
                        }
                        else
                        {
                            sqlite_cmd.CommandText = insAdmin;

                            sqlite_cmd.ExecuteNonQuery();
                            stats = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    stats = false;
                }



                return stats;
            }
            // check superadmin
            public bool isSuper(string username, string dbname = "KDMEDISP")


            {
                bool stats = false;
                string tablename = "AdminLogin";
                SQLiteConnection conn = new SQLiteConnection();

                try
                {

                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;

                    string chkSuperUser = "Select * FROM '" + tablename + "'  Where username=@username and privilege= 0 ;";
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.Parameters.AddWithValue("@username", username.ToLower());


                    sqlite_cmd.CommandText = chkSuperUser;

                    Int64 count = Convert.ToInt64(sqlite_cmd.ExecuteScalar());  // checke record exist before inserting new records
                if (count > 0)
                {
                    stats = true;
                }
                else
                {
                    stats = false;

                }
            }
            catch (Exception)
                {
                    stats = false;
                }



                return stats;
            }



            public bool loginAdmin(string username, string password, string dbname = "KDMEDISP")


            {
                string tablename = "AdminLogin";
                SQLiteConnection conn = new SQLiteConnection();


                bool login = false;

                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd;
                try
                {
                    string SelectAdmin = "SELECT username, password from  '" + tablename + "'  Where username=@username AND password= @password;";
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.Parameters.AddWithValue("@username", username);
                    sqlite_cmd.Parameters.AddWithValue("@password", password);
                    sqlite_cmd.CommandText = SelectAdmin;
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_cmd);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    //   imsg.info(dt.Rows.Count.ToString());
                    if ((string)dt.Rows[0]["username"] == username && (string)dt.Rows[0]["password"] == password)
                    {
                        login = true;
                    }

                }
                catch (Exception)
                {

                }

                return login;


            }

           
            public bool DeletePatient(string id, string manufacturerName)
            {
                string dbname = "KDMEDISP";
                string tablename = "tblPatients";
                try
                {
                    SQLiteConnection conn = new SQLiteConnection();

                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    string DelRec = " Delete FROM `" + tablename + "`  	 WHERE id=@id  ;";
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.Parameters.AddWithValue("@id", id);
                    sqlite_cmd.CommandText = DelRec;
                    sqlite_cmd.ExecuteNonQuery();
                    conn.Close();

                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }
            public bool DeletePrecriber(string id)
            {
                string dbname = "KDMEDISP";
                string tablename = "tblprescribers";
                try
                {
                    SQLiteConnection conn = new SQLiteConnection();

                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    string DelRec = " Delete FROM `" + tablename + "`  	 WHERE id=@id  ;";
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.Parameters.AddWithValue("@id", id);
                    sqlite_cmd.CommandText = DelRec;
                    sqlite_cmd.ExecuteNonQuery();
                    conn.Close();

                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }
        public bool DeleteMedicationFromPrescription(string id)
        {
            string dbname = "KDMEDISP";
            string tablename = "tblprescriptions";
            try
            {
                SQLiteConnection conn = new SQLiteConnection();

                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd;
                string DelRec = " Delete FROM `" + tablename + "`  	 WHERE id=@id  ;";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.Parameters.AddWithValue("@id", id);
                sqlite_cmd.CommandText = DelRec;
                sqlite_cmd.ExecuteNonQuery();
                conn.Close();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        private void closeConn(SQLiteConnection conn)
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            public bool DeleteManufacturer(string id)
            {
                string dbname = "KDMEDISP";
                string tablename = "tblManufacturers";
                try
                {
                    SQLiteConnection conn = new SQLiteConnection();

                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    string DelRec = " Delete FROM `" + tablename + "`  	 WHERE id=@id  ;";
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.Parameters.AddWithValue("@id", id);
                    sqlite_cmd.CommandText = DelRec;
                    sqlite_cmd.ExecuteNonQuery();
                    conn.Close();

                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }
        public bool DeleteDrugs(string id)
        {
            string dbname = "KDMEDISP";
            string tablename = "tblDrugs";
            try
            {
                SQLiteConnection conn = new SQLiteConnection();

                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd;
                string DelRec = " Delete FROM `" + tablename + "`  	 WHERE id=@id  ;";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.Parameters.AddWithValue("@id", id);
                sqlite_cmd.CommandText = DelRec;
                sqlite_cmd.ExecuteNonQuery();
                conn.Close();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool DeleteSupplier(string id)
            {
                string dbname = "KDMEDISP";
                string tablename = "tblsuppliers";
                try
                {
                    SQLiteConnection conn = new SQLiteConnection();

                    conn = CreateConnection(dbname);
                    SQLiteCommand sqlite_cmd;
                    string DelRec = " Delete FROM `" + tablename + "`  	 WHERE id=@id  ;";
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.Parameters.AddWithValue("@id", id);
                    sqlite_cmd.CommandText = DelRec;
                    sqlite_cmd.ExecuteNonQuery();
                    conn.Close();

                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }
           
        }
    }
