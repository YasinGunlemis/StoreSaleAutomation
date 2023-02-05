using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Note
    {
        int id;
        string noteDate, noteTime, noteTitle, noteDetail, noteCreator, noteToWho;

        public int Id { get => id; set => id = value; }
        public string NoteDate { get => noteDate; set => noteDate = value; }
        public string NoteTime { get => noteTime; set => noteTime = value; }
        public string NoteTitle { get => noteTitle; set => noteTitle = value; }
        public string NoteDetail { get => noteDetail; set => noteDetail = value; }
        public string NoteCreator { get => noteCreator; set => noteCreator = value; }
        public string NoteToWho { get => noteToWho; set => noteToWho = value; }

        public Note(int id, string noteDate, string noteTime, string noteTitle, string noteDetail, string noteCreator, string noteToWho)
        {
            this.id = id;
            this.noteDate = noteDate;
            this.noteTime = noteTime;
            this.noteTitle = noteTitle;
            this.noteDetail = noteDetail;
            this.noteCreator = noteCreator;
            this.noteToWho = noteToWho;
        }

        public Note(string noteDate, string noteTime, string noteTitle, string noteDetail, string noteCreator, string noteToWho)
        {
            this.noteDate = noteDate;
            this.noteTime = noteTime;
            this.noteTitle = noteTitle;
            this.noteDetail = noteDetail;
            this.noteCreator = noteCreator;
            this.noteToWho = noteToWho;
        }
    }
}
