using MySql.Data.MySqlClient;
using SchoolManagementSystem.Model;
using System;
using System.Data;

namespace SchoolManagementSystem.DAL
{
    internal class GradesDal
    {
        public DataTable GetAllGrades()
        {
            string query = @"SELECT id, grade_name, grade_order, grade_color, grade_group 
                     FROM grades  WHERE deleted_at IS NULL
                     ";
                return DbHelper.GetData(query);
        }

        public Grade GetGradeById(int gradeId)
        {
            string query = "SELECT * FROM grades WHERE id = @gradeId";
            var parameter = new MySqlParameter("@gradeId", MySqlDbType.Int32) { Value = gradeId };

            DataTable dt = DbHelper.GetData(query, parameter);
            if (dt.Rows.Count == 0) return null;

            DataRow row = dt.Rows[0];
            return new Grade
            {
                Id = Convert.ToInt32(row["id"]),
                GradeName = row["grade_name"].ToString(),
                GradeOrder = Convert.ToInt32(row["grade_order"]),
                GradeColor = row["grade_color"].ToString(),
                GradeGroup = row["grade_group"].ToString(),
                CreatedBy = row["created_by"]?.ToString(),
                CreatedAt = row["created_at"] != DBNull.Value ? Convert.ToDateTime(row["created_at"]) : DateTime.MinValue,
                UpdatedBy = row["updated_by"]?.ToString(),
                UpdatedAt = row["updated_at"] != DBNull.Value ? Convert.ToDateTime(row["updated_at"]) : DateTime.MinValue,
                DeletedBy = row["deleted_by"]?.ToString(),
                DeletedAt = row["deleted_at"] != DBNull.Value ? Convert.ToDateTime(row["deleted_at"]) : DateTime.MinValue
            };
        }

        public int addgrade(Grade grade)
        {
            string query = @"INSERT INTO grades
                            (grade_name, grade_order, grade_color, grade_group,
                             created_at, created_by)
                            VALUES
                            (@gradeName, @gradeOrder, @gradeColor, @gradeGroup, @createdAt, @createdBy);
                            SELECT LAST_INSERT_ID();";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@gradeName", MySqlDbType.VarChar) { Value = grade.GradeName },
                new MySqlParameter("@gradeOrder", MySqlDbType.Int32) { Value = grade.GradeOrder },
                new MySqlParameter("@gradeColor", MySqlDbType.VarChar) { Value = grade.GradeColor },
                new MySqlParameter("@gradeGroup", MySqlDbType.VarChar) { Value = grade.GradeGroup },
                new MySqlParameter("@createdAt", MySqlDbType.DateTime) { Value = grade.CreatedAt },
                new MySqlParameter("@createdBy", MySqlDbType.VarChar) { Value = grade.CreatedBy }
            };

            return Convert.ToInt32(DbHelper.ExecuteScalar(query, parameters));
        }

        public void UpdateGrade(int id, Grade grade)
        {
            string query = @"UPDATE grades 
                             SET grade_name = @name, 
                                 grade_order = @order, 
                                 grade_color = @color, 
                                 grade_group = @group, 
                                 updated_by = @user, 
                                 updated_at = NOW() 
                             WHERE id = @id";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@name", MySqlDbType.VarChar) { Value = grade.GradeName },
                new MySqlParameter("@order", MySqlDbType.Int32) { Value = grade.GradeOrder },
                new MySqlParameter("@color", MySqlDbType.VarChar) { Value = grade.GradeColor },
                new MySqlParameter("@group", MySqlDbType.VarChar) { Value = grade.GradeGroup },
                new MySqlParameter("@user", MySqlDbType.VarChar) { Value = grade.CreatedBy },
               // new MySqlParameter("@time", MySqlDbType.DateTime) { Value = grade.CreatedAt },
                new MySqlParameter("@id", MySqlDbType.Int32) { Value = id }
            };

            DbHelper.ExecuteNonQuery(query, parameters);
        }

        public bool DeleteGrade(int gradeId, string deletedBy)
        {
            string query = @"UPDATE grades 
                             SET deleted_at = NOW(), 
                                 deleted_by = @deletedBy
                                
                             WHERE id = @gradeId";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@gradeId", MySqlDbType.Int32) { Value = gradeId },
                new MySqlParameter("@deletedBy", MySqlDbType.VarChar) { Value = deletedBy }
            };

            return DbHelper.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}
