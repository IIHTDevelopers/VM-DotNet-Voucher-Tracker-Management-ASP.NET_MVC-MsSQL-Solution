﻿
using VoucherTrackerApp.DAL;
using VoucherTrackerApp.DAL.Interface;
using VoucherTrackerApp.DAL.Repository;
using VoucherTrackerApp.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace VoucherTrackerApp.Tests.TestCases
{
    public class BoundaryTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IVoucherTrackerInterface _voucherTrackerService;
        public readonly Mock<IVoucherTrackerRepository> fitnnesstrackerservice = new Mock<IVoucherTrackerRepository>();
        private readonly Voucher _voucher;
        private readonly IEnumerable<Voucher> voucherList;

        private static string type = "Boundary";

        public BoundaryTests(ITestOutputHelper output)
        {
            _voucherTrackerService = new VoucherTrackerService(fitnnesstrackerservice.Object);
            _output = output;
            _voucher = new Voucher
            {
                VoucherId = 1,
                Name = "Monthly Voucher",
                Amount = 5000.00m,
                StartDate = DateTime.Now.Date,
                EndDate = DateTime.Now.Date.AddMonths(1),
                Description = "General monthly voucher for expenses."
            };
            voucherList = new List<Voucher>
        {
            new Voucher
            {
                VoucherId = 1,
                Name = "Monthly Voucher",
                Amount = 5000.00m,
                StartDate = DateTime.Now.Date,
                EndDate = DateTime.Now.Date.AddMonths(1),
                Description = "General monthly voucher for expenses."
            },
            new Voucher
            {
                VoucherId = 1,
                Name = "Monthly Voucher",
                Amount = 5000.00m,
                StartDate = DateTime.Now.Date,
                EndDate = DateTime.Now.Date.AddMonths(1),
                Description = "General monthly voucher for expenses."
            },
            // Add more Voucher instances as needed
        };

        }

        [Fact]
        public async Task<bool> Testfor_Name_NotNull()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int id = 1;

            //Action
            try
            {
                fitnnesstrackerservice.Setup(repos => repos.GetVoucherByID(_voucher.VoucherId)).Returns(_voucher);
                var result = _voucherTrackerService.GetVoucherByID(_voucher.VoucherId);

                //Assertion
                if (result!= null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_Amount_NotNull()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int id = 1;

            //Action
            try
            {
                fitnnesstrackerservice.Setup(repos => repos.GetVoucherByID(_voucher.VoucherId)).Returns(_voucher);
                var result = _voucherTrackerService.GetVoucherByID(_voucher.VoucherId);

                //Assertion
                if (result!= null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_Description_NotNull()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int id = 1;

            //Action
            try
            {
                fitnnesstrackerservice.Setup(repos => repos.GetVoucherByID(_voucher.VoucherId)).Returns(_voucher);
                var result = _voucherTrackerService.GetVoucherByID(_voucher.VoucherId);

                //Assertion
                if (result!=null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_Date_NotNull()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            int id = 1;

            //Action
            try
            {
                fitnnesstrackerservice.Setup(repos => repos.GetVoucherByID(_voucher.VoucherId)).Returns(_voucher);
                var result = _voucherTrackerService.GetVoucherByID(_voucher.VoucherId);
               

                //Assertion
                if (result!= null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

    }
}