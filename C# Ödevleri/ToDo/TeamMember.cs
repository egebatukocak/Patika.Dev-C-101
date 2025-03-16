 public class TeamMember{

    private Dictionary<int, string> teamMembers;

    public Dictionary<int, string> TeamMembers { get => teamMembers; set => teamMembers = value; }

    public TeamMember() {
        teamMembers = new Dictionary<int, string>();
    }


}


