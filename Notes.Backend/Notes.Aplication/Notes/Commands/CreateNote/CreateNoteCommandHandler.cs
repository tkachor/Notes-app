using MediatR;
using Notes.Domain;
using Notes.Aplication.Interfaces;

namespace Notes.Aplication.Notes.Commands.CreateNote
{
    public class CreateNoteCommandHandler : IRequestHandler<CreteNoteCommand, Guid>
    {
        private readonly INotesDbContext dbContext;

        public CreateNoteCommandHandler(INotesDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreteNoteCommand request, CancellationToken cancellationToken)
        {
            var note = new Note
            {
                UserId = request.UserId,
                Titles = request.Title,
                Details = request.Details,
                Id = Guid.NewGuid(),
                CreationDate = DateTime.Now,
                EditDate = null
            };

            await dbContext.Notes.AddAsync(note, cancellationToken);
            await dbContext.SaveChangesAsync(cancellationToken);

            return note.Id;

        }
        
    }
}
