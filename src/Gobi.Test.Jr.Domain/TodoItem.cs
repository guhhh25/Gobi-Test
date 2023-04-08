
using System.ComponentModel.DataAnnotations;
namespace Gobi.Test.Jr.Domain
{
    public class TodoItem
    {
        [Key]
        public int Id { get; set; }
        public bool Completed { get; set; }
        public string Description { get; set; }
    }
}