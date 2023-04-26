using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitGenius
{
    public class WorkoutPlan
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string PlanName { get; set; }

        public bool DumbbellBenchPress { get; set; }
        public bool InclineDumbbellBenchPress { get; set; }
        public bool DumbbellChestFlys { get; set; }
        public bool PullUps { get; set; }
        public bool LatPulldowns { get; set; }
        public bool DumbbellRows { get; set; }
        public bool DumbbellCurls { get; set; }
        public bool RopePulldown { get; set; }
        public bool HammerCurls { get; set; }
        public bool ShoulderPress { get; set; }
        public bool LateralRaises { get; set; }
        public bool BarbellSquats { get; set; }
        public bool LegPress { get; set; }
        public bool WalkingLunges { get; set; }
        public bool RomanianDeadlifts { get; set; }
        public bool LegCurls { get; set; }
        public bool HipThrusts { get; set; }
        public bool BulgarianSplitSquats { get; set; }
        public bool CalfRaises { get; set; }
    }

}
