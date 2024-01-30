using System.Diagnostics.Metrics;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Xml.Linq;
// Chloe Nibali - 000913397
// CPRG 211 E - Lab 3
namespace L3_Interfaces_Abstraction_CPRG211E
{
    public class Program
    {
        static void Main(string[] args)
        {
            God god = new God();
            god.GodMode();
        }
    }
}
