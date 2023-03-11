using System;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace DefaultNamespace
{
    public class RootLifeTimeScope : LifetimeScope
    {
        [SerializeField]private View _view;
        
        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterEntryPoint<Presenter>();
            builder.Register<Model>(Lifetime.Singleton);
            builder.RegisterComponent(_view);
        }
    }
}