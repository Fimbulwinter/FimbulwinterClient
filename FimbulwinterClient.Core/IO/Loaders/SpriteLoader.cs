﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using FimbulwinterClient.Core.Assets;
using IrrlichtLime.IO;

namespace FimbulwinterClient.Core.Content.Loaders
{
    public class SpriteLoader : IContentLoader
    {
        public LoadType Type
        {
            get { return LoadType.Stream; }
        }

        public object Load(ReadFile readFile, string assetName)
        {
            throw new NotSupportedException();
        }

        public object Load(Stream stream, string assetName)
        {
            /*Sprite spr = new Sprite(SharedInformation.GraphicsDevice);

            if (!spr.Load(stream))
                return null;

            stream.Close();

            return spr;*/
            return null;
        }
    }
}