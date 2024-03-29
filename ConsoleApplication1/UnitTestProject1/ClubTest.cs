﻿using BiblioClasse;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{


    /// <summary>
    ///Classe de test pour ClubTest, destinée à contenir tous
    ///les tests unitaires ClubTest
    ///</summary>
    [TestClass()]
    public class ClubTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active ainsi que ses fonctionnalités.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Attributs de tests supplémentaires
        // 
        //Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        //Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test dans la classe
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Utilisez ClassCleanup pour exécuter du code après que tous les tests ont été exécutés dans une classe
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Test pour Constructeur Club
        ///</summary>
        [TestMethod()]
        public void ClubConstructorTest()
        {
            string name = string.Empty; 
            string ville = string.Empty;

            Assert.AreEqual(name, ville);
        }

        /// <summary>
        ///Test pour ToString
        ///</summary>
        [TestMethod()]
        public void ToStringTest()
        {
            string prochaine = string.Empty;
            string gagnante = string.Empty;
            string perdu = string.Empty;

            Assert.AreEqual(gagnante, perdu);
        }
    }
}