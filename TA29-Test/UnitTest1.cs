using TA29_UnitestConsola;

namespace TA29_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void cuadrado()
        {
            Geometria g = new Geometria(1);
            int result = g.areacuadrado(2);
            Assert.AreEqual(4, result);            
        }
        [Test]
        public void Circulo()
        {
            Geometria g = new Geometria(2);
            double result = g.areaCirculo(3);
            Assert.AreNotEqual(4, result);
        }
        [Test]
        public void Triangulo()
        {
            Geometria g = new Geometria(3);
            int result = g.areatriangulo(2, 3);
            Assert.AreEqual(3, result);
        }
        [Test]
        public void Rectangulo()
        {
            Geometria g = new Geometria(4);
            int result = g.arearectangulo(2, 4);
            Assert.AreEqual(8, result);
        }
        [Test]
        public void Pentagono()
        {
            Geometria g = new Geometria(5);
            int result = g.areapentagono(2, 3);
            Assert.AreEqual(3, result);
        }
        [Test]
        public void Rombo()
        {
            Geometria g = new Geometria(6);
            int result = g.arearombo(6, 3);
            Assert.AreEqual(9, result);
        }
        [Test]
        public void Romboide()
        {
            Geometria g = new Geometria(7);
            int result = g.arearomboide(2, 4);
            Assert.AreEqual(8, result);
        }
        [Test]
        public void Trapecio()
        {
            Geometria g = new Geometria(8);
            int result = g.areatrapecio(5, 3, 5);
            Assert.AreEqual(20, result);
        }

    }
}