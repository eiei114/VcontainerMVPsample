using Cysharp.Threading.Tasks;

namespace DefaultNamespace
{
    public class Model
    {
        private readonly AsyncReactiveProperty<int> _score = new(0);

        public IReadOnlyAsyncReactiveProperty<int> Score => _score;
        
        public void AddScore()
        {
            _score.Value++;
        }
    }
}