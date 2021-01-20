using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback_System
{
    class Feedback
    {
        private string name;
        private string email;
        private string contact;
        private string address;
        private string feedbackTxt;
        private int[] ratings;
        private string timestamp;
        public Feedback(string name, string email, string contact, string address, string feedback, int[] ratings, string timestamp) {
            this.name = name;
            this.Email = email;
            this.contact = contact;
            this.address = address;
            this.feedbackTxt = feedback;
            this.ratings = ratings;
            this.timestamp = timestamp;
        }

        public string CustomerName { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Address { get => address; set => address = value; }
        public string FeedbackText { get => feedbackTxt; set => feedbackTxt = value; }
        public int[] Ratings { get => ratings; set => ratings = value; }
        public string Timestamp { get => timestamp; set => timestamp = value; }
    }
}
