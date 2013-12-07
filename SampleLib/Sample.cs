using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLib
{

    /// <summary>
    /// Sample Class
    /// </summary>
    public class Sample
    {
        public string Name { get; set; }

        public string nas = "raf";

        

        #region fields
        private int intsam ;
        #endregion

        #region Property
        public int Intsam
        {
            get 
            {
                return intsam * 2;
            }
            set
            {
                intsam = value;
                intsam++;
            }
        }

        #endregion

        public Sample()
        {
        }

        public Sample(string namep)
        {
            Name = namep;

           
        }

        /// <summary>
        /// To get the Name
        /// </summary>
        /// <returns>Name string</returns>
        public string GetName()
        {
            return Name;
        }

        public string GetName(string namep)
        {
            Name = namep;

            return Name;
        }
    }
}
