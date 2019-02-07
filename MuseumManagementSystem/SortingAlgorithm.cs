using System;
using System.Collections.Generic;
using System.Globalization;

namespace MuseumManagementSystem
{
    public class SortingAlgorithm
    {
        /// <summary>
        /// ascending quick sort by intime using recusrion
        /// </summary>
        /// <param name = "list" ></ param >
        /// < returns ></ returns >
        public List<VisitorsInformation> QuickSortByInTime(List<VisitorsInformation> list)
        {
            if (list.Count <= 1)
            {
                return list;
            }

            Random random = new Random();
            List<VisitorsInformation> less = new List<VisitorsInformation>();
            List<VisitorsInformation> greater = new List<VisitorsInformation>();

            int pos = random.Next(list.Count);
            VisitorsInformation pivot = list[pos];

            list.RemoveAt(pos);

            foreach (VisitorsInformation item in list)
            {
                DateTime inTimeItem = DateTime.Parse(item.CheckInTime);
                DateTime inTimePivot = DateTime.Parse(pivot.CheckInTime);
                if (inTimeItem < inTimePivot)
                {
                    less.Add(item);
                }
                else
                {
                    greater.Add(item);
                }
            }
            return Concat(QuickSortByInTime(less), pivot, QuickSortByInTime(greater));
        }

        public List<VisitorsInformation> Concat(List<VisitorsInformation> less, VisitorsInformation pivot, List<VisitorsInformation> greater)
        {

            List<VisitorsInformation> sorted = new List<VisitorsInformation>(less);

            sorted.Add(pivot);

            foreach (VisitorsInformation i in greater)
            {
                sorted.Add(i);

            }

            return sorted;
        }

        /// <summary>
        /// descending quick sort by total visitor using recusrion
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public List<ReportsWeekly> QuickSortByTotalVisitor(List<ReportsWeekly> list)
        {
            if (list.Count <= 1)
            {
                return list;
            }

            Random random = new Random();
            List<ReportsWeekly> less = new List<ReportsWeekly>();
            List<ReportsWeekly> greater = new List<ReportsWeekly>();

            int pos = random.Next(list.Count);
            ReportsWeekly pivot = list[pos];

            list.RemoveAt(pos);

            foreach (ReportsWeekly item in list)
            {
                double totalTimeSpent = item.TotalTimeSpent;
                double totalTimeSpentPivot = pivot.TotalTimeSpent;
                if (totalTimeSpent < totalTimeSpentPivot)
                {
                    less.Add(item);
                }
                else
                {
                    greater.Add(item);
                }
            }
            return ConcatWeekly(QuickSortByTotalVisitor(less), pivot, QuickSortByTotalVisitor(greater));
        }

        public List<ReportsWeekly> ConcatWeekly(List<ReportsWeekly> less, ReportsWeekly pivot, List<ReportsWeekly> greater)
        {

            List<ReportsWeekly> sorted = new List<ReportsWeekly>(greater);

            sorted.Add(pivot);

            foreach (ReportsWeekly i in less)
            {
                sorted.Add(i);

            }

            return sorted;
        }

    }
}