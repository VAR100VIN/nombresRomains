using static NombresRomains.ConvertisseurNombresRomains;

namespace NombresRomains.test
{
    public class NombresRomainsTest
    {


        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]

        public void TestUnités(int n)
        {
            //ETANT DONNER un nombre <n> compris entre 1 et 3
            //QUAND on le convertit en nombres romains
            var resultat = Convertir(n);
            //ALORS on obtient <n> fois 'I'
            var attendu = new string('I', n);
            Assert.Equal(attendu, resultat);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        public void TestCinqPlusUnité(int nombreArabe)
        {
            //ETANT DONNER un nombre <nombreArabe> compris entre 5 et 8 

            //QUAND on le convertit en nombre romains
            var resultat = ConvertisseurNombresRomains.Convertir(nombreArabe);
            // ALORS on obtient 'V' plus <nombreArabe> -5> fois 'I'
            var attendu = 'V' + new string('I', nombreArabe - 5);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(11)]
        [InlineData(12)]
        [InlineData(13)]
        public void TestdixPlusunité(int nombreArabe)       
        {
            // ETANT DONNE un nombre <nombreArabe> compris entre 10 et 13

            // QUAND on le convertit en nombre romain
            var resultat = ConvertisseurNombresRomains.Convertir(nombreArabe);
            // ALORS on obtient 'X' plus <nombreArabe> -10> fois 'I'
            var attendu = "X" + new string('I', nombreArabe - 10);
           
        }

        [Theory]
        [InlineData(15)]
        [InlineData(16)]
        [InlineData(17)]
        [InlineData(18)]
        public void TestQuinzePLusunité(int nombreArabe)
        {
            // ETANT DONNE un nombre <n> compris entre 15 et 18
            // QUAND on le convertit en nombre romain
            var resultat = ConvertisseurNombresRomains.Convertir(nombreArabe);
            // ALORS on obtient 'XV' plus <nombreArabe> -15> fois 'I'
            var attendu = "XV" + new string('I', nombreArabe - 15);
           
        }

        [Theory]
        [InlineData(20)]
        [InlineData(21)]
        [InlineData(22)]
        [InlineData(23)]
        public void vingtPLusunité(int nombreArabe)
        {
            // ETANT DONNE un nombre compris entre 20 et 23
            // QUAND on le convertit en nombre romain
            var resultat = ConvertisseurNombresRomains.Convertir(nombreArabe);

            // ALORS on obtient 'XX' plus <nombreArabe> -20> fois 'I'
            var attendu = "XX" + new string('I', nombreArabe - 20);
            
        }

        [Theory]
        [InlineData(25)]
        [InlineData(26)]
        [InlineData(27)]
        [InlineData(28)]
        public void vingtcinqPLusunité(int nombreArabe)
        {
            // ETANT DONNE un nombre compris entre 25 et 28
            // QUAND on le convertit en nombre romain
            var resultat = ConvertisseurNombresRomains.Convertir(nombreArabe);

            // ALORS on obtient 'XXV' plus <nombreArabe> -25> fois 'I'
            var attendu = "XXV" + new string('I', nombreArabe - 25);

        }

        [Theory]
        [InlineData(30)]
        [InlineData(31)]
        [InlineData(32)]
        [InlineData(33)]
        public void trentePlusunité(int nombreArabe)
        {
            // ETANT DONNE un nombre compris entre 30 et 33
            // QUAND on le convertit en nombre romain
            var resultat = ConvertisseurNombresRomains.Convertir(nombreArabe);

            // ALORS on obtient 'XXX' plus <nombreArabe> -30> fois 'I'
            var attendu = "XXX" + new string('I', nombreArabe - 30);

        }


        [Fact]
        public void Test4()
        {
            //ETANT DONNE le nombre 4
            const int nombreArabe = 4;


            //QUAND on le convertit en nombres romains
            var resultat = Convertir(4);

            //ALORS on obtient 'IV'
            Assert.Equal("IV", resultat);
        }
       

        [Fact]
        public void Test9()
        {
            //ETANT DONNER un nombre <nombreArabe> qui est égal à 9 
            const int nombreArabe = 9;
            //QUAND on le convertit en nombre romains
            var resultat = Convertir(9);
            // ALORS on obtient 'IX'
            Assert.Equal("IX", resultat);
        }

        
      
        [Fact]
        public void Test14()
        {
            //ETANT DONNER un nombre <nombreArabe> qui est égal à 14
            const int nombreArabe = 14;
            //QUAND on le convertit en nombre romains
            var resultat = Convertir(14);
            // ALORS on obtient 'XIV'
            Assert.Equal("XIV", resultat);
        }

      

        [Fact]
        public void Test19()
        {
            //ETANT DONNER un nombre <nombreArabe> qui est égal à 19 
            const int nombreArabe = 19;
            //QUAND on le convertit en nombre romains
            var resultat = Convertir(19);
            // ALORS on obtient 'XIX'
            Assert.Equal("XIX", resultat);
        }

       

        [Fact]
        public void Test24()
        {
            //ETANT DONNER un nombre <nombreArabe> qui est égal à 24
            const int nombreArabe = 24;
            //QUAND on le convertit en nombre romains
            var resultat = Convertir(24);
            // ALORS on obtient 'XXIV'
            Assert.Equal("XXIV", resultat);
        }

       

        [Fact]
        public void Test29()
        {
            //ETANT DONNER un nombre <nombreArabe> qui est égal à 29
            const int nombreArabe = 29;
            //QUAND on le convertit en nombre romains
            var resultat = Convertir(29);
            // ALORS on obtient 'XXIX'
            Assert.Equal("XXIX", resultat);
        }

       
    }
}