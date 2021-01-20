using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace Feedback_System
{
    class DataService
    {
        internal static List<String> FetchCriterias() {
            string criteriaFilePath = Util.GetAbsoluteFilePath("Data\\settings.txt");
            List<String> criterias = new List<String>();
            try
            {
                using (var sr = new StreamReader(criteriaFilePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        criterias.Add(line);
                    }
                    sr.Close();
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Settings file is missing");
            }
            catch (Exception genEx) {
                MessageBox.Show("Something went wrong while loading system files");
            }
            return criterias;
        }



        internal static void SaveRating(string ratingString, List<string> criterias) {
            var ratingsFilePath = Util.GetAbsoluteFilePath("Data\\ratings.csv");
            try
            {
                if (!File.Exists(ratingsFilePath))
                {
                    using (var fs = File.Create(ratingsFilePath)) {
                        byte[] title = new UTF8Encoding(true).GetBytes(Util.convertListToCsv(criterias) + ",Datetime" + "\r\n");
                        fs.Write(title, 0, title.Length);
                        fs.Close();
                    }
                }

                var writeStream = File.AppendText(ratingsFilePath);
                writeStream.WriteLine(ratingString);
                writeStream.Close();
            }
            catch (DirectoryNotFoundException dirEx) {
                MessageBox.Show("System files folder is missing");
            }
            catch (Exception genEx)
            {
                MessageBox.Show("Something went wrong while loading system files");
            }
        } 
    }
}
