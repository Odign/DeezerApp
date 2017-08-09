using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeezerApp.Service.Domain;
using DeezerApp.Test.Utilities;
using System.Collections.Generic;

namespace DeezerApp.Test
{
    [TestClass]
    public class DeezerServiceTest
    {
        [TestMethod]
        public void LessThan150SongsTest()
        {
            ServiceResponse serviceResponse = new ServiceResponse();
            serviceResponse.data = SongsGenerator.ReturnListOfSongs(25);
            List<Song> songs = serviceResponse.GetQuantityOfSongs(150);
            Assert.AreEqual(25, songs.Count);
        }

        [TestMethod]
        public void The150SongsTest()
        {
            ServiceResponse serviceResponse = new ServiceResponse();
            serviceResponse.data = SongsGenerator.ReturnListOfSongs(150);
            List<Song> songs = serviceResponse.GetQuantityOfSongs(150);
            Assert.AreEqual(150, songs.Count);
        }

        [TestMethod]
        public void MoreThan150SongsTest()
        {
            ServiceResponse serviceResponse = new ServiceResponse();
            serviceResponse.data = SongsGenerator.ReturnListOfSongs(250);
            List<Song> songs = serviceResponse.GetQuantityOfSongs(150);
            Assert.AreEqual(150, songs.Count);
        }
    }
}
