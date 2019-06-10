using System;
using System.Collections.Generic;

namespace MyCoreApp
{
    public sealed class NumberGenerator {
        private readonly int _seed;
        private const int Length = 10;
        public NumberGenerator(int seed) {
            _seed = seed;
        }
        public IEnumerable<int> ProduceNumbers() {
            var rd = new Random();
            for (var step = 0; step < Length; step++) {
                yield return rd.Next(int.MinValue, _seed);
            }
        }
    }
}
