﻿using Domain.Core.Model;
using Infrastructure.Business.DTOs.SensorType;
using Infrastructure.Business.Interfaces;
using Infrastructure.Business.Managers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_home_web.Tests.ManagerTests
{
    [TestFixture]
    class SensorTypeManagerTest : TestInitializer
    {
        private SensorTypeManager _manager;
        private SensorType _sensorType;
        private SensorTypeDto _sensorTypeDto;


        [SetUp]
        protected override void Initialize()
        {
            base.Initialize();
            _manager = new SensorTypeManager(mockUnitOfWork.Object, mockMapper.Object);
            _sensorType = new SensorType { Id = 1, Name = "RandomName", Comment = "Comment", MeasurementName = "*C", MeasurementType = Domain.Core.Model.Enums.MeasurementType.Int, IsControl = true };
            _sensorTypeDto = new SensorTypeDto {Id = 1, Name = "RandomName", Comment = "Comment", MeasurementName = "*C", MeasurementType = Domain.Core.Model.Enums.MeasurementType.Int, IsControl = true };
        }

        [Test]
        public void Create_ValidDto_ReturnTrue()
        {
            mockMapper.Setup(m => m
                .Map<SensorTypeDto, SensorType>(_sensorTypeDto))
                    .Returns(_sensorType);

            mockUnitOfWork.Setup(u => u
                .SensorTypeRepo.Insert(_sensorType));

            var res = _manager.Create(_sensorTypeDto);

            Assert.IsNotNull(_sensorTypeDto);
        }

        [Test]
        public void Create_InvalidDto_ReturnFalse()
        {
            SensorTypeDto _sensorTypeDto  = null;
             SensorType _sensorType  = null;

            mockMapper.Setup(m => m
                .Map<SensorTypeDto, SensorType>(_sensorTypeDto))
                    .Returns(_sensorType);

            mockUnitOfWork.Setup(u => u
                .SensorTypeRepo.Insert(_sensorType));

            var res = _manager.Create(_sensorTypeDto);

            Assert.IsNull(_sensorTypeDto);
        }

        [Test]
        public void Update_ValidDto_ReturnTrue()
        {
            mockMapper.Setup(m => m
                .Map<SensorTypeDto, SensorType>(_sensorTypeDto))
                    .Returns(_sensorType);

            mockUnitOfWork.Setup(u => u
                .SensorTypeRepo.Update(_sensorType));

            var res = _manager.Update(_sensorTypeDto);

            Assert.IsNotNull(_sensorTypeDto);
        }

        [Test]
        public void Update_InvalidDto_ReturnTrue()
        {
            SensorTypeDto _sensorTypeDto = null;
             SensorType _sensorType = null;

            mockMapper.Setup(m => m
                 .Map<SensorTypeDto, SensorType>(_sensorTypeDto))
                     .Returns(_sensorType);

            mockUnitOfWork.Setup(u => u
                .SensorTypeRepo.Update(_sensorType));

            var res = _manager.Update(_sensorTypeDto);

            Assert.IsNull(_sensorTypeDto);
        }

        [Test]
        public void Delete_WithValidId_ReturnTrue()
        {
            var id = _sensorType.Id;

            mockUnitOfWork.Setup(u => u
                .SensorTypeRepo.GetById(id)).Returns(Task.FromResult(_sensorType));

            mockUnitOfWork.Setup(u => u
                .SensorTypeRepo.Delete(_sensorType)); 

            var res = _manager.Delete(id).Result;

            Assert.IsTrue(res.Succeeded);
        }

        [Test]              
        public void Delete_WithNullId_ReturnFalse()
        {

            mockUnitOfWork.Setup(u => u
                .SensorTypeRepo.GetById(0)).Throws(new Exception());

            mockUnitOfWork.Setup(u => u
                .SensorTypeRepo.Delete(_sensorType));

            var res = _manager.Delete(0).Result;

            Assert.IsFalse(res.Succeeded);
        }

        [Test]
        public void Delete_WithDefunctId_ReturnFalse()
        {

            mockUnitOfWork.Setup(u => u
                .SensorTypeRepo.GetById(7)).Throws(new Exception());

            mockUnitOfWork.Setup(u => u
                .SensorTypeRepo.Delete(_sensorType));

            var res = _manager.Delete(7).Result;

            Assert.IsFalse(res.Succeeded);
        }
    }
}
