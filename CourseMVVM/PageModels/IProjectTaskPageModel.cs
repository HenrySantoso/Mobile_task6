using CommunityToolkit.Mvvm.Input;
using CourseMVVM.Models;

namespace CourseMVVM.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}