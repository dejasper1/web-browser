﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.HistoryDataSetTableAdapters;


namespace WebBrowser.Logic
{
    public class HistoryManager
    {

        public static void AddItem(HistoryItem item)
        {
            var adapter = new HistoryTableAdapter();
            adapter.Insert(item.URL, item.Title, item.Date);

        }
        public static List<HistoryItem> GetItems()
        {
            var adapter = new HistoryTableAdapter();
            var results = new List<HistoryItem>();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                var item = new HistoryItem();
                item.Date = row.Date;
                item.Title = row.Title;
                item.URL = row.URL;
                item.Id = row.Id;

                results.Add(item);
            }

            return results;
        }

    }
}
