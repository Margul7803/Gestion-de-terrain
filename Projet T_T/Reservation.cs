using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_TT
{
    public enum Terrain
    {
        Terrain_1, Terrain_2, Terrain_3
    }
    public class Reservation
    {
        [Key]
        public string id { get; set; }
        public DateTime date { get; set; }
        public Terrain terrain { get; set; }

        public Reservation(DateTime date, Terrain terrain)
        {
            Guid id = Guid.NewGuid();
            this.id = id.ToString();
            this.date = date;
            this.terrain = terrain;
        }
        public Reservation(DateTime date,Terrain terrain,string defId)
        {
            this.id = defId;
            this.date = date;
            this.terrain = terrain;
        }

        public override string ToString() { return id + " " + date + " " + terrain; }

        public string GetResId() { return id; }
    }
}
