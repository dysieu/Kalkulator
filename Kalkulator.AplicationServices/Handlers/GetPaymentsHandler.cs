using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kalkulator.AplicationServices.API.Domain;
using Kalkulator.AplicationServices.API.Domain.Models;
using Kalkulator.DataAccess;
using MediatR;

namespace Kalkulator.AplicationServices.Handlers
{
    public class GetPaymentsHandler : IRequestHandler<GetPaymentsRequest, GetPaymentsResponse> 
    {
        private readonly IRepository<DataAccess.Entities.Payment> paymentRepository;
        public GetPaymentsHandler(IRepository<DataAccess.Entities.Payment> paymentRepository)
        {
            this.paymentRepository = paymentRepository;
        }
        public Task<GetPaymentsResponse> Handle(GetPaymentsRequest request, CancellationToken cancellationToken)
        {
            var payments = this.paymentRepository.GetAll();
            var domainPayments = payments.Select(x => new API.Domain.Models.Payment()
            {
                Id = x.Id,
                Title = x.Title
            });
            
            var response = new GetPaymentsResponse()
            {
                Data = domainPayments.ToList()
            };
            return Task.FromResult(response);
        }

       
    }
}
