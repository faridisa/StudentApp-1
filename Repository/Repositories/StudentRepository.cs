using Domain.Entities;
using Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories
{
    public class StudentRepository : BaseRepository<Student>,IStudentRepository
    {
        
    }
}
