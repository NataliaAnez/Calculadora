using CalculadoraWEB.Properties.Controllers;
using NUnit.Framework;

namespace NUnitTestCalculadora
{
    public class TestCalculadora
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSumaPost1()
        {
            //Arange=Preparación
            int num1 = 5;
            int num2 = 7;
            int esperado = 12;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecución
            
            int resultado = calc.SumaPost(num1, num2);

            //Assert=Verificación
            Assert.AreEqual(esperado, resultado);
            
        }

        [Test]
        public void TestSumaPost2()
        {
            //Arange=Preparación
            int num1 = 10;
            int num2 = 87;
            int esperado = 97;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecución

            int resultado = calc.SumaPost(num1, num2);

            //Assert=Verificación
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestSumaPost3()
        {
            //Arange=Preparación
            int num1 = -90;
            int num2 = 34;
            int esperado = -56;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecución

            int resultado = calc.SumaPost(num1, num2);

            //Assert=Verificación
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestSumaGet1()
        {
            //Arange=Preparación
            int num1 = 78;
            int num2 = 2;
            int esperado = 80;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecución

            int resultado = calc.SumaGet(num1, num2);

            //Assert=Verificación
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestSumaGet2()
        {
            //Arange=Preparación
            int num1 = -100;
            int num2 = 80;
            int esperado = -20;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecución

            int resultado = calc.SumaGet(num1, num2);

            //Assert=Verificación
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestSumaGet3()
        {
            //Arange=Preparación
            int num1 = 30;
            int num2 = 19;
            int esperado = 49;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecución

            int resultado = calc.SumaGet(num1, num2);

            //Assert=Verificación
            Assert.AreEqual(esperado, resultado);

        }



        [Test]
        public void TestRestaPost1()
        {
            //Arange=Preparación
            int num1 = 15;
            int num2 = 8;
            int esperado = 7;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecución

            int resultado = calc.RestaPost(num1, num2);

            //Assert=Verificación
            Assert.AreEqual(esperado, resultado);

        }
        
        [Test]
        public void TestRestaPost2()
        {
            //Arange=Preparación
            int num1 = 22;
            int num2 = 7;
            int esperado = 15;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecución

            int resultado = calc.RestaPost(num1, num2);

            //Assert=Verificación
            Assert.AreEqual(esperado, resultado);

        }
        [Test]
        public void TestRestaPost3()
        {
            //Arange=Preparación
            int num1 = 70;
            int num2 = 64;
            int esperado = 6;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecución

            int resultado = calc.RestaPost(num1, num2);

            //Assert=Verificación
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestRestaGet1()
        {
            //Arange=Preparación
            int num1 = -90;
            int num2 = 6;
            int esperado = -96;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecución

            int resultado = calc.RestaGet(num1, num2);

            //Assert=Verificación
            Assert.AreEqual(esperado, resultado);

        }
        [Test]
        public void TestRestaGet2()
        {
            //Arange=Preparación
            int num1 = 60;
            int num2 = 6;
            int esperado = 54;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecución

            int resultado = calc.RestaGet(num1, num2);

            //Assert=Verificación
            Assert.AreEqual(esperado, resultado);

        }
        [Test]
        public void TestRestaGet3()
        {
            //Arange=Preparación
            int num1 = 103;
            int num2 = 89;
            int esperado = 14;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecución

            int resultado = calc.RestaGet(num1, num2);

            //Assert=Verificación
            Assert.AreEqual(esperado, resultado);

        }



    }
}