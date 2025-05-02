using Google.Cloud.Firestore;
using System;

namespace Loginadmin.Class
{
    [FirestoreData]
    internal class Feedback
    {
        [FirestoreProperty]
        public string email { get; set; } // Email of the user providing feedback

        [FirestoreProperty]
        public string feedback { get; set; } // The feedback text/message

        [FirestoreProperty]

        public string rating { get; set; } // The feedback text/message

        [FirestoreProperty]
        public Timestamp timestamp { get; set; } // Timestamp when the feedback was submitted
    }
}
