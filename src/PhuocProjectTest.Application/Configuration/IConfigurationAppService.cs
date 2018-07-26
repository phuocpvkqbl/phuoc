using System.Threading.Tasks;
using PhuocProjectTest.Configuration.Dto;

namespace PhuocProjectTest.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
