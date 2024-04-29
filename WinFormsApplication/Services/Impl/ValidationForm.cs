namespace WinFormsApplication.Services.Impl
{
    public class ValidationForm
    {
        private List<InputBinding> _inputBindings = new();

        public void MakeBinding(Control control, Label label, Func<bool> predicate)
        {
            _inputBindings.Add(new()
            {
                Control = control,
                Label = label,
                Expr = predicate,
            });

            control.TextChanged += (s, e) => RemoveMark(control, label);
        }

        public bool Verify(out string message)
        {
            var isValid = true;

            foreach (var binding in _inputBindings)
            {
                if (VerifyInput(binding.Expr, binding.Control, binding.Label) == false)
                {
                    isValid = false;
                }
            }

            message = "Не все даннные введены корректно, проверьте введенные данные";

            return isValid;
        }

        private bool VerifyInput(Func<bool> predicate, Control control, Label label)
        {
            var isValid = predicate();

            if (isValid)
            {
                MarkAsValid(control, label);
            }
            else
            {
                MarkAsInvalid(control, label);
            }

            return isValid;
        }

        private void MarkAsInvalid(Control control, Label label)
        {
            control.ForeColor = Color.OrangeRed;

            label.ForeColor = Color.OrangeRed;
        }

        private void MarkAsValid(Control control, Label label)
        {
            control.ForeColor = Color.Green;

            label.ForeColor = Color.Green;
        }

        private void RemoveMark(Control control, Label label)
        {
            control.ForeColor = Color.Black;

            label.ForeColor = Color.Black;
        }

        public class InputBinding
        {
            public Control Control { get; set; }

            public Label Label { get; set; }

            public Func<bool> Expr { get; set; }
        }
    }
}
