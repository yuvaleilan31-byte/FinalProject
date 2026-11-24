using AppMaui.Models;
using CommunityToolkit.Mvvm.Input;

namespace AppMaui.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}