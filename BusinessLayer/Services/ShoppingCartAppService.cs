using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BusinessLayer.Models;
using BusinessLayer.Services.Interfaces;
using DataLayer.Models;
using DataLayer.UnitOfWork.Interfaces;

namespace BusinessLayer.Services
{
    public class ShoppingCartAppService : IGenericServices<ShoppingCartDto>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public ShoppingCartAppService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }

        public void Add(ShoppingCartDto shoppingCartDto)
        {
            this.unitOfWork.ShoppingCartRepository.Add(mapper.Map<ShoppingCart>(shoppingCartDto));
            this.unitOfWork.Commit();
        }

        public void Delete(ShoppingCartDto shoppingCartDto)
        {
            this.unitOfWork.ShoppingCartRepository.Delete(mapper.Map<ShoppingCart>(shoppingCartDto));
        }

        public IEnumerable<ShoppingCartDto> GetAll()
        {
            return this.unitOfWork.ShoppingCartRepository.GetAll().ToList().Select(shoppingcart => mapper.Map<ShoppingCartDto>(shoppingcart));
        }

        public ShoppingCartDto GetById(Guid id)
        {
            return mapper.Map<ShoppingCartDto>(this.unitOfWork.ShoppingCartRepository.GetById(id));
        }
    }
}
