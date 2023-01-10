using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Notes.Domain;


namespace Notes.Aplication.Interfaces
{
    internal interface INotesDbContext
    {
        DbSet<Note> Notes { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
