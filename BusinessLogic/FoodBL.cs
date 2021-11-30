using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class FoodBL
    {
        FoodDA foodDA = new FoodDA();
        public List<Food> GetAll()
        {
            return foodDA.GetAll();
        }
        public int Insert(Food food)
        {
            return foodDA.Insert_Update_Delete(food, 0);
        }
        public int Update(Food food)
        {
            return foodDA.Insert_Update_Delete(food, 1);
        }
        public int Delete(Food food)
        {
            return foodDA.Insert_Update_Delete(food, 2);
        }
        public Food GetByID(int ID)
        {
            List<Food> foods = foodDA.GetAll();
            foreach(var item in foods)
            {
                if (item.ID == ID)
                    return item;
            }
            return null;
        }
        public List<Food> FindByCategory(int categoryId)
        {
            List<Food> foods = foodDA.GetAll();
            List<Food> result = new List<Food>();
            foreach(var item in foods)
            {
                if (item.FoodCategoryID == categoryId)
                    result.Add(item);
            }
            return result;
        }
        public List<Food> Find(string key)
        {
            List<Food> foods = foodDA.GetAll();
            List<Food> result = new List<Food>();
            foreach(var item in foods)
            {
                if (item.ID.ToString().Contains(key) ||
                    item.Name.Contains(key)
                    || item.Unit.Contains(key)
                    || item.Price.ToString().Contains(key)
                    || item.Notes.Contains(key))
                    result.Add(item);
            }
            return result;
        }
        public SqlDataReader GetFoodHaveAddByTableID(int tableID)
        {
            return foodDA.GetFoodHaveAddByTableID(tableID);
        }
        public DataTable GetFoodByCategoryID(int CategoryID)
        {
            return foodDA.GetFoodByCategoryID(CategoryID);
        }


    }
}
