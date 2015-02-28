using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LichtOut
{
    public class LightTile : Button
    {
        private List<LightTile> neighbours;
        private bool on;
        private Color onColor;
        private Color offColor;

        public LightTile(Color onColor, Color offColor, bool on = false)
            : base()
        {
            this.Neighbours = new List<LightTile>();
            this.On = on;
            this.onColor = onColor;
            this.offColor = offColor;
            this.BackColor = (this.On) ? this.onColor : this.offColor;
        }

        public bool On
        {
            get
            {
                return this.on;
            }
            private set
            {
                this.on = value;
            }
        }

        public List<LightTile> Neighbours
        {
            get
            {
                return this.neighbours;
            }
            private set
            {
                this.neighbours = value;
            }
        }

        public void AddNeighbour(LightTile tile)
        {
            this.Neighbours.Add(tile);
        }

        public void SwitchLight()
        {
            foreach (var neighbour in this.Neighbours)
            {
                neighbour.ChangeState();
            }
        }

        public void ChangeState()
        {
            this.On = !this.On;
            this.BackColor = (this.On) ? this.onColor : this.offColor;
        }
    }
}
