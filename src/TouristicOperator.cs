using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PM03_Zaplatkin
{
    class TouristicOperator
    {
        private Trip[] trips;
        public TouristicOperator(int N)
        {
            this.trips = new Trip[N];
        }
        public Trip[] GetTrips()
        {
            return this.trips;
        }
        public void SetTripByIndex(Trip trip, int index)
        {
            this.trips[index] = trip;
        }

        public void SortByPriceAndTourGroupSizeAsc()
        {
            for (int i = 0; i < this.trips.Length; i++)
            {
                for (int j = 0; j < this.trips.Length - 1; j++)
                {
                    if (this.trips[j].GetPrice() > this.trips[j + 1].GetPrice())
                    {
                        Trip temp = this.trips[j + 1];
                        this.trips[j + 1] = this.trips[j];
                        this.trips[j] = temp;
                    }
                    else if (this.trips[j].GetPrice() == this.trips[j + 1].GetPrice())
                    {
                        if (this.trips[j].GetTourGroupSize() > this.trips[j + 1].GetTourGroupSize())
                        {
                            Trip temp = this.trips[j + 1];
                            this.trips[j + 1] = this.trips[j];
                            this.trips[j] = temp;
                        }
                    }
                }
            }
        }

        public void SaveTripsToFile(string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (var t in trips)
                {
                    sw.WriteLine(t);
                }
            }
        }
    }
}
