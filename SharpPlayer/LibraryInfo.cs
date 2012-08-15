using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SharpPlayer
{
    class LibraryInfo
    {
        public const UInt16 Version = 0x0001;

        private Dictionary<String,TagLib.File> _files;

        public LibraryInfo()
        {
            _files = new Dictionary<string, TagLib.File>();
        }

        public LibraryInfo( String path )
            : this()
        {
            Load( path );
        }

        private void Load( String path )
        {
            using ( FileStream stream = new FileStream( path, FileMode.Open, FileAccess.Read ) )
            {
                BinaryReader reader = new BinaryReader( stream );

                UInt16 version = reader.ReadUInt16();
            }
        }

        private void Save( String path )
        {
            using ( FileStream stream = new FileStream( path, FileMode.Create, FileAccess.Write ) )
            {
                BinaryWriter writer = new BinaryWriter( stream );

                writer.Write( Version );

                writer.Write( _files.Count );
                
            }
        }
    }
}
