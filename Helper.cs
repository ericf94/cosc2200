/* Group 3: Eric Fisher, Karina Thapa, Soham Patel, Cameron Allen
 * Submission Date: April 17th, 2024
 * Description: This class provides a function to helps retrieve an image path.
 * Note: This class was adapted from Alaadin Addas' CardDisplayTake3 from another course.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Hearts
{
    public static class Helper
    {
        public static BitmapImage GetImage(string path)
        {

            BitmapImage img = new BitmapImage();

            img.BeginInit();
            img.UriSource = new Uri(path, UriKind.RelativeOrAbsolute);
            img.EndInit();

            return img;

        }
    }
}
