using Microsoft.EntityFrameworkCore.Migrations;

namespace BehaviourAnalysis.Persistence.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionBody = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.QuestionId);
                });

            migrationBuilder.CreateTable(
                name: "Questionnaire",
                columns: table => new
                {
                    QuestionnaireId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nervous = table.Column<bool>(type: "bit", nullable: false),
                    Panic = table.Column<bool>(type: "bit", nullable: false),
                    BreathingRapidly = table.Column<bool>(type: "bit", nullable: false),
                    Sweating = table.Column<bool>(type: "bit", nullable: false),
                    TroublesInConcentration = table.Column<bool>(type: "bit", nullable: false),
                    TroublesInSleeping = table.Column<bool>(type: "bit", nullable: false),
                    TroublesWithWork = table.Column<bool>(type: "bit", nullable: false),
                    Hopeless = table.Column<bool>(type: "bit", nullable: false),
                    Angry = table.Column<bool>(type: "bit", nullable: false),
                    OverReacting = table.Column<bool>(type: "bit", nullable: false),
                    ChangesInEating = table.Column<bool>(type: "bit", nullable: false),
                    SuicidalThoughts = table.Column<bool>(type: "bit", nullable: false),
                    Tired = table.Column<bool>(type: "bit", nullable: false),
                    CloseFriend = table.Column<bool>(type: "bit", nullable: false),
                    SocialMediaAddiction = table.Column<bool>(type: "bit", nullable: false),
                    WeightGain = table.Column<bool>(type: "bit", nullable: false),
                    MaterialPossession = table.Column<bool>(type: "bit", nullable: false),
                    Shy = table.Column<bool>(type: "bit", nullable: false),
                    StressfulMemories = table.Column<bool>(type: "bit", nullable: false),
                    Nightmares = table.Column<bool>(type: "bit", nullable: false),
                    AvoidingPeople = table.Column<bool>(type: "bit", nullable: false),
                    NegativeThoughts = table.Column<bool>(type: "bit", nullable: false),
                    TroublesInFocusing = table.Column<bool>(type: "bit", nullable: false),
                    BlamingYourself = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questionnaire", x => x.QuestionnaireId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "Questionnaire");
        }
    }
}
