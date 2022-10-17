using System;
using System.Windows.Forms;

class MyButtonClass: Form {
    private Button mrButton;
    // Метод конструктор
    public MyButtonClass() {
        mrButton = new Button();
        mrButton.Text = "Нажми меня";
        mrButton.Top = 100;
        mrButton.Left = 100;
        mrButton.Height = 50;
        mrButton.Width = 70;
        
        mrButton.Click += new System.EventHandler(MyButtonClickEventHandler);
        this.Controls.Add(mrButton);
    }
    //Основной метод
    static void Main() {
        Application.Run(new MyButtonClass());
    }
    // Метод-обработчик событий
    void MyButtonClickEventHandler(object x, EventArgs y) {
        mrButton.Text = "Вы нажали меня";
    }
}