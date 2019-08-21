using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleFactory.Common
{
    public static class BirdFactoryWithLinq
    {
        private static readonly Dictionary<string, IBird> _birds;

        static BirdFactoryWithLinq()
        {
            _birds = new Dictionary<string, IBird>();
            _birds.Add("Eagle", new Eagle());
            _birds.Add("Swan", new Swan());
        }

        private static IBird GetBird(string birdName)
        {
            var bird = _birds
                .Where(x => x.Key.Equals(birdName))
                .Select(x => x.Value)
                .FirstOrDefault();

            return bird ?? throw new Exception("No match bird!");
        }
    }
}