using DataAccess.Data;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public class AccountService
    {
        private readonly ApplicationDbContext context;
        private readonly CustomerService customerService;

        public AccountService(ApplicationDbContext context, CustomerService customerService)
        {
            this.context = context;
            this.customerService = customerService;
        }

        /// <summary>
        /// Permite crear una factura
        /// </summary>
        /// <param name="account">Factura a crear</param>
        /// <returns>La factura creada</returns>
        public async Task<Account> CreateAccount(Account account)
        {
            // Se valida la existencia del cliente
            var existCustomer = customerService.GetCustomerById(account.CustomerId);
            if (!existCustomer)
            {
                account.CustomerId = 0;
                return account;
            }
            context.Accounts.Add(account);
            await context.SaveChangesAsync();

            return account;
        }
    }
}
