﻿using ApotheekApp.Domain.Interfaces;
using ApotheekApp.Domain.Models;

namespace ApotheekApp.Business.Services
{
    public class MedicineService : IMedicineService
    {
        public IEnumerable<Medicine> GetAllAsync()
        {
            // Return all medicine
            throw new NotImplementedException();
        }

        public IEnumerable<Medicine> GetAllByUserAsync() // Appuser user (pass as parameter)
        {
            // Return all medicine of a specific user based on id
            throw new NotImplementedException();
        }

        public Medicine GetByIdAsync(int id)
        {
            // Return medicine by id
            throw new NotImplementedException();
        }

        public Task Delete(int id) // Appuser user (pass as parameter)
        {
            // Delete medicine of a specific user based on id
            throw new NotImplementedException();
        }
    }
}