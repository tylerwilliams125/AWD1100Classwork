﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace StateMaintenance.Models.DataLayer;

public partial class State
{
    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string StateCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string StateName { get; set; } = null!;

    [InverseProperty("StateNavigation")]
    public virtual ICollection<Customer> Customers { get; } = new List<Customer>();
}
