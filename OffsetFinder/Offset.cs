using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Memory;

namespace MemoryTools.OffsetFinder
{
    public class Offset
    {
        
        private string name;
        /// <summary>
        /// Offset Name
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
                
        private string pattern;
        /// <summary>
        /// Offset Pattern
        /// </summary>
        public string Pattern
        {
            get { return pattern; }
            set { pattern = value; }
        }

        private string mask;
        /// <summary>
        /// Mask of offset
        /// </summary>
        public string Mask
        {
            get
            { return mask; }
            set { mask = value; }
        }
                
        private bool isPointer;
        /// <summary>
        /// Is offset is Pointer
        /// </summary>
        public bool IsPointer
        {
            get{return isPointer;}
            set { isPointer = value; }
        }

        private int dislocation;
        /// <summary>
        /// Dislocation of Address
        /// </summary>
        public int Dislocation
        {
            get { return dislocation; }
            set { dislocation = value; }
        }


        private List<uint> adresses;
        /// <summary>
        /// List Of finded adreses
        /// </summary>
        public List<uint> Adresses
        {
            get { return adresses; }
        }

        public void ClearAdreses()
        {
            adresses.Clear();
        }


        /// <summary>
        /// Add adres to list
        /// </summary>
        /// <param name="adres">adres</param>
        private void AddAdres(uint adres)
        {
            if (!adresses.Contains(adres))
            {
                adresses.Add(adres);
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Name">Offset Name</param>
        /// <param name="Pattern">Pattern to find</param>
        /// <param name="Mask">Mask for pattern</param>
        /// <param name="IsPointer">Is offset pointer</param>
        /// <param name="Dislocation">Dislocation of offset</param>
        public Offset(string Name, string Pattern, string Mask, bool IsPointer, int Dislocation)
        {
            this.Name = Name;
            this.Pattern = Pattern;
            this.Mask = Mask;
            this.IsPointer = IsPointer;
            this.Dislocation = Dislocation;
            adresses = new List<uint>();
        }

        public Offset()
        {
            adresses = new List<uint>();
        }

       

        /// <summary>
        /// Search offset Adreses In Memory of Attached process
        /// </summary>
        /// <param name="mv">Memory object attached to process</param>
        public void SearchOffset(MemoryWorker mv)
        {
            uint num = mv.FindPattern(pattern, mask);
            uint oldnum = 0;
            while (num != oldnum)
            {
                uint offset = num;
                num += (uint)dislocation;
                if (!IsPointer) adresses.Add(num);
                else
                {
                    uint num1 = mv.ReadUInt(num);
                    adresses.Add(num1);
                }

                oldnum = num;
                //num = mv.FindPattern(num, (int)mv.MainModule.ModuleMemorySize-num, pattern, mask);
                num = mv.FindPattern(num, (int)mv.MainModule.ModuleMemorySize - (int)offset, pattern, mask);
                
            }


            return;            
            
            //TODO: Add IsPointer and Dislocation reaction                                   
            //TODO: Add search of multiple adresses                        
        }
    }
}
