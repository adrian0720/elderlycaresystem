using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loginadmin.Class
{
    [FirestoreData]
    internal class AdminUser
    {
        [FirestoreProperty]
        public string username { get; set; }
        [FirestoreProperty]
        public string password { get; set; }
    }
}
