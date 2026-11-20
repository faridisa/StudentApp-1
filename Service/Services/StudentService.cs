using Domain.Entities;
using Repository.Repositories.Interfaces;
using Service.Helpers.Exceptions;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class StudentService : IStudentService
    {
        public readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public void Add(Student student)
        {
            _studentRepository.Create(student);
        }

        public List<Student> GetAll()
        {
            return _studentRepository.GetAll();
        }

        public Student GetById(int id)
        {
            return _studentRepository.GetById(id);
        }

        public void Remove(int id)
        {
            var res = _studentRepository.GetById(id);
            _studentRepository.Delete(res);
        }

        public void Update(Student update)
        {
            var st = _studentRepository.GetById(update.Id);
            if (st == null) new NotFoundException("Data not found");
            _studentRepository.Update(st);
        }
    }
}
