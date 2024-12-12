﻿using API.BLL.Exceptions;
using API.DAL.Repository.Base;
using AutoMapper;

namespace API.BLL.Services.Base;

public class Crud<T, CreateTDTO> : ICrud<T, CreateTDTO>
    where T : class
    where CreateTDTO : class
{
    private readonly IMapper _mapper;
    private readonly IRepo<T, int> _repo;

    public Crud(IMapper mapper, IRepo<T, int> repo)
    {
        _mapper = mapper;
        _repo = repo;
    }
    public async Task<T> AddAsync(CreateTDTO model)
    {
        var data = _mapper.Map<T>(model);
        return await _repo.AddAsync(data);
    }

    public async Task DeleteAsync(int id)
    {
        var data = await _repo.GetAsync(id) ?? throw new NotFoundException(id);
        await _repo.DeleteAsync(data);
    }

    public async Task<List<T>> GetAllAsync()
    {
        return await _repo.GetAllAsync();
    }

    public async Task<T> GetAsync(int id)
    {
        return await _repo.GetAsync(id) ?? throw new NotFoundException(id);
    }

    public async Task<T> UpdateByIdAsync(int id, CreateTDTO model)
    {
        var data = await _repo.GetAsync(id) ?? throw new NotFoundException(id);
        return await _repo.UpdateAsync(_mapper.Map(model, data));
    }
}