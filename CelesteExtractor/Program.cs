using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;

namespace CelesteExtractor {
    class DummyGame : Game {
        private List<string> paths;

        public DummyGame(List<string> paths) {
            new GraphicsDeviceManager(this);
            this.paths = paths;
        }

        protected override void LoadContent() {
            CelesteExtractor extractor = new CelesteExtractor(GraphicsDevice);
            foreach (string path in paths) {
                extractor.Extract(path);
            }
        }

        protected override void Update(GameTime gameTime) {
            Exit();
        }
    }

    class Program {
        static void Main(string[] args) {
            var paths = new List<string>(args);
			string input;
			while (true)
			{
				input = Console.ReadLine();
				if (input != null && input.Length > 1)
				{ paths.Add(input); }
				else
				{ break; }
			}
            using (DummyGame dummy = new DummyGame(paths)) {
                dummy.Run();
            }
        }
    }
}