﻿using DataCape.Models;
using PersistenceCape.Interfaces;
using PersistenceCape.Views;

namespace BusinessCape.Services
{
    public class RoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public async Task<IEnumerable<RoleModel>> Index()
        {
            return await _roleRepository.Index();
        }

        public async Task<RoleModel> Show(long id)
        {
            return await _roleRepository.Show(id);
        }

        public async Task<RoleView> ShowWithPermissions(long id)
        {
            return await _roleRepository.ShowWithPermissions(id);
        }

        public async Task Create(RoleModel role)
        {
            await _roleRepository.Create(role);
        }

        public async Task Update(RoleModel role)
        {
            await _roleRepository.Update(role);
        }

        public async Task Delete(long id)
        {
            await _roleRepository.Delete(id);
        }
    }
}
