using Entities.Concrete;

namespace WorkAround
{
    internal class IapplicantService
    {
        public IapplicantService()
        {
        }

        public static implicit operator IapplicantService(Person v)
        {
            throw new NotImplementedException();
        }
    }
}