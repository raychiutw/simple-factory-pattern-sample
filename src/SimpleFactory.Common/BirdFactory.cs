using System;

namespace SimpleFactory.Common
{
    public static class BirdFactory
    {
        public static IBird GetBird(string birdName)
        {
            switch (birdName)
            {
                case "Swan":
                    return new Swan();

                case "Eagle":
                    return new Eagle();

                default:
                    throw new Exception("missing matching bird name");
            }
        }
    }
}