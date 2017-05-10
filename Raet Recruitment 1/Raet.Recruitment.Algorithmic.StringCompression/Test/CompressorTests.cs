using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Raet.Recruitment.Algorithmic.StringCompression
{
    [TestClass()]
    public class CompressorTests
    {
        private Compressor _stringCompressor;

        [TestInitialize]
        public void Initialize()
        {
            _stringCompressor = new Compressor();
        }

        [TestMethod]
        [TestCategory("Compressor")]
        public void givenEmptyInput_whenCompress_thenReturnEmpty()
        {
            var toAssert = _stringCompressor.Compress("");
            Assert.AreEqual(string.Empty, toAssert);
        }

        [TestMethod]
        [TestCategory("Compressor")]
        public void givenNullInput_whenCompress_thenReturnEmpty()
        {
            var toAssert = _stringCompressor.Compress(null);
            Assert.AreEqual(string.Empty, toAssert);
        }

        [TestMethod]
        [TestCategory("Compressor")]
        public void givenSpaceInput_whenCompress_thenReturnEmpty()
        {
            var toAssert = _stringCompressor.Compress("   ");
            Assert.AreEqual(string.Empty, toAssert);
        }

        [TestMethod]
        [TestCategory("Compressor")]
        public void givenInput_whenCompress_thenReturnCommpressed()
        {
            var toAssert = _stringCompressor.Compress("aabcccccaaa");
            Assert.AreEqual(toAssert, "a2b1c5a3");
        }

        /// <summary>
        /// The original test had 0c6c I think this was a bug as if it was to be 0 base for numbers greater than 9 
        /// then the result of the test should have been 0c5c, it maks more sence this one.
        /// </summary>
        [TestMethod]
        [TestCategory("Compressor")]
        public void givenInputWithGreaterThanTenRepetitions_whenCompress_thenReturnCommpressed()
        {
            var toAssert = _stringCompressor.Compress("aabccccccccccccccccaaadee");
            Assert.AreEqual(toAssert, "a2b1c1c6a3d1e2");
        }

        [TestMethod]
        [TestCategory("Compressor")]
        public void givenUncompressibleInput_whenCompress_thenReturnSameValue()
        {
            var toAssert = _stringCompressor.Compress("abcdeefv");
            Assert.AreEqual(toAssert, "abcdeefv");
        }

        [TestMethod]
        [TestCategory("Compressor")]
        public void given1000Input_whenCompress_thenReturnCompressed()
        {
            string process = new string('A', 30) + new string('x', 30) + new string('f', 30) + new string('x', 30) + new string('d', 30) + "g" + new string('A', 850);
            var toAssert = _stringCompressor.Compress(process);
            Assert.AreEqual(toAssert, "A3A0x3x0f3f0x3x0d3d0g1A8A5A0");
        }
    }
}
