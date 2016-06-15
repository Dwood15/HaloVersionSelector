using System;
using System.IO;
using System.Windows.Forms;


/*  Halo Version Selector
 *      By Dwood
 *  If you improve this, please share with me! I'd be very interested!
 * */

namespace HaloVersionSelector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string destination = "D:\\Program Files (x86)\\Microsoft Games\\Halo Custom Edition\\";
        private string sourcefolder = "C:\\HaloVersions\\";
        private string haloce = "haloce.exe";
        private string strings = "strings.dll";
        private string d3d9 = "d3d9.dll";
        private string dinput = "dinput8.dll";

        private void deleteDestinations()
        {
            File.Delete(destination + haloce);
            File.Delete(destination + strings);
            File.Delete(destination + d3d9);
            File.Delete(destination + dinput);
        }

        private void button108_Click(object sender, EventArgs e)
        {
            deleteDestinations();
            File.Copy(sourcefolder + "haloce108.exe", destination + haloce);
            File.Copy(sourcefolder + "strings108.dll", destination + strings);
            if(File.Exists(sourcefolder + "d3d9108.dll"))
                File.Copy(sourcefolder + "d3d9108.dll", destination + d3d9);
        }

        private void button109_Click(object sender, EventArgs e)
        {
            deleteDestinations();
            File.Copy(sourcefolder + "haloce109.exe", destination + haloce);
            File.Copy(sourcefolder + "strings109.dll", destination + strings);
            if(File.Exists(sourcefolder + "dinput8109.dll"))
                File.Copy(sourcefolder + "dinput8109.dll", destination + dinput);
        }

        private void button110_Click(object sender, EventArgs e)
        {
            deleteDestinations();
            File.Copy(sourcefolder + "haloce110.exe", destination + haloce);
            File.Copy(sourcefolder + "strings110.dll", destination + strings);

            if(File.Exists(sourcefolder + "dinput8110.dll"))
                File.Copy(sourcefolder + "dinput8110.dll", destination + dinput);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.Delete(destination + d3d9);
            File.Delete(destination + dinput);
        }
    }
}
