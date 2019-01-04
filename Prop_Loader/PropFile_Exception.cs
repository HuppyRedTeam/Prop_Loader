using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prop_Loader
{
    class PropFile_Exception : ApplicationException
    {
        private string error_message;
        public PropFile_Exception(string message)
        {
            this.error_message = message;

        }

        public override string ToString()
        {
            return error_message;
        }

    }

}
