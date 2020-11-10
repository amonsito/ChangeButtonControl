using Xamarin.Forms;

namespace ControlsTest.Controls
{
    partial class GreenButton : Button
    {
        public GreenButton()
        {
            SetValue(PaddingProperty, 0);
            SetValue(CornerRadiusProperty, 20);
            VisualStates();
        }

        public static readonly BindableProperty ActiveProperty =
         BindableProperty.Create(
             propertyName: nameof(Active),
             returnType: typeof(bool),
              declaringType: typeof(GreenButton),
             defaultValue: default(bool),
             propertyChanged: ActiveChanged);

        public bool Active
        {
            get { return (bool)GetValue(ActiveProperty); }
            set { SetValue(ActiveProperty, value); }
        }
        private static void ActiveChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (newValue == null) return;

            if ((bool)newValue)
            {
                bindable.SetValue(BackgroundColorProperty, Color.FromHex("#06b864"));
                bindable.SetValue(BorderColorProperty, Color.FromHex("#FDFDFD"));
                bindable.SetValue(BorderWidthProperty, 0);
            }
            else
            {
                ((GreenButton)bindable).NormalColor();
            }

        }

        private void VisualStates()
        {
            var vsg = new VisualStateGroup();
            var vs1 = new VisualState { Name = "Normal" };
            vs1.Setters.Add(new Setter
            {
                Property = BackgroundColorProperty,
                Value = Color.FromHex("#222433")
            });
            vs1.Setters.Add(new Setter
            {
                Property = BorderColorProperty,
                Value = Color.FromHex("#FDFDFD")
            });
            vs1.Setters.Add(new Setter
            {
                Property = TextColorProperty,
                Value = Color.FromHex("#FDFDFD")
            });
            vs1.Setters.Add(new Setter
            {
                Property = BorderWidthProperty,
                Value = 1
            });

            /*Disable*/
            var vs2 = new VisualState { Name = "Disabled" };
            vs2.Setters.Add(new Setter
            {
                Property = BackgroundColorProperty,
                Value = Color.FromHex("#646464")
            });
            vs2.Setters.Add(new Setter
            {
                Property = BorderColorProperty,
                Value = Color.FromHex("#FDFDFD")
            });
            vs2.Setters.Add(new Setter
            {
                Property = TextColorProperty,
                Value = Color.FromHex("#000000")
            });
            vs2.Setters.Add(new Setter
            {
                Property = BorderWidthProperty,
                Value = 1
            });
            vs2.Setters.Add(new Setter
            {
                Property = FontAttributesProperty,
                Value = FontAttributes.Bold
            });
            vsg.States.Add(vs2);
            vsg.States.Add(vs1);
            VisualStateManager.GetVisualStateGroups(this).Add(vsg);
        }

        private void NormalColor()
        {
            SetValue(BackgroundColorProperty, Color.FromHex("#222433"));
            SetValue(BorderColorProperty, Color.FromHex("#FDFDFD"));
            SetValue(TextColorProperty, Color.FromHex("#FDFDFD"));
            SetValue(BorderWidthProperty, 1);
        }





    }
}
