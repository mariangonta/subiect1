using System;
using System.Collections.Generic;

namespace subiect1
{
    public class RegistrationUtility
    {
        public RegistrationContainer GetRegistrationById(List<RegistrationContainer> list, string id)
        {
            foreach (var item in list) if (item.Id == id) return item;

            return null;
        }

        public bool RemoveId(List<RegistrationContainer> list, string id)
        {
            int listLength = list.Count;
            for (int i = 0; i < listLength; i++)
                if (list[i].Id == id)
                {
                    list.RemoveAt(i);
                    return true;
                }
            return false;
        }
    }
}