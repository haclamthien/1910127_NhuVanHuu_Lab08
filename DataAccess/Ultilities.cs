using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Ultilities
    {
        private static string StrName = "ConnectionStringName";
        public static string ConnectionString = ConfigurationManager.ConnectionStrings[StrName].ConnectionString;
        // Các biến của bảng Food
        public static string Food_GetAll = "Food_GetAll";
        public static string Food_InsertUpdateDelete = "Food_InsertUpdateDelete";
        public static string Food_GetFoodByCategoryID = "Select * from food where FoodCategoryId = @categoryId";
        //public static string Food_Insert = "execute Food_Insert @ID output, @Name, @Unit,@FoodCategoryID, @Price, @Notes";

        // Các biến của bảng Category
        public static string Category_GetAll = "Category_GetAll";
        public static string Category_InsertUpdateDelete = "Cateogry_InsertUpdateDelete";
        public static string Category_GetIDAndName = "Select ID, Name from Category";
        public static string Category_GetAllDataSet = "Select  * from Category";
        //Dining Table
        public static string DiningTable_GetAll = "select * from DiningTable";
        public static string DiningTable_ResetStatus = "Update DiningTable Set Status = 0 where ID = @TableID";
        public static string DiningTable_Move = "exec MoveTable @BeMoveTableID, @TableID";
        public static string DiningTable_Pool = "exec PoolTable @BePoolTableID, @TableID";
        public static string DiningTable_InsertUpdateDelete = "DinningTable_InsertUpdateDelete";

        //Bill
        public static string Bill_Insert = "exec Bill_Insert @ID output, N'Hóa đơn thanh toán', @TableID, 0, null, null, 0, null, @AccountName";
        public static string Bill_GetBillHaveNotCheckOutByTableID = "select b.ID from Bill b where b.TableID = @TableID and b.Status =0";
        public static string Bill_Pay = "exec Pay @tableID, @BillID, @Amount, @Discount";
        public static string Bill_Delete = "delete Bill where ID = @BillID";
        public static string Bill_GetByDateAndTableID = "exec GetBillByTableID @TableID, @Date";
        public static string Bill_GetSalary = "exec GetSumSalaryVyDateAndTableID @Date, @TableID";
        public static string Bill_GetByDate = "exec GetBillByDate @Date";
        public static string Bill_GetSalaryAllDay = "exec GetSumSalaryVyDate @Date";


        //public static string Bill_GetIDByTableID = "select b.ID from Bill b where b.TableID = @TableID and b.Status =0";

        //BillDetail
        public static string BillDetail_Insert = "exec BillDetails_Insert @IDD output, @BillID, @FoodID, @Quantity";
        public static string BillDetail_Delete = "delete BillDetails where ID = @ID";
        public static string BillDetail_SumQuantily = "Select @numQuantily=sum(Quantily) from BillDetails where FoodID = @foodID";
        public static string BillDetail_GetFood = "exec GetFoodFromBill @BillID";
        
        //On multipul table
        public static string GetFoodHaveAddByTableID = "Select f.Name, b.Quantily, f.Price, (b.Quantily * f.Price) as sum, b.ID" +
                    " from Food f, BillDetails b , Bill c" +
                    " where f.ID = b.FoodID and c.ID = b.BillID and c.TableID = @tableID and c.Status = 0";

        //Account
        public static string Account_GetAll = "select a.AccoutName, a.Password, r.RoleName " +
                "from Account a, RoleAccount ra, [Role] r " +
                "where a.AccoutName = ra.AccountName and ra.Actived = 1 and r.ID = ra.RoleID";
        public static string Account_LoadData = "select a.AccoutName, a.FullName, a.Email, a.Tell, r.RoleName, ra.Actived " +
                "from Role r, Account a, RoleAccount ra " +
                "where r.ID=ra.RoleID and ra.AccountName = a.AccoutName";
        public static string Account_Insert = "Exec Insert_Account @AccountName, @FullName, @Email, @Tell, @RoleId, @Active";
        //Role
        public static string Role_GetAll = "select * from Role";

        //RoleAccount
        public static string RoleAccount_Delete = "Update RoleAccount set Actived = 'false' where AccountName =  @AccountName and RoleID = @RoleId";

    }
}
