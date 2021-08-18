using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace KDMEDISP
{
    class serialize
    {
        string filename = ""; 
        public serialize(string filePath)
        {
            filename = filePath;
          

        }

        public  void SerializeNow(object cl, object para)
        {
            try
            {
                var c = (DefaultConfig)cl;




                Stream s = File.Open(filename, FileMode.Create);
                BinaryFormatter b = new BinaryFormatter();
                b.Serialize(s, c);
                s.Close();
            }
            catch (Exception)
            {


            }
        }

        public object  DeSerializeNow( object cl)
        {
            var c = (DefaultConfig)cl;

            try
            {

                Stream s = File.Open(filename, FileMode.Open);
                BinaryFormatter b = new BinaryFormatter();
                c = (DefaultConfig)b.Deserialize(s);

                s.Close();
            }
            catch (Exception)
            {

              
            }
            return c;

        }
    }
   
}
