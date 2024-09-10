namespace AddMaster;

public partial class MainPage : ContentPage
{
    

    public MainPage()
    {
        InitializeComponent();
        Title = "Add Master Pro";
    }


    private void Clear(object sender, EventArgs e)
    {
        txtFirstNumber.Text = string.Empty;
        txtSecondNumber.Text = string.Empty;
        lblDisplay.Text = "0";
    }

    private void Add(object sender, EventArgs e)
    {
        double dblFirst, dblSecond;
        double.TryParse(txtFirstNumber.Text, out dblFirst);
        double.TryParse(txtSecondNumber.Text, out dblSecond);

        lblDisplay.Text = (dblFirst + dblSecond).ToString();
    }
}