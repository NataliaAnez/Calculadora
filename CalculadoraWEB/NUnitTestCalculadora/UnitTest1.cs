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

        [Test]
        public void TestMultiplicarPost1()
        {
            //Arange=Preparación
            int num1 = 2;
            int num2 = 40;
            int esperado = 80;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecución

            int resultado = calc.MultiplicarPost(num1, num2);

            //Assert=Verificación
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestMultiplicarPost2()
        {
            //Arange=Preparación
            int num1 = 98;
            int num2 = 32;
            int esperado = 3136;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecución

            int resultado = calc.MultiplicarPost(num1, num2);

            //Assert=Verificación
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestMultiplicarPost3()
        {
            //Arange=Preparación
            int num1 = 61;
            int num2 = 9;
            int esperado = 549;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecución

            int resultado = calc.MultiplicarPost(num1, num2);

            //Assert=Verificación
            Assert.AreEqual(esperado, resultado);

        }



        [Test]
        public void TestMultiplicarGet1()
        {
            //Arange=Preparación
            int num1 = 25;
            int num2 = 4;
            int esperado = 100;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecución

            int resultado = calc.MultiplicarGet(num1, num2);

            //Assert=Verificación
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestMultiplicarGet2()
        {
            //Arange=Preparación
            int num1 = 87;
            int num2 = 43;
            int esperado = 3741;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecución

            int resultado = calc.MultiplicarGet(num1, num2);

            //Assert=Verificación
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestMultiplicarGet3()
        {
            //Arange=Preparación
            int num1 = 62;
            int num2 = 9;
            int esperado = 558;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecución

            int resultado = calc.MultiplicarGet(num1, num2);

            //Assert=Verificación
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestDividirPost1()
        {
            //Arange=Preparación
            int num1 = 96;
            int num2 = 3;
            int esperado = 32;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecución

            int resultado = calc.DividirPost(num1, num2);

            //Assert=Verificación
            Assert.AreEqual(esperado, resultado);

        }


        [Test]
        public void TestDividirPost2()
        {
            //Arange=Preparación
            int num1 = 144;
            int num2 = 12;
            int esperado = 12;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecución

            int resultado = calc.DividirPost(num1, num2);

            //Assert=Verificación
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestDividirPost3()
        {
            //Arange=Preparación
            int num1 = 175;
            int num2 = 5;
            int esperado = 35;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecución

            int resultado = calc.DividirPost(num1, num2);

            //Assert=Verificación
            Assert.AreEqual(esperado, resultado);

        }



        [Test]
        public void TestDividirGet1()
        {
            //Arange=Preparación
            int num1 = 54;
            int num2 = 3;
            int esperado = 18;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecución

            int resultado = calc.DividirGet(num1, num2);

            //Assert=Verificación
            Assert.AreEqual(esperado, resultado);

        }


        [Test]
        public void TestDividirGet2()
        {
            //Arange=Preparación
            int num1 = 2597;
            int num2 = 53;
            int esperado =49;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecución

            int resultado = calc.DividirGet(num1, num2);

            //Assert=Verificación
            Assert.AreEqual(esperado, resultado);

        }


        [Test]
        public void TestDividirGet3()
        {
            //Arange=Preparación
            int num1 = 2080;
            int num2 = 32;
            int esperado = 65;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecución

            int resultado = calc.DividirGet(num1, num2);

            //Assert=Verificación
            Assert.AreEqual(esperado, resultado);

        }

    }
}