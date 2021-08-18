using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;

namespace PRODUCTIVITY
{
    class Db
    {
        util imsg = new util();
        public void CreateTable(string dbname, string tablename)
        {
            SQLiteConnection conn = new SQLiteConnection();
            //Console.WriteLine(dbname);
            AppMessage imsg = new AppMessage();
            if (File.Exists(dbname))
            {
                return;
            }
            else
            {
                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd;
                string CreateUsers = "CREATE TABLE  IF NOT EXISTS  '" + tablename + "'  (id INT AUTO_INCREMENT PRIMARY KEY NOT NULL, userName VARCHAR(20), Password VARCHAR(20), Privilege INT, Email VARCHAR(50))";
                string Cmaterials = "CREATE TABLE  IF NOT EXISTS  '" + tablename + "'  (id INTEGER PRIMARY KEY AUTOINCREMENT, Year VARCHAR(5), Rm NUMERIC , PricePerUnit DECIMAL (4), Deflator DECIMAL)";
                string Ccapital = "CREATE TABLE  IF NOT EXISTS  '" + tablename + "'  (id INTEGER PRIMARY KEY AUTOINCREMENT,  year VARCHAR(5), TotalPlantHours VARCHAR(20), Plant_Hour_Rate VARCHAR(20), Deflator VARCHAR(50))";
                string Clabour = "CREATE TABLE  IF NOT EXISTS  '" + tablename + "'  (id INTEGER PRIMARY KEY AUTOINCREMENT,  year VARCHAR(5),  slh VARCHAR(20), wrs VARCHAR(20), DefSkill VARCHAR(20), Usl VARCHAR(20), wru VARCHAR(20), DefUnsk VARCHAR(50))";
                string Cenergy = "CREATE TABLE  IF NOT EXISTS  '" + tablename + "'  (id INTEGER PRIMARY KEY AUTOINCREMENT,  year VARCHAR(5),  Oilused VARCHAR(20), Ppl VARCHAR(20),  DefOil VARCHAR(20), OthEn VARCHAR(50), DefOther VARCHAR(20),  EleUsd VARCHAR(20), PpEle VARCHAR(20), DefEle VARCHAR(20))";
                string Cother = "CREATE TABLE  IF NOT EXISTS  '" + tablename + "'  (id INTEGER PRIMARY KEY AUTOINCREMENT,  year VARCHAR(5),  CurrentExpenses VARCHAR(20), Deflator  VARCHAR(50))";
                string Coutput = "CREATE TABLE  IF NOT EXISTS  '" + tablename + "'  (id INTEGER PRIMARY KEY AUTOINCREMENT,  year VARCHAR(5),  mfgp VARCHAR(20), PpuH VARCHAR(20), DefFactor VARCHAR(20), Wip VARCHAR(20), PerCp VARCHAR(50), DiviSec VARCHAR(20), DefDivi VARCHAR(20))";
                string Cuser = "CREATE TABLE  IF NOT EXISTS  '" + tablename + "'  (id INTEGER PRIMARY KEY AUTOINCREMENT,  Username VARCHAR(20),   Password VARCHAR(20),  Email VARCHAR(50) , Privilege INT(1))";
                string Cprod = "CREATE TABLE  IF NOT EXISTS  '" + tablename + "'  (id INTEGER PRIMARY KEY AUTOINCREMENT,   Year VARCHAR(20),  Mfgp VARCHAR(20) , ppU VARCHAR(20), DefFac VARCHAR(20), Wip VARCHAR(20), perCom VARCHAR(20), Div VARCHAR(20),Def VARCHAR(20))";
                sqlite_cmd = conn.CreateCommand();

                switch (tablename)
                {
                    case "Material":
                        sqlite_cmd.CommandText = Cmaterials;

                        break;
                    case "Capital":
                        sqlite_cmd.CommandText = Ccapital;

                        break;
                    case "Labour":
                        sqlite_cmd.CommandText = Clabour;

                        break;
                    case "Energy":
                        sqlite_cmd.CommandText = Cenergy;

                        break;
                    case "Other":
                        sqlite_cmd.CommandText = Cother;

                        break;
                    case "Output":
                        sqlite_cmd.CommandText = Coutput;

                        break;
                    case "User":
                        sqlite_cmd.CommandText = Coutput;

                        break;
                    case "Prod":
                        sqlite_cmd.CommandText = sqlite_cmd.CommandText = Cprod;


                        break;
                    default:


                        break;
                }

                sqlite_cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public bool InsertData(string dbname, string year, string tablename, object data)
        {
            bool status = false;

            try
            {
                SQLiteConnection conn = new SQLiteConnection();
                //Console.WriteLine();
                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();
                string InsMaterials = "INSERT INTO '" + tablename + "'  (Year, Rm, PricePerUnit, Deflator) VALUES (@year, @rm, @price, @defla);";
                string InsCapital = "INSERT INTO '" + tablename + "'  (Year, TotalPlantHours, Plant_Hour_Rate, Deflator) VALUES (@year, @Tph, @Phr, @CapDe);";
                string InsLabour = "INSERT INTO '" + tablename + "'  (Year, slh, wrs, DefSkill, Usl, wru, DefUnsk ) VALUES (@year, @slh, @wrs, @DefSkill, @Usl, @wru, @DefUnsk);";
                string InsEnergy = "INSERT INTO '" + tablename + "'  (Year, Oilused, Ppl, DefOil, OthEn, DefOther, EleUsd, PpEle, DefEle ) VALUES (@year, @Oilused, @Ppl, @DefOil, @OthEn, @DefOther, @EleUsd , @PpEle, @DefEle);";
                string InsOtherExp = "INSERT INTO '" + tablename + "'  (Year, CurrentExpenses, Deflator ) VALUES (@year, @CurrentExpenses, @Deflator);";
                string InsOutput = "INSERT INTO '" + tablename + "'  (Year, mfgp, PpuH, DefFactor, Wip, PerCp, DiviSec, DefDivi ) VALUES (@year, @mfgp, @PpuH, @DefFactor, @Wip, @PerCp, @DiviSec , @DefDivi);";
                string InsUser = "INSERT INTO '" + tablename + "'  (Username, Password, Email, Privilege) VALUES (@username, @password, @email, @privilege);";

                switch (tablename)
                {
                    case "Material":
                        matProd cool = new matProd();
                        cool = (matProd)data;
                        // imsg.info(cool.matDeflator_Dm.ToString());

                        sqlite_cmd.Parameters.AddWithValue("@rm", cool.matQty_RM);
                        sqlite_cmd.Parameters.AddWithValue("@price", cool.pricePerUnit_Ppt);
                        sqlite_cmd.Parameters.AddWithValue("@defla", cool.matDeflator_Dm);
                        sqlite_cmd.Parameters.AddWithValue("@year", year);
                        sqlite_cmd.CommandText = InsMaterials;
                        //  //Console.WriteLine(tablename);

                        break;
                    case "Capital":
                        CapProd cap = new CapProd();
                        cap = (CapProd)data;
                        //  imsg.info(cap.TotalPlantHrs.ToString());
                        sqlite_cmd.Parameters.AddWithValue("@Tph", cap.TotalPlantHrs);
                        sqlite_cmd.Parameters.AddWithValue("@Phr", cap.PlantHrRate);
                        sqlite_cmd.Parameters.AddWithValue("@CapDe", cap.PlantHrDeflator);
                        sqlite_cmd.Parameters.AddWithValue("@year", year);
                        sqlite_cmd.CommandText = InsCapital;
                        // //Console.WriteLine(InsCapital);
                        break;
                    case "Labour":
                        LabourProd lab = new LabourProd();
                        lab = (LabourProd)data;
                        //  imsg.info(cap.TotalPlantHrs.ToString());
                        sqlite_cmd.Parameters.AddWithValue("@slh", lab.SkilledLabourHour);
                        sqlite_cmd.Parameters.AddWithValue("@wrs", lab.AverageRateSkilled);
                        sqlite_cmd.Parameters.AddWithValue("@DefSkill", lab.DeflatorSkilledLabour);

                        sqlite_cmd.Parameters.AddWithValue("@Usl", lab.UnSkilledLabourHour);
                        sqlite_cmd.Parameters.AddWithValue("@wru", lab.AverageRateUskilled);
                        sqlite_cmd.Parameters.AddWithValue("@DefUnsk", lab.DeflatorUnSkilledLabour);
                        sqlite_cmd.Parameters.AddWithValue("@year", year);
                        sqlite_cmd.CommandText = InsLabour;
                        break;
                    case "Energy":
                        EnergyInput energy = new EnergyInput();
                        energy = (EnergyInput)data;

                        //  imsg.info(cap.TotalPlantHrs.ToString());
                        sqlite_cmd.Parameters.AddWithValue("@Oilused", energy.oilUsed);
                        sqlite_cmd.Parameters.AddWithValue("@Ppl", energy.PricePerLitre);
                        sqlite_cmd.Parameters.AddWithValue("@DefOil", energy.OilDeflator);

                        sqlite_cmd.Parameters.AddWithValue("@OthEn", energy.OtherEnergyused);
                        sqlite_cmd.Parameters.AddWithValue("@DefOther", energy.OtherEnergyDeflator);
                        sqlite_cmd.Parameters.AddWithValue("@EleUsd", energy.ElectricityUsed);
                        sqlite_cmd.Parameters.AddWithValue("@PpEle", energy.ElectricityRate);
                        sqlite_cmd.Parameters.AddWithValue("@DefEle", energy.ElectricityDeflator);
                        sqlite_cmd.Parameters.AddWithValue("@Year", year);
                        sqlite_cmd.CommandText = InsEnergy;
                        break;
                    case "Other":
                        ExpensesInput expenses = new ExpensesInput();
                        expenses = (ExpensesInput)data;

                        //  imsg.info(cap.TotalPlantHrs.ToString());
                        sqlite_cmd.Parameters.AddWithValue("@CurrentExpenses", expenses.OtherExpenses);
                        sqlite_cmd.Parameters.AddWithValue("@Deflator", expenses.ExpensesDeflator);

                        sqlite_cmd.Parameters.AddWithValue("@Year", year);
                        sqlite_cmd.CommandText = InsOtherExp;
                        break;
                    case "Output":
                        TotalOutput output = new TotalOutput();
                        output = (TotalOutput)data;
                        sqlite_cmd.Parameters.AddWithValue("@mfgp", output.MassofFinishedgoods);
                        sqlite_cmd.Parameters.AddWithValue("@PpuH", output.pricePerUnitHour);
                        sqlite_cmd.Parameters.AddWithValue("@DefFactor", output.DeflactorFactor);

                        sqlite_cmd.Parameters.AddWithValue("@Wip", output.WorkInProgress);
                        sqlite_cmd.Parameters.AddWithValue("@PerCp", output.PercentageCompleted);
                        sqlite_cmd.Parameters.AddWithValue("@DiviSec", output.DividenFromSecurity);
                        sqlite_cmd.Parameters.AddWithValue("@DefDivi", output.DeflactorFactor);
                        sqlite_cmd.Parameters.AddWithValue("@Year", year);
                        sqlite_cmd.CommandText = InsOutput;
                        break;
                    case "User":

                        User user = new User();
                        user = (User)data;
                        sqlite_cmd.Parameters.AddWithValue("@Username", user.Username);
                        sqlite_cmd.Parameters.AddWithValue("@Password", user.Password);
                        sqlite_cmd.Parameters.AddWithValue("@Email", user.email);
                        sqlite_cmd.Parameters.AddWithValue("@privilege", user.privilege);
                        sqlite_cmd.CommandText = InsUser;

                        break;
                    case "Prod":

                        Productivities prod = new Productivities();
                        prod = (Productivities)data;
                        //sqlite_cmd.Parameters.AddWithValue("@Username", user.Username);
                        //sqlite_cmd.Parameters.AddWithValue("@Password", user.Password);
                        //sqlite_cmd.Parameters.AddWithValue("@Email", user.email);
                        //sqlite_cmd.Parameters.AddWithValue("@privilege", user.privilege);
                        //sqlite_cmd.CommandText = InsUser;

                        break;
                    default:


                        break;
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



        #region CreateConnection
        static SQLiteConnection CreateConnection(string Dbname)
        {

            string folder = "/ProdASSM/";
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string dbFolder = appData + folder;
            //Console.WriteLine(dbFolder + Dbname + ".db");
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
            catch (Exception ex)
            {
                AppMessage.Message = ex.Message;
                AppMessage.Title = "Create Table";
                AppMessage msg = new AppMessage();
                msg.ShowDialog();

            }
            return sqlite_conn;
        }

        #endregion




        public object viewRecFin(string dbname, string tablename, bool prodOverview = false)
        {
            bool stats = false;
            DataSet dset = new DataSet();
            DataTable dy = new DataTable();
            DataTable retTable = new DataTable();
            DataTable dtprodOVer = new DataTable();
            string Recyear;
            List<string> years = new List<string>();


            float MaterialIN = 0;
            float CapIn = 0;
            float CalcEI = 0;
            float OtherIn = 0;
            float outpIn = 0;
            float LabourIn = 0;
            float Tpm = 0;
            float TpmOut = 0;
            string[] tableNames = new string[] { "Output","Material", "Material Productivity",  "Capital", "Capital Productivity", "Labour",
                  "Labour Productivity",  "Energy",  "Energy Productivity", "Other", "Other Productivity" , "Total Productivity Measure[TPM]"};
            dtprodOVer.Columns.Add("Year");
            foreach (string item in tableNames)
            {
                dtprodOVer.Columns.Add(item);
            }

            //try
            //{
            SQLiteConnection conn = new SQLiteConnection();
            conn = CreateConnection(dbname);
            SQLiteCommand sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT  year FROM  Material  ";
            sqlite_cmd.CommandText += "UNION SELECT  year FROM  Capital UNION SELECT  year FROM  Labour UNION ";
            sqlite_cmd.CommandText += "SELECT  year FROM  Energy UNION SELECT  year FROM  Other UNION ";
            sqlite_cmd.CommandText += "SELECT   year from OUTPUT ";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_cmd);
            da.Fill(dy);

            for (int i = 0; i < dy.Rows.Count; i++)
            {
                string data = dy.Rows[i][0].ToString();

                if (!years.Contains(data))
                {
                    years.Add(data);
                }
            }

            #region codeA
            for (int mm = 0; mm < years.Count; mm++)
            {


                DataRow dtr = dtprodOVer.NewRow();
                dtr["Year"] = years[mm];


                try
                {
                    float Rm, PricePerUnit, Deflator;
                    sqlite_cmd.CommandText = "SELECT * FROM  Material WHERE year= @year ;";
                    sqlite_cmd.Parameters.AddWithValue("@year", years[mm]);
                    SQLiteDataAdapter adapt = new SQLiteDataAdapter(sqlite_cmd);
                    DataTable dtM = new DataTable();

                    adapt.Fill(dtM);

                    conn.Close();


                    float.TryParse(dtM.Rows[0]["Rm"].ToString(), out Rm);
                    float.TryParse(dtM.Rows[0]["PricePerUnit"].ToString(), out PricePerUnit);
                    float.TryParse(dtM.Rows[0]["Deflator"].ToString(), out Deflator);
                    Recyear = (dtM.Rows[0]["year"].ToString());
                    MaterialIN = ((Rm * PricePerUnit) / Deflator);
                    Console.WriteLine("Material");


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }

                try
                {

                    float TotalPlantHours, Plant_Hour_Rate, cPdeflator;
                    DataTable dtC = new DataTable();

                    sqlite_cmd.CommandText = "SELECT * FROM Capital WHERE year= @year ;";
                    sqlite_cmd.Parameters.AddWithValue("@year", years[mm]);
                    SQLiteDataAdapter adaptC = new SQLiteDataAdapter(sqlite_cmd);
                    adaptC.Fill(dtC);
                    conn.Close();

                    float.TryParse(dtC.Rows[0]["TotalPlantHours"].ToString(), out TotalPlantHours);
                    float.TryParse(dtC.Rows[0]["Plant_Hour_Rate"].ToString(), out Plant_Hour_Rate);
                    float.TryParse(dtC.Rows[0]["Deflator"].ToString(), out cPdeflator);


                    Recyear = (dtC.Rows[0]["year"].ToString());
                    CapIn = ((TotalPlantHours * Plant_Hour_Rate) / cPdeflator);

                    // Console.WriteLine("Capital");

                    Console.WriteLine(CapIn.ToString());
                }
                catch (Exception)
                {

                }



                try
                {

                    float slh, wrs, DefSkill, Usl, wru, DefUnsk;
                    DataTable dtL = new DataTable();

                    sqlite_cmd.CommandText = "SELECT * FROM Labour WHERE year= @year ;";
                    sqlite_cmd.Parameters.AddWithValue("@year", years[mm]);
                    SQLiteDataAdapter adaptL = new SQLiteDataAdapter(sqlite_cmd);
                    adaptL.Fill(dtL);
                    conn.Close();

                    float.TryParse(dtL.Rows[0]["slh"].ToString(), out slh);
                    float.TryParse(dtL.Rows[0]["wrs"].ToString(), out wrs);
                    float.TryParse(dtL.Rows[0]["DefSkill"].ToString(), out DefSkill);
                    float.TryParse(dtL.Rows[0]["Usl"].ToString(), out Usl);
                    float.TryParse(dtL.Rows[0]["wru"].ToString(), out wru);
                    float.TryParse(dtL.Rows[0]["DefUnsk"].ToString(), out DefUnsk);

                    Recyear = (dtL.Rows[0]["year"].ToString());

                    LabourIn = (((slh * wrs) / DefSkill) + ((Usl * wru) / DefUnsk));

                    //  Console.WriteLine("labour");
                    Console.WriteLine(LabourIn.ToString());
                }
                catch (Exception)
                {

                }



                try
                {
                    float Oilused, Ppl, DefOil, OthEn, DefOther, EleUsd, PpEle, DefEle;
                    sqlite_cmd.CommandText = "SELECT * FROM Energy WHERE year= @year ;";
                    sqlite_cmd.Parameters.AddWithValue("@year", years[mm]);
                    SQLiteDataAdapter adaptE = new SQLiteDataAdapter(sqlite_cmd);
                    DataTable dtE = new DataTable();

                    adaptE.Fill(dtE);
                    conn.Close();

                    float.TryParse(dtE.Rows[0]["Oilused"].ToString(), out Oilused);
                    float.TryParse(dtE.Rows[0]["Ppl"].ToString(), out Ppl);
                    float.TryParse(dtE.Rows[0]["DefOil"].ToString(), out DefOil);
                    float.TryParse(dtE.Rows[0]["OthEn"].ToString(), out OthEn);
                    float.TryParse(dtE.Rows[0]["DefOther"].ToString(), out DefOther);
                    float.TryParse(dtE.Rows[0]["EleUsd"].ToString(), out EleUsd);
                    float.TryParse(dtE.Rows[0]["PpEle"].ToString(), out PpEle);
                    float.TryParse(dtE.Rows[0]["DefEle"].ToString(), out DefEle);
                    Recyear = (dtE.Rows[0]["year"].ToString());

                    CalcEI = (((Oilused * Ppl) / DefOil) + (OthEn / DefOther) + ((EleUsd + PpEle) / DefEle));


                    //  Console.WriteLine("Energy");
                    Console.WriteLine(CalcEI.ToString());


                }
                catch (Exception)
                {

                }
                try
                {
                    float CurrentExpenses, ODeflator;
                    DataTable dtO = new DataTable();

                    sqlite_cmd.CommandText = "SELECT * FROM Other WHERE year= @year ;";
                    sqlite_cmd.Parameters.AddWithValue("@year", years[mm]);
                    SQLiteDataAdapter adaptO = new SQLiteDataAdapter(sqlite_cmd);
                    adaptO.Fill(dtO);
                    conn.Close();

                    float.TryParse(dtO.Rows[0]["CurrentExpenses"].ToString(), out CurrentExpenses);
                    float.TryParse(dtO.Rows[0]["Deflator"].ToString(), out ODeflator);

                    Recyear = (dtO.Rows[0]["year"].ToString());

                    OtherIn = (CurrentExpenses / ODeflator);

                    //  Console.WriteLine("Other");
                    Console.WriteLine(OtherIn.ToString());

                }
                catch (Exception)
                {

                }

                try
                {

                    float mfgp, PpuH, DefFactor, Wip, PerCp, DiviSec, DefDivi;
                    sqlite_cmd.CommandText = "SELECT * FROM Output WHERE year= @year ;";
                    sqlite_cmd.Parameters.AddWithValue("@year", years[mm]);
                    DataTable dtOut = new DataTable();

                    SQLiteDataAdapter adaptOut = new SQLiteDataAdapter(sqlite_cmd);
                    adaptOut.Fill(dtOut);
                    conn.Close();

                    float.TryParse(dtOut.Rows[0]["mfgp"].ToString(), out mfgp);
                    float.TryParse(dtOut.Rows[0]["PpuH"].ToString(), out PpuH);
                    float.TryParse(dtOut.Rows[0]["DefFactor"].ToString(), out DefFactor);
                    float.TryParse(dtOut.Rows[0]["Wip"].ToString(), out Wip);
                    float.TryParse(dtOut.Rows[0]["PerCp"].ToString(), out PerCp);
                    float.TryParse(dtOut.Rows[0]["DiviSec"].ToString(), out DiviSec);
                    float.TryParse(dtOut.Rows[0]["DefDivi"].ToString(), out DefDivi);
                    Recyear = (dtOut.Rows[0]["year"].ToString());

                    outpIn = (((mfgp * PpuH) / DefFactor) + ((Wip * PerCp * PpuH) / DefFactor) + (DiviSec / DefDivi));
                    //Console.WriteLine("Output calc");
                    //Console.WriteLine(mfgp);
                    //Console.WriteLine(Wip);
                    //Console.WriteLine(DiviSec);
                    //Console.WriteLine(outpIn);


                    // Console.WriteLine("Output");
                    Console.WriteLine(outpIn.ToString());

                }
                catch (Exception)
                {

                }

                if (CalcEI != 0)
                {
                    dtr["Energy"] = CalcEI.ToString();
                    if (outpIn != 0)
                    {
                        dtr["Energy Productivity"] = outpIn / CalcEI;
                        Tpm += CalcEI;
                    }
                    CalcEI = 0;

                }

                if (MaterialIN != 0)
                {
                    dtr["Material"] = MaterialIN.ToString();
                    if (outpIn != 0)
                    {
                        dtr["Material Productivity"] = outpIn / MaterialIN;
                        Tpm += MaterialIN;


                    }
                    MaterialIN = 0;
                }
                if (LabourIn != 0)
                {
                    dtr["Labour"] = LabourIn.ToString();

                    if (outpIn != 0)
                    {
                        dtr["Labour Productivity"] = outpIn / LabourIn;
                        Tpm += LabourIn;

                    }
                    LabourIn = 0;
                }
                if (CapIn != 0)
                {
                    dtr["Capital"] = CapIn.ToString();
                    if (outpIn != 0)
                    {
                        dtr["Capital Productivity"] = outpIn / CapIn;
                        Tpm += CapIn;

                    }
                    CapIn = 0;
                }

                if (OtherIn != 0)
                {
                    dtr["Other"] = OtherIn.ToString();
                    if (outpIn != 0)
                    {
                        dtr["Other Productivity"] = outpIn / OtherIn;
                        Tpm += OtherIn;

                    }
                    OtherIn = 0;
                }

                if (outpIn != 0)
                {
                    dtr["Output"] = outpIn.ToString();
                    TpmOut = outpIn;
                    outpIn = 0;


                }
                try
                {
                    float TpmFin = TpmOut / Tpm;
                    if (TpmFin > 0 && !Double.IsInfinity(TpmFin))
                    {
                        dtr["Total Productivity Measure[TPM]"] = TpmFin;
                        Tpm = 0;
                    }


                    dtprodOVer.Rows.Add(dtr);

                }
                catch (Exception)
                {

                }







                #endregion




                stats = true;



            }
            return dtprodOVer;

        }
        public object viewRecIndex(string dbname, string tablename, string baseYear, string TargetYear)
        {
            bool stats = false;
            DataSet dset = new DataSet();
            DataTable dy = new DataTable();
            DataTable retTable = new DataTable();
            DataTable dtprodOVer = new DataTable();
            string Recyear;
            List<string> years = new List<string>();
            bool baseYrVal = false;

            float MaterialIN = 0;
            float CapIn = 0;
            float CalcEI = 0;
            float OtherIn = 0;
            float outpIn = 0;
            float LabourIn = 0;
            float Tpm = 0;
            float TpmOut = 0;


            //      Base Parameters

            float BaseMaterialIN = 0;
            float BaseCapIn = 0;
            float BaseCalcEI = 0;
            float BaseOtherIn = 0;
            float BaseoutpIn = 0;
            float BaseLabourIn = 0;
            float BaseTpm = 0;

            //      Base productivity

            float BaseMaterialINProd = 0;
            float BaseCapInProd = 0;
            float BaseCalcEIProd = 0;
            float BaseOtherInProd = 0;
            float BaseoutpInProd = 0;
            float BaseLabourInProd = 0;
            float BaseTpmProd = 0;
            string[] tableNames = new string[] { "Output","Material", "Material Productivity",  "Capital", "Capital Productivity", "Labour",
                  "Labour Productivity",  "Energy",  "Energy Productivity", "Other", "Other Productivity" , "Total Productivity Measure[TPM]"};
            dtprodOVer.Columns.Add("Year");
            foreach (string item in tableNames)
            {
                dtprodOVer.Columns.Add(item);
            }

            //try
            //{
            SQLiteConnection conn = new SQLiteConnection();
            conn = CreateConnection(dbname);
            SQLiteCommand sqlite_cmd = conn.CreateCommand();


            // imsg.info(baseYear+ TargetYear);
            int b, t, endp;
            t = int.Parse(TargetYear);
            b = int.Parse(baseYear);
            if (t > b)
            {
                int diff = t - b;
                for (int yy = 0; yy < diff; yy++)
                {
                    int YearAdded = b + yy;
                    years.Add((YearAdded).ToString());
                    Console.WriteLine(YearAdded);
                }

            }
            {
                //     imsg.info("Please check Selected Period and try again!");
            }


            #region codeA
            for (int mm = 0; mm < years.Count; mm++)
            {


                DataRow dtr = dtprodOVer.NewRow();
                dtr["Year"] = years[mm];
                Console.WriteLine(years[mm]);


                try
                {
                    float Rm, PricePerUnit, Deflator;
                    if (years[mm] == baseYear)
                    {
                        baseYrVal = true;

                    }
                    else
                    {
                        baseYrVal = false;
                    }

                    sqlite_cmd.CommandText = "SELECT * FROM  Material WHERE year= @year ;";
                    sqlite_cmd.Parameters.AddWithValue("@year", years[mm]);
                    SQLiteDataAdapter adapt = new SQLiteDataAdapter(sqlite_cmd);
                    DataTable dtM = new DataTable();

                    adapt.Fill(dtM);

                    conn.Close();


                    float.TryParse(dtM.Rows[0]["Rm"].ToString(), out Rm);
                    float.TryParse(dtM.Rows[0]["PricePerUnit"].ToString(), out PricePerUnit);
                    float.TryParse(dtM.Rows[0]["Deflator"].ToString(), out Deflator);
                    Recyear = (dtM.Rows[0]["year"].ToString());
                    if (baseYrVal)
                    {
                        BaseMaterialIN = ((Rm * PricePerUnit) / Deflator);

                    }

                    else
                    {
                        MaterialIN = ((Rm * PricePerUnit) / Deflator);

                    }
                    Console.WriteLine("Material");


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }

                try
                {

                    float TotalPlantHours, Plant_Hour_Rate, cPdeflator;
                    DataTable dtC = new DataTable();

                    sqlite_cmd.CommandText = "SELECT * FROM Capital WHERE year= @year ;";
                    sqlite_cmd.Parameters.AddWithValue("@year", years[mm]);
                    SQLiteDataAdapter adaptC = new SQLiteDataAdapter(sqlite_cmd);
                    adaptC.Fill(dtC);
                    conn.Close();

                    float.TryParse(dtC.Rows[0]["TotalPlantHours"].ToString(), out TotalPlantHours);
                    float.TryParse(dtC.Rows[0]["Plant_Hour_Rate"].ToString(), out Plant_Hour_Rate);
                    float.TryParse(dtC.Rows[0]["Deflator"].ToString(), out cPdeflator);


                    Recyear = (dtC.Rows[0]["year"].ToString());
                    if (baseYrVal)
                    {
                        BaseCapIn = ((TotalPlantHours * Plant_Hour_Rate) / cPdeflator);

                    }
                    else
                    {
                        CapIn = ((TotalPlantHours * Plant_Hour_Rate) / cPdeflator);

                    }

                    // Console.WriteLine("Capital");

                    Console.WriteLine(CapIn.ToString());
                }
                catch (Exception)
                {

                }



                try
                {

                    float slh, wrs, DefSkill, Usl, wru, DefUnsk;
                    DataTable dtL = new DataTable();

                    sqlite_cmd.CommandText = "SELECT * FROM Labour WHERE year= @year ;";
                    sqlite_cmd.Parameters.AddWithValue("@year", years[mm]);
                    SQLiteDataAdapter adaptL = new SQLiteDataAdapter(sqlite_cmd);
                    adaptL.Fill(dtL);
                    conn.Close();

                    float.TryParse(dtL.Rows[0]["slh"].ToString(), out slh);
                    float.TryParse(dtL.Rows[0]["wrs"].ToString(), out wrs);
                    float.TryParse(dtL.Rows[0]["DefSkill"].ToString(), out DefSkill);
                    float.TryParse(dtL.Rows[0]["Usl"].ToString(), out Usl);
                    float.TryParse(dtL.Rows[0]["wru"].ToString(), out wru);
                    float.TryParse(dtL.Rows[0]["DefUnsk"].ToString(), out DefUnsk);

                    Recyear = (dtL.Rows[0]["year"].ToString());
                    if (baseYrVal)
                    {
                        BaseLabourIn = (((slh * wrs) / DefSkill) + ((Usl * wru) / DefUnsk));

                    }
                    else
                    {
                        LabourIn = (((slh * wrs) / DefSkill) + ((Usl * wru) / DefUnsk));

                    }

                    //  Console.WriteLine("labour");
                    Console.WriteLine(LabourIn.ToString());
                }
                catch (Exception)
                {

                }



                try
                {
                    float Oilused, Ppl, DefOil, OthEn, DefOther, EleUsd, PpEle, DefEle;
                    sqlite_cmd.CommandText = "SELECT * FROM Energy WHERE year= @year ;";
                    sqlite_cmd.Parameters.AddWithValue("@year", years[mm]);
                    SQLiteDataAdapter adaptE = new SQLiteDataAdapter(sqlite_cmd);
                    DataTable dtE = new DataTable();

                    adaptE.Fill(dtE);
                    conn.Close();

                    float.TryParse(dtE.Rows[0]["Oilused"].ToString(), out Oilused);
                    float.TryParse(dtE.Rows[0]["Ppl"].ToString(), out Ppl);
                    float.TryParse(dtE.Rows[0]["DefOil"].ToString(), out DefOil);
                    float.TryParse(dtE.Rows[0]["OthEn"].ToString(), out OthEn);
                    float.TryParse(dtE.Rows[0]["DefOther"].ToString(), out DefOther);
                    float.TryParse(dtE.Rows[0]["EleUsd"].ToString(), out EleUsd);
                    float.TryParse(dtE.Rows[0]["PpEle"].ToString(), out PpEle);
                    float.TryParse(dtE.Rows[0]["DefEle"].ToString(), out DefEle);
                    Recyear = (dtE.Rows[0]["year"].ToString());
                    if (baseYrVal)
                    {
                        BaseCalcEI = (((Oilused * Ppl) / DefOil) + (OthEn / DefOther) + ((EleUsd + PpEle) / DefEle));

                    }
                    else
                    {
                        CalcEI = (((Oilused * Ppl) / DefOil) + (OthEn / DefOther) + ((EleUsd + PpEle) / DefEle));

                    }

                    //  Console.WriteLine("Energy");
                    Console.WriteLine(CalcEI.ToString());


                }
                catch (Exception)
                {

                }
                try
                {
                    float CurrentExpenses, ODeflator;
                    DataTable dtO = new DataTable();

                    sqlite_cmd.CommandText = "SELECT * FROM Other WHERE year= @year ;";
                    sqlite_cmd.Parameters.AddWithValue("@year", years[mm]);
                    SQLiteDataAdapter adaptO = new SQLiteDataAdapter(sqlite_cmd);
                    adaptO.Fill(dtO);
                    conn.Close();

                    float.TryParse(dtO.Rows[0]["CurrentExpenses"].ToString(), out CurrentExpenses);
                    float.TryParse(dtO.Rows[0]["Deflator"].ToString(), out ODeflator);

                    Recyear = (dtO.Rows[0]["year"].ToString());
                    if (baseYrVal)
                    {
                        BaseOtherIn = (CurrentExpenses / ODeflator);

                    }
                    else
                    {
                        OtherIn = (CurrentExpenses / ODeflator);

                    }
                    //  Console.WriteLine("Other");
                    Console.WriteLine(OtherIn.ToString());

                }
                catch (Exception)
                {

                }

                try
                {

                    float mfgp, PpuH, DefFactor, Wip, PerCp, DiviSec, DefDivi;
                    sqlite_cmd.CommandText = "SELECT * FROM Output WHERE year= @year ;";
                    sqlite_cmd.Parameters.AddWithValue("@year", years[mm]);
                    DataTable dtOut = new DataTable();

                    SQLiteDataAdapter adaptOut = new SQLiteDataAdapter(sqlite_cmd);
                    adaptOut.Fill(dtOut);
                    conn.Close();

                    float.TryParse(dtOut.Rows[0]["mfgp"].ToString(), out mfgp);
                    float.TryParse(dtOut.Rows[0]["PpuH"].ToString(), out PpuH);
                    float.TryParse(dtOut.Rows[0]["DefFactor"].ToString(), out DefFactor);
                    float.TryParse(dtOut.Rows[0]["Wip"].ToString(), out Wip);
                    float.TryParse(dtOut.Rows[0]["PerCp"].ToString(), out PerCp);
                    float.TryParse(dtOut.Rows[0]["DiviSec"].ToString(), out DiviSec);
                    float.TryParse(dtOut.Rows[0]["DefDivi"].ToString(), out DefDivi);
                    Recyear = (dtOut.Rows[0]["year"].ToString());
                    if (baseYrVal)
                    {
                        BaseoutpIn = (((mfgp * PpuH) / DefFactor) + ((Wip * PerCp * PpuH) / DefFactor) + (DiviSec / DefDivi));

                    }
                    else
                    {
                        outpIn = (((mfgp * PpuH) / DefFactor) + ((Wip * PerCp * PpuH) / DefFactor) + (DiviSec / DefDivi));

                    }
                    //Console.WriteLine("Output calc");
                    //Console.WriteLine(mfgp);
                    //Console.WriteLine(Wip);
                    //Console.WriteLine(DiviSec);
                    //Console.WriteLine(outpIn);


                    // Console.WriteLine("Output");
                    Console.WriteLine(outpIn.ToString());

                }
                catch (Exception)
                {

                }
                if (baseYrVal)
                {

                    if (BaseCalcEI != 0)
                    {
                        dtr["Energy"] = CalcEI.ToString(); // dont show the base year values only store t
                        if (BaseoutpIn != 0)
                        {
                            BaseCalcEIProd = (BaseoutpIn / BaseCalcEI);
                            BaseTpm += CalcEI;
                            Console.WriteLine("Base Year");
                            Console.WriteLine(BaseCalcEIProd);
                            dtr["Energy Productivity"] = BaseCalcEIProd;

                        }

                    }
                }
                else
                {

                    if (CalcEI != 0)
                    {
                        dtr["Energy"] = (BaseCalcEI / CalcEI).ToString();
                        if (outpIn != 0)
                        {
                            dtr["Energy Productivity"] = BaseCalcEIProd / (outpIn / CalcEI);
                            BaseTpm += CalcEI;
                        }
                        CalcEI = 0;

                    }
                }

                if (baseYrVal)
                {
                    if (BaseMaterialIN != 0)
                    {
                        if (BaseoutpIn != 0)
                        {
                            BaseMaterialINProd = BaseoutpIn / BaseMaterialIN;
                        }
                        dtr["Material"] = BaseMaterialIN;
                        dtr["Material Productivity"] = BaseMaterialINProd;

                    }
                }
                else
                {
                    if (MaterialIN != 0)
                    {
                        dtr["Material"] = BaseMaterialIN / MaterialIN;
                        if (outpIn != 0)
                        {
                            dtr["Material Productivity"] = BaseMaterialINProd / (outpIn / MaterialIN);
                            Tpm += MaterialIN;


                        }
                        MaterialIN = 0;
                    }
                }
                if (baseYrVal)
                {
                    if (BaseLabourIn != 0)
                    {
                        dtr["Labour"] = BaseLabourIn.ToString();

                        if (BaseoutpIn != 0)
                        {
                            dtr["Labour Productivity"] = BaseoutpIn / BaseLabourIn;


                        }

                    }
                }
                else
                {
                    if (LabourIn != 0)
                    {
                        dtr["Labour"] = BaseLabourIn / LabourIn;

                        if (outpIn != 0)
                        {
                            dtr["Labour Productivity"] = (BaseoutpIn / BaseLabourIn) / (outpIn / LabourIn);
                            Tpm += LabourIn;

                        }
                        LabourIn = 0;
                    }
                }

                if (baseYrVal)
                {
                    if (BaseCapIn != 0)
                    {
                        dtr["Capital"] = BaseCapIn.ToString();
                        if (outpIn != 0)
                        {
                            dtr["Capital Productivity"] = BaseoutpIn / BaseCapIn;

                        }
                    }
                }

                else
                {
                    if (CapIn != 0)
                    {
                        dtr["Capital"] = BaseCapIn / CapIn;
                        if (outpIn != 0)
                        {
                            dtr["Capital Productivity"] = (BaseoutpIn / BaseCapIn) / (outpIn / CapIn);
                            Tpm += CapIn;

                        }
                        CapIn = 0;
                    }
                }
                if (baseYrVal)
                {
                    if (BaseOtherIn != 0)
                    {
                        dtr["Other"] = BaseOtherIn.ToString();
                        if (BaseoutpIn != 0)
                        {
                            dtr["Other Productivity"] = BaseoutpIn / BaseOtherIn;

                        }
                    }

                }
                else
                {
                    if (OtherIn != 0)
                    {
                        dtr["Other"] = BaseOtherIn / OtherIn;
                        if (outpIn != 0)
                        {
                            dtr["Other Productivity"] = (BaseoutpIn / BaseOtherIn) / (outpIn / OtherIn);
                            Tpm += OtherIn;

                        }
                        OtherIn = 0;
                    }
                }



                if (baseYrVal)
                {
                    if (BaseoutpIn != 0)
                    {
                        dtr["Output"] = BaseoutpIn.ToString();




                    }
                }
                else
                {
                    if (outpIn != 0)
                    {
                        dtr["Output"] = BaseoutpIn / outpIn;
                        TpmOut = outpIn;
                        outpIn = 0;


                    }
                }
                try
                {
                    float TpmFin = TpmOut / Tpm;
                    if (TpmFin > 0 && !Double.IsInfinity(TpmFin))
                    {
                        dtr["Total Productivity Measure[TPM]"] = TpmFin;
                        Tpm = 0;
                    }


                    dtprodOVer.Rows.Add(dtr);

                }
                catch (Exception)
                {

                }







                #endregion




                stats = true;



            }
            return dtprodOVer;

        }

        public table SearchRec(string dbname, string tablename,string searchMode)
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
                sqlite_cmd.CommandText = "SELECT * FROM " + tablename + ";";
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
        public table viewRec(string dbname, string tablename)
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
                sqlite_cmd.CommandText = "SELECT * FROM " + tablename + ";";
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

        public void update(string dbname, string tablename)
        {
            //bool stats = false;
            //DataTable dt = new DataTable();
            //// get your connection string


            //SQLiteConnection conn = new SQLiteConnection();
            //conn = CreateConnection(dbname);
            //SQLiteCommand sqlite_cmd = conn.CreateCommand();
            //sqlite_cmd.CommandText = "SELECT * FROM " + tablename + ";";
            //SQLiteDataAdapter da = new SQLiteDataAdapter(sqlite_cmd);
            //da.Fill(dt);

            //conn.Close();
            //switch (tablename)
            //{
            //    default:
            //        break;
            //}



            //  return stats;
        }
        public void createAdmins(string dbname="Admins")


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
        public bool InsertAdmin(string username, string password, string email , int privilege,string dbname = "Admins")


        {
            bool stats = false;
            string tablename = "AdminLogin";
            SQLiteConnection conn = new SQLiteConnection();
            AppMessage imsg = new AppMessage();

            try
            {

                conn = CreateConnection(dbname);
                SQLiteCommand sqlite_cmd;

                string insAdmin = "INSERT INTO '" + tablename + "'  (username, password, email, privilege ) VALUES (@username, @password, @email, @privilege);";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.Parameters.AddWithValue("@username", username);
                sqlite_cmd.Parameters.AddWithValue("@password", password);
                sqlite_cmd.Parameters.AddWithValue("@email", email);
                sqlite_cmd.Parameters.AddWithValue("@privilege", privilege);
                sqlite_cmd.CommandText = insAdmin;
                sqlite_cmd.ExecuteNonQuery();
                stats = true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                stats = false;
            }



            return stats;
        }


        public bool loginAdmin(string username, string password, string dbname = "Admins")


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












    }
}