﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LoanAPI.Models;

namespace LoanAPI.BusinessCalc
{
    public class EMICalculator : ICalculator
    {
        const int interestRate = 12; // Interest rate is fixed to 12%
        public EMIInfo getEmiDetails(float principal, int tenure)
        {
            var emi = new EMIInfo()
            {
                principalAmount = principal,
                noOfMonths = tenure,
                disbursalDate = DateTime.Today.ToString("dd MMMM yyyy")
            };
            float interest = (principal * tenure * interestRate) / ( 12 * 100); // Interest (PTR/100) where T should be in Years
            emi.totalPayableAmount = principal + interest;
            var monthlyEmi = new List<MonthlyEMIInfo>();
            for(int currentEmiNo =1; currentEmiNo <= tenure; currentEmiNo++)
            {
                // To Add every month emi details
                var currentMonth = new MonthlyEMIInfo()
                {
                    emiNumber = currentEmiNo,
                    principalEMiAmount = principal / tenure,
                    interestEMiAmount = interest / tenure,
                    totalEMiAmount = emi.totalPayableAmount / tenure,
                    emiDate = DateTime.Now.AddMonths(currentEmiNo).ToString("dd MMMM yyyy"),
                    pendingAmount = emi.totalPayableAmount - (emi.totalPayableAmount / tenure)
                };
                monthlyEmi.Add(currentMonth);
            }
            emi.eachEmi = monthlyEmi;
            return emi;
        }
    }
}