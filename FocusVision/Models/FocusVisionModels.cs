using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FocusVision.Models
{
    public class Effect
    {
        public string description { get; set; }
    }

    public class MoveMethod
    {
        public string name { get; set; }
        public string description { get; set; }
    }

    public class Move
    {
        public string name { get; set; }
        public string type { get; set; }
        public int? power { get; set; }
        public int pp { get; set; }
        public int? accuracy { get; set; }
        public int level { get; set; }
        public int? effect_chance { get; set; }
        public Effect effect { get; set; }
        public MoveMethod move_method { get; set; }
    }

    public class FocusVisionModels
    {
        public List<string> types { get; set; }
        public List<object> strengths { get; set; }
        public List<string> weaknesses { get; set; }
        public string name { get; set; }
        public string number { get; set; }
        public string description { get; set; }
        public int attack { get; set; }
        public int defense { get; set; }
        public int stamina { get; set; }
        public List<object> evolution { get; set; }
        public string involution { get; set; }
        public int hp { get; set; }
        public int special_attack { get; set; }
        public int special_defense { get; set; }
        public int speed { get; set; }
        public List<Move> moves { get; set; }
        public List<string> evolution_chain { get; set; }
        public double height { get; set; }
        public double weight { get; set; }
    }
}