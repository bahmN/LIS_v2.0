using MySql.Data.MySqlClient;

namespace LIS.Adm
{
    class SQLRequestFullNameUser
    {
        public static string fullNameUser(string idUser)
        {
            MySqlCommand cFullNameUser = new MySqlCommand("SELECT ФИО FROM Пользователь WHERE `ID пользователя`= '"+idUser+"'", frmAuthorization.connection);
            object userFullNameObj = cFullNameUser.ExecuteScalar();
            string userFullName = userFullNameObj.ToString();
            return userFullName;
        }
    }
}
