using DataAccess.Database;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class NoteDal : IRepository<Note>
    {
        SqlService sqlService;
        public static NoteDal noteDal;
        public NoteDal()
        {
            sqlService = SqlDatabase.GetInstance();
        }

        public string Add(Note entity)
        {
            try
            {
                sqlService.Stored("[NoteAdd]", new SqlParameter("@noteDate", entity.NoteDate), new SqlParameter("@noteTime", entity.NoteTime), new SqlParameter("@noteTittle", entity.NoteTitle), new SqlParameter("@noteDetail", entity.NoteDetail), new SqlParameter("@noteCreator", entity.NoteCreator), new SqlParameter("@noteToWho", entity.NoteToWho));
                return "Note added successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Delete(int id)
        {
            try
            {
                sqlService.Stored("[NoteDelete]", new SqlParameter("@id", id));
                return "Note deleted successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Note Get(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetDataTable()
        {
            try
            {

                return sqlService.GetDataTable("[NoteList]");
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string Update(Note entity)
        {
            try
            {
                sqlService.Stored("[NoteUpdate]", new SqlParameter("@id", entity.Id), new SqlParameter("@noteDate", entity.NoteDate), new SqlParameter("@noteTime", entity.NoteTime), new SqlParameter("@noteTittle", entity.NoteTitle), new SqlParameter("@noteDetail", entity.NoteDetail), new SqlParameter("@noteCreator", entity.NoteCreator), new SqlParameter("@noteToWho", entity.NoteToWho));
                return "Note added successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static NoteDal GetInstance()
        {
            if(noteDal == null)
            {
                noteDal = new NoteDal();
            }
            return noteDal;
        }
    }
}
