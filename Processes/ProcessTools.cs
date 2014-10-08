using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using MemoryTools.Processes;
using Memory;

namespace MemoryTools
{
    class ProcTools
    {
        private List<prc> _procs;

        public ProcTools()
        {
            _procs = new List<prc>();
            Memory = new MemoryWorker();
            Mems = new Mem();
        }

        private void RefreshProcs()
        {
            _procs.Clear();

            foreach (Process process in Process.GetProcesses())
            {
                string pname = process.ProcessName;
                int pid = process.Id;

                _procs.Add(new prc(pname, pid));
            }

        }

        /// <summary>
        /// Список процессов в системе
        /// </summary>
        /// <returns>Список из объектов содержащих имя процесса и его pid</returns>
        public List<prc> GetProcesses
        {
            get
            {
                RefreshProcs();
                return _procs;
            }
        }

        /// <summary>
        /// Возвращает PID процесса по его порядковому номеру в списке
        /// </summary>
        /// <param name="number">Номер по порядку процесса</param>
        /// <returns>PID процесса</returns>
        public int GetProcessPID(int number)
        {
            return _procs[number].PID;
        }

        public string GetProcessName(int number)
        {
            return _procs[number].Name;
        }

        public MemoryWorker Memory { get; private set; }
        public Mem Mems { get; private set; }
    }
}
