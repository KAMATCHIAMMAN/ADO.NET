using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace databaseFirstApproach.Models;

[Table("staff")]
public partial class Staff
{
    [Key]
    public int Id { get; set; }

    [Column("staffname")]
    public string Staffname { get; set; } = null!;

    [Column("salary")]
    public double Salary { get; set; }
}
