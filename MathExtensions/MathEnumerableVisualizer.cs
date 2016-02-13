using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.DebuggerVisualizers;
using System.Windows.Forms;
using MathLinq;
using System.IO;

[assembly: System.Diagnostics.DebuggerVisualizer(typeof(MathLinq.MathEnumerableVisualizer), typeof(VisualizerObjectSource),Target=typeof(MathEnumerable), Description = "Hej1")]
[assembly: System.Diagnostics.DebuggerVisualizer(typeof(MathLinq.MathEnumerableVisualizer2), typeof(VisualizerObjectSource),Target=typeof(MathEnumerable), Description = "Hej2")]
namespace MathLinq
{
    public class MathEnumerableVisualizer :DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            path += @"\MathLinq";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            var ffn = path + @"\Xdata.txt";



            var me = objectProvider.GetObject();


            MessageBox.Show(me.GetType().ToString());
        }
    }

    public class MathEnumerableVisualizer2 : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            MessageBox.Show("Hej");
        }
    }


}
