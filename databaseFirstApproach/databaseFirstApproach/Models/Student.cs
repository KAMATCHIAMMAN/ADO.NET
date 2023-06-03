using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace databaseFirstApproach.Models;

[Table("student")]
public partial class Student
{
    [Key]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; } = null!;

    [Column("fees")]
    public double Fees { get; set; }
}
