using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Aerodrom.Models
{
    public class User
    {       
 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string UserId { get; set; }

        [Required]
        [Display(Name = "User name")]       
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember on this computer")]
        public bool RememberMe { get; set; }

        /// <summary>
        /// Checks if user with given password exists in the database
        /// </summary>
        /// <param name="_username">User name</param>
        /// <param name="_password">User password</param>
        /// <returns>True if user exist and password is correct</returns>
        public bool IsValid(string _username, string _password)
        {
            var cn = new SqlConnection("Server=tcp:aerodromserver.database.windows.net,1433;Initial Catalog=aerodrombaza;Persist Security Info=False;User ID=Admin1;Password=Adminpass1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;") ;
            {
                string _sql = @"SELECT korisnickoIme FROM [dbo].[KorisnikTabela] " +
                              @"WHERE korisnickoIme = @u AND lozinka = @p";
                var cmd = new SqlCommand(_sql, cn);
                cmd.Parameters.Add(new SqlParameter("@u", SqlDbType.NVarChar)).Value = _username;
                cmd.Parameters.Add(new SqlParameter("@p", SqlDbType.NVarChar)).Value = _password;
                cn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Dispose();
                    cmd.Dispose();
                    return true;
                }
                else
                {
                    reader.Dispose();
                    cmd.Dispose();
                    return false;
                }
            }
        }
    }
}