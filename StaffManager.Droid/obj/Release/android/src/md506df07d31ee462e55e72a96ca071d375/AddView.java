package md506df07d31ee462e55e72a96ca071d375;


public class AddView
	extends md57b8dd31b26d57b878589ceca204f3b49.MvxActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("StaffManager.Droid.Views.AddView, StaffManager.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", AddView.class, __md_methods);
	}


	public AddView () throws java.lang.Throwable
	{
		super ();
		if (getClass () == AddView.class)
			mono.android.TypeManager.Activate ("StaffManager.Droid.Views.AddView, StaffManager.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
