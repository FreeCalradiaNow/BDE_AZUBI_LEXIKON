using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BDE_AZUBI_LEXIKON
{
    public class MainViewModel : INotifyPropertyChanged
    {
        //Konstruktor
        public MainViewModel()
        {
            PlatzhalterA = "TextA"; //Die StringValues können über Resources noch dynamischer gestaltet werden
            PlatzhalterB = "TextB";
        }

        //Eigenschaften/ Properties
        string platzhalterA; //Wegen PorpertyChanged muss oldschool implementiert werden, bei Versionm public string PlatzhalterA { get; set; } könnte das hier weg
        string platzhalterB;

        //public string PlatzhalterA { get; set; } //Wegen PorpertyChanged muss oldschool und umfassend implementiert werden
        //public string PlatzhalterB { get; set; }
        public string PlatzhalterA //Vollständige Implementierung
        {
            get => platzhalterA;
            set {
                if (platzhalterA != value)
                {
                    platzhalterA = value;
                    //this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PlatzhalterA)); // ausgelagert in Funktion RaisedPropertyChanged()
                    //this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PlatzhalterB));
                    this.RaisedPropertyChanged();
                    this.RaisedPropertyChanged(PlatzhalterAB);

                }
            }
        }
        public string PlatzhalterB
        {
            get => platzhalterB;
            set
            {
                if (platzhalterB != value)
                {
                    platzhalterB = value;
                    this.RaisedPropertyChanged();
                    this.RaisedPropertyChanged(nameof(PlatzhalterAB));
                }
            }
        }

        public string PlatzhalterAB => $"{PlatzhalterA} {PlatzhalterB}"; //neue Property aus vorhandenen -> kein Konstruktor nötig

        public event PropertyChangedEventHandler PropertyChanged; //ohne Konstruktor wie bei PltzhltAB bekommt das Binding keine Änderungen mit, deshalb PropertyChanged implementieren

        //public void RaisedPropertyChanged(string propertyName)
        //{
        //    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
        public void RaisedPropertyChanged([CallerMemberName] string propertyName = "") // durch CallerMemberName holt sich die Funktion den propertyName automatisch vom CallerMember
        {
            if (!string.IsNullOrEmpty(propertyName))
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}