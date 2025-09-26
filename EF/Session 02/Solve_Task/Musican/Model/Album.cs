using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solve_Task.Musican.Model
{
    class Album
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public DateTime Date { get; set; }

        [ForeignKey(nameof(Musician))]
        public int Mus_Id { get; set; }
        public Musician Musician { get; set; } = null!;

        public ICollection<Album_Song> Album_Songs { get; set; } = new HashSet<Album_Song>();
    }
}
