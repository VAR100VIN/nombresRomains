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
        public void TestUnité15161718(int nombreArabe)
        {
            // ETANT DONNE un nombre <n> compris entre 15 et 18
            // QUAND on le convertit en nombre romain
            var resultat = ConvertisseurNombresRomains.Convertir(nombreArabe);
            // ALORS on obtient "XV" suivi de <n> fois 'I'
            var attendu = "XV" + new string('I', nombreArabe - 15);
           
        }


        [Fact]
        public void Test1()
        {
            //ETANT DONNE le nombre 1
            const int nombreArabe = 1;

            //QUAND on le convertit en nombres romains
            var resultat = Convertir(1);

            //ALORS on obtient 'I'
            Assert.Equal("I", resultat);
        }


        [Fact]
        public void Test2()
        {
            //ETANT DONNE le nombre 2
            const int nombreArabe = 2;

            //QUAND on le convertit en nombres romains
            var resultat = Convertir(2);

            //ALORS on obtient 'II'
            Assert.Equal("II", resultat);

        }

        [Fact]
        public void Test3()
        {
            //ETANT DONNE le nombre 3
            const int nombreArabe = 3;

            //QUAND on le convertit en nombres romains
            var resultat = Convertir(3);

            //ALORS on obtient 'III'
            Assert.Equal("III", resultat);

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
        public void Test5()
        {
            //ETANT un nombre <nombreArabe> compris entre 5 et 5 
            const int nombreArabe = 5;

            //QUAND on le convertit en nombres romains
            var resultat = Convertir(5);

            //ALORS on obtient 'V' plus nombre <nombreArabe - 5> fois 'I'
            Assert.Equal("V", resultat);
        }
        public void Test6()
        {
            //ETANT DONNE le nombre 6
            const int nombreArabe = 6;

            //QUAND on le convertit en nombres romains
            var resultat = Convertir(6);

            //ALORS on obtient 'VI'
            Assert.Equal("VI", resultat);
        }

        [Fact]
        public void Test7()
        {
            //ETANT DONNE le nombre 7
            const int nombreArabe = 7;

            //QUAND on le convertit en nombres romains
            var resultat = Convertir(7);

            //ALORS on obtient 'VII'
            Assert.Equal("VII", resultat);
        }

        [Fact]
        public void Test8()
        {
            //ETANT DONNE le nombre 8
            const int nombreArabe = 8;

            //QUAND on le convertit en nombres romains
            var resultat = Convertir(8);

            //ALORS on obtient 'VIII'
            Assert.Equal("VIII", resultat);
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
        public void Test10()
        {
            //ETANT DONNER un nombre <nombreArabe> qui est égal à 10 
            const int nombreArabe = 10;
            //QUAND on le convertit en nombre romains
            var resultat = Convertir(10);
            // ALORS on obtient 'X'
            Assert.Equal("X", resultat);
        }

        [Fact]
        public void Test11()
        {
            //ETANT DONNER un nombre <nombreArabe> qui est égal à 11
            const int nombreArabe = 11;
            //QUAND on le convertit en nombre romains
            var resultat = Convertir(11);
            // ALORS on obtient 'XI'
            Assert.Equal("XI", resultat);
        }

        [Fact]
        public void Test12()
        {
            //ETANT DONNER un nombre <nombreArabe> qui est égal à 12
            const int nombreArabe = 12;
            //QUAND on le convertit en nombre romains
            var resultat = Convertir(12);
            // ALORS on obtient 'XII'
            Assert.Equal("XII", resultat);
        }

        [Fact]
        public void Test13()
        {
            //ETANT DONNER un nombre <nombreArabe> qui est égal à 13
            const int nombreArabe = 13;
            //QUAND on le convertit en nombre romains
            var resultat = Convertir(13);
            // ALORS on obtient 'XIII'
            Assert.Equal("XIII", resultat);
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
        public void Test15()
        {
            //ETANT DONNER un nombre <nombreArabe> qui est égal à 15
            const int nombreArabe = 15;
            //QUAND on le convertit en nombre romains
            var resultat = Convertir(15);
            // ALORS on obtient 'XV'
            Assert.Equal("XV", resultat);
        }

        [Fact]
        public void Test16()
        {
            //ETANT DONNER un nombre <nombreArabe> qui est égal à 16
            const int nombreArabe = 16;
            //QUAND on le convertit en nombre romains
            var resultat = Convertir(16);
            // ALORS on obtient 'XVI'
            Assert.Equal("XVI", resultat);
        }

        [Fact]
        public void Test17()
        {
            //ETANT DONNER un nombre <nombreArabe> qui est égal à 17
            const int nombreArabe = 17;
            //QUAND on le convertit en nombre romains
            var resultat = Convertir(17);
            // ALORS on obtient 'XVII'
            Assert.Equal("XVII", resultat);
        }

        [Fact]
        public void Test18()
        {
            //ETANT DONNER un nombre <nombreArabe> qui est égal à 18
            const int nombreArabe = 18;
            //QUAND on le convertit en nombre romains
            var resultat = Convertir(18);
            // ALORS on obtient 'XVIII'
            Assert.Equal("XVIII", resultat);
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
        public void Test20()
        {
            //ETANT DONNER un nombre <nombreArabe> qui est égal à 20
            const int nombreArabe = 20;
            //QUAND on le convertit en nombre romains
            var resultat = Convertir(20);
            // ALORS on obtient 'XX'
            Assert.Equal("XX", resultat);
        }

        [Fact]
        public void Test21()
        {
            //ETANT DONNER un nombre <nombreArabe> qui est égal à 21
            const int nombreArabe = 21;
            //QUAND on le convertit en nombre romains
            var resultat = Convertir(21);
            // ALORS on obtient 'XXI'
            Assert.Equal("XXI", resultat);
        }

        [Fact]
        public void Test22()
        {
            //ETANT DONNER un nombre <nombreArabe> qui est égal à 22
            const int nombreArabe = 22;
            //QUAND on le convertit en nombre romains
            var resultat = Convertir(22);
            // ALORS on obtient 'XXII'
            Assert.Equal("XXII", resultat);
        }

        [Fact]
        public void Test23()
        {
            //ETANT DONNER un nombre <nombreArabe> qui est égal à 23
            const int nombreArabe = 23;
            //QUAND on le convertit en nombre romains
            var resultat = Convertir(23);
            // ALORS on obtient 'XXIII'
            Assert.Equal("XXIII", resultat);
        }
    }
}