using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OIIP
{
	public class Viewmodel : BindableBase
	{
		private double porosity;

		public double Porosity
		{
			get { return porosity; }
			set
			{
				porosity = value;
				RaisePropertyChanged("Porosity");
			}
		}

		private double thickness;

		public double Thickness
		{
			get { return thickness; }
			set
			{
				thickness = value;
				RaisePropertyChanged("Thickness");
			}
		}
		private double area;

		public double Area
		{
			get { return area; }
			set
			{
				area = value;
				RaisePropertyChanged("Area");
			}
		}

		private double oIIP;
		private double saturation;

		public double OIIP
		{
			get { return oIIP; }
			set
			{
				oIIP = value;
				RaisePropertyChanged("OIIP");
			}
		}

		public DelegateCommand CalculateCommand { get; set; }
		public double Saturation
		{
			get => saturation; set
			{
				saturation = value;
				RaisePropertyChanged("Saturation");

			}
		}

		public Viewmodel()
		{
			CalculateCommand = new DelegateCommand(CalculateOIIP);
		}

		private void CalculateOIIP()
		{
			var answer = 7758 * Porosity * Area * Thickness * (1 - Saturation); ///see where your petroleum knowledge came in handy????
			OIIP = answer;
		}
	}
}
