using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface_with_Abstract
{
    interface IBase {
        void Message();
        void call();
    }
    interface ISmart: IBase {
        void Video();
        void  camera();
    }
    interface IAdvanced {
        void WaterProof();

    }
}
