using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SharpPlayer
{
    public partial class MainForm : Form
    {
        private static readonly string[] _extensions = new string[]
        {
            ".mp3", ".m4a"
        };

        private static readonly char _ps = Path.DirectorySeparatorChar;
        private static readonly String _dataDir = "%APPDATA%" + _ps + "SharpPlayer";
        private static readonly String _infoPath = _dataDir + _ps + "info";

        private bool _collapsed = false;
        private int _originalWidth;

        private Dictionary<String, TagLib.File> _trackDict;

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad( e );

            if ( !Directory.Exists( _dataDir ) )
                Directory.CreateDirectory( _dataDir );

            LoadInfo();
        }

        private void LoadInfo()
        {
            _trackDict = new Dictionary<string, TagLib.File>();

            if ( File.Exists( _infoPath ) )
            {
                throw new NotImplementedException();
            }
            else
            {
                foreach ( String dir in Directory.EnumerateDirectories( "C:\\Users\\James\\Music" ) )
                {
                    bool first = true;
                    ListViewGroup group = null;
                    foreach ( String file in Directory.EnumerateFiles( dir ) )
                    {
                        if ( _extensions.Contains( Path.GetExtension( file ) ) )
                        {
                            TagLib.File f = TagLib.File.Create( file );

                            if ( first )
                            {
                                first = false;
                                group = new ListViewGroup( f.Tag.Album );
                                trackListView.Groups.Add( group );
                            }

                            _trackDict.Add( file, f );
                            trackListView.Items.Add( new ListViewItem( new String[] { f.Tag.Track.ToString(), f.Tag.Title, String.Join( " & ", f.Tag.Performers ), FormatDuration( f.Properties.Duration ) }, group ) );
                        }
                    }
                }
            }
        }

        private String FormatDuration( TimeSpan span )
        {
            if ( span.TotalHours >= 1.0 )
                return String.Format( "{0:#}:{1:00}:{2:00}", (int) span.TotalHours, span.Minutes, span.Seconds );
            
            return String.Format( "{0:#}:{1:00}", span.Minutes, span.Seconds );
        }

        private void collapseToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if ( _collapsed )
                Expand();
            else
                Collapse();
        }

        protected override void OnResizeBegin( EventArgs e )
        {
            if ( !_collapsed )
            {
                _originalWidth = Width;
            }
        }

        protected override void OnResizeEnd( EventArgs e )
        {
            if ( !_collapsed && Width <= 278 )
            {
                Collapse( _originalWidth );
            }
        }

        private void Expand()
        {
            if ( _collapsed )
            {
                _collapsed = false;
                trackListView.Visible = true;
                collapseToolStripMenuItem.Image = SharpPlayer.Properties.Resources.application_sidebar_collapse;
                MaximumSize = new Size( 65536, 65536 );
                Width = _originalWidth;
            }
        }

        private void Collapse( int oldWidth = 0 )
        {
            if ( !_collapsed )
            {
                _collapsed = true;
                trackListView.Visible = false;
                collapseToolStripMenuItem.Image = SharpPlayer.Properties.Resources.application_sidebar_expand;
                _originalWidth = Math.Max( oldWidth, Width );
                Width = 262 + 16;
                MaximumSize = new Size( Width, 65536 );
            }
        }

        private void trackListView_Resize( object sender, EventArgs e )
        {
            if ( !_collapsed )
            {
                int width = trackListView.ClientSize.Width - trackNoHeader.Width - lengthHeader.Width;
                artistHeader.Width = ( width * 2 ) / 5;
                titleHeader.Width = width - artistHeader.Width;
            }
        }
    }
}
