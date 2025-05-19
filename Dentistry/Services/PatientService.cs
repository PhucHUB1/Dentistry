using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dentistry.Models;
using SQLite;

namespace Dentistry.Services
{
    public interface IPatientService
    {
        Task<List<Patient>> GetPatientsAsync();
        Task<Patient> GetPatientAsync(string id);
    }

    public class PatientService : IPatientService
    {
        private List<Patient> _mockPatients;

        public PatientService()
        {
            _mockPatients = new List<Patient>
            {
                new Patient
                {
                    Id = "c6e6838a-621e-4cee-8448-35acb6c1eb7e",
                    Name = "Bệnh nhân D",
                    Gender = "Nam",
                    DateOfBirth = new DateTime(2005, 5, 9),
                    Occupation = "Học sinh",
                    PhoneNumber = "0100000202",
                    Address = "Hai Bà Trưng, Hà Nội",
                    CreatedDate = new DateTime(2024, 6, 28, 13, 55, 52)
                },
                new Patient
                {
                    Id = "b12345",
                    Name = "Bệnh nhân B",
                    Gender = "Nam",
                    DateOfBirth = new DateTime(2024, 6, 28),
                    Occupation = "Bác sĩ thú y",
                    PhoneNumber = "0100000034",
                    Address = "Đống Đa",
                    CreatedDate = new DateTime(2024, 6, 28, 2, 22, 0)
                },
                new Patient
                {
                    Id = "m12345",
                    Name = "Bệnh nhân M",
                    Gender = "Nữ",
                    DateOfBirth = new DateTime(2001, 1, 1),
                    Occupation = "Học sinh",
                    PhoneNumber = "0100005803",
                    Address = "Thanh Xuân, Hà Nội",
                    CreatedDate = new DateTime(2024, 6, 28, 1, 56, 0)
                },
                new Patient
                {
                    Id = "e12345",
                    Name = "Bệnh nhân E",
                    Gender = "Nữ",
                    DateOfBirth = new DateTime(2005, 5, 9),
                    Occupation = "Sinh viên",
                    PhoneNumber = "0100000204",
                    Address = "Thanh Xuân, Hà Nội",
                    CreatedDate = new DateTime(2024, 6, 28, 1, 55, 0)
                },
                new Patient
                {
                    Id = "c12345",
                    Name = "Bệnh nhân C",
                    Gender = "Nữ",
                    DateOfBirth = new DateTime(2003, 10, 7),
                    Occupation = "Ca sĩ",
                    PhoneNumber = "0100000005",
                    Address = "Hà Đông, Hà Nội",
                    CreatedDate = new DateTime(2024, 6, 28, 1, 54, 0)
                },
                new Patient
                {
                    Id = "b67890",
                    Name = "Bệnh nhân B",
                    Gender = "Nam",
                    DateOfBirth = new DateTime(1998, 10, 15),
                    Occupation = "Sinh viên",
                    PhoneNumber = "0100000002",
                    Address = "Đống Đa, Hà Nội",
                    CreatedDate = new DateTime(2024, 6, 28, 1, 53, 0)
                },
                new Patient
                {
                    Id = "f12345",
                    Name = "Bệnh nhân F",
                    Gender = "Nữ",
                    DateOfBirth = new DateTime(2004, 8, 18),
                    Occupation = "Bác sĩ thú y",
                    PhoneNumber = "0100000001",
                    Address = "Hai Bà Trưng, Hà Nội",
                    CreatedDate = new DateTime(2024, 6, 28, 1, 52, 0)
                },
                new Patient
                {
                    Id = "a12345",
                    Name = "Bệnh nhân A",
                    Gender = "Nam",
                    DateOfBirth = new DateTime(2024, 6, 28),
                    Occupation = "Doanh nhân",
                    PhoneNumber = "0000000000",
                    Address = "Cau Giay, Ha Noi",
                    CreatedDate = new DateTime(2024, 6, 28, 1, 44, 0)
                }
            };
        }

        public async Task<List<Patient>> GetPatientsAsync()
        {
            await Task.Delay(100);
            return _mockPatients;
        }

        public async Task<Patient> GetPatientAsync(string id)
        {
           
            await Task.Delay(100);
            return _mockPatients.FirstOrDefault(p => p.Id == id);
        }
    }
}
