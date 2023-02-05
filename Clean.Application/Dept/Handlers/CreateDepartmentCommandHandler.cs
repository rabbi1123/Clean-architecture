using Clean.Application.Common.Interface;
using Clean.Application.Dept.Commands;
using Clean.Domain.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Application.Dept.Handlers
{
    public class CreateDepartmentCommandHandler : IRequestHandler<CreateDepartmentCommand, int>
    {
        private readonly IApplicationDbContext context;

        public CreateDepartmentCommandHandler(IApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<int> Handle(CreateDepartmentCommand request, CancellationToken cancellationToken)
        {
            var entity = new Department
            {
                DepartmentName = request.DepartmentName
            };

            context.Departments.Add(entity);
            await context.SaveChangesAsync();

            return entity.DepartmentId;
        }
    }
}
