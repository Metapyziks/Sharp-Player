using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SharpPlayer
{
    public enum Rating : byte
    {
        None = 0,
        Bad = 1,
        Poor = 2,
        Average = 3,
        Good = 4,
        Excellent = 5
    }

    public partial class RatingPanel : UserControl
    {
        private Rating _rating;

        [Browsable(true)]
        public Rating Rating
        {
            get { return _rating; }
            set
            {
                _rating = value;
                Invalidate();
            }
        }

        public RatingPanel()
        {
            DoubleBuffered = true;

            InitializeComponent();
        }

        protected override void OnMouseClick( MouseEventArgs e )
        {
            int x = e.X / ( ClientSize.Width / 5 );
            Rating = (Rating) ( x + 1 );
        }

        protected override void OnPaint( PaintEventArgs e )
        {
            base.OnPaint( e );

            for( int i = 0; i < 5; ++ i )
            {
                int x = 2 + 20 * i;
                if ( (int) Rating > i )
                    e.Graphics.DrawImage( SharpPlayer.Properties.Resources.star, x, 1 );
                else
                    e.Graphics.DrawImage( SharpPlayer.Properties.Resources.star_empty, x, 1 );
            }
        }
    }
}
