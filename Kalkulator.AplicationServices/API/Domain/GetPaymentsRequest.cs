using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator.AplicationServices.API.Domain
{
    public class GetPaymentsRequest : IRequest<GetPaymentsResponse>
    {
    }
}
