﻿using BulkyBook.DataAccess.Repository.IRepository;

namespace BulkyBook.DataAccess.Repository
{
	public class UnitOfWork : IUnitOfWork
	{
		private ApplicationDBContext _context;

		public UnitOfWork(ApplicationDBContext context)
		{
			_context = context;
			Category = new CategoryRepository(_context);
			CoverType = new CoverTypeRepository(_context);
            Product = new ProductRepository(_context);
			Company = new CompanyRepository(_context);
            ApplicationUser = new ApplicationUserRepository(_context);
            ShoppingCart = new ShoppingCartRepository(_context);
		}

		public ICategoryRepository Category { get; private set; }
		public ICoverTypeRepository CoverType { get; private set; }
        public IProductRepository Product { get; private set; }
		public ICompanyRepository Company {  get; private set; }
        public IShoppingCartRepository ShoppingCart {  get; private set; }
		public IApplicationUserRepository ApplicationUser {  get; private set; }
        public void Save()
		{
			_context.SaveChanges();
		}
	}
}
