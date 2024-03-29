﻿using ApotheekApp.Data.Repositories;
using ApotheekApp.Domain.Interfaces;
using ApotheekApp.Domain.Models;

namespace ApotheekApp.Business.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<Client> CreateClientAsync(Client client)
        {
            ArgumentNullException.ThrowIfNull(client);
            await _clientRepository.CreateClientAsync(client);
            await _clientRepository.SaveChanges();
            return client;
        }

        public async Task DeleteClientAsync(string id)
        {
            _clientRepository.DeleteClientAsync(id);
            await _clientRepository.SaveChanges();
        }

        public IEnumerable<Client> GetAllClients() => _clientRepository.GetAllClients();

        public Client GetClientByIdAsync(string id) => _clientRepository.GetClientByIdAsync(id);

        public Client GetClientByNameAsync(string lastname, DateTime dob, string? firstname) =>
            _clientRepository.GetClientByNameAsync(lastname, dob, firstname);

        public async Task<Client> UpdateClientAsync(Client client)
        {
            ArgumentNullException.ThrowIfNull(client);
            _clientRepository.UpdateClientAsync(client);
            await _clientRepository.SaveChanges();
            return client;
        }
    }
}