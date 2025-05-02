using Google.Cloud.Firestore;
using System;
using System.IO;

namespace FirestoreApplication.Classes
{
    internal static class FirestoreHelper
    {
        // JSON configuration for Firestore
        static string fireconfig = @"
        {
              ""type"": ""service_account"",
              ""project_id"": ""signup-login-e989d"",
              ""private_key_id"": ""12013ba460e8a63ca18ff179cf4eaf9dfbeaa151"",
              ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvAIBADANBgkqhkiG9w0BAQEFAASCBKYwggSiAgEAAoIBAQCkh/pViNvBbB9b\nHbOglBaMy8ASa+oUeh4L+kjOSWkYp+wvsIZvqhTBDYRDMSrR3CJLByTbUDo61T/F\no20QNRl89l6XaNzlAjRwfqe47oUas4M4irkmRtnRG75LawSoVaWLSwlwvtlftuZy\neeXs7i7C+CYEyn0m67cVOre9vPWLRWmTlMaQLPdKiBD6VCNHiz8+KFoi7qQAik+f\nNovPGCB6Lgo0rHUOKu4P3aei27rPkoVJvrGcN1LNPJtP7KQ9yOKQYsWUArcG2Wrr\nBNJX7W3at14eZm8rZJK3Xt7sCWFGxDifrqhG+aKfK1JDhrOyhelQQp6Ba0r+Mlji\nxt0FKe7lAgMBAAECggEAFxwRrDL0FEfGDbZvH7Zn28XV8ssdOVwVB/9TJkUcZxNV\nsuBwuZLM+yLADu9YgYU8fIetLxrRMFNPSPN/+FSlAa7Z3BrQBWCZEgCljphTXMvr\nD1A42lNS+TKUOM6i0awZ+6XXVnKQC111d+Mpnu0Dkhdoa6gvX6igchxpvij3ijnv\nSwODZaG4EgX8mHcY+P4oAWsj+bTC08dks6KAf1exzAehyFa9G0KZ8xXfgleRYoNK\nn/Guax2D0nOOH3ZPhNeJ7r8HHJEPAmO+JcpRmrAOkaiMbi0os4h0M3qCQ8Abv6Qy\nQSXQkMlCwAEwHfBLob5zGr3B28f8fkpXEIEeSfSSHwKBgQDgrj2SdnvebS5u8SmU\n78JT4pSjuierFwxWHVkKtrH398dwadDmVXw26UHvoteGtD3rKG/UEL/kE5E/YHX0\n1gC68o3lj/sWyGpFjTfb/rZ1yQtNcr8Cvf5iX4Ytc8Tk8vxcepNuEsC8SE3YKjby\nfyTd/h+h+3Q9dGXWIw85AKJt+wKBgQC7d0udGXFh4jEz1pGpEiYCpGwmhH45TS1d\n1TBjw6QtJJH7JM4tdE8uPnOP++0XY+RxeVMG4tXA4znsO/LqQeNzzf25K9E0ETZD\nZDr88tvDF+ctrgsQBY9RkutY6M+NS0Ihrhp61SzwtIqzSZ7qTIDqIzz3x9HmVOwB\naB+JfmTgnwKBgB/4CuDFJRjf9iRpAh6kAsWGztmBClXowKOcJ2hD2IzM377Z/5RW\ng4cYp34ecIZFLS5Boa/N9k/QjPE0m3QL4yy2iIQqeXKjb6OX1WPjGTknMwmBEzaj\nrAd5ShE7kL9253uNIV8fIfdoXlMspobYmnlPyFZ2/fIklrziXi8hLPtzAoGAWNTj\nuLLIvnhflk/TwAkAh/n/4ZSg92gx2ifegTfAwT92CUrchD98Ec64Ff9rzsygAIFc\nLYQpg/hohx+1MPo93K88zpUL0h9h1jdVmG1AY8cc3dF+Hn5z9lSnPv868po54RnO\nJGyFmh4DJ4f4TNApukkuZ7+BICMXnmcHorCI/sMCgYANNglsu3vYRua1OUjirlSw\nYoLYiJ6ikg1Zv5wwu09DfgVgpFuED7C5J3pgpjqzqd/Ut/+qHMOjkEpli3se3YuL\nYYS8RRSRgXgLlx1p9gjDIoYyBGfW8XjR0zJ/64JOpeEU+aKibAgJ0rSmU05yws7D\nVAjQyIfzzi2H8WtOui+K/w==\n-----END PRIVATE KEY-----\n"",
              ""client_email"": ""firebase-adminsdk-jdplu@signup-login-e989d.iam.gserviceaccount.com"",
              ""client_id"": ""100370031356982939387"",
              ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
              ""token_uri"": ""https://oauth2.googleapis.com/token"",
              ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
              ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-jdplu%40signup-login-e989d.iam.gserviceaccount.com""
        }";

        static string filepath = ""; // Path for the temporary JSON file
        public static FirestoreDb Database;

        public static void SetEnvironmentVariable()
        {
            // Create a temporary JSON file with the Firestore credentials
            filepath = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(Path.GetRandomFileName())) + ".json";
            File.WriteAllText(filepath, fireconfig);
            File.SetAttributes(filepath, FileAttributes.Hidden);

            // Set the environment variable for Google Cloud Firestore
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filepath);

            // Initialize the Firestore database
            Database = FirestoreDb.Create("signup-login-e989d");

            // Clean up: Delete the temporary JSON file
            File.Delete(filepath);
        }
    }
}
