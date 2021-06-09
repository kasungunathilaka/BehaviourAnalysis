using Microsoft.ML.Data;

namespace BehaviourAnalysisML.Model
{
    public class ModelInput
    {
        [ColumnName("feeling_nervous"), LoadColumn(0)]
        public float Feeling_nervous { get; set; }

        [ColumnName("panic"), LoadColumn(1)]
        public float Panic { get; set; }

        [ColumnName("breathing_rapidly"), LoadColumn(2)]
        public float Breathing_rapidly { get; set; }

        [ColumnName("sweating"), LoadColumn(3)]
        public float Sweating { get; set; }

        [ColumnName("trouble_in_concentration"), LoadColumn(4)]
        public float Trouble_in_concentration { get; set; }

        [ColumnName("having_trouble_in_sleeping"), LoadColumn(5)]
        public float Having_trouble_in_sleeping { get; set; }

        [ColumnName("having_trouble_with_work"), LoadColumn(6)]
        public float Having_trouble_with_work { get; set; }

        [ColumnName("hopelessness"), LoadColumn(7)]
        public float Hopelessness { get; set; }

        [ColumnName("anger"), LoadColumn(8)]
        public float Anger { get; set; }

        [ColumnName("over_react"), LoadColumn(9)]
        public float Over_react { get; set; }

        [ColumnName("change_in_eating"), LoadColumn(10)]
        public float Change_in_eating { get; set; }

        [ColumnName("suicidal_thought"), LoadColumn(11)]
        public float Suicidal_thought { get; set; }

        [ColumnName("feeling_tired"), LoadColumn(12)]
        public float Feeling_tired { get; set; }

        [ColumnName("close_friend"), LoadColumn(13)]
        public float Close_friend { get; set; }

        [ColumnName("social_media_addiction"), LoadColumn(14)]
        public float Social_media_addiction { get; set; }

        [ColumnName("weight_gain"), LoadColumn(15)]
        public float Weight_gain { get; set; }

        [ColumnName("material_possessions"), LoadColumn(16)]
        public float Material_possessions { get; set; }

        [ColumnName("introvert"), LoadColumn(17)]
        public float Introvert { get; set; }

        [ColumnName("popping_up_stressful_memory"), LoadColumn(18)]
        public float Popping_up_stressful_memory { get; set; }

        [ColumnName("having_nightmares"), LoadColumn(19)]
        public float Having_nightmares { get; set; }

        [ColumnName("avoids_people_or_activities"), LoadColumn(20)]
        public float Avoids_people_or_activities { get; set; }

        [ColumnName("feeling_negative"), LoadColumn(21)]
        public float Feeling_negative { get; set; }

        [ColumnName("trouble_concentrating"), LoadColumn(22)]
        public float Trouble_concentrating { get; set; }

        [ColumnName("blamming_yourself"), LoadColumn(23)]
        public float Blamming_yourself { get; set; }

        [ColumnName("Disorder"), LoadColumn(24)]
        public string Disorder { get; set; }
    }
}
