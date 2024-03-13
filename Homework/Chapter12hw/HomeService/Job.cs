using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeService
{
    internal class Job
    {
         
        
            //declare variables
            double TRIP_FEE = 35;
            string description;
            float hourToComplete;
            float hourlyFee;
            float totalFee;

            //paremetrized constructor
            public Job(string description, float hourToComplete, float hourlyFee)
            {
                //assign values on object creation
                this.description = description;
                this.hourToComplete = hourToComplete;
                this.hourlyFee = hourlyFee;
            }
            //set Description
            public void setDescription(string d)
            {
                description = d;
            }
            //get Description
            public string getDescription()
            {
                return description;
            }

            public void setHourToComplete(float hourToComp)
            {
                hourToComplete = hourToComp;
            }
            public double getHourToComplete()
            {
                return hourToComplete;
            }
            public void setHourlyFee(float fee)
            {
                hourlyFee = fee;
            }
            public double getHourlyFee()
            {
                return hourlyFee;
            }

            //return total fee
            public double getTotalFee()
            {
                //calculate total fee and return
                return (hourlyFee * hourToComplete) + TRIP_FEE;
            }
        }
    }

