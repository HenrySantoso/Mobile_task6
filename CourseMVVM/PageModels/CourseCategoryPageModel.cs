using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CourseMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseMVVM.PageModels
{
    public partial class CourseCategoryPageModel : ObservableObject, IProjectTaskPageModel
    {
        public IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand => throw new NotImplementedException();

        public bool IsBusy => throw new NotImplementedException();  
    }
}
