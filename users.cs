using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Loginadmin.Class
{
    [FirestoreData]
    internal class user
    {
        [FirestoreProperty]
        public string firstName { get; set; }
        [FirestoreProperty]
        public string lastName { get; set; }
        [FirestoreProperty]
        public string age { get; set; }
        [FirestoreProperty]
        public string condition { get; set; }
        [FirestoreProperty]
        public string contact { get; set; }
        [FirestoreProperty]
        public string email { get; set; }
        [FirestoreProperty]
        public string guardian { get; set; }
        [FirestoreProperty]
        public string sex { get; set; }
        [FirestoreProperty]
        public long weight { get; set; }
        [FirestoreProperty]
        public string height { get; set; }
        [FirestoreProperty]
        public int relationship { get; set; }


    }
}
