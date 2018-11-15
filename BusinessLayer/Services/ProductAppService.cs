using System;
using System.Collections.Generic;
using AutoMapper;
using BusinessLayer.Models;
using BusinessLayer.Services.Interfaces;
using DataLayer.UnitOfWork.Interfaces;

namespace BusinessLayer.Services
{
    public class ProductAppService : IGenericServices<ProductDto>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public ProductAppService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }

        public void Add(ProductDto productDto)
        {
            throw new NotImplementedException();
        }

        public void Delete(ProductDto productDto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public ProductDto GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
