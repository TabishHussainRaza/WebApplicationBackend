namespace BrightBoostApplication.Models.ViewModel;

public class TermCourseViewModel
{
    public int TermId { get; set; }
    public List<int> SubjectIds { get; set; }
    public bool RemoveAll { get; set; }
}