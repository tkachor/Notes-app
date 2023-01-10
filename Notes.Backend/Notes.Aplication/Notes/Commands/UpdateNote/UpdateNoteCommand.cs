using MediatR;

namespace Notes.Aplication.Notes.Commands.UpdateNote
{
    internal class UpdateNoteCommand : IRequest
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
    }
}
