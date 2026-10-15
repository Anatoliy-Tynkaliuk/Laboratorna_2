using System;
using System.Collections.Generic;

namespace Library.Models;

public partial class Loan
{
    public int Id { get; set; }
    public int ReaderId { get; set; }
    public int BookId { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime ReturnDate { get; set; }
    public Reader Reader { get; set; } = null!;
    public Book Book { get; set; } = null!;
}
