/* Title:           Trailer Category Class
 * Date:            8-28-18
 * Author:          Terry Holmes
 * 
 * Description:     This is the class for Tool Category */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace TrailerCategoryDLL
{
    public class TrailerCategoryClass
    {
        //setting up the class
        EventLogClass TheEventLogclass = new EventLogClass();

        TrailerCategoryDataSet aTrailerCategoryDataSet;
        TrailerCategoryDataSetTableAdapters.trailercategoryTableAdapter aTrailerCategoryTableAdapter;

        InsertTrailerCategoryEntryTableAdapters.QueriesTableAdapter aInsertTrailerCategoryTableAdapter;

        FindTrailerCategoryByCategoryIDDataSet aFindTrailerCategoryByCategoryIDDataSet;
        FindTrailerCategoryByCategoryIDDataSetTableAdapters.FindTrailerCategoryByCategoryIDTableAdapter aFindTrailerCategoryByCategoryIDTableAdapter;

        FindTrailerCategoryByCategoryDataSet aFindTrailerCategoryByCategoryDataSet;
        FindTrailerCategoryByCategoryDataSetTableAdapters.FindTrailerCategoryByCategoryTableAdapter aFindTrailerCategoryByCategoryTableAdapter;

        FindSortedTrailerCategoryDataSet aFindSortedTrailerCategoryDataSet;
        FindSortedTrailerCategoryDataSetTableAdapters.FindSortedTrailerCategoryTableAdapter aFindSortedTrailerCategoryTableAdapter;

        public FindSortedTrailerCategoryDataSet FindSortedTrailerCategory()
        {
            try
            {
                aFindSortedTrailerCategoryDataSet = new FindSortedTrailerCategoryDataSet();
                aFindSortedTrailerCategoryTableAdapter = new FindSortedTrailerCategoryDataSetTableAdapters.FindSortedTrailerCategoryTableAdapter();
                aFindSortedTrailerCategoryTableAdapter.Fill(aFindSortedTrailerCategoryDataSet.FindSortedTrailerCategory);
            }
            catch (Exception Ex)
            {
                TheEventLogclass.InsertEventLogEntry(DateTime.Now, "Trailer Category Class // Find Sorted Trailer Category " + Ex.Message);
            }

            return aFindSortedTrailerCategoryDataSet;
        }
        public FindTrailerCategoryByCategoryDataSet FindTrailerCategoryByCategory(string strTrailerCategory)
        {
            try
            {
                aFindTrailerCategoryByCategoryDataSet = new FindTrailerCategoryByCategoryDataSet();
                aFindTrailerCategoryByCategoryTableAdapter = new FindTrailerCategoryByCategoryDataSetTableAdapters.FindTrailerCategoryByCategoryTableAdapter();
                aFindTrailerCategoryByCategoryTableAdapter.Fill(aFindTrailerCategoryByCategoryDataSet.FindTrailerCategoryByCategory, strTrailerCategory);
            }
            catch (Exception Ex)
            {
                TheEventLogclass.InsertEventLogEntry(DateTime.Now, "Trailer Category Class // Find Trailer Category By Category " + Ex.Message);
            }

            return aFindTrailerCategoryByCategoryDataSet;
        }
        public FindTrailerCategoryByCategoryIDDataSet FindTrailerCategoryByCategoryID(int intCategoryID)
        {
            try
            {
                aFindTrailerCategoryByCategoryIDDataSet = new FindTrailerCategoryByCategoryIDDataSet();
                aFindTrailerCategoryByCategoryIDTableAdapter = new FindTrailerCategoryByCategoryIDDataSetTableAdapters.FindTrailerCategoryByCategoryIDTableAdapter();
                aFindTrailerCategoryByCategoryIDTableAdapter.Fill(aFindTrailerCategoryByCategoryIDDataSet.FindTrailerCategoryByCategoryID, intCategoryID);
            }
            catch (Exception Ex)
            {
                TheEventLogclass.InsertEventLogEntry(DateTime.Now, "Trailer Category Class // Find Trailer Category By Category ID " + Ex.Message);
            }

            return aFindTrailerCategoryByCategoryIDDataSet;
        }
        public bool InsertTrailerCategory(string strTrailerCategory)
        {
            bool blnFatalError = false;

            try
            {
                aInsertTrailerCategoryTableAdapter = new InsertTrailerCategoryEntryTableAdapters.QueriesTableAdapter();
                aInsertTrailerCategoryTableAdapter.InsertTrailerCategory(strTrailerCategory);
            }
            catch (Exception Ex)
            {
                TheEventLogclass.InsertEventLogEntry(DateTime.Now, "Trailer Category Class // Insert Trailer Category " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public TrailerCategoryDataSet GetTrailerCategoryInfo()
        {
            try
            {
                aTrailerCategoryDataSet = new TrailerCategoryDataSet();
                aTrailerCategoryTableAdapter = new TrailerCategoryDataSetTableAdapters.trailercategoryTableAdapter();
                aTrailerCategoryTableAdapter.Fill(aTrailerCategoryDataSet.trailercategory);
            }
            catch (Exception Ex)
            {
                TheEventLogclass.InsertEventLogEntry(DateTime.Now, "Trailer Category Class // Get Trailer Category Info " + Ex.Message);
            }

            return aTrailerCategoryDataSet;
        }
        public void UpdateTrailerCategoryDB(TrailerCategoryDataSet aTrailerCategoryDataSet)
        {
            try
            {
                aTrailerCategoryTableAdapter = new TrailerCategoryDataSetTableAdapters.trailercategoryTableAdapter();
                aTrailerCategoryTableAdapter.Update(aTrailerCategoryDataSet.trailercategory);
            }
            catch (Exception Ex)
            {
                TheEventLogclass.InsertEventLogEntry(DateTime.Now, "Trailer Category Class // Update Trailer Category DB " + Ex.Message);
            }
        }
    }
}
