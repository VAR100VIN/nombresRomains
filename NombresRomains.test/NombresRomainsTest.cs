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



    }
}