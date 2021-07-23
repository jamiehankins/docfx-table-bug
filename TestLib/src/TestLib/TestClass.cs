

namespace TestLib
{
    /// <summary>
    /// This is a test class to have something for DocFX to document.
    /// </summary>
    /// <remarks>
    /// We're going to talk about things now.
    /// <list type="table">
    /// <listheader>Things for the header</listheader>
    /// <item>
    /// <term><see cref="BoolReturningMethod(bool)"/></term>
    /// <description><inheritdoc cref="BoolReturningMethod(bool)" path="/summary"/></description>
    /// </item>
    /// <item>
    /// <term><see cref="DoDad"/></term>
    /// <description><inheritdoc cref="DoDad" path="/summary"/></description>
    /// </item>
    /// </list>
    /// </remarks>
    public class TestClass
    {
        /// <summary>
        /// This is a constructor to document.
        /// </summary>
        public TestClass() { }

        /// <summary>
        /// A string that could have something.
        /// </summary>
        public string DoDad { get; }

        /// <summary>
        /// Simple method to generate docs for.
        /// </summary>
        /// <remarks>
        /// I'd like to take a moment to thank all of those who helped me get to
        /// a place where I can write documentation like this.
        /// </remarks>
        /// <param name="source">A meaningless boolean value, much like most questions in the world.</param>
        /// <returns>An exactly equivalently meaningless boolean value, much like most answers in the world.</returns>
        public bool BoolReturningMethod(bool source) => source;
    }
}
