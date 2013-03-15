using BiblioClasse;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    


    /// <summary>
    ///Classe de test pour MatchTest, destinée à contenir tous
    ///les tests unitaires MatchTest
    ///</summary>
    [TestClass()]
    public class MatchTest
    {
        public Club Home = new Club("Bordeaux");
        public Club Away = new Club("Paris");

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
        ///Test pour Constructeur Match
        ///</summary>
        [TestMethod()]
        public void MatchConstructorTest()
        {
            

            Assert.IsNotNull(0);
        }

        /// <summary>
        ///Test pour Away
        ///</summary>
        [TestMethod()]
        public void AwayTest()
        {
            Match target = new Match(0,2);
            Assert.AreEqual(Away, target.Away);
        }

        /// <summary>
        ///Test pour AwayGoals
        ///</summary>
        [TestMethod()]
        public void AwayGoalsTest()
        {
            Match target = new Match(0,3);
            Assert.AreEqual(Away, target.AwayGoals);
        }

        /// <summary>
        ///Test pour Home
        ///</summary>
        [TestMethod()]
        public void HomeTest()
        {
            Match target = new Match(5,2);
            Assert.AreEqual(Home, target.Home);
        }

        /// <summary>
        ///Test pour HomeGoals
        ///</summary>
        [TestMethod()]
        public void HomeGoalsTest()
        {
            Match target = new Match(3,0);
            Assert.AreEqual(Home, target.HomeGoals);
          
        }

        /// <summary>
        ///Test pour IsAwayForfait
        ///</summary>
        [TestMethod()]
        public void IsAwayForfaitTest()
        {
            Match target = new Match(3,9); 
            Assert.IsTrue(target.IsAwayForfait);
        }

        /// <summary>
        ///Test pour IsDraw
        ///</summary>
        [TestMethod()]
        public void IsDrawTest()
        {
            Match target = new Match(10,10); 
            Assert.IsTrue(target.IsDraw);
        }

        /// <summary>
        ///Test pour IsHomeForfait
        ///</summary>
        [TestMethod()]
        public void IsHomeForfaitTest()
        {
            Match target = new Match(9,6); 
            Assert.IsTrue(target.IsHomeForfait);
        }
    }
}