using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Application.Dept.Commands
{
    public class CreateDepartmentCommand : IRequest<int>
    {
        public string DepartmentName { get; set; }
    }
}
