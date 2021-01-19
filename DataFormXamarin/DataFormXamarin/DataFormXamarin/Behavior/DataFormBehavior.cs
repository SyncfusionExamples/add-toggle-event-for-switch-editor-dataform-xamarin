using Syncfusion.XForms.DataForm;
using Syncfusion.XForms.DataForm.Editors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace DataFormXamarin
{
    public class DataFormBehavior : Behavior<ContentPage>
    {
        SfDataForm dataForm;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            dataForm = bindable.FindByName<SfDataForm>("dataForm");
            dataForm.RegisterEditor("Switch", new CustomSwitchEditor(dataForm));
            dataForm.RegisterEditor("Scan", "Switch");
        }
    }
	
	public class CustomSwitchEditor : DataFormSwitchEditor
	{
		public CustomSwitchEditor(SfDataForm dataForm) : base(dataForm)
		{

		}

		protected override void OnInitializeView(DataFormItem dataFormItem, Switch view)
		{
			base.OnInitializeView(dataFormItem, view);
		}

		private void View_Toggled(object sender, ToggledEventArgs e)
		{
			App.Current.MainPage.DisplayAlert("Toggled Event", "Triggered", "Ok");
		}

		protected override void OnWireEvents(Switch view)
		{
			base.OnWireEvents(view);
			view.Toggled += View_Toggled;
		}

		protected override void OnUnWireEvents(Switch view)
		{
			base.OnUnWireEvents(view);
			view.Toggled -= View_Toggled;
		}
	}
}
