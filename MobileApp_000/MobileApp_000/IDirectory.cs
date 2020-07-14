using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp_000
{
    public interface IDirectory
    {
        string CreateDirectory(string directoryName);
        void RemoveDirectory();
        string RenameDirectory(string oldDirectoryName, string newDirectoryName);
    }
}
