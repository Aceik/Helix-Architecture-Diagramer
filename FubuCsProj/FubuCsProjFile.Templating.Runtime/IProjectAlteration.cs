namespace Fubu.CsProjFile.FubuCsProjFile.Templating.Runtime
{
	public interface IProjectAlteration
	{
		void Alter(CsProjFile file, ProjectPlan plan);
	}
}
