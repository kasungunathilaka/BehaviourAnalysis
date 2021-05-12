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
                    QuestionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionBody = table.Column<string>(maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.QuestionId);
                });

            migrationBuilder.CreateTable(
                name: "Questionnaire",
                columns: table => new
                {
                    QuestionnaireId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nervous = table.Column<int>(nullable: false),
                    Panic = table.Column<int>(nullable: false),
                    BreathingRapidly = table.Column<int>(nullable: false),
                    Sweating = table.Column<int>(nullable: false),
                    TroublesInConcentration = table.Column<int>(nullable: false),
                    TroublesInSleeping = table.Column<int>(nullable: false),
                    TroublesWithWork = table.Column<int>(nullable: false),
                    Hopeless = table.Column<int>(nullable: false),
                    Angry = table.Column<int>(nullable: false),
                    OverReacting = table.Column<int>(nullable: false),
                    ChangesInEating = table.Column<int>(nullable: false),
                    SuicidalThoughts = table.Column<int>(nullable: false),
                    Tired = table.Column<int>(nullable: false),
                    CloseFriend = table.Column<int>(nullable: false),
                    SocialMediaAddiction = table.Column<int>(nullable: false),
                    WeightGain = table.Column<int>(nullable: false),
                    MaterialPossession = table.Column<int>(nullable: false),
                    Shy = table.Column<int>(nullable: false),
                    StressfulMemories = table.Column<int>(nullable: false),
                    Nightmares = table.Column<int>(nullable: false),
                    AvoidingPeople = table.Column<int>(nullable: false),
                    NegativeThoughts = table.Column<int>(nullable: false),
                    TroublesInFocusing = table.Column<int>(nullable: false),
                    BlamingYourself = table.Column<int>(nullable: false)
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
