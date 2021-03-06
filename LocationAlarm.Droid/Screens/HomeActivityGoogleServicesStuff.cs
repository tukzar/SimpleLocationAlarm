﻿using System;
using Android.Gms.Common;
using Android.Widget;
using Android.App;

namespace SimpleLocationAlarm.Droid.Screens
{
	public partial class HomeActivity
	{
		const int _googleServicesCheckRequestCode = 25;
		int _isGooglePlayServicesAvailable;

		void CheckGS ()
		{
			_isGooglePlayServicesAvailable = GooglePlayServicesUtil.IsGooglePlayServicesAvailable (this);

            try
            {
                _addAlarmMenuButton.SetVisible(_isGooglePlayServicesAvailable == ConnectionResult.Success && Mode == Screens.Mode.None);
            }
            catch (Exception e)
            {

            }

            if (_isGooglePlayServicesAvailable != ConnectionResult.Success) {
				if (GooglePlayServicesUtil.IsUserRecoverableError (_isGooglePlayServicesAvailable)) {
					GooglePlayServicesUtil.ShowErrorDialogFragment (_isGooglePlayServicesAvailable, this, _googleServicesCheckRequestCode);
				} else {
					ShowToast(Resource.String.device_not_supported);
					Finish ();
				}
			}
		}

		void OnActivityResultForGS (Result resultCode)
		{
            //if (resultCode == Result.Canceled) {
            //    GooglePlayServicesUtil.ShowErrorNotification (_isGooglePlayServicesAvailable, this);
            //    Finish ();
            //}
		}
	}
}

