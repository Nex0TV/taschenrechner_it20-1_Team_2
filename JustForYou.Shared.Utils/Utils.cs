using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace JustForYou.Shared.Utils
{
    /// <summary>
    /// Utility-Class for methods used in the entire product
    /// </summary>
    public class Utils
    {
        /// <summary>
        /// Get all Child Controls of a main control
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IEnumerable<Control> GetAllControls(Control root)
        {
            var stack = new Stack<Control>();
            stack.Push(root);

            while (stack.Any())
            {
                var next = stack.Pop();
                foreach (Control child in next.Controls)
                    stack.Push(child);

                yield return next;
            }
        }
    }
}
