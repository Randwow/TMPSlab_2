using System;
namespace Adapter
{
    //Наш адаптер 
    public class HourseToTransportAdapter : ITransport
    {
        Hourse hourse;

        public HourseToTransportAdapter(Hourse h) {
            hourse = h;
        }

        public void Drive() {
            hourse.Move();
        }
    }
}
