using System;
using System.Collections.Generic;

namespace EFDemoWithWebAPIDBFirst.Models
{
    public partial class Emp
    {
        public int Empno { get; set; }
        public string? Empname { get; set; }
        public decimal? Sal { get; set; }
        public int? Deptno { get; set; }

        public virtual Dept? DeptnoNavigation { get; set; }
    }
}
