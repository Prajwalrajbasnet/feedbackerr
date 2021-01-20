using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Feedback_System
{
    class Util
    {
        internal static string GetAbsoluteFilePath(string pathFromRoot){
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, pathFromRoot);
            return path;
        }

        internal static string  ConvertRatingToCsv(string name, string contact, string email, string address, List<String> ratings ) {
            string csv = string.Format("{0},{1},{2},{3},", name, contact, email, address);
            csv += convertListToCsv(ratings) + "," + DateTime.Now;
            return csv;
        }

        internal static string convertListToCsv(List<String> list){
            string csv = "";
            for (var i = 0; i < list.Count; i++){
                if (i < (list.Count - 1)){
                    csv += list[i] + ",";
                }
                else{
                    Console.WriteLine("Adding last word");
                    csv += list[i];
                }
            }
            return csv;
        }

        internal static string mapRatingTextToValue(string ratingText) {
            return (Constants.ratings.Length - Array.IndexOf(Constants.ratings, ratingText)).ToString();
        }

        internal static string mapRatingValueToText(int ratingValue) {
            return Constants.ratings[Constants.ratings.Length - ratingValue];
        }
    }
}
