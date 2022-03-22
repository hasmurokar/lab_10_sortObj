using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class CityBuild: IComparable<CityBuild>
    {
        public string CompanyName { get; set; }
        public string BuildObject { get; set; }
        public int Square { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string State { get; set; }

        public CityBuild(string companyName, string buildObject, int square, DateTime startDate, DateTime endDate, string state)
        {
            CompanyName = companyName;
            BuildObject = buildObject;
            Square = square;
            StartDate = startDate;
            EndDate = endDate;
            State = state;
        }
        public int GetDays()
        {
            return EndDate.Subtract(StartDate).Days;
        }
        public override string ToString()
        {
            return $"{CompanyName,-12} | {BuildObject,-12} | {Square,5}м^2 | {StartDate.ToString("d"),-9} | {EndDate.ToString("d"),-12} | {State,-10} | {GetDays()} д.";
        }

        public int CompareTo(CityBuild other)
        {
            return CompanyName.CompareTo(other.CompanyName);
        }

        public class SortByBuildObject : IComparer<CityBuild>
        {
            public int Compare(CityBuild x, CityBuild y)
            {
                return x.BuildObject.CompareTo(y.BuildObject);
            }
        }

        public class SortBySquare : IComparer<CityBuild>
        {
            public int Compare(CityBuild x, CityBuild y)
            {
                return x.Square.CompareTo(y.Square);
            }
        }

        public class SortByStartDate : IComparer<CityBuild>
        {
            public int Compare(CityBuild x, CityBuild y)
            {
                return x.StartDate.CompareTo(y.StartDate);
            }
        }
    }
}
