﻿using System;
using System.IO;
using Xamarin.Forms;
using MobileApp_000.Droid;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

[assembly: Dependency(typeof(DirectoryHelper))]

namespace MobileApp_000.Droid
{
    public class DirectoryHelper : IDirectory
    {
        public string documentBasePath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        public string CreateDirectory(string directoryName)
        {
            var directoryPath = Path.Combine(documentBasePath, directoryName);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            return directoryPath;
        }
        public void RemoveDirectory()
        {
            DirectoryInfo directory = new DirectoryInfo(documentBasePath);
            foreach (DirectoryInfo dir in directory.GetDirectories())
            {
                dir.Delete(true);
            }
        }
        public string RenameDirectory(string oldDirectoryName, string newDirectoryName)
        {
            var olddirectoryPath = Path.Combine(documentBasePath, oldDirectoryName);
            var newdirectoryPath = Path.Combine(documentBasePath, newDirectoryName);
            if (!Directory.Exists(olddirectoryPath))
            {
                Directory.Move(olddirectoryPath, newdirectoryPath);
            }
            return newdirectoryPath;
        }
    }
}