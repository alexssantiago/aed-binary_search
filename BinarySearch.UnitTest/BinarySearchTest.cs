using BinarySearch.Domain;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    //O atributo[TestFixture] indica uma classe que cont�m testes de unidade.
    public class BinarySearchTest
    {
        private Binary bs;

        public BinarySearchTest()
        {
            //bs = new Binary();
        }

        [Test]
        public void TestNotFound()
        {
            int[] values = new int[4] { 12, 123, 41, 10 };
            bs = new Binary(values);

            //
            //Assert.AreEqual() - verifica se os objetos passados como par�metros s�o iguais.
            //

            //Retorna um ERRO no teste, pois o '0' n�o est� contido no array informado, e portanto o retorno do met�do � igual a '-1' para itens n�o encontrados, 
            //e n�o '2' como informado abaixo
            //Assert.AreEqual(bs.Search(values, 0, first: 0, last: values.Length - 1), 2);

            //Retorna SUCESSO no teste, pois '42' est� contido no array informado, e portanto o retorno do met�do � sua posi��o como informada abaixo
            Assert.AreEqual(bs.Search(values, 41, first: 0, last: values.Length - 1), 2);

        }
    }
}