﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XF.Labs.Sample
{	
	public partial class AutoCompletePage : ContentPage
	{	
		public AutoCompletePage ()
		{
			InitializeComponent ();
			BindingContext = ViewModelLocator.Main;
		}
	}
}

