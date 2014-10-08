using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MemoryTools.Processes
{
    /// <summary>
    /// Класс содержащий имя процесса, его пид.
    /// </summary>
    class prc
    {
        private string _name;
        private int _pid;        
        
        /// <summary>
        /// Имя процесса
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }            
        }

        /// <summary>
        /// pid Процесса
        /// </summary>
        public int PID
        {
            get 
            {
                return _pid;
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name">Имя процесса</param>
        /// <param name="pid">pid процесса</param>
        /// <param name="number">Порядковый номер процесса</param>
        public prc(string name, int pid)
        {
            _name = name;
            _pid = pid;      
        }
    }
}
