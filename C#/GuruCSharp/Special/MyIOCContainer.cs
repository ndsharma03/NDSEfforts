using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GuruCSharp.Special
{
    //public class IocContainer
    //{
    //    private readonly Dictionary<type, type=""> _dependencyMap =
    //        new Dictionary<Type, type="">();

    //    public T Resolve<t>()
    //    {
    //        return (T)Resolve(typeof(T));
    //    }

    //    public void Register<tfrom, tto="">()
    //    {
    //        _dependencyMap.Add(typeof(TFrom), typeof(TTo));
    //    }

    //    private object Resolve(Type type)
    //    {
    //        Type resolvedType = LookUpDependency(type);
    //        ConstructorInfo constructor =
    //            resolvedType.GetConstructors().First();
    //        ParameterInfo[] parameters = constructor.GetParameters();

    //        if (!parameters.Any())
    //        {
    //            return Activator.CreateInstance(resolvedType);
    //        }
    //        else
    //        {
    //            return constructor.Invoke(
    //                ResolveParameters(parameters)
    //                    .ToArray());
    //        }
    //    }

    //    private Type LookUpDependency(Type type)
    //    {
    //        return _dependencyMap[type];
    //    }

    //    private IEnumerable<object> ResolveParameters(
    //        IEnumerable<parameterinfo> parameters)
    //    {
    //        return parameters
    //            .Select(p => Resolve(p.ParameterType))
    //            .ToList();
    //    }
    //}
//==============uses=================
//static void Main(string[] args)
//        {
 
//            var container = new IocContainer();
//            container.Register<vehiclecontroller, vehiclecontroller="">();
//            container.Register<car,truck>();
 
//            var vehicle = container.Resolve<vehiclecontroller>();
 
//            vehicle.Accelerate();
//            vehicle.Brake();
 
//            Console.ReadLine();
//        }
}
