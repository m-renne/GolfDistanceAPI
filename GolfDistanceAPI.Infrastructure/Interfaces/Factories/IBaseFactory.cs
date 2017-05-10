
namespace GolfDistanceAPI.Infrastructure.Interfaces.Factories
{
    public interface IBaseFactory
    {
        void Register<T, S>() where S : T;

        T Create<T>();
    }
}
