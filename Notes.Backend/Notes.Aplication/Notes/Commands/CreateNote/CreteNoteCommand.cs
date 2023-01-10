using System;
using MediatR;

namespace Notes.Aplication.Notes.Commands.CreateNote
{
    public class CreteNoteCommand : IRequest<Guid>
    {
        public Guid UserId { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
    }
}
