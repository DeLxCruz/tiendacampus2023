using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;

namespace Infrastructure.UnitOfWork;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly TiendaCampusContext _context;
    private IDepartamento _departamento;
    private ICiudad _ciudad;
    private IPais _pais;

    public UnitOfWork(TiendaCampusContext context)
    {
        _context = context;
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public Task<int> SaveAsync()
    {
        throw new NotImplementedException();
    }

    public IDepartamento Departamentos
    {
        get
        {
            if (_departamento == null)
            {
                _departamento = new DepartamentoRepository(_context);
            }
            return _departamento;
        }
    }
    public ICiudad Ciudades
    {
        get
        {
            if (_ciudad == null)
            {
                _ciudad = new CiudadRepository(_context);
            }
            return _ciudad;
        }
    }

    public IPais Paises
    {
        get
        {
            if (_pais == null)
            {
                _pais = new PaisRepository(_context);
            }
            return _pais;
        }
    }
}