using System;
using System.Threading;
using Cysharp.Threading.Tasks.Linq;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace DefaultNamespace
{
    public class Presenter : IDisposable,IInitializable
    {
        private readonly CancellationTokenSource _cts = new();
        private readonly Model _model;
        private readonly View _view;
        
        [Inject]
        private Presenter(Model model, View view)
        {
            _model = model;
            _view = view;
        }

        public void Dispose()
        {
            _cts.Cancel();
            _cts?.Dispose();
        }

        public void Initialize()
        {
            Debug.Log("Presenter.Initialize");
            _view.ButtonClick.AddListener(_model.AddScore);

            _model.Score.Subscribe(x => _view.Text = x.ToString());
        }
    }
}