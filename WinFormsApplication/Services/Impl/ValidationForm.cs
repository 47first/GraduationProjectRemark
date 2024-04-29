namespace WinFormsApplication.Services.Impl
{
    public class ValidationForm
    {
        private Dictionary<TextBox, Label> _bindings = new();

        private List<InputBinding> _inputBindings = new();

        public void MakeBinding(TextBox textBox, Label label, Func<bool> predicate)
        {
            _inputBindings.Add(new()
            {
                TextBox = textBox,
                Label = label,
                Expr = predicate,
            });

            textBox.TextChanged += (s, e) => RemoveMark(textBox, label);
        }

        public bool Verify(out string message)
        {
            var isValid = true;

            foreach (var binding in _inputBindings)
            {
                if (VerifyInput(binding.Expr, binding.TextBox, binding.Label) == false)
                {
                    isValid = false;
                }
            }

            message = "Не все даннные введены корректно, проверьте введенные данные";

            return isValid;
        }

        private bool VerifyInput(Func<bool> predicate, TextBox textBox, Label label)
        {
            var isValid = predicate();

            if (isValid)
            {
                MarkAsValid(textBox, label);
            }
            else
            {
                MarkAsInvalid(textBox, label);
            }

            return isValid;
        }

        private void MarkAsInvalid(TextBox textBox, Label label)
        {
            textBox.ForeColor = Color.OrangeRed;

            label.ForeColor = Color.OrangeRed;
        }

        private void MarkAsValid(TextBox textBox, Label label)
        {
            textBox.ForeColor = Color.Green;

            label.ForeColor = Color.Green;
        }

        private void RemoveMark(TextBox textBox, Label label)
        {
            textBox.ForeColor = Color.Black;

            label.ForeColor = Color.Black;
        }

        public class InputBinding
        {
            public TextBox TextBox { get; set; }

            public Label Label { get; set; }

            public Func<bool> Expr { get; set; }
        }
    }
}
