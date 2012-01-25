using System;
using System.Collections.Generic;
using System.Text;

namespace PressEnter.Flow
{
    public class ImageState : PressState
    {
        private string _imageName;

        public ImageState(string name)
        {
            this.ImageName = name;
        }

        public string ImageName
        {
            get { return _imageName; }
            set { _imageName = value; }
        }




    }
}
