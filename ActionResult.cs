public record ActionResult{
    public string ActionName;
    public string Animation;

    public ActionResult(string name, string anim)
    {
        this.ActionName = name;
        this.Animation = anim;
    }
}