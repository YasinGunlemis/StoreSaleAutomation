using DataAccess;
using DataAccess.Concrete;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class NoteManager 
    {
        string controlText;
        NoteDal noteDal;
        static NoteManager noteManager;

        public NoteManager()
        {
            noteDal = NoteDal.GetInstance();
        }

        public string Add(Note entity)
        {
            try
            {
                controlText = IsNoteComplete(entity);

                if (controlText != "")
                {
                    return controlText;
                }
                return noteDal.Add(entity);
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
                return noteDal.Delete(id);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public DataTable GetDataTable()
        {
            return noteDal.GetDataTable();
        }

        public string Update(Note entity)
        {
            try
            {
                controlText = IsNoteComplete(entity);

                if (controlText != "")
                {
                    return controlText;
                }
                return noteDal.Update(entity);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        string IsNoteComplete(Note entity)
        {
            try
            {
                if (string.IsNullOrEmpty(entity.NoteDate) || string.IsNullOrEmpty(entity.NoteTime) || string.IsNullOrEmpty(entity.NoteTitle) || string.IsNullOrEmpty(entity.NoteDetail) || string.IsNullOrEmpty(entity.NoteCreator) || string.IsNullOrEmpty(entity.NoteToWho))
                {
                    return "Please fill in the blanks";
                }
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw;
            }
        }

        public static NoteManager GetInstance()
        {
            if (noteManager == null)
            {
                noteManager = new NoteManager();
            }
            return noteManager;
        }
    }
}
