using Domain.Entities;
using Repository.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services.Interfaces
{
    public interface IStudentService
    {
        void Add(Student student);
        void Remove(int id);
        Student GetById(int id);
        List<Student> GetAll();
        void Update(Student update);
    }
}
 