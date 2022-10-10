using System;
using System.Threading.Tasks;

namespace Expenses2.Interfaces
{
    public interface IShare
    {
        Task Show(string title,string message,string filePath);
    }
}
