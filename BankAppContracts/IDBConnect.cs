using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IDBConnect
    {

        Task<bool> WriteToJason<T>(T jsonFilType, string jsonName);
        Task<List<T>> ReadFromJason<T>(string jsonName);
        Task<bool> UpdateJason<T>(List<T> models, string fileName);
        void UpdatePath();

    }
}

