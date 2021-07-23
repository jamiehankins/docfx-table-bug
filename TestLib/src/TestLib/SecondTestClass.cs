using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib.TestLib
{
    /// <summary>
    /// Also a test class.
    /// </summary>
    /// <remarks>
    /// There's really no reason to not believe that this class can test things.
    /// <list type="table">
    /// <listheader><i>This is the header.</i></listheader>
    /// <item><term>A Term</term><description>A Description</description></item>
    /// <item><term>Bee Term</term><description>Bee Description</description></item>
    /// </list>
    /// </remarks>
    public class SecondTestClass
    {
        /// <summary>
        /// Proudly constructing SecondTestClasses since 2021.
        /// </summary>
        public SecondTestClass() { }

        /// <inheritdoc cref="TestClass.BoolReturningMethod(bool)"/>
        public bool AnswerTheQuestion() => true;

        /// <summary>
        /// Gives the number that seems to be best.
        /// </summary>
        /// <returns>The best number.</returns>
        public int BestNumber() => 38;

        /// <summary>
        /// The remarks should be inherited,
        /// </summary>
        /// <inheritdoc cref="TestClass.BoolReturningMethod(bool)" path="/remarks"/>
        public void JustTheRemarks() { }
    }
}
