﻿namespace ApotheekApp.Business.Services
{
    public class MedicineService : IMedicineService
    {
        private IMedicineRepository _medicineRepository;
        public MedicineServices(IMedicineRepository medicineRepository)
        {
            _medicineRepository = medicineRepository;
        }
        public async Task<IEnumerable<Medicine>?> GetAllAsync()
        {
            IEnumerable<Medicine>? medicines = await _medicineRepository.GetAllAsync();
            return medicines;
        }
        public async Task<IEnumerable<Medicine>?> GetAllByClientAsync(Client client)
        {
            IEnumerable<Medicine>? medicines = await _medicineRepository.GetAllByClientAsync(client);
            return medicines;
        }

        public async Task<Medicine?> GetByIdAsync(int id)
        {
            Medicine? medicine = await _medicineRepository.GetByIdAsync(id);
            return medicine;
        }

        public async Task Delete(int id)
        {
            await _medicineRepository.Delete(id);
        }
    }
}