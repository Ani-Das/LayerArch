using Microsoft.AspNetCore.Mvc;
using EmpMvc.Models;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EmpMvc.Controllers
{
    public class ProductsController: Controller
    {
      public IActionResult List(){
        string constr= "User ID=sa;password=examplyMssql@123; server=localhost;Database=adb;trusted_connection=false;Persist Security Info=false;Encrypt=False";

        SqlConnection con = new SqlConnection(constr);
        SqlCommand command = new SqlCommand("select * from product",con);
        con.Open();
        SqlDataReader reader=command.ExecuteReader();

      }  

      public IActionResult Create(){
        return View();
      }
      [HttpPost]

      public IActionResult Create(int id,string name,int price, int stock)
      {
        if(ModelState.IsValid)
        {
        string constr="User ID=sa;password=examplyMssql@123; server=localhost;Database=adb;trusted_connection=false;Persist Security Info=false;Encrypt=False";

        SqlConnection con = new SqlConnection(constr);
        SqlCommand command = new SqlCommand("addproduct",con);
        command.CommandType=CommandType.StoredProcedure;
        command.Parameters.AddWithValue("@id",id);
        command.Parameters.AddWithValue("@name",name);
        command.Parameters.AddWithValue("@price",price);
        command.Parameters.AddWithValue("@stock",stock);
        con.Open();
        command.ExecuteNonQuery();
        con.Close();
        return RedirectToAction("List");
        }
        return View();
      }



    }
}