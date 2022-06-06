﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryService
{
    internal class InventoryManager
    {
        private List<Item> items;

        private InventoryData data;

        public InventoryManager()
        {
            this.data = new InventoryData();
            loadDataFromDatabase();
        }

        private void loadDataFromDatabase()
        {
            items = new List<Item>();

            foreach (Item I in (List<Item>)data.ReadAll())
            {
                items.Add((Item)I);
            }
        }

        public bool Add(object obj)
        {
            if (obj != null)
            {
                data.Insert((Item)obj);
                loadDataFromDatabase();
                return true;
            }
            else
            {
                return false;
            }

        }


        public bool Update(object obj,int id)
        {
            if (obj != null)
            {
                data.Update((Item)obj,id);
                loadDataFromDatabase();
                return true;
            }
            else
            {
                return false;
            }

        }

        public List<object> GetAll()
        {
            List<object> temp = new List<object>();

            foreach (Item item in items)
            {
                temp.Add(item);
            }
            return temp;
        }

        public bool Remove(object obj)
        {
            if (obj != null)
            {
                data.Delete((Item)obj);
                loadDataFromDatabase();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
