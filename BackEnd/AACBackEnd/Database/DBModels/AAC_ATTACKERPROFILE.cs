namespace AACBackEnd.Database.DBModels
{
    public class AAC_ATTACKERPROFILE
    {
        // ADD THE PROPERTIES HERE
        public int ProfileId { get; set; }
        // MANDATORY: ONE OF THE PROPERTIES MUST BE THE ID OF THE USER ITS REFERING TO
        public int UserId { get; set; }
    }
}
