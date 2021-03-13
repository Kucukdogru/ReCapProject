﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();

        IDataResult<Customer> GetById(int customerId);

        IResult Add(Customer customer);

        IDataResult<List<CustomerDetailDto>> GetCustomerDetails();
    }
}
