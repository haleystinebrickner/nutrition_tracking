using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class IntakeModel
    {
        /// <summary>
        /// Represents intake identification- to link to DB
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents the user name
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Represents category name
        /// </summary>

        /// <summary>
        /// Represents category name
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// Represents the intake value for the particular category at a given recorded point
        /// </summary>
        public double ConsumedValue { get; set; }

        /// <summary>
        /// Represents the total consumed value for this particular intake category
        /// </summary>
        public double TotalValue { get; set; }

        public IntakeModel(string categoryName, string consumedValueString)
        {
            Name = categoryName;

            int consumedValueNumber = 0;
            int.TryParse(consumedValueString, out consumedValueNumber); //string to int convsion before assign
            ConsumedValue = consumedValueNumber;

        }

        
        
    }

}


