using System;
using System.Collections.Generic;
using System.IO;

namespace subiect1
{
    public class AccessPackageLoader
    {
        AccessPackageUtility accessPackageUtility;
        
        string invalidFileMessage = "AccessPackages file is not present!";
        string corruptFileMessage = "One or more AccessPackages records are corrupt!";
        string invalidIdMessage = "One or more AccessPackages records have invalid ids!";

        public List<AccessPackage> list;

        public List<AccessPackage> GetPackages()
        {
            return list;
        }

        public AccessPackageLoader()
        {
            list = new List<AccessPackage>();
            accessPackageUtility = new AccessPackageUtility();
        }

        public string Populate(string source, bool ignoreFirstRow)
        {
            try
            {
                using (StreamReader sr = new StreamReader(source))
                {

                    List<int> ids = new List<int>();
                    string record;
                    while ((record = sr.ReadLine()) != null)
                    {
                        if (ignoreFirstRow)
                        {
                            ignoreFirstRow = false;
                            continue;
                        }

                        var item = accessPackageUtility.Convert(record);
                        if (item == null) return corruptFileMessage;
                        if (ids.IndexOf(item.Id) >= 0) return invalidIdMessage;

                        ids.Add(item.Id);
                        list.Add(item);
                    }

                    return "";
                }
            }
            catch (Exception ex)
            {
                return invalidFileMessage;
            }
            
        }
    }
}
