﻿using Business.Abstract;
using Business.Constants;
using Core.Utitilies.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PaymentManager : IPaymentService
    {
        public IResult Payment()
        {
            var rd = new Random().Next(2);
            if (rd == 0) return new ErrorResult(Messages.PaymentFailed);

            return new SuccessResult(Messages.PaymentSuccessful);
        }
    }
}
