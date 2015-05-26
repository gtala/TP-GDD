namespace PagoElectronico.ControlesCustomizados
{
    /// <summary>
    /// Summary description for Class1.
    /// </summary>
    public class NumericUpDownCustom : System.Windows.Forms.NumericUpDown
    {
        public NumericUpDownCustom()
        {
            Controls[0].Visible = false;
        }
    }
}
